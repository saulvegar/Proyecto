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

        public Seleccionar(String Sql, String Table)
        {
            this.sql = Sql;
            InitializeComponent();
        }

        private void Seleccionar_Load(object sender, EventArgs e)
        {
            c.cargarDatos(dgvSeleccionar, sql, table);
        }
    }
}
