using DALL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class ClienteService
    {
        private readonly ConnectionManager conexion;
        private readonly ClienteRepository repositorio;
        public ClienteService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new ClienteRepository(conexion);
        }

        public string GuardarCliente(Cliente cliente)
        {
            try
            {
                conexion.Open();
                if (repositorio.BuscarPorIdentificacionCliente(cliente.Identificacion) == null)
                {
                    repositorio.GuardarCliente(cliente);
                    return $"Se guardaron los  del cliente  {cliente.Nombre}datos satisfactoriamente";
                }
                return $"El cliente ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }



    }
}
