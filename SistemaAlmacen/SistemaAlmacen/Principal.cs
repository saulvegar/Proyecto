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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Conexion c = new Conexion();
            c.Configurar();
            Login loggito = new Login(c);
            loggito.Show();
        }

        private void cerrarAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            u.Show();
        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Articulos a = new Articulos();
            //this.Hide();
            a.Show();
        }

        private void sistemasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void almacénToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
