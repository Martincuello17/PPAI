﻿using System;

namespace FinalizarPreparacionPedido
{
    public class Pedido
    {
        public int cantComensales { get; set; }
        public DetallePedido detPedido { get; set; }
        public int factura { get; set; }
        public DateTime fechaHoraPed { get; set; }
        public int historialEstado { get; set; }
        public int nroPedido { get; set; }
        public Mesa mesa { get; set; }

        public Pedido(int nroPedido, Mesa mesa)
        {
            this.nroPedido = nroPedido;
            this.mesa = mesa;
        }
    }
}