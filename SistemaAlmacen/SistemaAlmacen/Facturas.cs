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
    public partial class Facturas : Form
    {
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
    }
}
