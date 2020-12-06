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
    public partial class FormGestionCliente : Form
    {
        ClienteService clienteService;
        Cliente cliente;
        public FormGestionCliente()
        {
            InitializeComponent();
            clienteService = new ClienteService(ConfigConnection.connectionString);
            llenarCombo();



        }
        private void inhhabilitar()
        {

        }
        void llenarCombo()
        {
            cmboTipo.Items.Add("CC");
            cmboTipo.Items.Add("CE");
            cmboTipo.Items.Add("TI");
            cmboTipo.Items.Add("NIT");
            cmboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Esta seguro que desea salir del registro cliente?", @"Atención",
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

        private Cliente MapearCliente()
        {
            cliente = new Cliente();
            cliente.TipoIdentificacion = cmboTipo.Text;
            cliente.Identificacion = txtId.Text;
            cliente.Nombre = txtname.Text;
            cliente.Apellidos = txtApellido.Text;
            cliente.Barrio = txtBarrio.Text;
            cliente.Direccion = txtDirecciòn.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Email = txtEmail.Text;
            return cliente;

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtId.Text.Equals("") || txtname.Text.Equals("") || cmboTipo.SelectedItem.Equals("")
            || txtApellido.Text.Equals("") || txtBarrio.Text.Equals("") || txtDirecciòn.Text.Equals("") || txtEmail.Text.Equals(""))
            {

                MessageBox.Show("Debe digitar los datos requeridos ", " Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else if (ValidarCorreo())
            {
                MessageBox.Show("Debe digitar un email correcto ", " Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                Cliente cliente = MapearCliente();
                string mensaje = clienteService.GuardarCliente(cliente);
                MessageBox.Show(mensaje, "Infomacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                cmboTipo.Focus();
                Limpiar();

            }

        }

        private void Limpiar()
        {
            txtId.Text = "";
            txtname.Text = "";
            txtApellido.Text = "";
            txtBarrio.Text = "";
            txtDirecciòn.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";

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

            private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) { e.Handled = true; }
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
