using DALL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductoService
    {
        private readonly ConnectionManager conexion;
        private readonly ProductoRepository repositorio;
        public ProductoService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new ProductoRepository(conexion);
        }

        public string GuardarProducto(Producto producto, int cod_color, int cod_marca)
        {
            try
            {
                conexion.Open();
                if (repositorio.BuscarPorCodigoProducto(producto.CodigoProducto) == null)
                {
                    repositorio.GuardarProducto(producto, cod_color, cod_marca);
                    return $"Se guardaron los datos del producto  {producto.Descripcion}  satisfactoriamente";
                }
                return $"El producto ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }

        public BusquedaProductoRespuesta BuscarPorcodigo(string codigo)
        {
            BusquedaProductoRespuesta respuesta = new BusquedaProductoRespuesta();
            try
            {

                conexion.Open();
                respuesta.Producto = repositorio.BuscarPorCodigoProducto(codigo);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Producto != null) ? "Se encontró el producto buscado" : "El cliente buscado no existe";
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

    public class ConsultaProductoRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Producto> Productos { get; set; }
    }


    public class BusquedaProductoRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Producto Producto { get; set; }
    }



    public class ConteoProductoRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }


}
