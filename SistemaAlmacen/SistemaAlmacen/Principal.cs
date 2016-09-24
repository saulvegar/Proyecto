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
            a.Show();
        }

        private void localizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Localizaciones l = new Localizaciones();
            l.Show();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departamentos d = new Departamentos();
            d.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Facturas f = new Facturas();
            f.Show();
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grupos g = new Grupos();
            g.Show();
        }

        private void tsbFacturas_Click(object sender, EventArgs e)
        {
            Facturas f = new Facturas();
            f.Show();
        }

        private void tsbArticulos_Click(object sender, EventArgs e)
        {
            Articulos a = new Articulos();
            a.Show();
        }
    }
}
