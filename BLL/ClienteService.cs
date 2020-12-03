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
    public class ClienteService
    {
        private readonly ConnectionManager conexion;
        private readonly ClienteRepository repositorio;
        public ClienteService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new ClienteRepository(conexion);
        }

        public ClienteService()
        {
        }

        public string GuardarCliente(Cliente cliente)
        {
            Email email = new Email();
            string mensajeEmail ;
            try
            {
                conexion.Open();
                if (repositorio.BuscarPorIdentificacionCliente(cliente.Identificacion) == null)
                {
                    repositorio.GuardarCliente(cliente);
                    mensajeEmail = email.EnviarEmail(cliente);
                    return $"Se guardaron los del cliente: {cliente.Nombre} datos satisfactoriamente";
                }
                return $"El cliente ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }


        public BusquedaClienteRespuesta BuscarPorIdentificacion(string identificacion)
        {
            BusquedaClienteRespuesta respuesta = new BusquedaClienteRespuesta();
            try
            {

                conexion.Open();
                respuesta.Cliente = repositorio.BuscarPorIdentificacionCliente(identificacion);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Cliente != null) ? "Se encontró el cliente buscado" : "El cliente buscado no existe";
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



    public class ConsultaClienteRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Cliente> Clientes { get; set; }
    }


    public class BusquedaClienteRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Cliente Cliente { get; set; }
    }



    public class ConteoClienteRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }

}
