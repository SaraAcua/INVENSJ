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
            string direccion, string telefono, string email)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
        }

        public Persona()
        {

        }

        
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }

}

