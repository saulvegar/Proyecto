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
    public partial class NuevoArticulo : Form
    {
        public NuevoArticulo()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtIdGrupo.Text.ToString().Trim());
            String nombre = txtNombre.Text.ToString().Trim();
            String descripcion = txtDescripcion.Text.ToString().Trim(); ;
            String unidad = cbUnidad.Text.ToString().Trim();
            //int id_local = int.Parse(txtIdLocal.Text.ToString().Trim());

            Articulo a = new Articulo();
            //a.InsertarArticulo(id, nombre, descripcion, unidad, id_local);
            this.Hide();
        }

        private void txtIdGrupo_Click(object sender, EventArgs e)
        {
            String sql = "select * from Grupo;";
            Seleccionar s = new Seleccionar(sql, "Grupo");
            s.Show();
        }
    }
}
