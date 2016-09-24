using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SistemaAlmacen
{
    class Localizacion
    {
        //se definen las variables para cada uno de los campos que tiene la tabla localizacion
        int id_localizacion;
        int id_articulo;
        int num_cuviculo;

        //método para insertar un nuevo localizacion
        public void InsertarLocalizacion(int Id_Localizacion, int Id_Articulo, int Num_Cuviculo)
        {
            this.id_localizacion = Id_Localizacion;
            this.id_articulo = Id_Articulo;
            this.num_cuviculo = Num_Cuviculo;

            Conexion cone = new Conexion();
            cone.Configurar();
            cone.Conectar();

            SqlCommand procedimiento = new SqlCommand("InsertarLocalizacion", cone.conex);
            procedimiento.CommandType = CommandType.StoredProcedure;
            procedimiento.Parameters.Add("@id_localizacion", SqlDbType.Int).Value = id_localizacion;
            procedimiento.Parameters.Add("@id_articulo", SqlDbType.Int).Value = id_articulo;
            procedimiento.Parameters.Add("@num_cuviculo", SqlDbType.Int).Value = num_cuviculo;

            try
            {
                procedimiento.ExecuteNonQuery();
                MessageBox.Show("Localizacion agregado exitosamente!", "Agregar Localizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("Error al agregar el nuevo localizacion: " + sqlex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cone.Cerrar();
        }

        //método para actualizar un nuevo localizacion 
        public void ActualizarLocalizacion(int Id_Localizacion, int Id_Articulo, int Num_Cuviculo)
        {
            this.id_localizacion = Id_Localizacion;
            this.id_articulo = Id_Articulo;
            this.num_cuviculo = Num_Cuviculo;

            Conexion cone = new Conexion();
            cone.Configurar();
            cone.Conectar();

            SqlCommand query = cone.conex.CreateCommand();
            String consulta = String.Format("execute ActualizarLocalizacion '{2}';", id_localizacion, id_articulo, num_cuviculo);
            query.CommandText = consulta;

            try
            {
                query.ExecuteNonQuery();
                MessageBox.Show("Localizacion actualizado exitosamente!", "Actualización de localizacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("Algo salió mal. " + sqlex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cone.Cerrar();

        }

        //metodo que banea una o varias localizaciones
        public void EliminarLocalizaciones(String[] Id)
        {
            Conexion cone = new Conexion();
            cone.Configurar();
            cone.Conectar();
            String ids = String.Join(",", Id);

            SqlCommand proc = new SqlCommand("EliminarLocalizacion", cone.conex);
            proc.CommandType = CommandType.StoredProcedure;
            proc.Parameters.Add("@lista_ids", SqlDbType.Int).Value = ids;

            try
            {
                proc.ExecuteNonQuery();
                MessageBox.Show("Localizacion(es) dada(s) de baja exitosamente!", "Dar de baja Localizacion(es)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("Algo salió mal. " + sqlex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cone.Cerrar();
        }
    }
}
