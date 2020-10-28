using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    class Compra:Factura
    {
        public Compra(string codigoPedido, string codigoProveedor)
        {
            CodigoPedido = codigoPedido;
            CodigoProveedor = codigoProveedor;
        }

        public Compra()
        {

        }

        public string CodigoPedido { get; set; }
        public string CodigoProveedor { get; set; }
    }
}

