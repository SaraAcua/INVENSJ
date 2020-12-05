using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    class Venta:FacturaCompra
    {
        public Venta(Cliente persona)
        {
            Persona = persona;
            
        }

        public Venta()
        {
          
        }

        public string CodigoVenta { get; set; }
        public string IdentificacionCliente { get; set; }
    }
}

