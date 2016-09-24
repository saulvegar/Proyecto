using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
        }
    }
}
