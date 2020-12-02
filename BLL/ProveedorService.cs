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



    }
}
