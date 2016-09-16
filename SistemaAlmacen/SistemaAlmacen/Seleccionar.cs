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
        String sql;
        String table;
        String textLabel;
        public int id;

        public Seleccionar(String Sql, String Table, String TextLabel)
        {
            this.sql = Sql;
            this.table = Table;
            this.textLabel = TextLabel;
            InitializeComponent();
        }

        private void Seleccionar_Load(object sender, EventArgs e)
        {
            lblTexto.Text = textLabel;
            c.cargarDatos(dgvSeleccionar, sql, table);
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            id = int.Parse(dgvSeleccionar.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
