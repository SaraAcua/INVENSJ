using BLL;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormInicio : Form
    {
        public OracleDataReader ora_DataReader;
        ProductoService productoService;
        ClienteService cliente;
        ProveedorService proveedor;
        MovimientosService service;

        public FormInicio()
        {
            InitializeComponent();
            productoService = new ProductoService(ConfigConnection.connectionString);
            cliente = new ClienteService(ConfigConnection.connectionString);
            proveedor = new ProveedorService(ConfigConnection.connectionString);
            Dashboard();

        }

       public void Dashboard()
        {
          DashboardService dashboardService = new DashboardService( ConfigConnection.connectionString);
            LblClientesTotal.Text = dashboardService.ConsultarCliente();
            LblVentasToal.Text = dashboardService.ConsultarTotalVentas();
            LblProveedoresTotal.Text = dashboardService.ConsultarProveedores();
            LblProductos.Text = dashboardService.ConsultarCantidadProductos();
            lblMarcas.Text = dashboardService.ConsultarCantidadMarcas();
            lblCaja.Text = dashboardService.ConsultarTotalVentas();

        }

        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToLongTimeString();
            labelFecha.Text = DateTime.Now.ToString("dddd MMMM yyy");
             Dashboard();
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            using (OracleConnection connection = new OracleConnection("Data Source = localhost:1521 / xepdb1; User Id = invensj; Password = invensj"))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Conexión válida");
                }
                catch (Exception exception)
                {
                   MessageBox.Show(exception.Message);
                }
            }
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {
            
        }

        private void chartCantidad_Click(object sender, EventArgs e)
        {
         
                   }
    }
}
