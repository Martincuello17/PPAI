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
        public DateTime hora { get; set; }
        public Menu menu { get; set; }
        public float precio { get; set; }
        public Producto producto { get; set; }
        public Pedido pedido { get; set; }
        //cantidad, precio, producto
        public delegate void cantidadDelegate();

        public event cantidadDelegate eleccionCantidad;
        public object elegirCambioCantidad
        {
            set { eleccionCantidad(); }
        }
    }
}
