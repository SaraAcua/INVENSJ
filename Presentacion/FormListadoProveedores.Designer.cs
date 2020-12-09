namespace Presentacion
{
    partial class FormListadoProveedores
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
            this.btnImprimir = new System.Windows.Forms.Button();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarBarrio = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnBuscarId = new System.Windows.Forms.Button();
            this.dtgvProveedor = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Transparent;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnImprimir.ForeColor = System.Drawing.Color.Black;
            this.btnImprimir.Location = new System.Drawing.Point(397, 442);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(91, 41);
            this.btnImprimir.TabIndex = 41;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 15;
            this.guna2GradientPanel1.Controls.Add(this.label3);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.btnBuscarBarrio);
            this.guna2GradientPanel1.Controls.Add(this.textBox2);
            this.guna2GradientPanel1.Controls.Add(this.txtId);
            this.guna2GradientPanel1.Controls.Add(this.btnBuscarId);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(66)))), ((int)(((byte)(97)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(119)))), ((int)(((byte)(173)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(44, 110);
            this.guna2GradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(444, 98);
            this.guna2GradientPanel1.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(220, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Barrio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Identificaciòn";
            // 
            // btnBuscarBarrio
            // 
            this.btnBuscarBarrio.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarBarrio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarBarrio.FlatAppearance.BorderSize = 0;
            this.btnBuscarBarrio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBuscarBarrio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(119)))), ((int)(((byte)(173)))));
            this.btnBuscarBarrio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarBarrio.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarBarrio.ForeColor = System.Drawing.Color.White;
            this.btnBuscarBarrio.Image = global::Presentacion.Properties.Resources.buscar;
            this.btnBuscarBarrio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarBarrio.Location = new System.Drawing.Point(329, 32);
            this.btnBuscarBarrio.Name = "btnBuscarBarrio";
            this.btnBuscarBarrio.Size = new System.Drawing.Size(83, 30);
            this.btnBuscarBarrio.TabIndex = 31;
            this.btnBuscarBarrio.Text = "     Buscar";
            this.btnBuscarBarrio.UseVisualStyleBackColor = false;
            this.btnBuscarBarrio.Click += new System.EventHandler(this.btnBuscarBarrio_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(223, 37);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 30;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(36, 37);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 29;
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // btnBuscarId
            // 
            this.btnBuscarId.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscarId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarId.FlatAppearance.BorderSize = 0;
            this.btnBuscarId.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBuscarId.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(119)))), ((int)(((byte)(173)))));
            this.btnBuscarId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarId.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarId.ForeColor = System.Drawing.Color.White;
            this.btnBuscarId.Image = global::Presentacion.Properties.Resources.buscar;
            this.btnBuscarId.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarId.Location = new System.Drawing.Point(142, 32);
            this.btnBuscarId.Name = "btnBuscarId";
            this.btnBuscarId.Size = new System.Drawing.Size(83, 30);
            this.btnBuscarId.TabIndex = 28;
            this.btnBuscarId.Text = "     Buscar";
            this.btnBuscarId.UseVisualStyleBackColor = false;
            this.btnBuscarId.Click += new System.EventHandler(this.btnBuscarId_Click);
            // 
            // dtgvProveedor
            // 
            this.dtgvProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProveedor.Location = new System.Drawing.Point(44, 229);
            this.dtgvProveedor.Name = "dtgvProveedor";
            this.dtgvProveedor.Size = new System.Drawing.Size(444, 207);
            this.dtgvProveedor.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(40, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "LISTADO PROVEEDORES";
            // 
            // FormListadoProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(730, 646);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.dtgvProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListadoProveedores";
            this.Text = "FormListadoProveedorescs";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImprimir;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.DataGridView dtgvProveedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarBarrio;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnBuscarId;
    }
}