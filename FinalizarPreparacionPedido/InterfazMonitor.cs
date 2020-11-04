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
        public int cantidadProductos { get; set; }
        public int numeroMesa { get; set; }

        public InterfazMonitor()
        {
            InitializeComponent();
            lblFechaActual.Text = DateTime.Now.ToString("G");
        }

        private void InterfazMonitor_Load(object sender, EventArgs e)
        {

        }

        public void actualizar(int numeroMesa, int cantidadProducto)
        {
            this.cantidadProductos = cantidadProducto;
            this.numeroMesa = numeroMesa;
            dgvPedidosEnPreparacion.Rows.Add(numeroMesa, cantidadProducto);
        }
    }
}
