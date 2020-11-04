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
    public partial class InterfazDispositivoMovil : Form, IObservadorDetallePedido
    {
        public int cantidadProductos { get; set; }
        public int numeroMesa { get; set; }

        public void actualizar(int numeroMesa, int cantidadProducto)
        {
            dgvPedidosEnPreparacion.Visible = false;
            pNotificacion.Visible = false;
            this.cantidadProductos = cantidadProducto;
            this.numeroMesa = numeroMesa;
            dgvPedidosEnPreparacion.Rows.Add(numeroMesa, cantidadProducto);
            lblPedidosListos.Text = "¡Tienes nuevos pedidos listos para servir en la mesa " + numeroMesa.ToString() + "!";
            iCampana.Visible = true;
            Console.Beep();
        }

        public InterfazDispositivoMovil()
        {
            InitializeComponent();
            lblFechaActual.Text = DateTime.Now.ToString("G");
            dgvPedidosEnPreparacion.Visible = false;

        }

        private void iCampana_Click(object sender, EventArgs e)
        {
            pNotificacion.Visible = true;
            dgvPedidosEnPreparacion.Visible = true;
        }

        private void pNotificacion_MouseClick(object sender, MouseEventArgs e)
        {
            dgvPedidosEnPreparacion.Visible = true;
        }
    }
}
