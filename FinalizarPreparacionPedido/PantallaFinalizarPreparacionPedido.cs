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
    public partial class PantallaFinalizarPreparacionPedido : Form, ISujetoDetallePedido
    {
        public PantallaFinalizarPreparacionPedido()
        {
            InitializeComponent();
            cargarGrilla();
            InterfazDispositivoMovil interfazMozo = new InterfazDispositivoMovil(this);
            interfazMozo.Show();
            InterfazMonitor interfazMonitor = new InterfazMonitor(this);
            interfazMonitor.Show();
        }
        public List<IObservadorDetallePedido> observador = new List<IObservadorDetallePedido>();

        public void suscribir(IObservadorDetallePedido obs)
        {
            observador.Add(obs);
        }
        
        public void seleccionar()
        {

            for (int i = 0; i < observador.Count; i++)
            {
                IObservadorDetallePedido obs = (IObservadorDetallePedido)observador[i];
                for (int j = 0; j < dgvPedidosEnPreparacion.Rows.Count; j++)
                {
                    if ((bool)dgvPedidosEnPreparacion.Rows[j].Cells[0].Value && dgvPedidosEnPreparacion.Rows[j].Visible)
                    {
                        obs.notificar(dgvPedidosEnPreparacion.Rows[j].Cells[4].Value.ToString(), int.Parse(dgvPedidosEnPreparacion.Rows[j].Cells[3].Value.ToString()));
                        dgvPedidosEnPreparacion.Rows[j].Visible = false;
                    }
                } 
            }
        }


        public void cargarGrilla()
        {
            dgvPedidosEnPreparacion.Rows.Add(false,"Sorrentino","No Aplica",1, 5 + "-" + 6);
            dgvPedidosEnPreparacion.Rows.Add(false, "Zapallitos", "Veggie", 3, "3");
            dgvPedidosEnPreparacion.Rows.Add(false, "Matambre", "Sabor a campo", 2, 4);
            dgvPedidosEnPreparacion.Rows.Add(false, "Langostinos", "Un toque marino", 5, 7 + "-" + 8);
            dgvPedidosEnPreparacion.Rows.Add(false, "Bondiola", "De la abuela", 7, "10");
            dgvPedidosEnPreparacion.Rows.Add(false, "Flan", "No Aplica", 5, "11");
        }

        private void btnFinalizarPedidos_Click(object sender, EventArgs e)
        {
            seleccionar();
        }

        private void btnFinalizarPreparacion_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = true;
        }
    }
}
