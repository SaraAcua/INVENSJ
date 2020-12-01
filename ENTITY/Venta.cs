using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    class Venta:FacturaCompra
    {
        public Venta(Persona persona)
        {
            Persona = persona;
            Tipo = "Venta";
        }

        public Venta()
        {

        }

        public string CodigoVenta { get; set; }
        public string IdentificacionCliente { get; set; }
    }
}

