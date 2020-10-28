using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Cliente:Persona
    {
        public Cliente(string email)
        {
            Email = email;

        }

        public Cliente()
        {

        }

        public string Email { get; set; }
    }
}
