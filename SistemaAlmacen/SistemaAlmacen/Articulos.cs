using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SistemaAlmacen
{
    public partial class Articulos : Form
    {
        private static String tableName = "articulo";
        private String sqlString = "select * from " + tableName + ";";
        Conexion c = new Conexion();

        public Articulos()
        {
            InitializeComponent();
        }

        private void Artículos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'almacenArticulos.Articulos' Puede moverla o quitarla según sea necesario.
            //this.articulosTableAdapter.Fill(this.almacenArticulos.Articulos);
            c.cargarDatos(dgvArticulos, sqlString, tableName);

        }

        private void nuevoArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NuevoArticulo na = new NuevoArticulo();
            na.Show();
        }

        private void darDeBajaArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void actualizarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvArticulos.CurrentRow.Cells[0].Value.ToString());
            ActualizarArticulo aa = new ActualizarArticulo(id);
            aa.Show();
        }

        private void btnAñadir_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnAñadir, "Agregar artículo");
        }

        private void btnEliminar_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnEliminar, "Dar de baja artículo");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnEditar, "Editar articulo");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnImprimir, "Imprimir");
        }

        private void Exportar_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnExportar, "Exportar a Excel");
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            String sql = String.Format("select * from articulo where nombre like '%{0}%' or descripcion like '%{1}%';", txtBuscar.Text.Trim(), txtBuscar.Text.Trim());
            c.cargarDatos(dgvArticulos, sql, tableName);
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            //SaveFileDialog fichero = new SaveFileDialog();
            //fichero.Filter = "Excel (*.xls)|*.xls";
            //if (fichero.ShowDialog() == DialogResult.OK)
            //{
            //    Microsoft.Office.Interop.Excel.Application aplicacion;
            //    Microsoft.Office.Interop.Excel.Workbook libro_trabajo;
            //    Microsoft.Office.Interop.Excel.Worksheet hoja_trabajo;
            //    aplicacion = new Microsoft.Office.Interop.Excel.Application();
            //    libro_trabajo = aplicacion.Workbooks.Add();
            //    hoja_trabajo = (Microsoft.Office.Interop.Excel.Worksheet) libro_trabajo.Worksheets.get_Item(1);

            //    for (int i = 0; i < dgvArticulos.Rows.Count - 1; i++)
            //    {
            //        for (int j = 0; j < dgvArticulos.Columns.Count; j++)
            //        {
            //            hoja_trabajo.Cells[i + 1, j + 1] = dgvArticulos.Rows[i].Cells[j].Value.ToString();
            //        }
            //    }
            //    libro_trabajo.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
            //    libro_trabajo.Close(true);
            //    aplicacion.Quit();
            //}
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            NuevoArticulo na = new NuevoArticulo();
            na.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String[] ids = new String[dgvArticulos.SelectedRows.Count];

            for (int i = 0; i < dgvArticulos.SelectedRows.Count; i++)
            {
                ids[i] = dgvArticulos.SelectedRows[i].Cells[0].Value.ToString();
            }
            Articulo u = new Articulo();
            u.EliminarArticulos(ids);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvArticulos.CurrentRow.Cells[0].Value.ToString());
            ActualizarArticulo aa = new ActualizarArticulo(id);
            aa.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            c.cargarDatos(dgvArticulos, sqlString, tableName);
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.SelectedRows.Count > 1)
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
