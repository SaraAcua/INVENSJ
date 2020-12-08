using DALL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FacturaCompraService
    {

        private readonly ConnectionManager conexion;
        private readonly FacturaCompraRepository repositorio;
        public FacturaCompraService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new FacturaCompraRepository(conexion);
        }


        public string GuardarFacturaCompra(FacturaCompra factura)
        {
            try
            {
                conexion.Open();
                
                    repositorio.GuardarFacturaCompra(factura);
                    
                    return $"Se guardaron los datos satisfactoriamente";
                
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }


    }
}
