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

         
        public string GuardarCliente(Movimientos movimientos)
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


        public BusquedaMovimientosRespuesta BuscarPorMotivo(string motivo)
        {
            BusquedaMovimientosRespuesta respuesta = new BusquedaMovimientosRespuesta();
            try
            {

                conexion.Open();
                respuesta.Movimientos = repositorio.BuscarPorMotivo(motivo);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Movimientos != null) ? "Se encontró el motivo buscado" : "El motivo buscado no existe";
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
