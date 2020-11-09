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
        FormRegistodeProducto formRegistodeProducto = new FormRegistodeProducto();
        FormConsultarProductos consultarProductos  = new FormConsultarProductos();
        FormCrearVenta crearVenta = new FormCrearVenta();
        FormClientes formClientes = new FormClientes();
        FormGestionCompra gestionCompra = new FormGestionCompra();
        FormProveedores formProveedores = new FormProveedores();
        FormListadoVentas listadoVentas = new FormListadoVentas();
        FormListadoCompra listadoCompra = new FormListadoCompra();
        FormListadoProveedores listadoProveedorescs = new FormListadoProveedores();
        FormListadoCliente listadoCliente = new FormListadoCliente();
        FormInicio inicio = new FormInicio();
        
        public FrmPrincipal()
        {
            InitializeComponent();
            PersonalizarSubMenu();
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            this.ControlBox = false;
            this.DoubleBuffered = true;

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
           if (panelMenuProd.Visible == true)
            {
                panelMenuProd.Visible = false;
            }
           if (panelMenuFacturacion.Visible == true)
            {
                panelMenuFacturacion.Visible = false;
            }
            if (panelMenuCompras.Visible == true)
            {
                panelMenuCompras.Visible = false;
            }
            if (panelMenuReportes.Visible==true)
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
            {
                subMenu.Visible = false;
            }
               
        }
    
        private void btnRegistarProd_Click(object sender, EventArgs e)
        {
       
            AbrirFormEnPanel(formRegistodeProducto);
            EsconderSubMenu();
        }

        private void btnConsultarProd_Click(object sender, EventArgs e)
        {
          
            AbrirFormEnPanel(consultarProductos);
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
            AbrirFormEnPanel(gestionCompra);
            EsconderSubMenu();
        }

        private void btnConsultarCompra_Click(object sender, EventArgs e)
        {
           
            AbrirFormEnPanel(formProveedores);
            EsconderSubMenu();
        }

        private void btnConsultarReportes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(listadoVentas);
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
            AbrirFormEnPanel(formClientes);
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
            AbrirFormEnPanel(inicio);
         

        }
        private void MostrarFormLogo()
        {
            AbrirFormEnPanel(inicio);
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
             AbrirFormEnPanel(crearVenta);
            EsconderSubMenu();
          
        }

        private void btnListadoProv_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(listadoProveedorescs);
            EsconderSubMenu();
        }

        private void btnListadoCliente_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(listadoCliente);
            EsconderSubMenu();
        }

        private void btnListadoCompras_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(listadoCompra);
            EsconderSubMenu();
        }

     

        private void btnVentas_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuFacturacion);
        }

        private void btnMenuCompra_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelMenuCompras);
        }

        private void btnMenuReportes_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelMenuReportes);
        }

        private void BtnAlmacen_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuProd);
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            picMax.Visible = false;
            picRestaurar.Visible = true;
        }

        private void picMin_Click(object sender, EventArgs e)
        {
         
            this.WindowState = FormWindowState.Minimized;
            picMax.Visible = true;
            picRestaurar.Visible = false;
        }

        private void picRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            picMax.Visible = true;
            picRestaurar.Visible = false;
            picMin.Visible = true;
            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0X112, 0xf012, 0);
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
