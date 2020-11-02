namespace FinalizarPreparacionPedido
{
    partial class InterfazDispositivoMovil
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblFinalizarPreparacionPedido = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvPedidosEnPreparacion = new System.Windows.Forms.DataGridView();
            this.NumeroMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosEnPreparacion)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.panel3.Controls.Add(this.lblFinalizarPreparacionPedido);
            this.panel3.Location = new System.Drawing.Point(1, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(503, 26);
            this.panel3.TabIndex = 4;
            // 
            // lblFinalizarPreparacionPedido
            // 
            this.lblFinalizarPreparacionPedido.AutoSize = true;
            this.lblFinalizarPreparacionPedido.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalizarPreparacionPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalizarPreparacionPedido.ForeColor = System.Drawing.Color.White;
            this.lblFinalizarPreparacionPedido.Location = new System.Drawing.Point(139, 1);
            this.lblFinalizarPreparacionPedido.Name = "lblFinalizarPreparacionPedido";
            this.lblFinalizarPreparacionPedido.Size = new System.Drawing.Size(211, 22);
            this.lblFinalizarPreparacionPedido.TabIndex = 0;
            this.lblFinalizarPreparacionPedido.Text = "Pedidos listos para servir";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(200)))), ((int)(((byte)(4)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 59);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalizarPreparacionPedido.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(35, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvPedidosEnPreparacion
            // 
            this.dgvPedidosEnPreparacion.AllowUserToAddRows = false;
            this.dgvPedidosEnPreparacion.AllowUserToDeleteRows = false;
            this.dgvPedidosEnPreparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidosEnPreparacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroMesa,
            this.Cantidad});
            this.dgvPedidosEnPreparacion.Location = new System.Drawing.Point(26, 98);
            this.dgvPedidosEnPreparacion.Name = "dgvPedidosEnPreparacion";
            this.dgvPedidosEnPreparacion.ReadOnly = true;
            this.dgvPedidosEnPreparacion.Size = new System.Drawing.Size(442, 296);
            this.dgvPedidosEnPreparacion.TabIndex = 5;
            // 
            // NumeroMesa
            // 
            this.NumeroMesa.HeaderText = "Número de mesa";
            this.NumeroMesa.Name = "NumeroMesa";
            this.NumeroMesa.ReadOnly = true;
            this.NumeroMesa.Width = 190;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 200;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.lblFechaActual);
            this.panel5.Location = new System.Drawing.Point(1, 420);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(503, 78);
            this.panel5.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FinalizarPreparacionPedido.Properties.Resources.logo2;
            this.pictureBox2.Location = new System.Drawing.Point(227, 15);
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
            this.label1.Location = new System.Drawing.Point(374, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fecha: 13/10/2020 Hora: 16:32";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaActual.ForeColor = System.Drawing.Color.Yellow;
            this.lblFechaActual.Location = new System.Drawing.Point(775, 24);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(118, 31);
            this.lblFechaActual.TabIndex = 0;
            this.lblFechaActual.Text = "Fecha: 13/10/2020 Hora: 16:32";
            this.lblFechaActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // InterfazDispositivoMovil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 499);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dgvPedidosEnPreparacion);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "InterfazDispositivoMovil";
            this.Text = "InterfazDispositivoMovil";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosEnPreparacion)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblFinalizarPreparacionPedido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPedidosEnPreparacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}