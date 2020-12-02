using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Presentacion
{
    public partial class FormGestionProveedor : Form
    {
        ProveedorService proveedorService;
        Proveedor proveedor;
        public FormGestionProveedor()
        {
            InitializeComponent();
            proveedorService = new ProveedorService(ConfigConnection.connectionString);
            llenarCombo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Esta seguro que desea salir del registro proveedor?", @"Atención",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.None;
                //btnCancelar.Focus();

            }
        }
        void llenarCombo()
        {
            cmboTipo.Items.Add("CC");
            cmboTipo.Items.Add("CE");
            cmboTipo.Items.Add("NIT");
            cmboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private Proveedor MapearProveedor()
        {
            proveedor = new Proveedor();
            proveedor.TipoIdentificacion = cmboTipo.Text;
            proveedor.Identificacion = txtId.Text;
            proveedor.RazonSocial = txtRazonSocial.Text;
            proveedor.Barrio = txtBarrio.Text;
            proveedor.Direccion = txtDireccion.Text;
            proveedor.Telefono = txtTelefono.Text;
            proveedor.Email = txtEmail.Text;
            return proveedor;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
           Proveedor proveedor = MapearProveedor();
            string mensaje = proveedorService.GuardarProveedor(proveedor);
            MessageBox.Show(mensaje, "Infomacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Limpiar();

        }

        private void Limpiar()
        {
            txtId.Text = "";
            txtRazonSocial.Text = "";
            txtTelefono.Text = "";
            txtBarrio.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";

        }
    }
}
    

