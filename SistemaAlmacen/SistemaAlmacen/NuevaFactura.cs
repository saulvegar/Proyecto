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
    public partial class NuevaFactura : Form
    {
        public NuevaFactura()
        {
            InitializeComponent();
        }

        private void tbIdProveedor_Click(object sender, EventArgs e)
        {
            String sql = "exec ListarProveedores;";
            String tituloForm = "Catálogo de proveedores";
            String textLabel = "Seleccione un proveedor:";
            Seleccionar s = new Seleccionar(sql, "Proveedor", textLabel);
            s.Text = tituloForm;

            DialogResult res = s.ShowDialog();

            if (res == DialogResult.OK)
            {
                try
                {
                    tbIdProveedor.Text = s.Id.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Algo salió mal. " + ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbIdArticulo_Click(object sender, EventArgs e)
        {
            String sql = "exec ListarArticulos;";
            String tituloForm = "Catálogo de artículos";
            String textLabel = "Seleccione un artículos:";
            Seleccionar s = new Seleccionar(sql, "Articulo", textLabel);
            s.Text = tituloForm;

            DialogResult res = s.ShowDialog();

            if (res == DialogResult.OK)
            {
                    //txtIdArticulo.Text = s.Id.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int id_proveedor = int.Parse(tbIdProveedor.Text.Trim());
            DateTime fecha_entrada = dtpFechaEntrada.Value;
            DateTime fecha_u_entrada = dtpFechaUEntrada.Value;
            String concepto = tbConcepto.Text.Trim();
            Double importe = Double.Parse(tbImporte.Text.Trim());

            Factura f = new Factura();
            //f.InsertarFactura(id_articulo, id_proveedor, cantidad, precio_unitario, total, fecha_entrada, fecha_u_entrada, concepto, importe);

            ControlCollection ctrls = (ControlCollection)this.Controls;
            Limpiar.VaciarCampos(ctrls);
        }

        private void btnAñadirArticulos_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar s = new Seleccionar("ListarArticulos", "Articulo", "Seleccione un artículo:");
            s.Text = "Catálogo de artículos";

            DialogResult res = s.ShowDialog();

            if (res == DialogResult.OK)
            {
                dgvArticulos.CurrentRow.Cells[0].Value = s.Id;
            }
        }

        private void tbIdArticulo_Click_1(object sender, EventArgs e)
        {
            Seleccionar s = new Seleccionar("ListarArticulos", "Articulo", "Seleccione un artículo");
            s.Text = "Catálogo de artículos";

            DialogResult res = s.ShowDialog();
            if (res == DialogResult.OK)
            {
                tbIdArticulo.Text = s.Id.ToString();
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            String IdArticulo = tbIdArticulo.Text.Trim();
            Double Cantidad = Double.Parse(tbCantidad.Text.Trim());
            Double PrecioUnitario = Double.Parse(tbPrecioUnitario.Text.Trim());
            Double Total = Cantidad * PrecioUnitario;

            dgvArticulos.Rows.Add(IdArticulo, Cantidad, PrecioUnitario, Total);

            tbIdArticulo.Clear();
            tbCantidad.Clear();
            tbPrecioUnitario.Clear();

            tbIdArticulo.Focus();
        }

        private void eliminarFilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow  fila in dgvArticulos.SelectedRows)
            {
                dgvArticulos.Rows.RemoveAt(fila.Index);
            }
        } 
    }
}
