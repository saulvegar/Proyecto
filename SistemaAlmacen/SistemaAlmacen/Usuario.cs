using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SistemaAlmacen
{
    class Usuario
    {
        int id;
        String usuario;
        String contraseña;
        String departamento;
        String cargo;
        char estatus;

        public void InsertarUsuario(String Usuario, String Contraseña, String Departamento, String Cargo)
        {
            this.usuario = Usuario;
            this.contraseña = Contraseña;
            this.departamento = Departamento;
            this.cargo = Cargo;

            Conexion cone = new Conexion();
            cone.Configurar();
            cone.Conectar();

            SqlCommand query = cone.conex.CreateCommand();
            String consulta = String.Format("insert into usuario(usuario, contraseña, dpto, cargo, estatus) values('{0}', '{1}', '{2}', '{3}', 'a');", usuario, contraseña, departamento, cargo);
            query.CommandText = consulta;

            try
            {
                query.ExecuteNonQuery();
                MessageBox.Show("Usuario agregado exitosamente!", "Agregar usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show("Error al agregar el nuevo usuario: " + sqlex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cone.Cerrar();
        }

        public void ActualizarUsuario(int Id, String Usuario, String Contraseña, String Departamento, String Cargo, char Estatus)
        {
            this.id = Id;
            this.usuario = Usuario;
            this.contraseña = Contraseña;
            this.departamento = Departamento;
            this.cargo = Cargo;
            this.estatus = Estatus;

            Conexion cone = new Conexion();
            cone.Configurar();
            cone.Conectar();

            SqlCommand query = cone.conex.CreateCommand();
            String consulta = String.Format("update usuario set usuario='{0}', contraseña='{1}', dpto='{2}', cargo='{3}', estatus='{4}' where id={5};", usuario, contraseña, departamento, cargo, estatus, id);
            query.CommandText = consulta;

            try
            {
                query.ExecuteNonQuery();
                MessageBox.Show("Usuario actualizado exitosamente!", "Actualización de usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqlex)
            {
            }
            cone.Cerrar();

        }

        public SqlDataReader SeleccionarUsuario(int Id)
        {
            this.id = Id;
            Conexion cone = new Conexion();
            cone.Configurar();
            cone.Conectar();

            SqlCommand query = cone.conex.CreateCommand();
            String consulta = String.Format("select usuario, contraseña, dpto, cargo, estatus from usuario where id={0};", id);
            query.CommandText = consulta;

            try
            {
                return query.ExecuteReader();
            }
            catch(SqlException sqlex)
            {
                
            }
            cone.Cerrar();
            return null;
        }

        public void EliminarUsuarios(String[] Id)
        {
            Conexion cone = new Conexion();
            cone.Configurar();
            cone.Conectar();
            String ids = String.Join(",", Id);
            
            SqlCommand query = cone.conex.CreateCommand();
            String consulta = String.Format("update usuario set estatus='b' where id in({0});", ids);
            query.CommandText = consulta;

            try
            {
                query.ExecuteNonQuery();
                MessageBox.Show("Usuario(s) dado(s) de baja exitosamente!", "Eliminar usuario(s)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException sqlex)
            {

            }
            cone.Cerrar();
        }
    }
}
