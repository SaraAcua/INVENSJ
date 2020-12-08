using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class DetalleFacturaCompra 
    {

        public DetalleFacturaCompra(FacturaCompra factura, Producto producto,  int cantidadProducto)
        {
            CodigoCompra = factura.CodigoFactura;
            CodigoProducto = producto.CodigoProducto;
            CantidadProducto = cantidadProducto;
            Valorunitario = producto.Costo;
            



        }
            
        public DetalleFacturaCompra()
        {
           
        }

        public string CodigoCompra { get; set; }
        public string CodigoProducto { get; set; }
        public int CantidadProducto { get; set; }
        public int Valorunitario { get; set; }
        public double ValorSubTotal { get { return Valorunitario * CantidadProducto; } set { } }



        

    }
}
