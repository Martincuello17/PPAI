using System;
using System.Data;

namespace FinalizarPreparacionPedido
{
    public class Producto
    {
        public int cantComensales { get; set; }
        public DateTime fechaHoraPed { get; set; }
        public int nroPedido { get; set; }
    }
}