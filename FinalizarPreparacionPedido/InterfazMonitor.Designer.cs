namespace FinalizarPreparacionPedido
{
    partial class InterfazMonitor
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFinalizarPreparacionPedido = new System.Windows.Forms.Label();
            this.dgvPedidosEnPreparacion = new System.Windows.Forms.DataGridView();
            this.NumeroMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosEnPreparacion)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(200)))), ((int)(((byte)(4)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 59);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalizarPreparacionPedido.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(22, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblFinalizarPreparacionPedido
            // 
            this.lblFinalizarPreparacionPedido.AutoSize = true;
            this.lblFinalizarPreparacionPedido.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalizarPreparacionPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalizarPreparacionPedido.ForeColor = System.Drawing.Color.White;
            this.lblFinalizarPreparacionPedido.Location = new System.Drawing.Point(303, 0);
            this.lblFinalizarPreparacionPedido.Name = "lblFinalizarPreparacionPedido";
            this.lblFinalizarPreparacionPedido.Size = new System.Drawing.Size(211, 22);
            this.lblFinalizarPreparacionPedido.TabIndex = 0;
            this.lblFinalizarPreparacionPedido.Text = "Pedidos listos para servir";
            // 
            // dgvPedidosEnPreparacion
            // 
            this.dgvPedidosEnPreparacion.AllowUserToAddRows = false;
            this.dgvPedidosEnPreparacion.AllowUserToDeleteRows = false;
            this.dgvPedidosEnPreparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidosEnPreparacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroMesa,
            this.Cantidad});
            this.dgvPedidosEnPreparacion.Location = new System.Drawing.Point(65, 93);
            this.dgvPedidosEnPreparacion.Name = "dgvPedidosEnPreparacion";
            this.dgvPedidosEnPreparacion.ReadOnly = true;
            this.dgvPedidosEnPreparacion.Size = new System.Drawing.Size(655, 296);
            this.dgvPedidosEnPreparacion.TabIndex = 9;
            // 
            // NumeroMesa
            // 
            this.NumeroMesa.HeaderText = "Número de mesa";
            this.NumeroMesa.Name = "NumeroMesa";
            this.NumeroMesa.ReadOnly = true;
            this.NumeroMesa.Width = 300;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 300;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.panel3.Controls.Add(this.lblFinalizarPreparacionPedido);
            this.panel3.Location = new System.Drawing.Point(2, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(817, 26);
            this.panel3.TabIndex = 8;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FinalizarPreparacionPedido.Properties.Resources.logo2;
            this.pictureBox2.Location = new System.Drawing.Point(387, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(658, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha: 13/10/2020 Hora: 16:32";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(1, 395);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(818, 78);
            this.panel5.TabIndex = 10;
            // 
            // InterfazMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 474);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvPedidosEnPreparacion);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Name = "InterfazMonitor";
            this.Text = "InterfazMonitor";
            this.Load += new System.EventHandler(this.InterfazMonitor_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosEnPreparacion)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFinalizarPreparacionPedido;
        private System.Windows.Forms.DataGridView dgvPedidosEnPreparacion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}