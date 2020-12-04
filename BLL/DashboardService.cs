using DALL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DashboardService
    {

        private readonly ConnectionManager conexion;
        private readonly DashboardRepository repositorio;
        public DashboardService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new DashboardRepository(conexion);
        }

       
        
        public ArrayList ConsultarDatos()
        {
            ArrayList Datos = new ArrayList();
            try
            {
                conexion.Open();
                Datos = repositorio.ConsultarDatos();
                conexion.Close();
                
            }
            catch
            {

            }
            finally { conexion.Close(); }
            return Datos;
        }



    }
}
