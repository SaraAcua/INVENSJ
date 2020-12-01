using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    class DetalleFacturaVenta
    {
        public DetalleFacturaVenta(FacturaVenta factura, Producto producto, int cantidadProducto)
        {
            Factura = factura;
            Producto = producto;
            CodigoProducto = producto.CodigoProducto;
            Descripcion = producto.Descripcion;
            CantidadProducto = cantidadProducto;
            FechaVenta = factura.Fecha;
            Precio = producto.Precio;


        }

        public DetalleFacturaVenta()
        {

        }

        public string CodigoVenta { get; set; }
        public string CodigoProducto { get; set; }
        public string Descripcion { get; set; }
        public int CantidadProducto { get; set; }
        public string FechaVenta { get; set; }
        public int Valorunitario { get; set; }
        public int Precio { get; set; }
        public FacturaVenta Factura { get; set; }
        public Producto Producto { get; set; }
        public double ValorTotal { get { return Valorunitario * CantidadProducto; } set { } }

    }
}
