using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Persona
    {
        public Persona( string identificacion, string nombre,
            string direccionProveedor, string telefonoProveedor)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Direccion = direccionProveedor;
            Telefono = telefonoProveedor;

        }

        public Persona()
        {

        }

        
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

    }

}

