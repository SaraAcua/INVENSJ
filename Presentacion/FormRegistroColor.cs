using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITY;

namespace Presentacion
{
    public partial class FormRegistroColor : Form
    {
       ColorService colorService;
        Color color;
        public FormRegistroColor()
        {
            InitializeComponent();

           colorService = new ColorService(ConfigConnection.connectionString);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Esta seguro que desea salir del registro de color?", @"Atención",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Close();

            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }
        private Color MapearColor()
        {
            color = new Color();
           color.Nombre   = txtNombre.Text;
        
            return color;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Color color = MapearColor();
            string mensaje = colorService.GuardarColor(color);
            MessageBox.Show(mensaje, "Infomacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Limpiar();

        }

        private void Limpiar()
        {
            txtNombre.Text = "";
     
        }
    }
}
