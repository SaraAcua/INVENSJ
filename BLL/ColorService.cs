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

        public ColorService()
        {
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
                return $"La marca ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }


        public List<String> ConsultarColor()
        {
            List<String> coloresString = new List<string>();
            coloresString.Add("SELECCIONE");
            try
            {
                conexion.Open();
                List<Color> ColoresRegistrados = repositorio.ConsultarTodos();
                conexion.Close();
                foreach(Color color in ColoresRegistrados)
                {
                    coloresString.Add(color.Nombre);
                }
            }
            catch
            {

            }
            finally { conexion.Close(); }
            return coloresString;
        }



        public string ConsultarIdColor(string nombre)
        {

            string respuesta="10";
            try
            {
                conexion.Open();
                respuesta = repositorio.ConsultarIdColor(nombre);
                conexion.Close();

            }
            catch
            {

            }
            finally { conexion.Close(); }
            return respuesta;
        }



        public ConsultaColorRespuesta ConsultarTodos()
        {
            ConsultaColorRespuesta respuesta = new ConsultaColorRespuesta();
            try
            {

                conexion.Open();
                respuesta.Colores = repositorio.ConsultarTodos();
                conexion.Close();
                if (respuesta.Colores.Count > 0)
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

    public class ConsultaColorRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Color> Colores { get; set; }
    }


    public class BusquedaColorRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Color Color { get; set; }
    }



    public class ConteoColorRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }

}
