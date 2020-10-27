using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    class Proveedor
    {
        public Proveedor(string nitProvedor, string codigoProveedor, string nombreProveedor,
            string direccionProveedor , string telefonoProveedor)
        {
            NitProvedor = nitProvedor;
            CodigoProveedor = codigoProveedor;
            NombreProveedor = nombreProveedor;
            DireccionProveedor = direccionProveedor;
            TelefonoProveedor = telefonoProveedor;
            
        }

        public Proveedor()
        {

        }

        public string NitProvedor { get; set; }
        public string CodigoProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public string DireccionProveedor { get; set; }
        public string TelefonoProveedor { get; set; }
        
    }
}
