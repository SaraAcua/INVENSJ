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
            FormGestionCliente gestionCliente = new FormGestionCliente();
            gestionCliente.ShowDialog();
        }

        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            FormGestionCliente gestionCliente = new FormGestionCliente();
            gestionCliente.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
          // BusquedaClienteRespuesta respuesta = new BusquedaClienteRespuesta();
      
            var respuesta = clienteService.BuscarPorIdentificacion(txtId.Text);

            if (respuesta.Error==false)
            {
               // dtgcliente.DataSource = null;
                respuesta = clienteService.BuscarPorIdentificacion(txtId.Text);
                dtgcliente.DataSource = respuesta.Cliente;
                //TxtTotal.Text = clienteService.Totalizar().Cuenta.ToString();
                //txtId.Text = clienteService.TotalizarTipo("F").Cuenta.ToString();
            }

            else
            {
                MessageBox.Show("Debe digitar una identificacion ", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

       
            MessageBox.Show(respuesta.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

      

    }
    }

