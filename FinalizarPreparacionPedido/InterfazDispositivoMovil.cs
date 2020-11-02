﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalizarPreparacionPedido
{
    public partial class InterfazDispositivoMovil : Form, IObservadorDetallePedido
    {
        public int cantidadProductos { get; set; }
        public int numeroMesa { get; set; }
        public void suscribir(ISujetoDetallePedido sujeto)
        {
            sujeto.suscribir(this);
        }

        public void actualizar(int numeroMesa, int cantidadProducto)
        {
            this.cantidadProductos = cantidadProducto;
            this.numeroMesa = numeroMesa;
            dgvPedidosEnPreparacion.Rows.Add(numeroMesa, cantidadProducto);
            Console.Beep();
        }

        public InterfazDispositivoMovil(ISujetoDetallePedido sujeto)
        {
            InitializeComponent();
            suscribir(sujeto);

        }
    }
}
