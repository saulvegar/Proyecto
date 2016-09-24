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
    public partial class Grupos : Form
    {
        private static String tableName = "grupo";
        private String sqlString = "select * from " + tableName + ";";
        Conexion c = new Conexion();

        public Grupos()
        {
            InitializeComponent();
        }

        private void Grupos_Load(object sender, EventArgs e)
        {
            c.cargarDatos(dgvGrupos, sqlString, tableName);
        }
    }
}
