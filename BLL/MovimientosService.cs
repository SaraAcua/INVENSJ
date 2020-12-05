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


    }
}
