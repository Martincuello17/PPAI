using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizarPreparacionPedido
{
    public interface IObservadorDetallePedido
    {
        void actualizar(int numeroMesa, int cantidadProducto);
    }
}
