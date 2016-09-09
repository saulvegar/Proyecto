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
            int id = int.Parse(txtId.Text.ToString().Trim());
            String nombre = txtNombre.Text.ToString().Trim();
            String descripcion = txtDescripcion.Text.ToString().Trim(); ;
            String unidad = txtUnidad.Text.ToString().Trim();
            String tipo = txtUnidad.Text.ToString().Trim();
            int precio_uni = int.Parse(txtPrecioUnitario.Text.ToString().Trim());
            //DateTime f_entrada = dtpFechaEntrada.Value.Date;
            //DateTime f_salida = dtpFechaSalida.Value.Date;
            String f_entrada = dtpFechaEntrada.Value.Day + "/" + dtpFechaEntrada.Value.Month + "/" + dtpFechaEntrada.Value.Year;
            String f_salida = dtpFechaSalida.Value.Day + "/" + dtpFechaSalida.Value.Month + "/" + dtpFechaSalida.Value.Year;
            int cantidad = int.Parse(txtCantidad.Text.ToString().Trim());
            int existencia = int.Parse(txtExistencia.Text.ToString().Trim());
            int precio_prod = int.Parse(txtPrecioProducto.Text.ToString().Trim());
            int id_local = int.Parse(txtIdLocal.Text.ToString().Trim());

            Articulo a = new Articulo();
            a.InsertarArticulo(id, nombre, descripcion, unidad, tipo, precio_uni, f_entrada, f_salida, cantidad, existencia, precio_prod, id_local);
            this.Hide();
        }
    }
}
