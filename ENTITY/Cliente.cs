using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Cliente
    {
        public Cliente(string identificacion, string nombreCliente)
        {
            Identificacion = identificacion;
            Nombre = nombreCliente;
        }

        public Cliente()
        {

        }

        public string Identificacion { get; set; }
        public string Nombre { get; set; }
    }
}
