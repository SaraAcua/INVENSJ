﻿namespace Presentacion
{
    partial class FormProveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEditarProv = new System.Windows.Forms.Button();
            this.BtnRegsitrarProv = new System.Windows.Forms.Button();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtId = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtgvProveedor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnEditarProv);
            this.panel3.Controls.Add(this.BtnRegsitrarProv);
            this.panel3.Location = new System.Drawing.Point(407, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 58);
            this.panel3.TabIndex = 25;
            // 
            // btnEditarProv
            // 
            this.btnEditarProv.BackColor = System.Drawing.Color.Transparent;
            this.btnEditarProv.FlatAppearance.BorderSize = 0;
            this.btnEditarProv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnEditarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarProv.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarProv.ForeColor = System.Drawing.Color.Black;
            this.btnEditarProv.Image = global::Presentacion.Properties.Resources.edit;
            this.btnEditarProv.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEditarProv.Location = new System.Drawing.Point(89, 1);
            this.btnEditarProv.Name = "btnEditarProv";
            this.btnEditarProv.Size = new System.Drawing.Size(71, 54);
            this.btnEditarProv.TabIndex = 9;
            this.btnEditarProv.Text = "Editar";
            this.btnEditarProv.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarProv.UseVisualStyleBackColor = false;
            this.btnEditarProv.Click += new System.EventHandler(this.btnEditarProv_Click);
            // 
            // BtnRegsitrarProv
            // 
            this.BtnRegsitrarProv.BackColor = System.Drawing.Color.Transparent;
            this.BtnRegsitrarProv.FlatAppearance.BorderSize = 0;
            this.BtnRegsitrarProv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtnRegsitrarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegsitrarProv.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegsitrarProv.ForeColor = System.Drawing.Color.Black;
            this.BtnRegsitrarProv.Image = global::Presentacion.Properties.Resources.diskette;
            this.BtnRegsitrarProv.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnRegsitrarProv.Location = new System.Drawing.Point(3, 2);
            this.BtnRegsitrarProv.Name = "BtnRegsitrarProv";
            this.BtnRegsitrarProv.Size = new System.Drawing.Size(80, 54);
            this.BtnRegsitrarProv.TabIndex = 7;
            this.BtnRegsitrarProv.Text = "Registrar";
            this.BtnRegsitrarProv.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnRegsitrarProv.UseVisualStyleBackColor = false;
            this.BtnRegsitrarProv.Click += new System.EventHandler(this.BtnRegsitrarProv_Click);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 15;
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.btnBuscar);
            this.guna2GradientPanel1.Controls.Add(this.txtId);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(119)))), ((int)(((byte)(173)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(59, 74);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(268, 87);
            this.guna2GradientPanel1.TabIndex = 24;
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
            // dtgvProveedor
            // 
            this.dtgvProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProveedor.Location = new System.Drawing.Point(59, 179);
            this.dtgvProveedor.Name = "dtgvProveedor";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtgvProveedor.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvProveedor.Size = new System.Drawing.Size(516, 214);
            this.dtgvProveedor.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(57, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "PROVEEDORES";
            // 
            // FormProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(730, 646);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.dtgvProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProveedores";
            this.Text = "FormProveedores";
            this.panel3.ResumeLayout(false);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEditarProv;
        private System.Windows.Forms.Button BtnRegsitrarProv;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private Guna.UI2.WinForms.Guna2TextBox txtId;
        private System.Windows.Forms.DataGridView dtgvProveedor;
        private System.Windows.Forms.Label label1;
    }
}