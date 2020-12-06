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
    public partial class FormProveedores : Form
    {
        ProveedorService proveedor;
        public FormProveedores()
        {
            proveedor = new ProveedorService(ConfigConnection.connectionString);
            InitializeComponent();
        }

        private void BtnRegsitrarProv_Click(object sender, EventArgs e)
        {
            FormGestionProveedor gestionProveedor = new FormGestionProveedor();
            gestionProveedor.ShowDialog();
        }

        private void btnEditarProv_Click(object sender, EventArgs e)
        {
            FormGestionProveedor gestionProveedor = new FormGestionProveedor();
            gestionProveedor.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            var respuesta = proveedor.BuscarPorIdentificacion(txtId.Text);
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
        }
    }

