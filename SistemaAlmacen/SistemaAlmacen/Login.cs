using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SistemaAlmacen
{
    public partial class Login : Form
    {
        private Conexion conexion;

        public Login(Conexion c)
        {
            conexion = c;
            InitializeComponent();

            //conexion.Configurar();
            conexion.Conectar();
            
            SqlCommand query = conexion.conex.CreateCommand();
            String consulta = "select Usuario from Usuario;";
            query.CommandText = consulta;
            try
            {
                SqlDataReader reader = query.ExecuteReader();

                while (reader.Read())
                {
                    cbUser.Items.Add(reader[0].ToString());
                }

                conexion.Cerrar();
            }
            catch (Exception e)
            {
                MessageBoxButtons tipoBoton = MessageBoxButtons.OK;
                MessageBoxIcon icono = MessageBoxIcon.Error;
                MessageBox.Show("No se pudo conectar a la base de datos." + " " + e.Message, "Error del servidor", tipoBoton, icono);
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Obtengo el texto del combo box de nombre de usuario y del textbox de contraseña
            String nombreUsuario = cbUser.Text.Trim();
            String contraseña = txtContraseña.Text.Trim();

            try
            {
                //si el usuario y la contraseña son correctos muestra la patalla principal
                if (Autentificar(nombreUsuario, contraseña) > 0)
                {
                    Principal princi = new Principal();
                    princi.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Has introducido un nombre de usuario o contraseña incorrecto(a) o su usuario actualmente se encuentra dado de baja.", "Error de autenticación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Error, no se pudo consultar el usuario en la base de datos. " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //cbUser.Text = "";
            //txtContraseña.Clear();
            ControlCollection ctrls = (ControlCollection) this.Controls;
            Limpiar.VaciarCampos(ctrls);
        }

        //este método comprueba si el usuario existe en la tabla y si la contraseña ingresada es correcta
        public int Autentificar(String usuario, String contraseña)
        {
            int resultado = -1;

            conexion.Conectar();
            SqlCommand query = conexion.conex.CreateCommand();
            String consulta = String.Format("select * from Usuario where usuario='{0}' and contraseña='{1}' and estatus='a';", usuario, contraseña);
            query.CommandText = consulta;

            SqlDataReader reader = query.ExecuteReader();

            while (reader.Read())
            {
                resultado = 1;
            }
            conexion.Cerrar();

            return resultado;
        }

        

        
    }
}
