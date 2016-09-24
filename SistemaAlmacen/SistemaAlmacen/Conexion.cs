using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Threading;

namespace SistemaAlmacen
{
    public class Conexion
    {
        //Se declara un atributo de la clase de tipo sqlconnection con el cual se hara el enlace con la base de datos
        //Asi como las variables que necesita para conectarse
        public SqlConnection conex;
        String servidor = "";
        String baseDatos = "";
        String usuario = "";
        String contrasena = "";

        //Este es el constructor de la clase
        public Conexion()
        {
        }

        //Este mtodo retorno el objeto conex de tipo sqlConection
        public SqlConnection Conex
        {
            get
            {
                return conex;
            }
        }

        //Este metodo lee el archivo txt de configuración y setea la variables de la clase con los valores de las líneas del txt
        public void Configurar()
        {
            //ruta del archivo config que contiene los datos de conexion a bd
            StreamReader objReader = new StreamReader("C:\\SAC\\SAConfig.txt");

            //se define una variable de tipo string inicializada en vacio
            String sLine = "";
            //se define una lista
            List<String> arrText = new List<String>();
            
            //en este ciclo lee las lineas que tenga el txt mientras el numero de lineas se mayor que cero
            do
            {
                sLine = objReader.ReadLine();
                // leer lineas del archivo txt
                // si no tiene nada el archivo entonces agregara linea
                if ((sLine != null))
                {
                    arrText.Add(sLine);
                }
            } while (!(sLine == null));

            objReader.Close();

            servidor = arrText.ElementAt(0);
            baseDatos = arrText.ElementAt(1);
            usuario = arrText.ElementAt(2);
            contrasena = arrText.ElementAt(3);
        }

        //este metodo conecta a la base de datos
        public void Conectar()
        {
            try
            {
                /*la variable de clase conex se instancia con los parametros del txt para hacer la conexion 
                 * y el metodo open de esta variable es el que abre la conexion*/ 
                conex = new SqlConnection("Data Source=" + servidor + "; Database=" + baseDatos + ";User ID="+usuario+";Password="+contrasena);
                conex.Open();
                
            }

            //si no es posible aer la conexion o algo sale mal arroja un mensaje a la pantalla diciendo que no se pudo conectar
            catch (SqlException e)
            {
                MessageBoxButtons tipoBoton = MessageBoxButtons.OK;
                MessageBoxIcon icono = MessageBoxIcon.Error;
                MessageBox.Show("No se conectó con la base de datos. " + e.Message, "Error del servidor", tipoBoton, icono);
            }
        }

        //cierra la conexion mediante el metodo close de la variable conex
        public void Cerrar()
        {
            conex.Close();
            conex.Dispose();
        }

        /*este metodo generico llena cualquier datagrid no importa en que formulario se encuentre con 
         * los datos de a consulta a la tabla que se le pasen*/
        public void cargarDatos(DataGridView dgv, String Nombresp, String table)
        {
            Configurar();
            Conectar();

            SqlCommand sp = new SqlCommand(Nombresp, conex);
            sp.CommandType = CommandType.StoredProcedure;

            try
            {
                //SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conex);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sp);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, table);
                dgv.DataSource = ds;
                dgv.DataMember = table;
                Cerrar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo cargar los usuarios en la tabla. " + ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void exportarExcel(String sql)
        {
            Configurar();
            Conectar();
            SqlCommand query = conex.CreateCommand();
            query.CommandText = sql;

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = query;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                //dgv.DataSource = bSource;
                sda.Update(dbdataset);


                DataSet ds = new DataSet("New_DataSet");
                ds.Locale = Thread.CurrentThread.CurrentCulture;

                sda.Fill(dbdataset);
                ds.Tables.Add(dbdataset);
                
            }
            catch(SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
        }

    }
}
