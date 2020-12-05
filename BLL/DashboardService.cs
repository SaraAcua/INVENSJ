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

       
        
        public string ConsultarCliente()
        {
            string Datos = "";
            try
            {
                conexion.Open();
                Datos = repositorio.ConsultarCliente();
                conexion.Close();
                
            }
            catch
            {

            }
            finally { conexion.Close(); }
            return Datos;
        }



        public string ConsultarTotalVentas()
        {
            string Datos = "";
            try
            {
                conexion.Open();
                Datos = repositorio.ConsultarTotalVentas();
                conexion.Close();

            }
            catch
            {

            }
            finally { conexion.Close(); }
            return Datos;
        }

        public string ConsultarProveedores()
        {
            string Datos = "";
            try
            {
                conexion.Open();
                Datos = repositorio.ConsultarProveedores();
                conexion.Close();

            }
            catch
            {

            }
            finally { conexion.Close(); }
            return Datos;
        }


        public string ConsultarCantidadProductos()
        {
            string Datos = "";
            try
            {
                conexion.Open();
                Datos = repositorio.ConsultarCantidadProducto();
                conexion.Close();

            }
            catch
            {

            }
            finally { conexion.Close(); }
            return Datos;
        }



        public string ConsultarCantidadMarcas()
        {
            string Datos = "";
            try
            {
                conexion.Open();
                Datos = repositorio.ConsultarCantidadMarcas();
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
