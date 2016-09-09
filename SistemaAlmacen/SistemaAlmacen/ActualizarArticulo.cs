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
        int id;

        public ActualizarArticulo(int Id)
        {
            this.id = Id;
            InitializeComponent();
        }

        private void ActualizarArticulo_Load(object sender, EventArgs e)
        {
            Conexion cone = new Conexion();
            cone.Configurar();
            cone.Conectar();

            SqlCommand query = cone.conex.CreateCommand();
            String consulta = String.Format("execute ListarArticuloPorId {0};", id);
            query.CommandText = consulta;
            SqlDataReader sdr = query.ExecuteReader();

            while (sdr.Read())
            {
                txtId.Text = sdr.GetValue(0).ToString();
                txtNombre.Text = sdr.GetValue(1).ToString();
                txtDescripcion.Text = sdr.GetValue(2).ToString();
                txtUnidad.Text = sdr.GetValue(3).ToString();
                txtTipo.Text = sdr.GetValue(4).ToString();
                txtPrecioUnitario.Text = sdr.GetValue(5).ToString();
                //DateTime f_entrada = DateTime.Parse(sdr.GetValue(6).ToString(), System.Globalization.CultureInfo.InvariantCulture);
                //DateTime f_salida = DateTime.Parse(sdr.GetValue(7).ToString(), System.Globalization.CultureInfo.InvariantCulture);
                dtpFechaEntrada.Text = sdr.GetValue(6).ToString();
                dtpFechaSalida.Text = sdr.GetValue(7).ToString();
                
                txtCantidad.Text = sdr.GetValue(8).ToString();
                txtExistencia.Text = sdr.GetValue(9).ToString();
                txtPrecioProducto.Text = sdr.GetValue(10).ToString();
                txtIdLocal.Text = sdr.GetValue(13).ToString();

                if(sdr.GetValue(11).ToString().Trim().Equals("a"))
                {
                    rbActivo.Checked = true;
                }
                if(sdr.GetValue(11).ToString().Trim().Equals("b"))
                {
                    rbInactivo.Checked = true;
                }
            }
            sdr.Close();
            cone.Cerrar();
        }
    }
}
