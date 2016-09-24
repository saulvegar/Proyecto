using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SistemaAlmacen
{
    class Proveedor
    {
        //se definen las variables para cada uno de los campos que tiene la tabla proveedor
        int id_proveedor;
        String nombre;
        String domicilio;
        String rfc;
        String ciudad;
        String n_eco;

        //método para insertar un nuevo Proveedor
        public void InsertarProveedor(int Id_Proveedor, String Nombre, String Domicilio, String RFC, String Ciudad, String N_ECO)
        {
            this.id_proveedor = Id_Proveedor;
            this.nombre = Nombre;
            this.domicilio = Domicilio;
            this.rfc = RFC;
            this.ciudad = Ciudad;
            this.n_eco = N_ECO;

            Conexion cone = new Conexion();
            cone.Configurar();
            cone.Conectar();

            SqlCommand procedimiento = new SqlCommand("InsertarProveedor", cone.conex);
            procedimiento.CommandType = CommandType.StoredProcedure;
            procedimiento.Parameters.Add("@id_proveedor", SqlDbType.Int).Value = id_proveedor;
            procedimiento.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombre;
            procedimiento.Parameters.Add("@domicilio", SqlDbType.NVarChar).Value = domicilio;
            procedimiento.Parameters.Add("@rfc", SqlDbType.NVarChar).Value = rfc;
            procedimiento.Parameters.Add("@ciudad", SqlDbType.NVarChar).Value = ciudad;
            procedimiento.Parameters.Add("@n_eco", SqlDbType.NVarChar).Value = n_eco;

            try
            {
                procedimiento.ExecuteNonQuery();
                MessageBox.Show("Proveedor agregado exitosamente!", "Agregar proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("Error al agregar el nuevo proveedor: " + sqlex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cone.Cerrar();
        }

        //método para actualizar un nuevo proveedor
        public void ActualizarProveedor(int Id_Proveedor, String Nombre, String Domicilio, String RFC, String Ciudad, String N_ECO)
        {
            this.id_proveedor = Id_Proveedor;
            this.nombre = Nombre;
            this.domicilio = Domicilio;
            this.rfc = RFC;
            this.ciudad = Ciudad;
            this.n_eco = N_ECO;

            Conexion cone = new Conexion();
            cone.Configurar();
            cone.Conectar();

            SqlCommand query = cone.conex.CreateCommand();
            String consulta = String.Format("execute ActualizarProveedor {0}, '{1}', '{2}', '{3}', {4}, '{5}';", id_proveedor, nombre, domicilio, rfc, ciudad, n_eco);
            query.CommandText = consulta;

            try
            {
                query.ExecuteNonQuery();
                MessageBox.Show("Proveedor actualizado exitosamente!", "Actualización de proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("Algo salió mal. " + sqlex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cone.Cerrar();

        }

        //metodo que banea uno o varios proveedores
        public void EliminarProveedores(String[] Id)
        {
            Conexion cone = new Conexion();
            cone.Configurar();
            cone.Conectar();
            String ids = String.Join(",", Id);

            SqlCommand proc = new SqlCommand("EliminarProveedor", cone.conex);
            proc.CommandType = CommandType.StoredProcedure;
            proc.Parameters.Add("@lista_ids", SqlDbType.Int).Value = ids;

            try
            {
                proc.ExecuteNonQuery();
                MessageBox.Show("Proveedor(es) dado(s) de baja exitosamente!", "Dar de baja proveedor(es)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("Algo salió mal. " + sqlex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cone.Cerrar();
        }
    }
}
