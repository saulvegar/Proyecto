using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SistemaAlmacen
{
    static class Limpiar
    {
        //Este método vacia todos los campos del formulario
        public static void VaciarCampos(System.Windows.Forms.Control.ControlCollection Controls)
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox text = ctrl as TextBox;
                    text.Clear();
                }
                if (ctrl is ComboBox)
                {
                    ComboBox text = ctrl as ComboBox;
                    text.Text = "Seleccionar";
                }
                if (ctrl is DateTimePicker)
                {
                    DateTime fecha = DateTime.Now;
                    DateTimePicker picker = ctrl as DateTimePicker;
                    picker.Value = fecha;
                }
            }
        }

        //este metodo borra todos los campos de un formulario siempre y cuando todos sean de tipo textbox
        public static void Vaciar(TextBox[] arreglo)
        {
            foreach (TextBox t in arreglo)
            {
                t.Clear();
            }
        }  
    }
}
