using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalizarPreparacionPedido
{
    public class GestorFinalizarPreparacionPedido : ISujetoDetallePedido
    {
        public int cantidadProducto { get; set; }
        public string[] datosPedidoEnPreparacion { get; set; }
        public string[] datosPedidosNotificados { get; set; }
        public string[] datosPedidoSeleccionadosAServir { get; set; }
        public int numeroMesa { get; set; }
        public List<IObservadorDetallePedido> observadores { get; set; }

        public GestorFinalizarPreparacionPedido()
        {
        }

        public void suscribir(IObservadorDetallePedido obs)
        {
            observadores.Add(obs);
        }

        public void confirmarcionElaboracion()
        {
            publicarDetPedidoAServir((IObservadorDetallePedido)observadores);
        }

        public void publicarDetPedidoAServir(IObservadorDetallePedido observadores)
        {
            suscribir(observadores);
            notificar();
        }

        public void notificar()
        {
            for (int i = 0; i < observadores.Count; i++)
            {
                observadores[i].actualizar(numeroMesa, cantidadProducto);
            }
        }



    }
}
