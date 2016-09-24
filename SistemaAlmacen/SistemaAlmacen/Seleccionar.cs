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
    public partial class Seleccionar : Form
    {
        Conexion c = new Conexion();
        String table;
        String nombreProcedimiento;
        String textLabel;
        private int id = 0;

        public int Id
        {
            get
            {
                return id;
            }
        }

        public Seleccionar(String NombreProcedimiento, String Table, String TextLabel)
        {
            this.table = Table;
            this.nombreProcedimiento = NombreProcedimiento;
            this.textLabel = TextLabel;
            InitializeComponent();
        }

        private void Seleccionar_Load(object sender, EventArgs e)
        {
            lblTexto.Text = textLabel;
            c.cargarDatos(dgvSeleccionar, nombreProcedimiento, table);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                id = int.Parse(dgvSeleccionar.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
