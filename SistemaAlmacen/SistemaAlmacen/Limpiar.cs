using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaAlmacen
{
    static class Limpiar
    {

        //public void VaciarCampos()
        //{
        //    foreach (Control ctrl in this.Controls)
        //    {
        //        if (ctrl is TextBox)
        //        {
        //            TextBox text = ctrl as TextBox;
        //            text.Clear();
        //        }
        //    }
        //}
        public static void Vaciar(TextBox[] arreglo)
        {
            foreach (TextBox t in arreglo)
            {
                t.Clear();
            }
        }

        public static List<T> ObtenerControles<T>(this Control container) where T : Control
        {
         List<T> controls = new List<T>();
         foreach (Control c in container.Controls)
         {
           if (c is T)
             controls.Add((T)c);
           controls.AddRange(ObtenerControles<T>(c));
         }
        return controls;
    }
    }
}
