using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    class Venta:Factura
    {
        public Venta(string codigoVenta, string identificacionCliente)
        {
            CodigoVenta = codigoVenta;
            IdentificacionCliente = identificacionCliente;
        }

        public Venta()
        {

        }

        public string CodigoVenta { get; set; }
        public string IdentificacionCliente { get; set; }
    }
}

