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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int id_grupo = int.Parse(tbIdGrupo.Text.ToString().Trim());
            String nombre = tbNombre.Text.ToString().Trim();
            String descripcion = tbDescripcion.Text.ToString().Trim(); ;
            String unidad = cbUnidad.Text.ToString().Trim();
            //int id_local = int.Parse(txtIdLocal.Text.ToString().Trim());

            Articulo a = new Articulo();
            a.InsertarArticulo(id_grupo, nombre, descripcion, unidad);
            
            ControlCollection ctrls = (ControlCollection) this.Controls;
            Limpiar.VaciarCampos(ctrls);
            
            //this.Hide();
        }

        private void tbIdGrupo_Click(object sender, EventArgs e)
        {
            Seleccionar s = new Seleccionar("ListarGrupos", "Grupo", "Seleccione un grupo");
            s.Text = "Catálogo de grupos";

            DialogResult res = s.ShowDialog();

            if (res == DialogResult.OK)
            {
                tbIdGrupo.Text = s.Id.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tbIdArticulo_Click(object sender, EventArgs e)
        {
            Seleccionar s = new Seleccionar("ListarArticulos", "Articulo", "Seleccione el artículo:");
            s.Text = "Catálogo de artículos";

            DialogResult res = s.ShowDialog();
            if (res == DialogResult.OK)
            {
                tbIdArticulo.Text = s.Id.ToString();
            }
        }

        private void tbIdLocalizacion_Click(object sender, EventArgs e)
        {
            Seleccionar s = new Seleccionar("ListarLocalizaciones", "Localizacion", "Seleccione la localización");
            s.Text = "Catálogo de localizaciones";

            DialogResult res = s.ShowDialog();
            if (res == DialogResult.OK)
            {
                tbIdLocalizacion.Text = s.Id.ToString();
            }
        }
    }
}
