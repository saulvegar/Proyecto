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
    public partial class Proveedores : Form
    {
        String tableName = "proveedores";
        String nombreProcedimiento = "ListarProveedores";
        Conexion c = new Conexion();

        public Proveedores()
        {
            InitializeComponent();
        }

        private void Proveedores_Load(object sender, EventArgs e)
        {
            c.cargarDatos(dgvProveedores, nombreProcedimiento, tableName);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoProveedor np = new NuevoProveedor();
            np.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            ActualizarProveedor ap = new ActualizarProveedor();
            ap.Show();
        }

        private void dgvProveedores_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProveedores.SelectedRows.Count > 1)
            {
                btnEditar.Enabled = false;
            }
            else
            {
                btnEditar.Enabled = true;
            }
        }
    }
}
