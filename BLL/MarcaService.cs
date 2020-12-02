using DALL;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class MarcaService
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



    }
}
