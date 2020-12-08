using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
      public class DetalleFacturaVenta
    {
        public DetalleFacturaVenta(FacturaVenta factura, Producto producto, int cantidadProducto)
        {
            CodigoVenta = factura.CodigoFactura;
            CodigoProducto = producto.CodigoProducto;
            CantidadProducto = cantidadProducto;
            Valorunitario = producto.Precio;


        }

        public DetalleFacturaVenta()
        {

        }

        public string CodigoVenta { get; set; }
        public string CodigoProducto { get; set; }
        public int CantidadProducto { get; set; }
        public int Valorunitario { get; set; }        
        public double ValorSubTotal { get { return Valorunitario * CantidadProducto; } set { } }

    }
}
