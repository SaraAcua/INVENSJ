namespace Presentacion
{
    partial class FormInicio
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
            this.components = new System.ComponentModel.Container();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.timerFechaHora = new System.Windows.Forms.Timer(this.components);
            this.btnConexion = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Russo One", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.Location = new System.Drawing.Point(49, 372);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(0, 64);
            this.labelHora.TabIndex = 1;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(119)))), ((int)(((byte)(173)))));
            this.labelFecha.Location = new System.Drawing.Point(53, 420);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(0, 31);
            this.labelFecha.TabIndex = 2;
            // 
            // timerFechaHora
            // 
            this.timerFechaHora.Enabled = true;
            this.timerFechaHora.Tick += new System.EventHandler(this.timerFechaHora_Tick);
            // 
            // btnConexion
            // 
            this.btnConexion.CheckedState.Parent = this.btnConexion;
            this.btnConexion.CustomImages.Parent = this.btnConexion;
            this.btnConexion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConexion.ForeColor = System.Drawing.Color.White;
            this.btnConexion.HoverState.Parent = this.btnConexion;
            this.btnConexion.Location = new System.Drawing.Point(269, 157);
            this.btnConexion.Name = "btnConexion";
            this.btnConexion.ShadowDecoration.Parent = this.btnConexion;
            this.btnConexion.Size = new System.Drawing.Size(180, 45);
            this.btnConexion.TabIndex = 3;
            this.btnConexion.Text = "PROBAR CONEXION";
            this.btnConexion.Click += new System.EventHandler(this.btnConexion_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(730, 606);
            this.Controls.Add(this.btnConexion);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.labelHora);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInicio";
            this.Text = "FormInicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Timer timerFechaHora;
        private Guna.UI2.WinForms.Guna2Button btnConexion;
    }
}