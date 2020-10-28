using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    class Proveedor :Persona
    {
        public Proveedor(string nitProvedor)
        {
            NitProvedor = nitProvedor;
            
        }

        public Proveedor()
        {

        }

        public string NitProvedor { get; set; }
        
        
    }
}
