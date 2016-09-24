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
    public partial class NuevaLocalizacion : Form
    {
        public NuevaLocalizacion()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int Num_Cuviculo = int.Parse(tbNumCuviculo.Text.Trim());
            Localizacion l = new Localizacion();
            l.InsertarLocalizacion(Num_Cuviculo);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        
        
    }
}
