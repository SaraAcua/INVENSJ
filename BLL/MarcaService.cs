using DALL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MarcaService
    {

        private readonly ConnectionManager conexion;
        private readonly MarcaRepository repositorio;
        public MarcaService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new MarcaRepository(conexion);
        }

        public string GuardarMarca(Marca marca)
        {
            try
            {
                conexion.Open();
                if (repositorio.BuscarPorNombreMarca(marca.Nombre) == null)
                {
                    repositorio.GuardarMarca(marca);
                    return $"Se guardaron los datos de la marca : {marca.Nombre} datos satisfactoriamente";
                }
                return $"La marca ya existe";
            }
            catch (Exception e)
            {
                return $"Error de la Aplicacion: {e.Message}";
            }
            finally { conexion.Close(); }
        }



        public ConsultaMarcaRespuesta ConsultarTodos()
        {
            ConsultaMarcaRespuesta respuesta = new ConsultaMarcaRespuesta();
            try
            {

                conexion.Open();
                respuesta.Marcas = repositorio.ConsultarTodos();
                conexion.Close();
                if (respuesta.Marcas.Count > 0)
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



        public List<String> ConsultarMarca()
        {
            List<String> marcasString = new List<string>();
            marcasString.Add("SELECCIONE");
            try
            {
                conexion.Open();
                List<Marca> MarcasRegistradas = repositorio.ConsultarTodos();
                conexion.Close();
                foreach (Marca marca in MarcasRegistradas)
                {
                    marcasString.Add(marca.Nombre);
                }
            }
            catch
            {

            }
            finally { conexion.Close(); }
            return marcasString;
        }


    }




    public class ConsultaMarcaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Marca> Marcas { get; set; }
    }


    public class BusquedaMarcaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Marca Marca { get; set; }
    }



    public class ConteoMarcaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }
}
