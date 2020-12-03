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
       
        public FormConsultarProductos()
        {
            InitializeComponent();
            productoService = new ProductoService(ConfigConnection.connectionString);
         
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            var respuesta = productoService.BuscarPorcodigo(txtCodigoProducto.Text);
            List<Producto> productos = new List<Producto>();
            if (!respuesta.Error)
            {

                productos.Add(respuesta.Producto);
                dtgProducto.DataSource = productos;
                //TxtTotal.Text = clienteService.Totalizar().Cuenta.ToString();
                //txtId.Text = clienteService.TotalizarTipo("F").Cuenta.ToString();
            }

            else
            {
                MessageBox.Show("Debe digitar una identificacion ", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCodigoProducto.Text = "";
            dtgProducto.DataSource = "";
        }
    }
}
