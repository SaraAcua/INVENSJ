using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    class Compra:FacturaCompra
    {
        public Compra(string codigoPedido, Persona persona)
        {
            CodigoPedido = codigoPedido;
            Persona = persona;
            Tipo = "Compra";
        }

        public Compra()
        {

        }

        public string CodigoPedido { get; set; }
        public string CodigoProveedor { get; set; }
        
    }
}

