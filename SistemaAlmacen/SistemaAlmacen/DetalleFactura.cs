using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace SistemaAlmacen
{
    class DetalleFactura
    {
        int id_factura;
        int id_articulo;
        int cantidad;
        Double precio_uni;
        Double total;

        public void InsertarDetalleFactura(int Id_Factura, int Id_Articulo, int Cantidad, Double Precio_Uni, Double Total)
        {
            this.id_factura = Id_Factura;
            this.id_articulo = Id_Articulo;
            this.cantidad = Cantidad;
            this.precio_uni = Precio_Uni;
            this.total = Total;

            Conexion c = new Conexion();
            c.Configurar();
            c.Conectar();

            SqlCommand procedimiento = new SqlCommand("InsertarDetalleFactura", c.conex);
            procedimiento.CommandType = CommandType.StoredProcedure;
            procedimiento.Parameters.Add("@id_factura", SqlDbType.Int).Value = id_factura;
            procedimiento.Parameters.Add("@id_articulo", SqlDbType.Int).Value = id_articulo;
            procedimiento.Parameters.Add("@cantidad", SqlDbType.Int).Value = cantidad;
            procedimiento.Parameters.Add("@precio_uni", SqlDbType.Decimal).Value = precio_uni;
            procedimiento.Parameters.Add("@total", SqlDbType.Decimal).Value = total;

            try
            {
                procedimiento.ExecuteNonQuery();
            }
            catch (SqlException sqlex)
            {
                 
            }
        }
    }
}
