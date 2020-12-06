
namespace Presentacion
{
    partial class FormMovimientos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMovimientos));
            this.cmboMotivo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LbelFecha = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGuardarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProd = new System.Windows.Forms.Button();
            this.dtgvMovimientos = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmboConsulta = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMovimientos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmboMotivo
            // 
            this.cmboMotivo.FormattingEnabled = true;
            this.cmboMotivo.Location = new System.Drawing.Point(35, 86);
            this.cmboMotivo.Name = "cmboMotivo";
            this.cmboMotivo.Size = new System.Drawing.Size(97, 21);
            this.cmboMotivo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(42, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Motivo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(140, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cod. producto";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(138, 87);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(107, 20);
            this.txtCodigo.TabIndex = 4;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(251, 87);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(67, 20);
            this.txtCantidad.TabIndex = 39;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(248, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(339, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Fecha";
            // 
            // LbelFecha
            // 
            this.LbelFecha.AutoSize = true;
            this.LbelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbelFecha.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbelFecha.Location = new System.Drawing.Point(344, 88);
            this.LbelFecha.Name = "LbelFecha";
            this.LbelFecha.Size = new System.Drawing.Size(59, 16);
            this.LbelFecha.TabIndex = 43;
            this.LbelFecha.Text = "/    /     /";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(35, 135);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(283, 41);
            this.txtObservacion.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(35, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Observaciòn";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Controls.Add(this.btnGuardarProducto);
            this.panel3.Controls.Add(this.btnEliminarProd);
            this.panel3.Location = new System.Drawing.Point(37, 187);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 58);
            this.panel3.TabIndex = 47;
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
            // 
            // dtgvMovimientos
            // 
            this.dtgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvMovimientos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvMovimientos.Location = new System.Drawing.Point(38, 317);
            this.dtgvMovimientos.Name = "dtgvMovimientos";
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dtgvMovimientos.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvMovimientos.Size = new System.Drawing.Size(460, 127);
            this.dtgvMovimientos.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(31, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 20);
            this.label7.TabIndex = 51;
            this.label7.Text = "REGISTRO DE SALIDA";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConsulta);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmboConsulta);
            this.panel1.Location = new System.Drawing.Point(39, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 52);
            this.panel1.TabIndex = 52;
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.Transparent;
            this.btnConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnConsulta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(119)))), ((int)(((byte)(173)))));
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConsulta.Image = global::Presentacion.Properties.Resources.buscar;
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.Location = new System.Drawing.Point(122, 18);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(83, 30);
            this.btnConsulta.TabIndex = 55;
            this.btnConsulta.Text = "     Buscar";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(4, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 54;
            this.label6.Text = "Motivo";
            // 
            // cmboConsulta
            // 
            this.cmboConsulta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmboConsulta.FormattingEnabled = true;
            this.cmboConsulta.Location = new System.Drawing.Point(7, 23);
            this.cmboConsulta.Name = "cmboConsulta";
            this.cmboConsulta.Size = new System.Drawing.Size(97, 21);
            this.cmboConsulta.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(372, 458);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 53;
            this.label8.Text = "Total";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(423, 459);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(13, 13);
            this.LblTotal.TabIndex = 54;
            this.LblTotal.Text = "--";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancelar.Location = new System.Drawing.Point(176, 1);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 54);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // FormMovimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(741, 523);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtgvMovimientos);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LbelFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmboMotivo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMovimientos";
            this.Text = "FormMovimientos";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMovimientos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboMotivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LbelFecha;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnGuardarProducto;
        private System.Windows.Forms.Button btnEliminarProd;
        private System.Windows.Forms.DataGridView dtgvMovimientos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmboConsulta;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button btnCancelar;
    }
}