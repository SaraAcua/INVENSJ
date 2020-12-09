using DALL;
using ENTITY;
using Infraestructura;
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


        public ConsultaFacturaRespuesta BuscarReporte(DateTime fechaInicial, DateTime fechaFinal)
        {
            ConsultaFacturaRespuesta respuesta = new ConsultaFacturaRespuesta();
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



        public string GenerarPdf(List<DetalleFacturaCompra> detalles, string filename)
        {
            DocumentoPdf documentoPdf = new DocumentoPdf();
            try
            {
                documentoPdf.GuardarPdf(detalles, filename);
                return "Se generó el Documento satisfactoriamente";
            }
            catch (Exception e)
            {

                return "Error al crear docuemnto" + e.Message;
            }
        }




    }

    public class ConsultaFacturaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<FacturaCompra> Facturas { get; set; }
    }


    public class BusquedaFacturaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public FacturaCompra FacturaCompra { get; set; }
    }



    public class ConteoFacturaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }


}
