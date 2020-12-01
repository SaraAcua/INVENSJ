using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Persona
    {
        public Persona( string identificacion, string nombre, string apellidos,
            string direccion, string telefono, string email, string tipo)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Apellidos = apellidos;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
            Tipo = tipo;
        }

        public Persona()
        {

        }

        
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Tipo { get; set; }
    }

}

