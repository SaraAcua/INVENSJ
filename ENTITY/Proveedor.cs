using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Proveedor
    {
        public Proveedor(string tipoIdentificacion, string identificacion, string razonSocial, 
            string direccion, string barrio, string telefono, string email)
        {
            TipoIdentificacion = tipoIdentificacion;
            Identificacion = identificacion;
            RazonSocial = razonSocial;
            Direccion = direccion;
            Barrio = barrio;
            Telefono = telefono;
            Email = email;
            
        }

        public Proveedor()
        {

        }

        public string Barrio { get; set; }
        public string TipoIdentificacion { get; set; }
        public string Identificacion { get; set; }
        public string RazonSocial { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        
    }
}

