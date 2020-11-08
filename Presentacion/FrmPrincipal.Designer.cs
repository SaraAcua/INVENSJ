namespace Presentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureInicio = new System.Windows.Forms.PictureBox();
            this.pictureExpandir = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnConsultarProd = new System.Windows.Forms.Button();
            this.btnRegistarProd = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnGestionVenta = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnRegistarCompra = new System.Windows.Forms.Button();
            this.btnListadoCliente = new System.Windows.Forms.Button();
            this.btnListadoProv = new System.Windows.Forms.Button();
            this.btnListadoCompras = new System.Windows.Forms.Button();
            this.btnListadoVentas = new System.Windows.Forms.Button();
            this.PanelMenuLateral = new System.Windows.Forms.Panel();
            this.panelMenuReportes = new System.Windows.Forms.Panel();
            this.btnMenuReportes = new System.Windows.Forms.Button();
            this.panelMenuCompras = new System.Windows.Forms.Panel();
            this.btnMenuCompra = new System.Windows.Forms.Button();
            this.panelMenuFacturacion = new System.Windows.Forms.Panel();
            this.btnVentas = new System.Windows.Forms.Button();
            this.panelMenuProd = new System.Windows.Forms.Panel();
            this.BtnAlmacen = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExpandir)).BeginInit();
            this.PanelMenuLateral.SuspendLayout();
            this.panelMenuReportes.SuspendLayout();
            this.panelMenuCompras.SuspendLayout();
            this.panelMenuFacturacion.SuspendLayout();
            this.panelMenuProd.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.panel1.Controls.Add(this.pictureInicio);
            this.panel1.Controls.Add(this.pictureExpandir);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(250, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(730, 38);
            this.panel1.TabIndex = 1;
            // 
            // pictureInicio
            // 
            this.pictureInicio.Image = global::Presentacion.Properties.Resources.iconfinder_Artboard_1_30306981;
            this.pictureInicio.Location = new System.Drawing.Point(56, 1);
            this.pictureInicio.Name = "pictureInicio";
            this.pictureInicio.Size = new System.Drawing.Size(38, 35);
            this.pictureInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureInicio.TabIndex = 1;
            this.pictureInicio.TabStop = false;
            this.pictureInicio.Click += new System.EventHandler(this.pictureInicio_Click);
            // 
            // pictureExpandir
            // 
            this.pictureExpandir.Image = global::Presentacion.Properties.Resources.iconfinder_Burger_Menu_4781852;
            this.pictureExpandir.Location = new System.Drawing.Point(-1, 0);
            this.pictureExpandir.Name = "pictureExpandir";
            this.pictureExpandir.Size = new System.Drawing.Size(51, 38);
            this.pictureExpandir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureExpandir.TabIndex = 0;
            this.pictureExpandir.TabStop = false;
            this.pictureExpandir.Click += new System.EventHandler(this.pictureExpandir_Click_1);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.LightGray;
            this.panelContenedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.ForeColor = System.Drawing.Color.White;
            this.panelContenedor.Location = new System.Drawing.Point(250, 38);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(730, 646);
            this.panelContenedor.TabIndex = 2;
            // 
            // btnConsultarProd
            // 
            this.btnConsultarProd.BackColor = System.Drawing.Color.CadetBlue;
            this.btnConsultarProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultarProd.FlatAppearance.BorderSize = 0;
            this.btnConsultarProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnConsultarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultarProd.ForeColor = System.Drawing.Color.White;
            this.btnConsultarProd.Location = new System.Drawing.Point(0, 40);
            this.btnConsultarProd.Name = "btnConsultarProd";
            this.btnConsultarProd.Size = new System.Drawing.Size(233, 40);
            this.btnConsultarProd.TabIndex = 1;
            this.btnConsultarProd.Text = "Consultar productos";
            this.btnConsultarProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarProd.UseVisualStyleBackColor = false;
            this.btnConsultarProd.Click += new System.EventHandler(this.btnConsultarProd_Click);
            // 
            // btnRegistarProd
            // 
            this.btnRegistarProd.BackColor = System.Drawing.Color.CadetBlue;
            this.btnRegistarProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistarProd.FlatAppearance.BorderSize = 0;
            this.btnRegistarProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnRegistarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistarProd.ForeColor = System.Drawing.Color.White;
            this.btnRegistarProd.Location = new System.Drawing.Point(0, 0);
            this.btnRegistarProd.Name = "btnRegistarProd";
            this.btnRegistarProd.Size = new System.Drawing.Size(233, 40);
            this.btnRegistarProd.TabIndex = 0;
            this.btnRegistarProd.Text = "Gestiòn de productos ";
            this.btnRegistarProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistarProd.UseVisualStyleBackColor = false;
            this.btnRegistarProd.Click += new System.EventHandler(this.btnRegistarProd_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.CadetBlue;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.ForeColor = System.Drawing.Color.White;
            this.btnClientes.Location = new System.Drawing.Point(0, 40);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(233, 40);
            this.btnClientes.TabIndex = 1;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnConsultaFactura_Click);
            // 
            // btnGestionVenta
            // 
            this.btnGestionVenta.BackColor = System.Drawing.Color.CadetBlue;
            this.btnGestionVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionVenta.FlatAppearance.BorderSize = 0;
            this.btnGestionVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnGestionVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestionVenta.ForeColor = System.Drawing.Color.White;
            this.btnGestionVenta.Location = new System.Drawing.Point(0, 0);
            this.btnGestionVenta.Name = "btnGestionVenta";
            this.btnGestionVenta.Size = new System.Drawing.Size(233, 40);
            this.btnGestionVenta.TabIndex = 0;
            this.btnGestionVenta.Text = "Gestiòn de Venta";
            this.btnGestionVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestionVenta.UseVisualStyleBackColor = false;
            this.btnGestionVenta.Click += new System.EventHandler(this.btnGestionVenta_Click);
            // 
            // btnProveedores
            // 
            this.btnProveedores.BackColor = System.Drawing.Color.CadetBlue;
            this.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.ForeColor = System.Drawing.Color.White;
            this.btnProveedores.Location = new System.Drawing.Point(0, 40);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(233, 40);
            this.btnProveedores.TabIndex = 1;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.UseVisualStyleBackColor = false;
            this.btnProveedores.Click += new System.EventHandler(this.btnConsultarCompra_Click);
            // 
            // btnRegistarCompra
            // 
            this.btnRegistarCompra.BackColor = System.Drawing.Color.CadetBlue;
            this.btnRegistarCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistarCompra.FlatAppearance.BorderSize = 0;
            this.btnRegistarCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnRegistarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistarCompra.ForeColor = System.Drawing.Color.White;
            this.btnRegistarCompra.Location = new System.Drawing.Point(0, 0);
            this.btnRegistarCompra.Name = "btnRegistarCompra";
            this.btnRegistarCompra.Size = new System.Drawing.Size(233, 40);
            this.btnRegistarCompra.TabIndex = 0;
            this.btnRegistarCompra.Text = "Gestiòn de compra";
            this.btnRegistarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistarCompra.UseVisualStyleBackColor = false;
            this.btnRegistarCompra.Click += new System.EventHandler(this.btnRegistarCompra_Click);
            // 
            // btnListadoCliente
            // 
            this.btnListadoCliente.BackColor = System.Drawing.Color.CadetBlue;
            this.btnListadoCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListadoCliente.FlatAppearance.BorderSize = 0;
            this.btnListadoCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnListadoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListadoCliente.ForeColor = System.Drawing.Color.White;
            this.btnListadoCliente.Location = new System.Drawing.Point(0, 121);
            this.btnListadoCliente.Name = "btnListadoCliente";
            this.btnListadoCliente.Size = new System.Drawing.Size(233, 40);
            this.btnListadoCliente.TabIndex = 3;
            this.btnListadoCliente.Text = "Listado clientes";
            this.btnListadoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListadoCliente.UseVisualStyleBackColor = false;
            this.btnListadoCliente.Click += new System.EventHandler(this.btnListadoCliente_Click);
            // 
            // btnListadoProv
            // 
            this.btnListadoProv.BackColor = System.Drawing.Color.CadetBlue;
            this.btnListadoProv.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListadoProv.FlatAppearance.BorderSize = 0;
            this.btnListadoProv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnListadoProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListadoProv.ForeColor = System.Drawing.Color.White;
            this.btnListadoProv.Location = new System.Drawing.Point(0, 40);
            this.btnListadoProv.Name = "btnListadoProv";
            this.btnListadoProv.Size = new System.Drawing.Size(233, 40);
            this.btnListadoProv.TabIndex = 2;
            this.btnListadoProv.Text = "Listado proveedores";
            this.btnListadoProv.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListadoProv.UseVisualStyleBackColor = false;
            this.btnListadoProv.Click += new System.EventHandler(this.btnListadoProv_Click);
            // 
            // btnListadoCompras
            // 
            this.btnListadoCompras.BackColor = System.Drawing.Color.CadetBlue;
            this.btnListadoCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListadoCompras.FlatAppearance.BorderSize = 0;
            this.btnListadoCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnListadoCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListadoCompras.ForeColor = System.Drawing.Color.White;
            this.btnListadoCompras.Location = new System.Drawing.Point(0, 0);
            this.btnListadoCompras.Name = "btnListadoCompras";
            this.btnListadoCompras.Size = new System.Drawing.Size(233, 40);
            this.btnListadoCompras.TabIndex = 1;
            this.btnListadoCompras.Text = "Listado compras";
            this.btnListadoCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListadoCompras.UseVisualStyleBackColor = false;
            this.btnListadoCompras.Click += new System.EventHandler(this.btnListadoCompras_Click);
            // 
            // btnListadoVentas
            // 
            this.btnListadoVentas.BackColor = System.Drawing.Color.CadetBlue;
            this.btnListadoVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListadoVentas.FlatAppearance.BorderSize = 0;
            this.btnListadoVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnListadoVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListadoVentas.ForeColor = System.Drawing.Color.White;
            this.btnListadoVentas.Location = new System.Drawing.Point(0, 80);
            this.btnListadoVentas.Name = "btnListadoVentas";
            this.btnListadoVentas.Size = new System.Drawing.Size(233, 41);
            this.btnListadoVentas.TabIndex = 0;
            this.btnListadoVentas.Text = "Listado ventas";
            this.btnListadoVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListadoVentas.UseVisualStyleBackColor = false;
            this.btnListadoVentas.Click += new System.EventHandler(this.btnConsultarReportes_Click);
            // 
            // PanelMenuLateral
            // 
            this.PanelMenuLateral.AutoScroll = true;
            this.PanelMenuLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.PanelMenuLateral.Controls.Add(this.panelMenuReportes);
            this.PanelMenuLateral.Controls.Add(this.btnMenuReportes);
            this.PanelMenuLateral.Controls.Add(this.panelMenuCompras);
            this.PanelMenuLateral.Controls.Add(this.btnMenuCompra);
            this.PanelMenuLateral.Controls.Add(this.panelMenuFacturacion);
            this.PanelMenuLateral.Controls.Add(this.btnVentas);
            this.PanelMenuLateral.Controls.Add(this.panelMenuProd);
            this.PanelMenuLateral.Controls.Add(this.BtnAlmacen);
            this.PanelMenuLateral.Controls.Add(this.panel2);
            this.PanelMenuLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenuLateral.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuLateral.Margin = new System.Windows.Forms.Padding(4);
            this.PanelMenuLateral.Name = "PanelMenuLateral";
            this.PanelMenuLateral.Size = new System.Drawing.Size(250, 684);
            this.PanelMenuLateral.TabIndex = 0;
            // 
            // panelMenuReportes
            // 
            this.panelMenuReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMenuReportes.Controls.Add(this.btnListadoCliente);
            this.panelMenuReportes.Controls.Add(this.btnListadoVentas);
            this.panelMenuReportes.Controls.Add(this.btnListadoProv);
            this.panelMenuReportes.Controls.Add(this.btnListadoCompras);
            this.panelMenuReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuReportes.Location = new System.Drawing.Point(0, 549);
            this.panelMenuReportes.Name = "panelMenuReportes";
            this.panelMenuReportes.Size = new System.Drawing.Size(233, 160);
            this.panelMenuReportes.TabIndex = 12;
            // 
            // btnMenuReportes
            // 
            this.btnMenuReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuReportes.FlatAppearance.BorderSize = 0;
            this.btnMenuReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.btnMenuReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(137)))), ((int)(((byte)(173)))));
            this.btnMenuReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuReportes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuReportes.Image = global::Presentacion.Properties.Resources.estadistica;
            this.btnMenuReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuReportes.Location = new System.Drawing.Point(0, 504);
            this.btnMenuReportes.Name = "btnMenuReportes";
            this.btnMenuReportes.Size = new System.Drawing.Size(233, 45);
            this.btnMenuReportes.TabIndex = 12;
            this.btnMenuReportes.Text = "              Reportes";
            this.btnMenuReportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuReportes.UseVisualStyleBackColor = true;
            this.btnMenuReportes.Click += new System.EventHandler(this.btnMenuReportes_Click_1);
            // 
            // panelMenuCompras
            // 
            this.panelMenuCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMenuCompras.Controls.Add(this.btnProveedores);
            this.panelMenuCompras.Controls.Add(this.btnRegistarCompra);
            this.panelMenuCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuCompras.Location = new System.Drawing.Point(0, 424);
            this.panelMenuCompras.Name = "panelMenuCompras";
            this.panelMenuCompras.Size = new System.Drawing.Size(233, 80);
            this.panelMenuCompras.TabIndex = 10;
            // 
            // btnMenuCompra
            // 
            this.btnMenuCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuCompra.FlatAppearance.BorderSize = 0;
            this.btnMenuCompra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.btnMenuCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(137)))), ((int)(((byte)(173)))));
            this.btnMenuCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuCompra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuCompra.Image = global::Presentacion.Properties.Resources.carro_de_la_compra__1_1;
            this.btnMenuCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuCompra.Location = new System.Drawing.Point(0, 379);
            this.btnMenuCompra.Name = "btnMenuCompra";
            this.btnMenuCompra.Size = new System.Drawing.Size(233, 45);
            this.btnMenuCompra.TabIndex = 12;
            this.btnMenuCompra.Text = "              Compras";
            this.btnMenuCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuCompra.UseVisualStyleBackColor = true;
            this.btnMenuCompra.Click += new System.EventHandler(this.btnMenuCompra_Click_1);
            // 
            // panelMenuFacturacion
            // 
            this.panelMenuFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMenuFacturacion.Controls.Add(this.btnClientes);
            this.panelMenuFacturacion.Controls.Add(this.btnGestionVenta);
            this.panelMenuFacturacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuFacturacion.Location = new System.Drawing.Point(0, 299);
            this.panelMenuFacturacion.Name = "panelMenuFacturacion";
            this.panelMenuFacturacion.Size = new System.Drawing.Size(233, 80);
            this.panelMenuFacturacion.TabIndex = 4;
            // 
            // btnVentas
            // 
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(137)))), ((int)(((byte)(173)))));
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVentas.Image = global::Presentacion.Properties.Resources.bolso;
            this.btnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Location = new System.Drawing.Point(0, 254);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(233, 45);
            this.btnVentas.TabIndex = 12;
            this.btnVentas.Text = "              Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // panelMenuProd
            // 
            this.panelMenuProd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelMenuProd.Controls.Add(this.btnConsultarProd);
            this.panelMenuProd.Controls.Add(this.btnRegistarProd);
            this.panelMenuProd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuProd.Location = new System.Drawing.Point(0, 174);
            this.panelMenuProd.Name = "panelMenuProd";
            this.panelMenuProd.Size = new System.Drawing.Size(233, 80);
            this.panelMenuProd.TabIndex = 2;
            // 
            // BtnAlmacen
            // 
            this.BtnAlmacen.BackColor = System.Drawing.Color.Transparent;
            this.BtnAlmacen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAlmacen.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnAlmacen.FlatAppearance.BorderSize = 0;
            this.BtnAlmacen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(66)))), ((int)(((byte)(102)))));
            this.BtnAlmacen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(137)))), ((int)(((byte)(173)))));
            this.BtnAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlmacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlmacen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAlmacen.Image = global::Presentacion.Properties.Resources.almacen;
            this.BtnAlmacen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlmacen.Location = new System.Drawing.Point(0, 129);
            this.BtnAlmacen.Name = "BtnAlmacen";
            this.BtnAlmacen.Size = new System.Drawing.Size(233, 45);
            this.BtnAlmacen.TabIndex = 1;
            this.BtnAlmacen.Text = "              Almacen";
            this.BtnAlmacen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlmacen.UseVisualStyleBackColor = false;
            this.BtnAlmacen.Click += new System.EventHandler(this.BtnAlmacen_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 129);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.IMG_6180;
            this.pictureBox1.Location = new System.Drawing.Point(22, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 684);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelMenuLateral);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(949, 600);
            this.Name = "FrmPrincipal";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INVENSJ";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(77)))), ((int)(((byte)(97)))));
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureExpandir)).EndInit();
            this.PanelMenuLateral.ResumeLayout(false);
            this.panelMenuReportes.ResumeLayout(false);
            this.panelMenuCompras.ResumeLayout(false);
            this.panelMenuFacturacion.ResumeLayout(false);
            this.panelMenuProd.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureExpandir;
        private System.Windows.Forms.PictureBox pictureInicio;
        private System.Windows.Forms.Button btnConsultarProd;
        private System.Windows.Forms.Button btnRegistarProd;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnGestionVenta;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button btnRegistarCompra;
        private System.Windows.Forms.Button btnListadoCompras;
        private System.Windows.Forms.Button btnListadoVentas;
        private System.Windows.Forms.Panel PanelMenuLateral;
        private System.Windows.Forms.Button btnListadoCliente;
        private System.Windows.Forms.Button btnListadoProv;
        private System.Windows.Forms.Panel panelMenuReportes;
        private System.Windows.Forms.Button btnMenuReportes;
        private System.Windows.Forms.Panel panelMenuCompras;
        private System.Windows.Forms.Button btnMenuCompra;
        private System.Windows.Forms.Panel panelMenuFacturacion;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel panelMenuProd;
        private System.Windows.Forms.Button BtnAlmacen;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}