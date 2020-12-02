using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    class Compra:FacturaCompra
    {
        public Compra(string codigoPedido, Cliente persona)
        {
            CodigoPedido = codigoPedido;
            Persona = persona;
            
        }

        public Compra()
        {

        }

        public string CodigoPedido { get; set; }
        public string CodigoProveedor { get; set; }
        
    }
}

