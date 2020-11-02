using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();

            PersonalizarSubMenu();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
     
        private void PersonalizarSubMenu()
        {
            panelMenuProd.Visible = false;
            panelMenuFacturacion.Visible = false; 
            panelMenuCompras.Visible = false;
            panelMenuReportes.Visible = false;
        }

        private void EsconderSubMenu()
        {
           if (panelMenuProd.Visible = true)
            {
                panelMenuProd.Visible = false;
            }
           if (panelMenuFacturacion.Visible = true)
            {
                panelMenuFacturacion.Visible = false;
            }
        
           
           
            if (panelMenuCompras.Visible=true)
            {
                panelMenuCompras.Visible = false;
            }
            if (panelMenuReportes.Visible=true)
            {
                panelMenuReportes.Visible = false;
            }
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                EsconderSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


        private void BtnProducto_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuProd);

        }


        private void btnFacturacion_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelMenuFacturacion);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //showSubMenu(panelMenuClientes);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
           // showSubMenu(panelMenuVentas);
        }

        private void btnMenuCompra_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuCompras);
        }

        private void btnMenuReportes_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuReportes);
        }

        private void btnRegistarProd_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormRegistodeProducto());
            EsconderSubMenu();
        }

        private void btnConsultarProd_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormConsultarProductos());
            EsconderSubMenu();
        }

        private void btnRegistarCliente_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void btnRegistarCompra_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void btnConsultarCompra_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void btnConsultarReportes_Click(object sender, EventArgs e)
        {
            MostrarFormLogo();
            EsconderSubMenu();
        }
        private void AbrirFormEnPanel(object Formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
          

        }
    

        private void btnConsultaFactura_Click(object sender, EventArgs e)
        {
            EsconderSubMenu();
        }

        private void pictureExpandir_Click_1(object sender, EventArgs e)
        {

            if (PanelMenuLateral.Width == 250)
            {
                PanelMenuLateral.Width = 50;
            }
            else
            {
                PanelMenuLateral.Width = 250;
            }
        }

        private void pictureInicio_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormInicio());
         

        }
        private void MostrarFormLogo()
        {
            AbrirFormEnPanel(new FormInicio());
        }
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            MostrarFormLogo();
        }
        private void MostrarFormLogoAlCerrarForms(object sender, FormClosedEventArgs e)
        {
            MostrarFormLogo();
        }

        private void btnGestionVenta_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new FormCrearVenta());
        }
    }
}
