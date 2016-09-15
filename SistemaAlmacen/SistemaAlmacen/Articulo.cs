using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace SistemaAlmacen
{
    class Articulo
    {
        //se definen las variables para cada uno de los campos que tiene la tabla articulo
        int id_articulo;
        String nombre;
        String descripcion;
        String unidad;
        int cantidad;
        char estatus;
        int id_local;

        //método para insertar un nuevo articulo
        public void InsertarArticulo(int Id, String Nombre, String Descripcion, String Unidad, int Cantidad, int Id_local)
        {
            this.id_articulo = Id;
            this.nombre = Nombre;
            this.descripcion = Descripcion;
            this.unidad = Unidad;
            this.cantidad = Cantidad;
            this.id_local = Id_local;

            Conexion cone = new Conexion();
            cone.Configurar();
            cone.Conectar();

            SqlCommand procedimiento = new SqlCommand("InsertarArticulo", cone.conex);
            procedimiento.CommandType = CommandType.StoredProcedure;
            procedimiento.Parameters.Add("@id_articulo", SqlDbType.Int).Value = id_articulo;
            procedimiento.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
            procedimiento.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = descripcion;
            procedimiento.Parameters.Add("@unidad", SqlDbType.NVarChar).Value = unidad;
            procedimiento.Parameters.Add("@cantidad", SqlDbType.Int).Value = cantidad;
            procedimiento.Parameters.Add("@id_local", SqlDbType.Int).Value = id_local;

            try
            {
                procedimiento.ExecuteNonQuery();
                MessageBox.Show("Articulo agregado exitosamente!", "Agregar articulo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("Error al agregar el nuevo articulo: " + sqlex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cone.Cerrar();
        }

        //método para actualizar un nuevo articulo
        public void ActualizarArticulo(int Id, String Nombre, String Descripcion, String Unidad, int Cantidad, char Estatus)
        {
            this.id_articulo = Id;
            this.nombre = Nombre;
            this.descripcion = Descripcion;
            this.unidad = Unidad;
            this.cantidad = Cantidad;
            this.estatus = Estatus;

            Conexion cone = new Conexion();
            cone.Configurar();
            cone.Conectar();

            SqlCommand query = cone.conex.CreateCommand();
            //String consulta = String.Format("update articulo set nombre='{0}', descripcion='{1}', unidad='{2}', tipo='{3}', precio_uni={4}, f_entrada='{5}', f_salida='{6}', cantidad={7}, existencia={8}, precio_prod={9}, estatus='{10}' where id={11};", nombre, descricpion, unidad, tipo, precio_uni, f_entrada, f_salida, cantidad, existencia, precio_prod, estatus, id);
            String consulta = String.Format("execute ActualizarArticulo {0}, '{1}', '{2}', '{3}', {4}, '{5}';", id_articulo, nombre, descripcion, unidad, cantidad, estatus);
            query.CommandText = consulta;

            try
            {
                query.ExecuteNonQuery();
                MessageBox.Show("Articulo actualizado exitosamente!", "Actualización de articulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqlex)
            {
            }
            cone.Cerrar();

        }  

        //metodo que banea uno o varios articulos
        public void EliminarArticulos(String[] Id)
        {
            Conexion cone = new Conexion();
            cone.Configurar();
            cone.Conectar();
            String ids = String.Join(",", Id);

            //SqlCommand query = cone.conex.CreateCommand();
            //String consulta = String.Format("update articulo set estatus='b' where id in({0});", ids);
            //query.CommandText = consulta;

            SqlCommand proc = new SqlCommand("EliminarArticulo", cone.conex);
            proc.CommandType = CommandType.StoredProcedure;
            proc.Parameters.Add("@lista_ids", SqlDbType.Int).Value = ids;

            try
            {
                proc.ExecuteNonQuery();
                MessageBox.Show("Articulo(s) dado(s) de baja exitosamente!", "Dar de baja articulo(s)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqlex)
            {

            }
            cone.Cerrar();
        }
    }
}
