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
        int id;
        String nombre;
        String descripcion;
        String unidad;
        String tipo;
        int precio_uni;
        String f_entrada;
        String f_salida;
        int cantidad;
        int existencia;
        int precio_prod;
        char estatus;
        int id_local;

        public void InsertarArticulo(int Id, String Nombre, String Descripcion, String Unidad, String Tipo, int Precio_uni, String F_entrada, String F_salida, int Cantidad, int Existencia, int Precio_prod, int Id_local)
        {
            this.id = Id;
            this.nombre = Nombre;
            this.descripcion = Descripcion;
            this.unidad = Unidad;
            this.tipo = Tipo;
            this.precio_uni = Precio_uni;
            this.f_entrada = F_entrada;
            this.f_salida = F_salida;
            this.cantidad = Cantidad;
            this.existencia = Existencia;
            this.precio_prod = Precio_prod;
            this.id_local = Id_local;

            Conexion cone = new Conexion();
            cone.Configurar();
            cone.Conectar();

            SqlCommand procedimiento = new SqlCommand("InsertarArticulo", cone.conex);
            procedimiento.CommandType = CommandType.StoredProcedure;
            procedimiento.Parameters.Add("@id", SqlDbType.Int).Value = id;
            procedimiento.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
            procedimiento.Parameters.Add("@descripcion", SqlDbType.NVarChar).Value = descripcion;
            procedimiento.Parameters.Add("@unidad", SqlDbType.NVarChar).Value = unidad;
            procedimiento.Parameters.Add("@tipo", SqlDbType.NVarChar).Value = tipo;
            procedimiento.Parameters.Add("@precio_uni", SqlDbType.Int).Value = precio_uni;
            procedimiento.Parameters.Add("@f_entrada", SqlDbType.NVarChar).Value = f_entrada;
            procedimiento.Parameters.Add("@f_salida", SqlDbType.NVarChar).Value = f_salida;
            procedimiento.Parameters.Add("@cantidad", SqlDbType.Int).Value = cantidad;
            procedimiento.Parameters.Add("@existencia", SqlDbType.Int).Value = existencia;
            procedimiento.Parameters.Add("@precio_prod", SqlDbType.Int).Value = precio_prod;
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

        public void ActualizarArticulo(int Id, String Nombre, String Descripcion, String Unidad, String Tipo, int Precio_uni, String F_entrada, String F_salida, int Cantidad, int Existencia, int Precio_prod, char Estatus)
        {
            this.id = Id;
            this.nombre = Nombre;
            this.descripcion = Descripcion;
            this.unidad = Unidad;
            this.tipo = Tipo;
            this.precio_prod = Precio_prod;
            this.f_entrada = F_entrada;
            this.f_salida = F_salida;
            this.cantidad = Cantidad;
            this.existencia = Existencia;
            this.precio_prod = Precio_prod;
            this.estatus = Estatus;

            Conexion cone = new Conexion();
            cone.Configurar();
            cone.Conectar();

            SqlCommand query = cone.conex.CreateCommand();
            //String consulta = String.Format("update articulo set nombre='{0}', descripcion='{1}', unidad='{2}', tipo='{3}', precio_uni={4}, f_entrada='{5}', f_salida='{6}', cantidad={7}, existencia={8}, precio_prod={9}, estatus='{10}' where id={11};", nombre, descricpion, unidad, tipo, precio_uni, f_entrada, f_salida, cantidad, existencia, precio_prod, estatus, id);
            String consulta = String.Format("execute ActualizarArticulo {0}, '{1}', '{2}', '{3}', '{4}', {5}, '{6}', '{7}', {8}, {9}, {10}, '{11}';", id, nombre, descripcion, unidad, tipo, precio_uni, f_entrada, f_salida, cantidad, existencia, precio_prod, estatus);
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

        public void EliminarArticulos(String[] Id)
        {
            Conexion cone = new Conexion();
            cone.Configurar();
            cone.Conectar();
            String ids = String.Join(",", Id);

            SqlCommand query = cone.conex.CreateCommand();
            String consulta = String.Format("update articulo set estatus='b' where id in({0});", ids);
            query.CommandText = consulta;

            try
            {
                query.ExecuteNonQuery();
                MessageBox.Show("Articulo(s) dado(s) de baja exitosamente!", "Dar de baja articulo(s)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqlex)
            {

            }
            cone.Cerrar();
        }
    }
}
