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
            Factura = factura;
            Producto = producto;
            CodigoProducto = producto.CodigoProducto;
            Descripcion = producto.Descripcion;
            CantidadProducto = cantidadProducto;
            FechaVenta = factura.Fecha;
            Costo = producto.Costo;
            
            
        }
            
        public DetalleFacturaCompra()
        {
           
        }

        public string CodigoCompra { get; set; }
        public string CodigoProducto { get; set; }
        public string Descripcion { get; set; }
        public int CantidadProducto { get; set; }
        public string FechaVenta { get; set; }
        public int Valorunitario { get; set; }
        public int Costo { get; set; }
        public FacturaCompra Factura { get; set; }
        public Producto Producto { get; set; }
        public double ValorTotal { get { return Valorunitario * CantidadProducto; } set { } }



        

    }
}
