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
        public void suscribir(ISujetoDetallePedido sujeto)
        {
            sujeto.suscribir(this);
        }
        public void notificar(string numeroMesa, int cantidad)
        {
            dgvPedidosEnPreparacion.Rows.Add(numeroMesa, cantidad);
            Console.Beep();
        }
        public InterfazDispositivoMovil(ISujetoDetallePedido sujeto)
        {
            InitializeComponent();
            suscribir(sujeto);
        }
    }
}
