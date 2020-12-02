using DALL;
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

        public string GuardarColor(string nombreColor)
        {
            try
            {
                conexion.Open();
                
                    repositorio.GuardarColor(nombreColor);
                    return $"Se guardaron los datos de color: {nombreColor}  satisfactoriamente";
                
                
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }


    }
}
