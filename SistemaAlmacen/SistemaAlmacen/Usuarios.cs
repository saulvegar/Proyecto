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
    public partial class Usuarios : Form
    {
        //private SqlDataAdapter dataAdapter;
        private static String tableName = "usuario";
        private String sqlString = "select * from " + tableName + ";";
        Conexion c = new Conexion();
        String nombreProcedimiento = "ListarUsuarios";

        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            c.cargarDatos(dgvUsuarios, nombreProcedimiento, tableName);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            NuevoUsuario nu = new NuevoUsuario();
            nu.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
            ActualizarUsuario au = new ActualizarUsuario(id);
            au.Show();
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsuarios.SelectedRows.Count > 1)
            {
                btnActualizar.Enabled = false;
            }
            else
            {
                btnActualizar.Enabled = true;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //cargarUsuarios(dgvUsuarios);
            c.cargarDatos(dgvUsuarios, sqlString, tableName);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String[] ids = new String[dgvUsuarios.SelectedRows.Count];

            for (int i = 0; i < dgvUsuarios.SelectedRows.Count; i++)
            {
                ids[i] = dgvUsuarios.SelectedRows[i].Cells[0].Value.ToString();
            }
            Usuario u = new Usuario();
            u.EliminarUsuarios(ids);
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            String sql = String.Format("select * from usuario where usuario like '%{0}%';", txtBuscar.Text.Trim());
            c.cargarDatos(dgvUsuarios, sql, tableName);
        }
    }
}
