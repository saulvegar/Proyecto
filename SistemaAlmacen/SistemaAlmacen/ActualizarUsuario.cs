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
                tbUsuario.Text = r.GetValue(1).ToString();
                tbContrasena.Text = r.GetValue(2).ToString();
                tbDepartamento.Text = r.GetValue(3).ToString();
                tbCargo.Text = r.GetValue(4).ToString();

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
            String usuario = tbUsuario.Text.Trim();
            String contraseña = tbContrasena.Text.Trim();
            String departamento = tbDepartamento.Text.Trim();
            String cargo = tbCargo.Text.Trim();
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
