using DALL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FacturaVentaService
    {

        private readonly ConnectionManager conexion;
        private readonly FacturaVentaRepository repositorio;
        public FacturaVentaService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new FacturaVentaRepository(conexion);
        }

        public string GuardarFacturaVenta(FacturaVenta factura)
        {
            try
            {
                conexion.Open();

                repositorio.GuardarFacturaVenta(factura);

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
