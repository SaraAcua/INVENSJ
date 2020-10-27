using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    class Producto
    {
        public Producto(string codigoPedido, string codigoProducto, string nombreProducto, 
            string nitProveedor, string valorUnitarioCompra, string valorUnitarioVenta, string cantidadProducto)
        {
            CodigoPedido = codigoPedido;
            CodigoProducto = codigoProducto;
            NombreProducto = nombreProducto;
            NitProveedor = nitProveedor;
            ValorUnitarioCompra = valorUnitarioCompra;
            ValorUnitarioVenta = valorUnitarioVenta;
            CantidadProducto = cantidadProducto;
        }

        public Producto()
        {

        }

        public string CodigoPedido { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string NitProveedor { get; set; }
        public string ValorUnitarioCompra { get; set; }
        public string ValorUnitarioVenta { get; set; }
        public string CantidadProducto { get; set; }
        
    }
}

