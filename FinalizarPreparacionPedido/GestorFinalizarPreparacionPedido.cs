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
        //public List<IObservadorDetallePedido> observadores { get; set; }
        public List<IObservadorDetallePedido> observadores = new List<IObservadorDetallePedido>();

        public GestorFinalizarPreparacionPedido()
        {
            InterfazDispositivoMovil interfazDispositivoMovil = new InterfazDispositivoMovil(this);
            interfazDispositivoMovil.Show();
            InterfazMonitor interfazMonitor = new InterfazMonitor(this);
            interfazMonitor.Show();
        }

        public void suscribir(IObservadorDetallePedido obs)
        {
            observadores.Add(obs);
        }

        public void confirmarcionElaboracion()
        {
            publicarDetPedidoAServir();
        }

        public void publicarDetPedidoAServir()
        {
            notificar();    
        }

        public void notificar()
        {
            for (int i = 0; i < observadores.Count; i++)
            {
                IObservadorDetallePedido obs = (IObservadorDetallePedido)observadores[i];
                obs.actualizar(numeroMesa, cantidadProducto);
            }
        }



    }
}
