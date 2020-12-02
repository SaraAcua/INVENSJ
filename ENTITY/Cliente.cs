using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Cliente
    {
        public Cliente( string tipoIdentificacion, string identificacion, string nombre, string apellidos,
            string direccion,string barrio, string telefono, string email, string tipo)
        {
            TipoIdentificacion = tipoIdentificacion;
            Identificacion = identificacion;
            Nombre = nombre;
            Apellidos = apellidos;
            Direccion = direccion;
            Barrio = barrio;
            Telefono = telefono;
            Email = email;
            
        }

        public Cliente()
        {

        }

        public string Barrio { get; set; }
        public string TipoIdentificacion { get; set; }
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        
    }

}

