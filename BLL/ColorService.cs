using DALL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ColorService
    {
        private readonly ConnectionManager conexion;
        private readonly ColorRepository repositorio;
        public ColorService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new ColorRepository(conexion);
        }

        public string GuardarColor(Color color)
        {
            try
            {
                conexion.Open();
                if (repositorio.BuscarPorNombreColor(color.Nombre) == null)
                {
                    repositorio.GuardarColor(color);
                    return $"Se guardaron los datos del color: {color.Nombre} datos satisfactoriamente";
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
