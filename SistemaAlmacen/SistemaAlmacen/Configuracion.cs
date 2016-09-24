using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace SistemaAlmacen
{
    public partial class Configuracion : Form
    {
        String direccion = "C:\\SAC\\";
        String nombrearchivo = "SAConfig.txt";
        Login loggito;
        ErrorProvider ep = new ErrorProvider();

        public Configuracion()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (txtServidor.Text.Trim() != String.Empty && txtBaseDatos.Text.Trim() != String.Empty && txtUsuario.Text.Trim() != String.Empty && txtContrasena.Text.Trim() != String.Empty)
            {
                try
                {
                    String ruta = direccion + nombrearchivo;
                    StreamWriter escritor = default(StreamWriter);
                    escritor = File.AppendText(ruta);
                    //escritor.WriteLine();
                    escritor.WriteLine(txtServidor.Text);
                    escritor.WriteLine(txtBaseDatos.Text);
                    escritor.WriteLine(txtUsuario.Text);
                    escritor.WriteLine(txtContrasena.Text);
                    escritor.Flush();
                    escritor.Close();
                    MessageBox.Show("Archivo SAConfig Creado con éxito");

                    Conexion c = new Conexion();
                    c.Configurar();
                    loggito = new Login(c);
                    loggito.Show();
                    this.Hide();
                    //this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Escritura realizada incorrectamente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ControlCollection ctrls = (ControlCollection) this.Controls;

            //TextBox[] arr = {txtServidor, txtBaseDatos, txtUsuario, txtContrasena};
            Limpiar.VaciarCampos(ctrls);
        }

        private void txtServidor_Validated(object sender, EventArgs e)
        {
            if (txtServidor.Text.Trim() == String.Empty)
            {
                ep.SetError(txtServidor, "No ha especificado el nombre del servidor");
                //txtServidor.Focus();
            }
            else
            {
                ep.Clear();
            }
        }

        private void txtBaseDatos_Validated(object sender, EventArgs e)
        {
            if (txtBaseDatos.Text.Trim() == String.Empty)
            {
                ep.SetError(txtBaseDatos, "No ha especificado la base de datos");
                //txtBaseDatos.Focus();
            }
            else
            {
                ep.Clear();
            }
        }

        private void txtUsuario_Validated(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Trim() == String.Empty)
            {
                ep.SetError(txtUsuario, "No ha especificado el nombre de usuario");
                //txtUsuario.Focus();
            }
            else
            {
                ep.Clear();
            }
        }

        private void txtContrasena_Validated(object sender, EventArgs e)
        {
            if (txtContrasena.Text.Trim() == String.Empty)
            {
                ep.SetError(txtContrasena, "No ha especificado la contraseña");
                //txtContrasena.Focus();
            }
            else
            {
                ep.Clear();
            }
        }

        private void Configuracion_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
