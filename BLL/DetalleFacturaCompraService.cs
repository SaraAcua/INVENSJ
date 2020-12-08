using DALL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DetalleFacturaCompraService
    {
        private readonly ConnectionManager conexion;
        private readonly DetalleFacturaCompraRepository repositorio;
        public DetalleFacturaCompraService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new DetalleFacturaCompraRepository(conexion);
        }

        public string GuardarDetallesCompra(List<DetalleFacturaCompra> detalles)
        {
            try
            {
                foreach (DetalleFacturaCompra detalle in detalles)
                {
                    conexion.Open();

                    repositorio.GuardarDetalleFacturaCompra(detalle);

                    conexion.Close();
                }
                    return $"Se guardaron los datos de la factura satisfactoriamente";
                
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }




    }
}
