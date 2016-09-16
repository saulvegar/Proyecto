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
        int id_grupo;

        public NuevoArticulo()
        {
            InitializeComponent();
        }

        public NuevoArticulo(int Id_Grupo)
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int id_grupo = int.Parse(txtIdGrupo.Text.ToString().Trim());
            String nombre = txtNombre.Text.ToString().Trim();
            String descripcion = txtDescripcion.Text.ToString().Trim(); ;
            String unidad = cbUnidad.Text.ToString().Trim();
            //int id_local = int.Parse(txtIdLocal.Text.ToString().Trim());

            Articulo a = new Articulo();
            a.InsertarArticulo(id_grupo, nombre, descripcion, unidad);
            this.Hide();
        }

        private void txtIdGrupo_Click(object sender, EventArgs e)
        {
            String sql = "select * from Grupo;";
            String tituloForm = "Catálogo de grupos";
            String textLabel = "Seleccione un grupo:";
            Seleccionar s = new Seleccionar(sql, "Grupo", textLabel);
            s.Text = tituloForm;

            DialogResult res = s.ShowDialog();

            if (res == DialogResult.OK)
            {
                txtIdGrupo.Text = s.id.ToString();
            }
            //s.Show();


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
