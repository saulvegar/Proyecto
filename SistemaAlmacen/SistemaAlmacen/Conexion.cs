using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Threading;
//using ExcelLibrary.CompoundDocumentFormat;

namespace SistemaAlmacen
{
    public class Conexion
    {
        public SqlConnection conex;
        String servidor = "";
        String baseDatos = "";
        String usuario = "";
        String contrasena = "";

        public Conexion()
        {
        }

        public SqlConnection Conex
        {
            get
            {
                return conex;
            }
        }

        public void Configurar()
        {
            //ruta del archivo config que contiene los datos de conexion a bd
            StreamReader objReader = new StreamReader("C:\\SAC\\SAConfig.txt");

            String sLine = "";
            List<String> arrText = new List<String>();
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

        public void Conectar()
        {
            try
            {
                conex = new SqlConnection("Data Source=" + servidor + "; Database=" + baseDatos + ";User ID="+usuario+";Password="+contrasena);
                conex.Open();
                
            }
            catch (SqlException e)
            {
                MessageBoxButtons tipoBoton = MessageBoxButtons.OK;
                MessageBoxIcon icono = MessageBoxIcon.Error;
                MessageBox.Show("No se conectó con la base de datos. " + e.Message, "Error del servidor", tipoBoton, icono);
            }
        }

        public void Cerrar()
        {
            conex.Close();
            conex.Dispose();
        }

        public void cargarDatos(DataGridView dgv, String sql, String table)
        {
            Configurar();
            Conectar();

            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conex);

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
