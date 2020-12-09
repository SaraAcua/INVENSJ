using BLL;
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
    public partial class FormListadoVentas : Form
    {
        FacturaVentaService ventaService;
        public FormListadoVentas()
        {
            InitializeComponent();
            ventaService = new FacturaVentaService(ConfigConnection.connectionString);
            dateTimeListadoCompra.Format = DateTimePickerFormat.Custom;
            dateTimeListadoCompra.CustomFormat = "dd/MM/yyyy";
            dateTimeListadoCompra1.Format = DateTimePickerFormat.Custom;
            dateTimeListadoCompra1.CustomFormat = "dd/MM/yyyy";
        }
        private void Limpiar()
        {
            dateTimeListadoCompra.CustomFormat = "";


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConsultaFacturaRespuesta respuesta = new ConsultaFacturaRespuesta();


           // respuesta = ventaService.(DateTime.Parse(dateTimeListadoCompra.Text), DateTime.Parse(dateTimeListadoCompra1.Text));
            dtgvVentas.DataSource = respuesta.Facturas;
            Limpiar();
        }
    }
}
