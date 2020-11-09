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
            this.button3 = new System.Windows.Forms.Button();
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
            this.txtStock = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbTalla = new System.Windows.Forms.ComboBox();
            this.picAddMarca = new System.Windows.Forms.PictureBox();
            this.picAgregarImage = new System.Windows.Forms.PictureBox();
            this.txtRutaImge = new Guna.UI2.WinForms.Guna2TextBox();
            this.picAddColor = new System.Windows.Forms.PictureBox();
            this.txtPrecioVenta = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPrecioCompra = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNombreProd = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.btnEliminarProd);
            this.panel3.Location = new System.Drawing.Point(254, 228);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 58);
            this.panel3.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
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
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = global::Presentacion.Properties.Resources.diskette;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(89, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 54);
            this.button3.TabIndex = 7;
            this.button3.Text = "Guardar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
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
            this.label10.Location = new System.Drawing.Point(88, 99);
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
            this.label7.Location = new System.Drawing.Point(205, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Stock";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(289, 54);
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
            this.label8.Location = new System.Drawing.Point(289, 99);
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
            this.label6.Location = new System.Drawing.Point(14, 99);
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
            this.label5.Location = new System.Drawing.Point(157, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Precio de venta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(16, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio de compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(155, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre";
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
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo producto ";
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
            this.guna2GradientPanel1.Controls.Add(this.txtStock);
            this.guna2GradientPanel1.Controls.Add(this.cmbMarca);
            this.guna2GradientPanel1.Controls.Add(this.cmbColor);
            this.guna2GradientPanel1.Controls.Add(this.cmbTalla);
            this.guna2GradientPanel1.Controls.Add(this.picAddMarca);
            this.guna2GradientPanel1.Controls.Add(this.picAgregarImage);
            this.guna2GradientPanel1.Controls.Add(this.txtRutaImge);
            this.guna2GradientPanel1.Controls.Add(this.picAddColor);
            this.guna2GradientPanel1.Controls.Add(this.txtPrecioVenta);
            this.guna2GradientPanel1.Controls.Add(this.txtPrecioCompra);
            this.guna2GradientPanel1.Controls.Add(this.txtNombreProd);
            this.guna2GradientPanel1.Controls.Add(this.txtCodigoProd);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.label9);
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
            // txtStock
            // 
            this.txtStock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStock.DefaultText = "";
            this.txtStock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStock.DisabledState.Parent = this.txtStock;
            this.txtStock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStock.FocusedState.Parent = this.txtStock;
            this.txtStock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtStock.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStock.HoverState.Parent = this.txtStock;
            this.txtStock.Location = new System.Drawing.Point(208, 117);
            this.txtStock.Name = "txtStock";
            this.txtStock.PasswordChar = '\0';
            this.txtStock.PlaceholderText = "";
            this.txtStock.SelectedText = "";
            this.txtStock.ShadowDecoration.Parent = this.txtStock;
            this.txtStock.Size = new System.Drawing.Size(60, 19);
            this.txtStock.TabIndex = 40;
            // 
            // cmbMarca
            // 
            this.cmbMarca.FormattingEnabled = true;
            this.cmbMarca.Location = new System.Drawing.Point(289, 117);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(152, 21);
            this.cmbMarca.TabIndex = 39;
            // 
            // cmbColor
            // 
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(74, 117);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(84, 21);
            this.cmbColor.TabIndex = 38;
            // 
            // cmbTalla
            // 
            this.cmbTalla.FormattingEnabled = true;
            this.cmbTalla.Location = new System.Drawing.Point(17, 117);
            this.cmbTalla.Name = "cmbTalla";
            this.cmbTalla.Size = new System.Drawing.Size(51, 21);
            this.cmbTalla.TabIndex = 37;
            // 
            // picAddMarca
            // 
            this.picAddMarca.BackColor = System.Drawing.Color.Transparent;
            this.picAddMarca.Image = global::Presentacion.Properties.Resources.add;
            this.picAddMarca.Location = new System.Drawing.Point(447, 118);
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
            this.picAgregarImage.Location = new System.Drawing.Point(447, 71);
            this.picAgregarImage.Name = "picAgregarImage";
            this.picAgregarImage.Size = new System.Drawing.Size(26, 27);
            this.picAgregarImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAgregarImage.TabIndex = 35;
            this.picAgregarImage.TabStop = false;
            this.picAgregarImage.Click += new System.EventHandler(this.picAgregarImage_Click);
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
            this.txtRutaImge.Location = new System.Drawing.Point(289, 71);
            this.txtRutaImge.Name = "txtRutaImge";
            this.txtRutaImge.PasswordChar = '\0';
            this.txtRutaImge.PlaceholderText = "";
            this.txtRutaImge.SelectedText = "";
            this.txtRutaImge.ShadowDecoration.Parent = this.txtRutaImge;
            this.txtRutaImge.Size = new System.Drawing.Size(152, 22);
            this.txtRutaImge.TabIndex = 33;
            // 
            // picAddColor
            // 
            this.picAddColor.BackColor = System.Drawing.Color.Transparent;
            this.picAddColor.Image = global::Presentacion.Properties.Resources.add;
            this.picAddColor.Location = new System.Drawing.Point(161, 115);
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
            this.txtPrecioVenta.Location = new System.Drawing.Point(157, 72);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.PasswordChar = '\0';
            this.txtPrecioVenta.PlaceholderText = "";
            this.txtPrecioVenta.SelectedText = "";
            this.txtPrecioVenta.ShadowDecoration.Parent = this.txtPrecioVenta;
            this.txtPrecioVenta.Size = new System.Drawing.Size(111, 22);
            this.txtPrecioVenta.TabIndex = 26;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrecioCompra.DefaultText = "";
            this.txtPrecioCompra.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrecioCompra.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrecioCompra.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioCompra.DisabledState.Parent = this.txtPrecioCompra;
            this.txtPrecioCompra.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrecioCompra.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioCompra.FocusedState.Parent = this.txtPrecioCompra;
            this.txtPrecioCompra.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPrecioCompra.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrecioCompra.HoverState.Parent = this.txtPrecioCompra;
            this.txtPrecioCompra.Location = new System.Drawing.Point(17, 72);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.PasswordChar = '\0';
            this.txtPrecioCompra.PlaceholderText = "";
            this.txtPrecioCompra.SelectedText = "";
            this.txtPrecioCompra.ShadowDecoration.Parent = this.txtPrecioCompra;
            this.txtPrecioCompra.Size = new System.Drawing.Size(102, 22);
            this.txtPrecioCompra.TabIndex = 25;
            // 
            // txtNombreProd
            // 
            this.txtNombreProd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombreProd.DefaultText = "";
            this.txtNombreProd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNombreProd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNombreProd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreProd.DisabledState.Parent = this.txtNombreProd;
            this.txtNombreProd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNombreProd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreProd.FocusedState.Parent = this.txtNombreProd;
            this.txtNombreProd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNombreProd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNombreProd.HoverState.Parent = this.txtNombreProd;
            this.txtNombreProd.Location = new System.Drawing.Point(157, 30);
            this.txtNombreProd.Name = "txtNombreProd";
            this.txtNombreProd.PasswordChar = '\0';
            this.txtNombreProd.PlaceholderText = "";
            this.txtNombreProd.SelectedText = "";
            this.txtNombreProd.ShadowDecoration.Parent = this.txtNombreProd;
            this.txtNombreProd.Size = new System.Drawing.Size(284, 22);
            this.txtNombreProd.TabIndex = 24;
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
            this.txtCodigoProd.Location = new System.Drawing.Point(17, 29);
            this.txtCodigoProd.Name = "txtCodigoProd";
            this.txtCodigoProd.PasswordChar = '\0';
            this.txtCodigoProd.PlaceholderText = "";
            this.txtCodigoProd.SelectedText = "";
            this.txtCodigoProd.ShadowDecoration.Parent = this.txtCodigoProd;
            this.txtCodigoProd.Size = new System.Drawing.Size(102, 22);
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
        private System.Windows.Forms.Button button3;
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
        private Guna.UI2.WinForms.Guna2TextBox txtPrecioCompra;
        private Guna.UI2.WinForms.Guna2TextBox txtNombreProd;
        private Guna.UI2.WinForms.Guna2TextBox txtCodigoProd;
        private Guna.UI2.WinForms.Guna2TextBox txtRutaImge;
        private System.Windows.Forms.PictureBox picAddColor;
        private System.Windows.Forms.PictureBox picAddMarca;
        private System.Windows.Forms.PictureBox picAgregarImage;
        private System.Windows.Forms.PictureBox picImgen;
        private Guna.UI2.WinForms.Guna2TextBox txtStock;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbTalla;
    }
}