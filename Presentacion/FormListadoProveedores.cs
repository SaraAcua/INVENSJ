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
    public partial class FormListadoProveedores : Form
    {
        Proveedor proveedor;
        ProveedorService service;
        public FormListadoProveedores()
        {
            service = new ProveedorService(ConfigConnection.connectionString);
            InitializeComponent();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back &&
                e.KeyChar != '-')
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar == '-')
                {
                    if (((TextBox)sender).Text.Contains('-'))
                        e.Handled = true;
                    else
                        e.Handled = false;
                }
            }
        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            var respuesta = service.BuscarPorIdentificacion(txtId.Text);
            List<Proveedor> proveedors = new List<Proveedor>();
            if (respuesta.Error)
            {
                MessageBox.Show("No existe el proveedor ", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (txtId.Text.Equals(""))
            {
                MessageBox.Show("Debe digitar una identifiacion ", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                proveedors.Add(respuesta.Proveedor);
                dtgvProveedor.DataSource = proveedors;
                //TxtTotal.Text = clienteService.Totalizar().Cuenta.ToString();
                //txtId.Text = clienteService.TotalizarTipo("F").Cuenta.ToString();


            }
        }

        private void btnBuscarBarrio_Click(object sender, EventArgs e)
        {

        }
    }
}