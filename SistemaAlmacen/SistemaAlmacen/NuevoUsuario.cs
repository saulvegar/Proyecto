using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaAlmacen
{
    public partial class NuevoUsuario : Form
    {
        public NuevoUsuario()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text.Trim();
            String contraseña = txtContrasena.Text.Trim();
            String dpto = txtDepartamento.Text.Trim();
            String cargo = txtCargo.Text.Trim();

            Usuario u = new Usuario();
            u.InsertarUsuario(usuario, contraseña, dpto, cargo);
            this.Hide();
        }
    }
}
