using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizarPreparacionPedido
{
    public interface ISujetoDetallePedido
    {
        void suscribir(IObservadorDetallePedido obs);
    }
    public interface IObservadorDetallePedido
    {
        void notificar(string mensaje);
    }
}
