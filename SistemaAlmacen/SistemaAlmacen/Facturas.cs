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
    public partial class Facturas : Form
    {
        private static String tableName = "FacturaConArticulos";
        Conexion c = new Conexion();
        String nombreProcedimiento = "ListarFacturasConArticulos";

        public Facturas()
        {
            InitializeComponent();
        }

        private void btnNueva_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnNueva, "Agregar nueva factura");
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            NuevaFactura nf = new NuevaFactura();
            nf.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarFactura af = new ActualizarFactura();
            af.Show();
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            c.cargarDatos(dgvFacturas, nombreProcedimiento, tableName);
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFacturas.SelectedRows.Count > 1)
            {
                btnEditar.Enabled = false;
            }
            else
            {
                btnEditar.Enabled = true;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String[] ids = new String[dgvFacturas.SelectedRows.Count];

            for (int i = 0; i < dgvFacturas.SelectedRows.Count; i++)
            {
                ids[i] = dgvFacturas.SelectedRows[i].Cells[0].Value.ToString();
            }
            Factura f = new Factura();
            f.EliminarFacturas(ids);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            c.cargarDatos(dgvFacturas, nombreProcedimiento, tableName);
        }
    }
}
