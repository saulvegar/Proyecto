using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SistemaAlmacen
{
    class Grupo
    {
        //se definen las variables para cada uno de los campos que tiene la tabla grupo
        int id_grupo;
        String nombre;

        //método para insertar un nuevo grupo
        public void InsertarGrupo(String Nombre)
        {
            this.nombre = Nombre;

            Conexion cone = new Conexion();
            cone.Configurar();
            cone.Conectar();

            SqlCommand procedimiento = new SqlCommand("InsertarGrupo", cone.conex);
            procedimiento.CommandType = CommandType.StoredProcedure;
            procedimiento.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;

            try
            {
                procedimiento.ExecuteNonQuery();
                MessageBox.Show("Grupo agregado exitosamente!", "Agregar Grupo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("Error al agregar el nuevo grupo: " + sqlex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cone.Cerrar();
        }

        //método para actualizar un nuevo grupo
        public void ActualizarGrupo(int Id_Grupo, String Nombre)
        {
            this.id_grupo = Id_Grupo;
            this.nombre = Nombre;

            Conexion cone = new Conexion();
            cone.Configurar();
            cone.Conectar();

            SqlCommand query = cone.conex.CreateCommand();
            String consulta = String.Format("execute ActualizarGrupo '{1}';", id_grupo, nombre);
            query.CommandText = consulta;

            try
            {
                query.ExecuteNonQuery();
                MessageBox.Show("Grupo actualizado exitosamente!", "Actualización de grupo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(SqlException sqlex)
            {
                MessageBox.Show("Algo salió mal. " + sqlex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cone.Cerrar();

        }

        //metodo que banea un o varios grupos
        public void EliminarGrupos(String[] Id)
        {
            Conexion cone = new Conexion();
            cone.Configurar();
            cone.Conectar();
            String ids = String.Join(",", Id);

            SqlCommand proc = new SqlCommand("EliminarGrupo", cone.conex);
            proc.CommandType = CommandType.StoredProcedure;
            proc.Parameters.Add("@lista_ids", SqlDbType.Int).Value = ids;

            try
            {
                proc.ExecuteNonQuery();
                MessageBox.Show("Grupo(s) dada(s) de baja exitosamente!", "Dar de baja Grupo(s)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("Algo salió mal. " + sqlex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cone.Cerrar();
        }
    }
}
