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

        //public string GuardarProducto(Producto producto)
        //{
        //    try
        //    {
        //        conexion.Open();
        //        if (repositorio.BuscarPorCodigoProducto(producto.CodigoProducto) == null)
        //        {
        //            repositorio.GuardarProducto(producto);
        //            return $"Se guardaron los  del producto  {producto.Descripcion}  datos satisfactoriamente";
        //        }
        //        return $"El producto ya existe";
        //    }
        //    catch (Exception e)
        //    {
        //        return $"Error de la Aplicacion: {e.Message}";
        //    }
        //    finally { conexion.Close(); }
        //}




    }
}
