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
    public partial class FormRegistroMarca : Form
    {
        MarcaService marcaService;
        Marca marca;
        public FormRegistroMarca()
        {
            InitializeComponent();
           marcaService = new MarcaService(ConfigConnection.connectionString);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Esta seguro que desea salir del registro de marca?", @"Atención",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Close();

            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }


        private Marca MapearMarca()
        {
            marca = new Marca();
           marca.Nombre = txtNombre.Text;

            return marca;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals(""))
            {
                MessageBox.Show("Debe digitar los datos requeridos ", " Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                Marca marca = MapearMarca();
                string mensaje = marcaService.GuardarMarca(marca);
                MessageBox.Show(mensaje, "Infomacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                Limpiar();
            }
        }

        private void Limpiar()
        {
            txtNombre.Text = "";

        }
    }
    }
