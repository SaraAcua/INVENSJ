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


        public int ConsultarIdFactura()
        {

            int respuesta = 0;
            try
            {
                conexion.Open();
                respuesta = repositorio.ConsultarIdFactura();
                conexion.Close();

            }
            catch
            {

            }
            finally { conexion.Close(); }
            return respuesta;
        }

        public ConsultaFacturaVentaRespuesta BuscarReporte(DateTime fechaInicial, DateTime fechaFinal)
        {
            ConsultaFacturaVentaRespuesta respuesta = new ConsultaFacturaVentaRespuesta();
            try
            {
                conexion.Open();
                respuesta.Facturas = repositorio.ReporteFactura(fechaInicial, fechaFinal);
                conexion.Close();
                if (respuesta.Facturas.Count > 0)
                {
                    respuesta.Mensaje = "Se consultan los Datos";
                }
                else
                {
                    respuesta.Mensaje = "No hay datos para consultar";
                }
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception e)
            {

                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }
        }





    }

    public class ConsultaFacturaVentaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<FacturaVenta> Facturas { get; set; }
    }


    public class BusquedaFacturaVentaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public FacturaVenta FacturaVenta { get; set; }
    }



    public class ConteoFacturaVentaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }

}
