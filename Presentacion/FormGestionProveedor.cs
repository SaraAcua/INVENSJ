using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;

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
            cmboTipo.Items.Add("NIT");
            cmboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private Proveedor MapearProveedor()
        {
            proveedor = new Proveedor();
            proveedor.TipoIdentificacion = cmboTipo.Text;
            proveedor.Identificacion = txtId.Text;
            proveedor.RazonSocial = txtRazonSocial.Text;
            proveedor.Telefono = txtTelefono.Text;
            proveedor.Barrio = txtBarrio.Text;
            proveedor.Direccion = txtDireccion.Text;
            proveedor.Email = txtEmail.Text;
            return proveedor;

        }

        private bool ValidarCorreo()
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(txtEmail.Text.Trim(), expresion))
            {
                if (Regex.Replace(txtEmail.Text.Trim(), expresion, String.Empty).Length == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals("") || txtRazonSocial.Text.Equals("") || cmboTipo.SelectedItem.Equals("")
               || txtBarrio.Text.Equals("") || txtDireccion.Text.Equals("") || txtEmail.Text.Equals(""))
            {

                MessageBox.Show("Debe digitar los datos requeridos ", " Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (ValidarCorreo())
            {
                MessageBox.Show("Debe digitar un email correcto ", " Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                Proveedor proveedor = MapearProveedor();
                string mensaje = proveedorService.GuardarProveedor(proveedor);
                MessageBox.Show(mensaje, "Infomacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                Limpiar();
            }

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

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                Proveedor proveedor = new Proveedor();
                BusquedaProveedorRespuesta consulta = new BusquedaProveedorRespuesta();
                consulta = proveedorService.BuscarPorIdentificacion(txtId.Text);
                if (!consulta.Error)
                {
                    proveedor = consulta.Proveedor;
                    txtRazonSocial.Text = proveedor.RazonSocial;
                    txtBarrio.Text = proveedor.Barrio;
                    txtDireccion.Text = proveedor.Direccion;
                    txtTelefono.Text = proveedor.Telefono;
                    txtEmail.Text = proveedor.Email;
                }
                else
                {
                    MessageBox.Show("Proveedor no esta registrado ", " Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    Limpiar();
                }
            }


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
    

