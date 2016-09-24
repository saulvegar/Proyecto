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
    public partial class NuevoGrupo : Form
    {
        public NuevoGrupo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String nombre = tbNombre.Text.Trim();
            Grupo g = new Grupo();
            g.InsertarGrupo(nombre);
        }
    }
}
