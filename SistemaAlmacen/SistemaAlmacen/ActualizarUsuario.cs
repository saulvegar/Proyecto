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
    public partial class ActualizarUsuario : Form
    {
        int id;

        public ActualizarUsuario(int Id)
        {
            this.id = Id;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ActualizarUsuario_Load(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            SqlDataReader r = u.SeleccionarUsuario(id);

            while (r.Read())
            {
                txtUsuario.Text = r.GetValue(1).ToString();
                txtContrasena.Text = r.GetValue(2).ToString();
                txtDepartamento.Text = r.GetValue(3).ToString();
                txtCargo.Text = r.GetValue(4).ToString();

                if (r.GetValue(5).ToString().Equals("a"))
                {
                    rbActivo.Checked = true;
                }
                if (r.GetValue(5).ToString().Equals("b"))
                {
                    rbInactivo.Checked = true;
                }
            }
            r.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {        
            String usuario = txtUsuario.Text.Trim();
            String contraseña = txtContrasena.Text.Trim();
            String departamento = txtDepartamento.Text.Trim();
            String cargo = txtCargo.Text.Trim();
            char estatus = ' ';

            if (rbActivo.Checked == true)
            {
                estatus = 'a';
            }
            if (rbInactivo.Checked == true)
            {
                estatus = 'b';
            }

            Usuario u = new Usuario();
            u.ActualizarUsuario(id, usuario, contraseña, departamento, cargo, estatus);
        }
    }
}
