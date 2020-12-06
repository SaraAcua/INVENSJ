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
    public partial class FormClientes : Form
    {
        ClienteService clienteService;
        public FormClientes()
        {
            clienteService = new ClienteService(ConfigConnection.connectionString);

            InitializeComponent();
        }

        private void BtnRegsitrarCliente_Click(object sender, EventArgs e)
        {
          
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            FormGestionCliente gestionCliente = new FormGestionCliente();
            gestionCliente.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
          
      
            var respuesta = clienteService.BuscarPorIdentificacion(txtId.Text);
            List<Cliente> clientes = new List<Cliente>();

            if ((respuesta.Error)|| (txtId.Text.Equals("")))
            {
                MessageBox.Show("Debe digitar una identificacion ", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                clientes.Add(respuesta.Cliente);
                dtgcliente.DataSource = clientes;
                //TxtTotal.Text = clienteService.Totalizar().Cuenta.ToString();
                //txtId.Text = clienteService.TotalizarTipo("F").Cuenta.ToString();
                //MessageBox.Show("No hay clientes ", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void BtnRegsitrarCliente_Click_1(object sender, EventArgs e)
        {
            FormGestionCliente gestionCliente = new FormGestionCliente();
            gestionCliente.ShowDialog();
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
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
    }
    }

