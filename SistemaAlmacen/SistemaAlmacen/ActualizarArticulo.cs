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
    public partial class ActualizarArticulo : Form
    {
        int id_articulo;

        public ActualizarArticulo(int Id_Articulo)
        {
            this.id_articulo = Id_Articulo;
            InitializeComponent();
        }

        private void ActualizarArticulo_Load(object sender, EventArgs e)
        {
            Conexion cone = new Conexion();
            cone.Configurar();
            cone.Conectar();

            SqlCommand proc = new SqlCommand("ListarArticuloPorId", cone.conex);
            proc.CommandType = CommandType.StoredProcedure;
            proc.Parameters.Add("@id_articulo", SqlDbType.Int).Value = id_articulo;
            SqlDataReader sdr = proc.ExecuteReader();

            while (sdr.Read())
            {
                tbIdLocalizacion.Text = sdr.GetValue(0).ToString();
                tbNombre.Text = sdr.GetValue(2).ToString();
                tbDescripcion.Text = sdr.GetValue(3).ToString();
                cbUnidad.Text = sdr.GetValue(4).ToString();
                tbId_Grupo.Text = sdr.GetValue(1).ToString();
                tbCantidad.Text = sdr.GetValue(5).ToString();

                if(sdr.GetValue(6).ToString().Trim().Equals("a"))
                {
                    rbActivo.Checked = true;
                }
                if(sdr.GetValue(6).ToString().Trim().Equals("b"))
                {
                    rbInactivo.Checked = true;
                }
            }
            sdr.Close();
            cone.Cerrar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            String nombre = tbNombre.Text.Trim();
            String descripcion = tbDescripcion.Text.Trim();
            String unidad = cbUnidad.Text.Trim();
            int cantidad = int.Parse(tbCantidad.Text.Trim());
            char estatus = '\0';

            if(rbActivo.Checked)
            {
                estatus = 'a';
            }
            if(rbInactivo.Checked)
            {
                estatus = 'b';
            }

            Articulo a = new Articulo();
            a.ActualizarArticulo(id_articulo, nombre, descripcion, unidad, cantidad, estatus);
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
