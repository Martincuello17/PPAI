using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizarPreparacionPedido
{
    public class DetallePedido
    {
        public int cantidad { get; set; }
        public int detFactura { get; set; }
        public int historialEstado { get; set; }
        public string hora { get; set; }
        public Menu menu { get; set; }
        public float precio { get; set; }
        public Producto producto { get; set; }
        public Pedido pedido { get; set; }

        public DetallePedido(int cantidad, string hora, Menu menu, Producto producto, Pedido pedido)
        {
            this.cantidad = cantidad;
            this.hora = hora;
            this.menu = menu;
            this.producto = producto;
            this.pedido = pedido;
        }
    }
}
