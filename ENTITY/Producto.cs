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
            string nitProveedor, int valorUnitarioCompra, int valorUnitarioVenta, int cantidadProducto, string color)
        {
            CodigoPedido = codigoPedido;
            CodigoProducto = codigoProducto;
            NombreProducto = nombreProducto;
            NitProveedor = nitProveedor;
            ValorUnitarioCompra = valorUnitarioCompra;
            ValorUnitarioVenta = valorUnitarioVenta;
            CantidadProducto = cantidadProducto;
            Color = color;
        }

        public Producto()
        {

        }

        public string CodigoPedido { get; set; }
        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public string NitProveedor { get; set; }
        public int ValorUnitarioCompra { get; set; }
        public int ValorUnitarioVenta { get; set; }
        public int CantidadProducto { get; set; }
        public string Color { get; set; }
        public int Iva { get; set; }


        public bool ValidarStock(string codigoProducto, int cantidad)
        {
            if ((CodigoProducto == codigoProducto) && (CantidadProducto >= cantidad))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void ActualizarStock(string codigoProducto, int cantidad, string tipoOperacion)
        {
            switch (tipoOperacion)
            {
                case "Venta":
                    if ((CodigoProducto == codigoProducto) && (CantidadProducto >= cantidad))
                    {
                        CantidadProducto = CantidadProducto - cantidad;
                    }
                    break;
                case "Compra":
                    CantidadProducto = CantidadProducto + cantidad;
                    break;
                default:
                    break;
            }
        }

        public void CalcularIva(int precioProducto)
        {
            Iva = precioProducto * 19/100;
        }


    }
}

