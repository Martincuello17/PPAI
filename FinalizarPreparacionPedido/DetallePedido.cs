using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizarPreparacionPedido
{
    public class DetallePedido
    {
        //cantidad, precio, producto
        public delegate void cantidadDelegate();
        public event cantidadDelegate eleccionCantidad;
        public object elegirCambioCantidad
        {
            set { eleccionCantidad(); }
        }
    }
}
