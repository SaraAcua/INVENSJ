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
    public partial class FormClientes : Form
    {
        ClienteService clienteService = new ClienteService();
        public FormClientes()
        {
            clienteService = new ClienteService(ConfigConnection.connectionString, ConfigConnection.ProviderName);
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
            ConsultaPersonaRespuesta respuesta = new ConsultaPersonaRespuesta();

         
                dtgcliente.DataSource = null;
                respuesta = clienteService.ConsultarTodos();
                dtgcliente.DataSource = respuesta.Personas;
                //TxtTotal.Text = clienteService.Totalizar().Cuenta.ToString();
                //txtId.Text = clienteService.TotalizarTipo("F").Cuenta.ToString();


            }
            else
            {
                MessageBox.Show("Debe Seleccionar una opción ", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            MessageBox.Show(respuesta.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
    }
}
