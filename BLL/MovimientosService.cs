using DALL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MovimientosService
    {

        private readonly ConnectionManager conexion;
        private readonly MovimientosRepository repositorio;
        public MovimientosService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new MovimientosRepository(conexion);
        }

         
        public string GuardarMovimiento(Movimientos movimientos)
        { 
            try
            {
                conexion.Open();
                
                    repositorio.GuardarMovimiento(movimientos);
                    
                    return $"Se guardaron los datos del movimiento";
                
                
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }


        public ConsultaMovimientosRespuesta BuscarPorMotivo(string motivo)
        {
            ConsultaMovimientosRespuesta respuesta = new ConsultaMovimientosRespuesta();
            try
            {

                conexion.Open();
                respuesta.Movimientoss = repositorio.BuscarPorMotivo(motivo);
                conexion.Close();
                if (respuesta.Movimientoss.Count > 0)
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



       



        public ConteoMovimientosRespuesta TotalizarTipo(string motivo)
        {
            ConteoMovimientosRespuesta respuesta = new ConteoMovimientosRespuesta();
            try
            {

                conexion.Open();
                respuesta.Cuenta = repositorio.Totalizar(motivo);
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = "Se consultan los Datos";

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

        public string ActualizarInventario(Producto producto)
        {
            try
            {
                    conexion.Open();
                    repositorio.ActualizarInventario(producto);
                    conexion.Close();
                return $"Se guardaron los datos del movimiento satisfactoriamente";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }







    }



    public class ConsultaMovimientosRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Movimientos> Movimientoss { get; set; }
    }


    public class BusquedaMovimientosRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Movimientos Movimientos { get; set; }
    }



    public class ConteoMovimientosRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }


}
