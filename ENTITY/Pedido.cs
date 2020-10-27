using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    class Pedido
    {
        public Pedido(string codigoPedido, string codigoProveedor)
        {
            CodigoPedido = codigoPedido;
            CodigoProveedor = codigoProveedor;
        }

        public Pedido()
        {

        }

        public string CodigoPedido { get; set; }
        public string CodigoProveedor { get; set; }
    }
}
}
