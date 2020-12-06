namespace Presentacion
{
    partial class FormRegistodeProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistodeProducto));
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGvRegistroProd = new System.Windows.Forms.DataGridView();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.txtCodigoColor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCodigoMarca = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStockMaximo = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtStockMinimo = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIva = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCantidad = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.txtRutaImge = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbTalla = new System.Windows.Forms.ComboBox();
            this.picAddMarca = new System.Windows.Forms.PictureBox();
            this.picAgregarImage = new System.Windows.Forms.PictureBox();
            this.picAddColor = new System.Windows.Forms.PictureBox();
            this.txtPrecioVenta = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCostoCompra = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDescripcionProd = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCodigoProd = new Guna.UI2.WinForms.Guna2TextBox();
            this.picImgen = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGvRegistroProd)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregarImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImgen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "REGISTRO DE PRODUCTO";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Controls.Add(this.btnGuardarProducto);
            this.panel3.Controls.Add(this.btnEliminarProd);
            this.panel3.Location = new System.Drawing.Point(254, 228);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 58);
            this.panel3.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(175, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 54);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.UseWaitCursor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardarProducto
            // 
            this.btnGuardarProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardarProducto.FlatAppearance.BorderSize = 0;
            this.btnGuardarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnGuardarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarProducto.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarProducto.ForeColor = System.Drawing.Color.Black;
            this.btnGuardarProducto.Image = global::Presentacion.Properties.Resources.diskette;
            this.btnGuardarProducto.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuardarProducto.Location = new System.Drawing.Point(89, 2);
            this.btnGuardarProducto.Name = "btnGuardarProducto";
            this.btnGuardarProducto.Size = new System.Drawing.Size(80, 54);
            this.btnGuardarProducto.TabIndex = 7;
            this.btnGuardarProducto.Text = "Guardar";
            this.btnGuardarProducto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuardarProducto.UseVisualStyleBackColor = false;
            this.btnGuardarProducto.Click += new System.EventHandler(this.btnGuardarProducto_Click);
            // 
            // btnEliminarProd
            // 
            this.btnEliminarProd.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminarProd.FlatAppearance.BorderSize = 0;
            this.btnEliminarProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEliminarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProd.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProd.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarProd.Image = global::Presentacion.Properties.Resources.eliminar;
            this.btnEliminarProd.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEliminarProd.Location = new System.Drawing.Point(3, 2);
            this.btnEliminarProd.Name = "btnEliminarProd";
            this.btnEliminarProd.Size = new System.Drawing.Size(80, 54);
            this.btnEliminarProd.TabIndex = 6;
            this.btnEliminarProd.Text = "Eliminar";
            this.btnEliminarProd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEliminarProd.UseVisualStyleBackColor = false;
            this.btnEliminarProd.Click += new System.EventHandler(this.btnEliminarProd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(123, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Color";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(110, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Stock maximo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(273, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "Imagen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label8.Location = new System.Drawing.Point(279, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Marca";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(16, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Talla";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(304, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(244, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Costo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(85, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripciòn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(16, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGvRegistroProd
            // 
            this.dataGvRegistroProd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGvRegistroProd.BackgroundColor = System.Drawing.Color.Silver;
            this.dataGvRegistroProd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGvRegistroProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGvRegistroProd.Location = new System.Drawing.Point(25, 292);
            this.dataGvRegistroProd.Name = "dataGvRegistroProd";
            this.dataGvRegistroProd.Size = new System.Drawing.Size(688, 228);
            this.dataGvRegistroProd.TabIndex = 3;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.guna2GradientPanel1.BorderRadius = 15;
            this.guna2GradientPanel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.guna2GradientPanel1.Controls.Add(this.txtCodigoColor);
            this.guna2GradientPanel1.Controls.Add(this.txtCodigoMarca);
            this.guna2GradientPanel1.Controls.Add(this.label13);
            this.guna2GradientPanel1.Controls.Add(this.label11);
            this.guna2GradientPanel1.Controls.Add(this.txtStockMaximo);
            this.guna2GradientPanel1.Controls.Add(this.txtStockMinimo);
            this.guna2GradientPanel1.Controls.Add(this.label12);
            this.guna2GradientPanel1.Controls.Add(this.txtIva);
            this.guna2GradientPanel1.Controls.Add(this.txtCantidad);
            this.guna2GradientPanel1.Controls.Add(this.cmbMarca);
            this.guna2GradientPanel1.Controls.Add(this.cmbColor);
            this.guna2GradientPanel1.Controls.Add(this.label9);
            this.guna2GradientPanel1.Controls.Add(this.txtRutaImge);
            this.guna2GradientPanel1.Controls.Add(this.cmbTalla);
            this.guna2GradientPanel1.Controls.Add(this.picAddMarca);
            this.guna2GradientPanel1.Controls.Add(this.picAgregarImage);
            this.guna2GradientPanel1.Controls.Add(this.picAddColor);
            this.guna2GradientPanel1.Controls.Add(this.txtPrecioVenta);
            this.guna2GradientPanel1.Controls.Add(this.txtCostoCompra);
            this.guna2GradientPanel1.Controls.Add(this.txtDescripcionProd);
            this.guna2GradientPanel1.Controls.Add(this.txtCodigoProd);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.label10);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Controls.Add(this.label7);
            this.guna2GradientPanel1.Controls.Add(this.label3);
            this.guna2GradientPanel1.Controls.Add(this.label6);
            this.guna2GradientPanel1.Controls.Add(this.label8);
            this.guna2GradientPanel1.Controls.Add(this.label5);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(119)))), ((int)(((byte)(173)))));
            this.guna2GradientPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(25, 57);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(488, 165);
            this.guna2GradientPanel1.TabIndex = 5;
            // 
            // txtCodigoColor
            // 
            this.txtCodigoColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoColor.DefaultText = "";
            this.txtCodigoColor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigoColor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigoColor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoColor.DisabledState.Parent = this.txtCodigoColor;
            this.txtCodigoColor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoColor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoColor.FocusedState.Parent = this.txtCodigoColor;
            this.txtCodigoColor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodigoColor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoColor.HoverState.Parent = this.txtCodigoColor;
            this.txtCodigoColor.Location = new System.Drawing.Point(86, 68);
            this.txtCodigoColor.Name = "txtCodigoColor";
            this.txtCodigoColor.PasswordChar = '\0';
            this.txtCodigoColor.PlaceholderText = "";
            this.txtCodigoColor.SelectedText = "";
            this.txtCodigoColor.ShadowDecoration.Parent = this.txtCodigoColor;
            this.txtCodigoColor.Size = new System.Drawing.Size(31, 22);
            this.txtCodigoColor.TabIndex = 49;
            // 
            // txtCodigoMarca
            // 
            this.txtCodigoMarca.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoMarca.DefaultText = "";
            this.txtCodigoMarca.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigoMarca.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigoMarca.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoMarca.DisabledState.Parent = this.txtCodigoMarca;
            this.txtCodigoMarca.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoMarca.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoMarca.FocusedState.Parent = this.txtCodigoMarca;
            this.txtCodigoMarca.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodigoMarca.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoMarca.HoverState.Parent = this.txtCodigoMarca;
            this.txtCodigoMarca.Location = new System.Drawing.Point(244, 67);
            this.txtCodigoMarca.Name = "txtCodigoMarca";
            this.txtCodigoMarca.PasswordChar = '\0';
            this.txtCodigoMarca.PlaceholderText = "";
            this.txtCodigoMarca.SelectedText = "";
            this.txtCodigoMarca.ShadowDecoration.Parent = this.txtCodigoMarca;
            this.txtCodigoMarca.Size = new System.Drawing.Size(32, 22);
            this.txtCodigoMarca.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(207, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 16);
            this.label13.TabIndex = 47;
            this.label13.Text = "Cantidad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(16, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 16);
            this.label11.TabIndex = 46;
            this.label11.Text = "Stock minimo";
            // 
            // txtStockMaximo
            // 
            this.txtStockMaximo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStockMaximo.DefaultText = "";
            this.txtStockMaximo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStockMaximo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStockMaximo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStockMaximo.DisabledState.Parent = this.txtStockMaximo;
            this.txtStockMaximo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStockMaximo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStockMaximo.FocusedState.Parent = this.txtStockMaximo;
            this.txtStockMaximo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStockMaximo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStockMaximo.HoverState.Parent = this.txtStockMaximo;
            this.txtStockMaximo.Location = new System.Drawing.Point(112, 117);
            this.txtStockMaximo.Name = "txtStockMaximo";
            this.txtStockMaximo.PasswordChar = '\0';
            this.txtStockMaximo.PlaceholderText = "";
            this.txtStockMaximo.SelectedText = "";
            this.txtStockMaximo.ShadowDecoration.Parent = this.txtStockMaximo;
            this.txtStockMaximo.Size = new System.Drawing.Size(88, 19);
            this.txtStockMaximo.TabIndex = 45;
            this.txtStockMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockMaximo_KeyPress);
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStockMinimo.DefaultText = "";
            this.txtStockMinimo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStockMinimo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStockMinimo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStockMinimo.DisabledState.Parent = this.txtStockMinimo;
            this.txtStockMinimo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStockMinimo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStockMinimo.FocusedState.Parent = this.txtStockMinimo;
            this.txtStockMinimo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStockMinimo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStockMinimo.HoverState.Parent = this.txtStockMinimo;
            this.txtStockMinimo.Location = new System.Drawing.Point(17, 117);
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.PasswordChar = '\0';
            this.txtStockMinimo.PlaceholderText = "";
            this.txtStockMinimo.SelectedText = "";
            this.txtStockMinimo.ShadowDecoration.Parent = this.txtStockMinimo;
            this.txtStockMinimo.Size = new System.Drawing.Size(71, 19);
            this.txtStockMinimo.TabIndex = 44;
            this.txtStockMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockMinimo_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(374, 12);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 16);
            this.label12.TabIndex = 43;
            this.label12.Text = "Iva";
            // 
            // txtIva
            // 
            this.txtIva.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIva.DefaultText = "";
            this.txtIva.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIva.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIva.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIva.DisabledState.Parent = this.txtIva;
            this.txtIva.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIva.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIva.FocusedState.Parent = this.txtIva;
            this.txtIva.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIva.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIva.HoverState.Parent = this.txtIva;
            this.txtIva.Location = new System.Drawing.Point(373, 27);
            this.txtIva.Name = "txtIva";
            this.txtIva.PasswordChar = '\0';
            this.txtIva.PlaceholderText = "";
            this.txtIva.SelectedText = "";
            this.txtIva.ShadowDecoration.Parent = this.txtIva;
            this.txtIva.Size = new System.Drawing.Size(60, 22);
            this.txtIva.TabIndex = 41;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCantidad.DefaultText = "";
            this.txtCantidad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCantidad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCantidad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantidad.DisabledState.Parent = this.txtCantidad;
            this.txtCantidad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCantidad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantidad.FocusedState.Parent = this.txtCantidad;
            this.txtCantidad.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCantidad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCantidad.HoverState.Parent = this.txtCantidad;
            this.txtCantidad.Location = new System.Drawing.Point(209, 117);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PasswordChar = '\0';
            this.txtCantidad.PlaceholderText = "";
            this.txtCantidad.SelectedText = "";
            this.txtCantidad.ShadowDecoration.Parent = this.txtCantidad;
            this.txtCantidad.Size = new System.Drawing.Size(60, 19);
            this.txtCantidad.TabIndex = 40;
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(280, 68);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(85, 21);
            this.cmbMarca.TabIndex = 39;
            this.cmbMarca.SelectedIndexChanged += new System.EventHandler(this.cmbMarca_SelectedIndexChanged);
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(126, 69);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(77, 21);
            this.cmbColor.TabIndex = 38;
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.cmbColor_SelectedIndexChanged);
            // 
            // txtRutaImge
            // 
            this.txtRutaImge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRutaImge.DefaultText = "";
            this.txtRutaImge.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRutaImge.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRutaImge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRutaImge.DisabledState.Parent = this.txtRutaImge;
            this.txtRutaImge.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRutaImge.Enabled = false;
            this.txtRutaImge.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRutaImge.FocusedState.Parent = this.txtRutaImge;
            this.txtRutaImge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRutaImge.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRutaImge.HoverState.Parent = this.txtRutaImge;
            this.txtRutaImge.Location = new System.Drawing.Point(275, 117);
            this.txtRutaImge.Name = "txtRutaImge";
            this.txtRutaImge.PasswordChar = '\0';
            this.txtRutaImge.PlaceholderText = "";
            this.txtRutaImge.SelectedText = "";
            this.txtRutaImge.ShadowDecoration.Parent = this.txtRutaImge;
            this.txtRutaImge.Size = new System.Drawing.Size(153, 19);
            this.txtRutaImge.TabIndex = 33;
            // 
            // cmbTalla
            // 
            this.cmbTalla.FormattingEnabled = true;
            this.cmbTalla.Location = new System.Drawing.Point(19, 69);
            this.cmbTalla.Name = "cmbTalla";
            this.cmbTalla.Size = new System.Drawing.Size(58, 21);
            this.cmbTalla.TabIndex = 37;
            // 
            // picAddMarca
            // 
            this.picAddMarca.BackColor = System.Drawing.Color.Transparent;
            this.picAddMarca.Image = global::Presentacion.Properties.Resources.add;
            this.picAddMarca.Location = new System.Drawing.Point(373, 63);
            this.picAddMarca.Name = "picAddMarca";
            this.picAddMarca.Size = new System.Drawing.Size(26, 27);
            this.picAddMarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAddMarca.TabIndex = 36;
            this.picAddMarca.TabStop = false;
            this.picAddMarca.Click += new System.EventHandler(this.picAddMarca_Click);
            // 
            // picAgregarImage
            // 
            this.picAgregarImage.BackColor = System.Drawing.Color.Transparent;
            this.picAgregarImage.Image = global::Presentacion.Properties.Resources.add;
            this.picAgregarImage.Location = new System.Drawing.Point(434, 112);
            this.picAgregarImage.Name = "picAgregarImage";
            this.picAgregarImage.Size = new System.Drawing.Size(26, 27);
            this.picAgregarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAgregarImage.TabIndex = 35;
            this.picAgregarImage.TabStop = false;
            this.picAgregarImage.Click += new System.EventHandler(this.picAgregarImage_Click);
            // 
            // picAddColor
            // 
            this.picAddColor.BackColor = System.Drawing.Color.Transparent;
            this.picAddColor.Image = global::Presentacion.Properties.Resources.add;
            this.picAddColor.Location = new System.Drawing.Point(210, 63);
            this.picAddColor.Name = "picAddColor";
            this.picAddColor.Size = new System.Drawing.Size(26, 27);
            this.picAddColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAddColor.TabIndex = 32;
            this.picAddColor.TabStop = false;
            this.picAddColor.Click += new System.EventHandler(this.picAddColor_Click);
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioVenta.DefaultText = "";
            this.txtPrecioVenta.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecioVenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecioVenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioVenta.DisabledState.Parent = this.txtPrecioVenta;
            this.txtPrecioVenta.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioVenta.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioVenta.FocusedState.Parent = this.txtPrecioVenta;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrecioVenta.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioVenta.HoverState.Parent = this.txtPrecioVenta;
            this.txtPrecioVenta.Location = new System.Drawing.Point(305, 28);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.PasswordChar = '\0';
            this.txtPrecioVenta.PlaceholderText = "";
            this.txtPrecioVenta.SelectedText = "";
            this.txtPrecioVenta.ShadowDecoration.Parent = this.txtPrecioVenta;
            this.txtPrecioVenta.Size = new System.Drawing.Size(60, 22);
            this.txtPrecioVenta.TabIndex = 26;
            // 
            // txtCostoCompra
            // 
            this.txtCostoCompra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCostoCompra.DefaultText = "";
            this.txtCostoCompra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCostoCompra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCostoCompra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCostoCompra.DisabledState.Parent = this.txtCostoCompra;
            this.txtCostoCompra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCostoCompra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCostoCompra.FocusedState.Parent = this.txtCostoCompra;
            this.txtCostoCompra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCostoCompra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCostoCompra.HoverState.Parent = this.txtCostoCompra;
            this.txtCostoCompra.Location = new System.Drawing.Point(245, 28);
            this.txtCostoCompra.Name = "txtCostoCompra";
            this.txtCostoCompra.PasswordChar = '\0';
            this.txtCostoCompra.PlaceholderText = "";
            this.txtCostoCompra.SelectedText = "";
            this.txtCostoCompra.ShadowDecoration.Parent = this.txtCostoCompra;
            this.txtCostoCompra.Size = new System.Drawing.Size(54, 22);
            this.txtCostoCompra.TabIndex = 25;
            // 
            // txtDescripcionProd
            // 
            this.txtDescripcionProd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcionProd.DefaultText = "";
            this.txtDescripcionProd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDescripcionProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDescripcionProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcionProd.DisabledState.Parent = this.txtDescripcionProd;
            this.txtDescripcionProd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDescripcionProd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcionProd.FocusedState.Parent = this.txtDescripcionProd;
            this.txtDescripcionProd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDescripcionProd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDescripcionProd.HoverState.Parent = this.txtDescripcionProd;
            this.txtDescripcionProd.Location = new System.Drawing.Point(87, 28);
            this.txtDescripcionProd.Name = "txtDescripcionProd";
            this.txtDescripcionProd.PasswordChar = '\0';
            this.txtDescripcionProd.PlaceholderText = "";
            this.txtDescripcionProd.SelectedText = "";
            this.txtDescripcionProd.ShadowDecoration.Parent = this.txtDescripcionProd;
            this.txtDescripcionProd.Size = new System.Drawing.Size(149, 22);
            this.txtDescripcionProd.TabIndex = 24;
            // 
            // txtCodigoProd
            // 
            this.txtCodigoProd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCodigoProd.DefaultText = "";
            this.txtCodigoProd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCodigoProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCodigoProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoProd.DisabledState.Parent = this.txtCodigoProd;
            this.txtCodigoProd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCodigoProd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoProd.FocusedState.Parent = this.txtCodigoProd;
            this.txtCodigoProd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCodigoProd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCodigoProd.HoverState.Parent = this.txtCodigoProd;
            this.txtCodigoProd.Location = new System.Drawing.Point(19, 28);
            this.txtCodigoProd.Name = "txtCodigoProd";
            this.txtCodigoProd.PasswordChar = '\0';
            this.txtCodigoProd.PlaceholderText = "";
            this.txtCodigoProd.SelectedText = "";
            this.txtCodigoProd.ShadowDecoration.Parent = this.txtCodigoProd;
            this.txtCodigoProd.Size = new System.Drawing.Size(58, 22);
            this.txtCodigoProd.TabIndex = 23;
         
            // 
            // picImgen
            // 
            this.picImgen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picImgen.Location = new System.Drawing.Point(519, 57);
            this.picImgen.Name = "picImgen";
            this.picImgen.Size = new System.Drawing.Size(166, 165);
            this.picImgen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImgen.TabIndex = 6;
            this.picImgen.TabStop = false;
            // 
            // FormRegistodeProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(743, 606);
            this.Controls.Add(this.picImgen);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dataGvRegistroProd);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistodeProducto";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "FormRegistodeProducto";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGvRegistroProd)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAddMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAgregarImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picImgen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGvRegistroProd;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.Button btnEliminarProd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txtPrecioVenta;
        private Guna.UI2.WinForms.Guna2TextBox txtCostoCompra;
        private Guna.UI2.WinForms.Guna2TextBox txtDescripcionProd;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigoProd;
        private Guna.UI2.WinForms.Guna2TextBox txtRutaImge;
        private System.Windows.Forms.PictureBox picAddColor;
        private System.Windows.Forms.PictureBox picAddMarca;
        private System.Windows.Forms.PictureBox picAgregarImage;
        private System.Windows.Forms.PictureBox picImgen;
        private Guna.UI2.WinForms.Guna2TextBox txtCantidad;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbTalla;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtStockMaximo;
        private Guna.UI2.WinForms.Guna2TextBox txtStockMinimo;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtIva;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigoColor;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigoMarca;
    }
}