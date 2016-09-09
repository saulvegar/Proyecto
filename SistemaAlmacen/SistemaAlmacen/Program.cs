using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SistemaAlmacen
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            String direccion = "C:\\SAC\\";
            String nombrearchivo = "SAConfig.txt";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Articulos());

            if (System.IO.File.Exists(direccion + nombrearchivo))
            {
                //this.Close();
                Conexion c = new Conexion();
                c.Configurar();
                Application.Run(new Login(c));
                //loggito.Show();
            }
            else
            {
                System.IO.Directory.CreateDirectory("C:\\SAC");
                // crear directorio 
                Application.Run(new Configuracion());
            }
        }
    }
}
