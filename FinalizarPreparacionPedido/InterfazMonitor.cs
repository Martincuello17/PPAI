using System;
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
    public partial class InterfazMonitor : Form, IObservadorDetallePedido
    {
        public void suscribir(ISujetoDetallePedido sujeto)
        {
            sujeto.suscribir(this);
        }
        public void notificar(string numeroMesa, int cantidad)
        {
            dgvPedidosEnPreparacion.Rows.Add(numeroMesa, cantidad);
        }
        public InterfazMonitor(ISujetoDetallePedido sujeto)
        {
            InitializeComponent();
            suscribir(sujeto);
        }

        private void InterfazMonitor_Load(object sender, EventArgs e)
        {

        }
    }
}
