using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    class Producto
    {
        public Producto( string codigoProducto, string descripcion,
            int costo , int precio, string talla, string color, string marca,
            int stockMinimo, int stockMaximo, int cantidad)
        {
            
            CodigoProducto = codigoProducto;
            Descripcion = descripcion;
            Costo = costo;
            Precio = precio;
            Iva = 0;
            Talla = talla;
            Color = color;
            Marca = marca;
            StockMinimo = stockMinimo;
            StockMaximo = stockMaximo;
            Cantidad = cantidad;
        }

        public Producto()
        {

        }

        
        public string CodigoProducto { get; set; }
        public string Descripcion { get; set; }
        public int Costo { get; set; }
        public int Precio { get; set; }     
        public string  Talla { get; set; }
        public string Color { get; set; }
        public string Marca { get; set; }
        public int Iva { get; set; }
        public int StockMinimo { get; set; }
        public int StockMaximo { get; set; }
        public int Cantidad { get; set; }


        public bool ValidarCantidad(string codigoProducto, int cantidad)
        {
            if ((CodigoProducto == codigoProducto) && (Cantidad >= cantidad))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public void ActualizarCantidad(string codigoProducto, int cantidad, string tipoOperacion)
        {
            switch (tipoOperacion)
            {
                case "FacturaVenta":
                    if ((CodigoProducto == codigoProducto) && (Cantidad >= cantidad))
                    {
                        Cantidad = Cantidad - cantidad;
                    }
                    break;
                case "FacturaCompra":
                    Cantidad = Cantidad + cantidad;
                    break;
                case "Movimientos":
                    Cantidad = Cantidad - cantidad;
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

