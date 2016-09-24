using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace SistemaAlmacen
{
    class Usuario
    {
        //se definen variabes para cada uno de los campos tal como se encuentran en la tabla usario en la bd
        int id_usuario;
        String usuario;
        String contraseña;
        String departamento;
        String cargo;
        char estatus;

        //este método inserta un usuario nuevo en la tabla usuario
        public void InsertarUsuario(String Usuario, String Contraseña, String Departamento, String Cargo)
        {
            this.usuario = Usuario;
            this.contraseña = Contraseña;
            this.departamento = Departamento;
            this.cargo = Cargo;

            Conexion cone = new Conexion();
            cone.Configurar();
            cone.Conectar();

            //se declara un comando de tipo procedimiento almacenado y se le pasa el nombre que tiene en la bd asi como os parmetros que recibe
            SqlCommand proc = new SqlCommand("InsertarUsuario", cone.conex);
            proc.CommandType = CommandType.StoredProcedure;
            proc.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = usuario;
            proc.Parameters.Add("@contraseña", SqlDbType.NVarChar).Value = contraseña;
            proc.Parameters.Add("@dpto", SqlDbType.NVarChar).Value = departamento;
            proc.Parameters.Add("@cargo", SqlDbType.NVarChar).Value = cargo;

            try
            {
                //intenta ejecutar el comando
                proc.ExecuteNonQuery();
                MessageBox.Show("Usuario agregado exitosamente!", "Agregar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (SqlException sqlex)
            {
                //en caso de que falle arroja un mensaje que no se pudo agrar el usuario
                MessageBox.Show("Error al agregar el nuevo usuario: " + sqlex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cone.Cerrar();
        }

        //metodo para actualizar un usuario ya existente
        public void ActualizarUsuario(int Id_usuario, String Usuario, String Contraseña, String Departamento, String Cargo, char Estatus)
        {
            this.id_usuario = Id_usuario;
            this.usuario = Usuario;
            this.contraseña = Contraseña;
            this.departamento = Departamento;
            this.cargo = Cargo;
            this.estatus = Estatus;

            Conexion cone = new Conexion();
            cone.Configurar();
            cone.Conectar();

            //SqlCommand query = cone.conex.CreateCommand();
            //String consulta = String.Format("update usuario set usuario='{0}', contraseña='{1}', dpto='{2}', cargo='{3}', estatus='{4}' where id={5};", usuario, contraseña, departamento, cargo, estatus, id);
            //query.CommandText = consulta;

            SqlCommand procedimiento = new SqlCommand("ActualizarUsuario", cone.conex);
            procedimiento.CommandType = CommandType.StoredProcedure;
            procedimiento.Parameters.Add("@id_usuario", SqlDbType.Int).Value = id_usuario;
            procedimiento.Parameters.Add("@usuario", SqlDbType.NVarChar).Value = usuario;
            procedimiento.Parameters.Add("@contraseña", SqlDbType.NVarChar).Value = contraseña;
            procedimiento.Parameters.Add("@dpto", SqlDbType.VarChar).Value = departamento;
            procedimiento.Parameters.Add("@cargo", SqlDbType.VarChar).Value = cargo;
            procedimiento.Parameters.Add("@estatus", SqlDbType.VarChar).Value = estatus;

            try
            {
                procedimiento.ExecuteNonQuery();
                MessageBox.Show("Usuario actualizado exitosamente!", "Actualización de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("Algo salió mal. " + sqlex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cone.Cerrar();

        }

        //metodo que te devuelve una lista de todos los usuarios
        public SqlDataReader SeleccionarUsuario(int Id_usuario)
        {
            this.id_usuario = Id_usuario;
            Conexion cone = new Conexion();
            cone.Configurar();
            cone.Conectar();

            //SqlCommand query = cone.conex.CreateCommand();
            //String consulta = String.Format("select usuario, contraseña, dpto, cargo, estatus from usuario where id={0};", id);
            //query.CommandText = consulta;
            SqlCommand proc = new SqlCommand("ListarUsuarioPorId", cone.conex);
            proc.CommandType = CommandType.StoredProcedure;
            proc.Parameters.Add("@id", SqlDbType.Int).Value = id_usuario;


            try
            {
                return proc.ExecuteReader();
            }
            catch(SqlException sqlex)
            {
                MessageBox.Show("Error al cargar los datos del usuario. " + sqlex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cone.Cerrar();
            return null;
        }

        //metodo que te banea uno o muchos usuarios 
        public void EliminarUsuarios(String[] Id)
        {
            Conexion cone = new Conexion();
            cone.Configurar();
            cone.Conectar();
            String ids = String.Join(",", Id);
            
            //SqlCommand query = cone.conex.CreateCommand();
            //String consulta = String.Format("update usuario set estatus='b' where id in({0});", ids);
            //query.CommandText = consulta;
            SqlCommand proc = new SqlCommand("EliminarUsuario", cone.conex);
            proc.CommandType = CommandType.StoredProcedure;
            proc.Parameters.Add("@lista_ids", SqlDbType.NVarChar).Value = ids;

            try
            {
                proc.ExecuteNonQuery();
                MessageBox.Show("Usuario(s) dado(s) de baja exitosamente!", "Eliminar usuario(s)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("Algo salió mal. " + sqlex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cone.Cerrar();
        }
    }
}
