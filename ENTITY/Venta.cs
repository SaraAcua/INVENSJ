using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    class Venta
    {
        public Venta(string codigoProducto, string nombreProducto, int cantidadProducto,
            string fechaVenta, int valorunitario, int valorTotal )
        {
            CodigoProducto = codigoProducto;
            NombreProducto = nombreProducto;
            CantidadProducto = cantidadProducto;
            FechaVenta = fechaVenta;
            Valorunitario = valorunitario;
            ValorTotal = valorTotal;
        }

        public Venta()
        {

        }

        public string CodigoProducto { get; set; }
        public string NombreProducto { get; set; }
        public int CantidadProducto { get; set; }
        public string FechaVenta { get; set; }
        public int Valorunitario { get; set; }
        public int ValorTotal { get; set; }
    }
}
