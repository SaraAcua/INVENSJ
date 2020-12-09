using DALL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DetalleFacturaVentaService
    {
        private readonly ConnectionManager conexion;
        private readonly DetalleFacturaVentaRepository repositorio;
        public DetalleFacturaVentaService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new DetalleFacturaVentaRepository(conexion);
        }

        public string GuardarDetallesVenta(List<DetalleFacturaVenta> detalles, List<Producto> productos)
        {
            try
            {
                foreach (DetalleFacturaVenta detalle in detalles)
                {
                    conexion.Open();

                    repositorio.GuardarDetalleFacturaVenta(detalle);

                    conexion.Close();
                }

                //------------
                foreach (Producto producto in productos)
                {
                    conexion.Open();

                    repositorio.ActualizarInventario(producto);


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
