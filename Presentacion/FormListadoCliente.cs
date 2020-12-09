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
    public partial class FormListadoCliente : Form
    {
        Cliente cliente;
        ClienteService service;
        public FormListadoCliente()
        {
            service = new ClienteService(ConfigConnection.connectionString);
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
            List<Cliente> clientes = new List<Cliente>();

            if ((respuesta.Error))
            {
                MessageBox.Show("No existe el cliente ", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else if (txtId.Text.Equals(""))
            {
                MessageBox.Show("Debe digitar una identifiacion ", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                clientes.Add(respuesta.Cliente);
                dtgvClientesReportes.DataSource = clientes;
                //TxtTotal.Text = clienteService.Totalizar().Cuenta.ToString();
                //txtId.Text = clienteService.TotalizarTipo("F").Cuenta.ToString();
            }
        }

        private void btnBuscarBarrio_Click(object sender, EventArgs e)
        {
            ConsultaClienteRespuesta respuesta = new ConsultaClienteRespuesta();


            respuesta = service.BuscarPorBarrio(txtBarrio.Text);
            dtgvClientesReportes.DataSource = respuesta.Clientes; ;
        }
    }
}
