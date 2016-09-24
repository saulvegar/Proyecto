using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace SistemaAlmacen
{
    class Factura 
    {
        //se definen las variables para cada uno de los campos que tiene la tabla factura
        int id_factura;
        String numFactura;
        int id_proveedor;
        DateTime fecha_entrada;
        DateTime fecha_ultima_entrada;
        String concepto;
        Double importe;

        //método para insertar una nueva factura
        public void InsertarFactura(String NumFactura, int Id_Proveedor,  DateTime Fecha_entrada, DateTime Fecha_ultima_entrada, String Concepto, Double Importe)
        {
            this.id_proveedor = Id_Proveedor;
            this.numFactura = NumFactura;
            this.fecha_entrada = Fecha_entrada;
            this.fecha_ultima_entrada = Fecha_ultima_entrada;
            this.concepto = Concepto;
            this.importe = Importe;

            Conexion cone = new Conexion();
            cone.Configurar();
            cone.Conectar();

            SqlCommand procedimiento = new SqlCommand("InsertarFactura", cone.conex);
            procedimiento.CommandType = CommandType.StoredProcedure;
            procedimiento.Parameters.Add("@id_factura", SqlDbType.Int).Value = id_factura;
            procedimiento.Parameters.Add("@numeroFactura", SqlDbType.Int).Value = numFactura;
            procedimiento.Parameters.Add("@id_proveedor", SqlDbType.Int).Value = id_proveedor;
            procedimiento.Parameters.Add("@fecha_entrada", SqlDbType.NVarChar).Value = fecha_entrada;
            procedimiento.Parameters.Add("@fecha_ultima_entrada", SqlDbType.NVarChar).Value = fecha_ultima_entrada;
            procedimiento.Parameters.Add("@concepto", SqlDbType.NVarChar).Value = concepto;
            procedimiento.Parameters.Add("@importe", SqlDbType.Real).Value = importe;

            try
            {
                procedimiento.ExecuteNonQuery();
            }
            catch (SqlException sqlex)
            {
                //MessageBox.Show("Error al agregar la nueva factura: " + sqlex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cone.Cerrar();
        }

        //método para actualizar una nueva factura
        public void ActualizarFactura(int Id_Factura, int Id_Proveedor, DateTime Fecha_entrada, DateTime Fecha_ultima_entrada, String Concepto, Double Importe)
        {
            this.id_factura = Id_Factura;
            this.id_proveedor = Id_Proveedor;
            this.fecha_entrada = Fecha_entrada;
            this.fecha_ultima_entrada = Fecha_ultima_entrada;
            this.concepto = Concepto;
            this.importe = Importe;

            Conexion cone = new Conexion();
            cone.Configurar();
            cone.Conectar();

            SqlCommand query = cone.conex.CreateCommand();
            //String consulta = String.Format("update articulo set nombre='{0}', descripcion='{1}', unidad='{2}', tipo='{3}', precio_uni={4}, f_entrada='{5}', f_salida='{6}', cantidad={7}, existencia={8}, precio_prod={9}, estatus='{10}' where id={11};", nombre, descricpion, unidad, tipo, precio_uni, f_entrada, f_salida, cantidad, existencia, precio_prod, estatus, id);
            //String consulta = String.Format("execute ActualizarFactura {2}, {3}, {4}, '{5}', '{6}', '{7}', {8};", id_factura, id_proveedor, cantidad, precio_uni, total, fecha_entrada, fecha_ultima_entrada, concepto, importe);
            //query.CommandText = consulta;

            try
            {
                query.ExecuteNonQuery();
                MessageBox.Show("Factura actualizada exitosamente!", "Actualización de factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(SqlException sqlex)
            {
                MessageBox.Show("Algo salió mal. " + sqlex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cone.Cerrar();

        }

        //metodo que banea una o varias facturas
        public void EliminarFacturas(String[] Id)
        {
            Conexion cone = new Conexion();
            cone.Configurar();
            cone.Conectar();
            String ids = String.Join(",", Id);

            SqlCommand proc = new SqlCommand("EliminarFactura", cone.conex);
            proc.CommandType = CommandType.StoredProcedure;
            proc.Parameters.Add("@lista_ids", SqlDbType.Int).Value = ids;

            try
            {
                proc.ExecuteNonQuery();
                MessageBox.Show("Factura(s) dada(s) de baja exitosamente!", "Dar de baja factura(s)", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(SqlException sqlex)
            {
                MessageBox.Show("Algo salió mal. " + sqlex.Message, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cone.Cerrar();
        }
    }
}
