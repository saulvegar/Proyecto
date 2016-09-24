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
        private int id_factura;
        private int id_articulo;
        private int cantidad;
        private Double precio_uni;
        private Double total;

        public int Id_factura
        {
            get { return id_factura; }
            set { id_factura = value; }
        }

        public int Id_articulo
        {
            get { return id_articulo; }
            set { id_articulo = value; }
        }

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public Double Precio_uni
        {
            get { return precio_uni; }
            set { precio_uni = value; }
        }

        public Double Total
        {
            get { return total; }
            set { total = value; }
        }

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
