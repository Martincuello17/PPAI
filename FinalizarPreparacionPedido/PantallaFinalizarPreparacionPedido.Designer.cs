namespace FinalizarPreparacionPedido
{
    partial class PantallaFinalizarPreparacionPedido
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnIniciarPreparacion = new System.Windows.Forms.Button();
            this.btnFinalizarPreparacion = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnRegistrarRecetas = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblFinalizarPreparacionPedido = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFinalizarPedidos = new System.Windows.Forms.Button();
            this.dgvPedidosEnPreparacion = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSeleccionepedidos = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblFechaActual = new System.Windows.Forms.Label();
            this.Listo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMenu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroMesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TiempoEspera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosEnPreparacion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(200)))), ((int)(((byte)(4)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 59);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalizarPreparacionPedido.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(13, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 49);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.btnIniciarPreparacion);
            this.panel2.Controls.Add(this.btnFinalizarPreparacion);
            this.panel2.Controls.Add(this.btnPedidos);
            this.panel2.Controls.Add(this.btnInformes);
            this.panel2.Controls.Add(this.btnRegistrarRecetas);
            this.panel2.Controls.Add(this.btnFacturar);
            this.panel2.Location = new System.Drawing.Point(-1, 57);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 482);
            this.panel2.TabIndex = 1;
            // 
            // btnIniciarPreparacion
            // 
            this.btnIniciarPreparacion.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnIniciarPreparacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarPreparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPreparacion.Location = new System.Drawing.Point(0, 231);
            this.btnIniciarPreparacion.Name = "btnIniciarPreparacion";
            this.btnIniciarPreparacion.Size = new System.Drawing.Size(206, 39);
            this.btnIniciarPreparacion.TabIndex = 5;
            this.btnIniciarPreparacion.Text = "Iniciar preparacion";
            this.btnIniciarPreparacion.UseVisualStyleBackColor = false;
            // 
            // btnFinalizarPreparacion
            // 
            this.btnFinalizarPreparacion.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnFinalizarPreparacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarPreparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarPreparacion.Location = new System.Drawing.Point(0, 194);
            this.btnFinalizarPreparacion.Name = "btnFinalizarPreparacion";
            this.btnFinalizarPreparacion.Size = new System.Drawing.Size(206, 39);
            this.btnFinalizarPreparacion.TabIndex = 4;
            this.btnFinalizarPreparacion.Text = "Finalizar preparacion";
            this.btnFinalizarPreparacion.UseVisualStyleBackColor = false;
            this.btnFinalizarPreparacion.Click += new System.EventHandler(this.btnFinalizarPreparacion_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.Location = new System.Drawing.Point(0, 156);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(206, 39);
            this.btnPedidos.TabIndex = 3;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = false;
            // 
            // btnInformes
            // 
            this.btnInformes.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformes.Location = new System.Drawing.Point(0, 105);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(206, 39);
            this.btnInformes.TabIndex = 2;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = false;
            // 
            // btnRegistrarRecetas
            // 
            this.btnRegistrarRecetas.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnRegistrarRecetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarRecetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarRecetas.Location = new System.Drawing.Point(0, 53);
            this.btnRegistrarRecetas.Name = "btnRegistrarRecetas";
            this.btnRegistrarRecetas.Size = new System.Drawing.Size(206, 39);
            this.btnRegistrarRecetas.TabIndex = 1;
            this.btnRegistrarRecetas.Text = "Registrar recetas";
            this.btnRegistrarRecetas.UseVisualStyleBackColor = false;
            // 
            // btnFacturar
            // 
            this.btnFacturar.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnFacturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFacturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturar.Location = new System.Drawing.Point(0, 0);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(206, 39);
            this.btnFacturar.TabIndex = 0;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.panel3.Controls.Add(this.lblFinalizarPreparacionPedido);
            this.panel3.Location = new System.Drawing.Point(227, 85);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(668, 37);
            this.panel3.TabIndex = 2;
            this.panel3.Visible = false;
            // 
            // lblFinalizarPreparacionPedido
            // 
            this.lblFinalizarPreparacionPedido.AutoSize = true;
            this.lblFinalizarPreparacionPedido.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalizarPreparacionPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalizarPreparacionPedido.ForeColor = System.Drawing.Color.White;
            this.lblFinalizarPreparacionPedido.Location = new System.Drawing.Point(194, 7);
            this.lblFinalizarPreparacionPedido.Name = "lblFinalizarPreparacionPedido";
            this.lblFinalizarPreparacionPedido.Size = new System.Drawing.Size(289, 25);
            this.lblFinalizarPreparacionPedido.TabIndex = 0;
            this.lblFinalizarPreparacionPedido.Text = "Finalizar Preparacion Pedido";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCancelar);
            this.panel4.Controls.Add(this.btnFinalizarPedidos);
            this.panel4.Controls.Add(this.dgvPedidosEnPreparacion);
            this.panel4.Controls.Add(this.groupBox1);
            this.panel4.Location = new System.Drawing.Point(227, 120);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(668, 406);
            this.panel4.TabIndex = 3;
            this.panel4.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(502, 358);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(141, 37);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnFinalizarPedidos
            // 
            this.btnFinalizarPedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarPedidos.Location = new System.Drawing.Point(325, 358);
            this.btnFinalizarPedidos.Name = "btnFinalizarPedidos";
            this.btnFinalizarPedidos.Size = new System.Drawing.Size(141, 37);
            this.btnFinalizarPedidos.TabIndex = 3;
            this.btnFinalizarPedidos.Text = "Finalizar Pedidos";
            this.btnFinalizarPedidos.UseVisualStyleBackColor = true;
            this.btnFinalizarPedidos.Click += new System.EventHandler(this.btnFinalizarPedidos_Click);
            // 
            // dgvPedidosEnPreparacion
            // 
            this.dgvPedidosEnPreparacion.AllowUserToAddRows = false;
            this.dgvPedidosEnPreparacion.AllowUserToDeleteRows = false;
            this.dgvPedidosEnPreparacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidosEnPreparacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Listo,
            this.NombreProducto,
            this.NombreMenu,
            this.Cantidad,
            this.NumeroMesa,
            this.TiempoEspera});
            this.dgvPedidosEnPreparacion.Location = new System.Drawing.Point(16, 65);
            this.dgvPedidosEnPreparacion.Name = "dgvPedidosEnPreparacion";
            this.dgvPedidosEnPreparacion.Size = new System.Drawing.Size(652, 271);
            this.dgvPedidosEnPreparacion.TabIndex = 1;
            this.dgvPedidosEnPreparacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPedidosEnPreparacion_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSeleccionepedidos);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pedidos \"En Preparación\":";
            // 
            // lblSeleccionepedidos
            // 
            this.lblSeleccionepedidos.AutoSize = true;
            this.lblSeleccionepedidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionepedidos.Location = new System.Drawing.Point(7, 20);
            this.lblSeleccionepedidos.Name = "lblSeleccionepedidos";
            this.lblSeleccionepedidos.Size = new System.Drawing.Size(263, 17);
            this.lblSeleccionepedidos.TabIndex = 0;
            this.lblSeleccionepedidos.Text = "Seleccione los pedidos finalizados:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.lblFechaActual);
            this.panel5.Location = new System.Drawing.Point(-1, 539);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(919, 78);
            this.panel5.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(742, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fecha: Hora:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FinalizarPreparacionPedido.Properties.Resources.logo2;
            this.pictureBox2.Location = new System.Drawing.Point(440, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(49, 49);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // lblFechaActual
            // 
            this.lblFechaActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaActual.ForeColor = System.Drawing.Color.Yellow;
            this.lblFechaActual.Location = new System.Drawing.Point(800, 34);
            this.lblFechaActual.Name = "lblFechaActual";
            this.lblFechaActual.Size = new System.Drawing.Size(104, 31);
            this.lblFechaActual.TabIndex = 0;
            this.lblFechaActual.Text = "13/10/2020 16:32";
            this.lblFechaActual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Listo
            // 
            this.Listo.HeaderText = "Listo";
            this.Listo.Name = "Listo";
            this.Listo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Listo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Listo.Width = 35;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre del producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            this.NombreProducto.Width = 150;
            // 
            // NombreMenu
            // 
            this.NombreMenu.HeaderText = "Nombre del menú";
            this.NombreMenu.Name = "NombreMenu";
            this.NombreMenu.ReadOnly = true;
            this.NombreMenu.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 60;
            // 
            // NumeroMesa
            // 
            this.NumeroMesa.HeaderText = "Número de mesa";
            this.NumeroMesa.Name = "NumeroMesa";
            this.NumeroMesa.ReadOnly = true;
            this.NumeroMesa.Width = 110;
            // 
            // TiempoEspera
            // 
            this.TiempoEspera.HeaderText = "Tiempo espera";
            this.TiempoEspera.Name = "TiempoEspera";
            this.TiempoEspera.ReadOnly = true;
            // 
            // PantallaFinalizarPreparacionPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(918, 616);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PantallaFinalizarPreparacionPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finalizar Preparacion";
            this.Load += new System.EventHandler(this.PantallaFinalizarPreparacionPedido_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidosEnPreparacion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSeleccionepedidos;
        private System.Windows.Forms.DataGridView dgvPedidosEnPreparacion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFinalizarPedidos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblFechaActual;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Button btnRegistrarRecetas;
        private System.Windows.Forms.Button btnFinalizarPreparacion;
        private System.Windows.Forms.Button btnIniciarPreparacion;
        private System.Windows.Forms.Label lblFinalizarPreparacionPedido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Listo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroMesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TiempoEspera;
    }
}

