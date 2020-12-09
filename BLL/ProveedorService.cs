using DALL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProveedorService
    {
        private readonly ConnectionManager conexion;
        private readonly ProveedorRepository repositorio;
        public ProveedorService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new ProveedorRepository(conexion);
        }

        public string GuardarProveedor(Proveedor proveedor)
        {
            try
            {
                conexion.Open();
                if (repositorio.BuscarPorIdentificacionProveedor(proveedor.Identificacion) == null)
                {
                    repositorio.GuardarProveedor(proveedor);
                    return $"Se guardaron los del cliente: {proveedor.RazonSocial} datos satisfactoriamente";
                }
                return $"El proveedor ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }



        public BusquedaProveedorRespuesta BuscarPorIdentificacion(string identificacion)
        {
            BusquedaProveedorRespuesta respuesta = new BusquedaProveedorRespuesta();
            try
            {

                conexion.Open();
                respuesta.Proveedor = repositorio.BuscarPorIdentificacionProveedor(identificacion);
                conexion.Close();
                if (respuesta.Proveedor == null)
                {
                    respuesta.Error = true;
                    return respuesta;
                }
                respuesta.Mensaje = (respuesta.Proveedor != null) ? "Se encontró el Proveedor buscado" : "El Proveedor buscado no existe";
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


        public string ModificarProveedor(Proveedor proveedor)
        {
            try
            {
                conexion.Open();
                if (repositorio.BuscarPorIdentificacionProveedor(proveedor.Identificacion) != null)
                {
                    repositorio.ModificarProveedor(proveedor);
                    return $"Se modificaron los datos del proveedor: {proveedor.RazonSocial}   satisfactoriamente";
                }
                return $"El proveedor no existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }



        public ConsultaProveedorRespuesta BuscarPorBarrio(string barrio)
        {
            ConsultaProveedorRespuesta respuesta = new ConsultaProveedorRespuesta();
            try
            {
                conexion.Open();
                respuesta.Proveedores = repositorio.BuscarProveedorPorBarrio(barrio);
                conexion.Close();
                if (respuesta.Proveedores.Count > 0)
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



    public class ConsultaProveedorRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Proveedor> Proveedores { get; set; }
    }


    public class BusquedaProveedorRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Proveedor Proveedor { get; set; }
    }



    public class ConteoProveedorRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }

}
