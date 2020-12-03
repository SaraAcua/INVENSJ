using BLL;
using ENTITY;
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
    public partial class FormConsultarProductos : Form
    {
        ProductoService productoService;
        Producto producto;
        public FormConsultarProductos()
        {
            InitializeComponent();
            productoService = new ProductoService(ConfigConnection.connectionString);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            var respuesta = productoService.(txtId.Text);
            List<Cliente> clientes = new List<Cliente>();
            if (!respuesta.Error)
            {

                clientes.Add(respuesta.Cliente);
                dtgcliente.DataSource = clientes;
                //TxtTotal.Text = clienteService.Totalizar().Cuenta.ToString();
                //txtId.Text = clienteService.TotalizarTipo("F").Cuenta.ToString();
            }

            else
            {
                MessageBox.Show("Debe digitar una identificacion ", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
    }
}
