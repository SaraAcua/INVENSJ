using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    class DetalleFactura 
    {

        public DetalleFactura(Factura factura, Producto producto,  int cantidadProducto)
        {
            Factura = factura;
            Producto = producto;
            CodigoProducto = producto.CodigoProducto;
            NombreProducto = producto.NombreProducto;
            CantidadProducto = cantidadProducto;
            FechaVenta = factura.Fecha;
            Valorunitario = producto.ValorUnitarioVenta;
            
            
        }
            
        public DetalleFactura()
        {
           
        }

        public string CodigoVenta { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public int CantidadProducto { get; set; }
        public string FechaVenta { get; set; }
        public int Valorunitario { get; set; }
        public Factura Factura { get; set; }
        public Producto Producto { get; set; }
        public double ValorTotal { get { return Valorunitario * CantidadProducto; } set { } }



        

    }
}
