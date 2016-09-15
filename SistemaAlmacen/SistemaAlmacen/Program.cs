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
            //Se defie la ruta que tendra el archivo txt de configuración
            String direccion = "C:\\SAC\\";
            String nombrearchivo = "SAConfig.txt";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Si el archivo txt ya existe entra en el if
            if (System.IO.File.Exists(direccion + nombrearchivo))
            {
                //Se declara una variable de la clase conexión y se instancia, y se manda llamar al método configurar
                Conexion c = new Conexion();
                c.Configurar();
                Application.Run(new Login(c));
            }
            
            // Si no existe el archivo txt se crea el directorio
            else
            {
                System.IO.Directory.CreateDirectory("C:\\SAC"); 
                Application.Run(new Configuracion());
            }
        }
    }
}
