namespace Presentacion
{
    partial class FormClientes
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
            this.dtgcliente = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.BtnRegsitrarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgcliente)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgcliente
            // 
            this.dtgcliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgcliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgcliente.Location = new System.Drawing.Point(62, 183);
            this.dtgcliente.Name = "dtgcliente";
            this.dtgcliente.Size = new System.Drawing.Size(612, 217);
            this.dtgcliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(65, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "CLIENTES";
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 15;
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.btnBuscar);
            this.guna2GradientPanel1.Controls.Add(this.txtId);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(119)))), ((int)(((byte)(173)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(62, 78);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(268, 87);
            this.guna2GradientPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Identificacion";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(119)))), ((int)(((byte)(173)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = global::Presentacion.Properties.Resources.buscar;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(139, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 30);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "     Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtId
            // 
            this.txtId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId.DefaultText = "";
            this.txtId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.DisabledState.Parent = this.txtId;
            this.txtId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.FocusedState.Parent = this.txtId;
            this.txtId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtId.HoverState.Parent = this.txtId;
            this.txtId.Location = new System.Drawing.Point(40, 39);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.PlaceholderText = "";
            this.txtId.SelectedText = "";
            this.txtId.ShadowDecoration.Parent = this.txtId;
            this.txtId.Size = new System.Drawing.Size(92, 20);
            this.txtId.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEditarCliente);
            this.panel3.Controls.Add(this.BtnRegsitrarCliente);
            this.panel3.Location = new System.Drawing.Point(410, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 58);
            this.panel3.TabIndex = 22;
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarCliente.FlatAppearance.BorderSize = 0;
            this.btnEditarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEditarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarCliente.ForeColor = System.Drawing.Color.Black;
            this.btnEditarCliente.Image = global::Presentacion.Properties.Resources.edit;
            this.btnEditarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditarCliente.Location = new System.Drawing.Point(89, 1);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(71, 54);
            this.btnEditarCliente.TabIndex = 9;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarCliente.UseVisualStyleBackColor = false;
            this.btnEditarCliente.Click += new System.EventHandler(this.btnEditarCliente_Click);
            // 
            // BtnRegsitrarCliente
            // 
            this.BtnRegsitrarCliente.BackColor = System.Drawing.Color.Transparent;
            this.BtnRegsitrarCliente.FlatAppearance.BorderSize = 0;
            this.BtnRegsitrarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnRegsitrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegsitrarCliente.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegsitrarCliente.ForeColor = System.Drawing.Color.Black;
            this.BtnRegsitrarCliente.Image = global::Presentacion.Properties.Resources.diskette;
            this.BtnRegsitrarCliente.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRegsitrarCliente.Location = new System.Drawing.Point(3, 2);
            this.BtnRegsitrarCliente.Name = "BtnRegsitrarCliente";
            this.BtnRegsitrarCliente.Size = new System.Drawing.Size(80, 54);
            this.BtnRegsitrarCliente.TabIndex = 7;
            this.BtnRegsitrarCliente.Text = "Registrar";
            this.BtnRegsitrarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRegsitrarCliente.UseVisualStyleBackColor = false;
            this.BtnRegsitrarCliente.Click += new System.EventHandler(this.BtnRegsitrarCliente_Click);
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(730, 646);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.dtgcliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClientes";
            this.Text = "FormClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dtgcliente)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgcliente;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private Guna.UI2.WinForms.Guna2TextBox txtId;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button BtnRegsitrarCliente;
    }
}