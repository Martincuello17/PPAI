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
    public partial class PantallaFinalizarPreparacionPedido : Form
    {
        public PantallaFinalizarPreparacionPedido()
        {
            InitializeComponent();
            cargarGrilla();
            lblFechaActual.Text = DateTime.Now.ToString("G");
        }
        public GestorFinalizarPreparacionPedido gestor = new GestorFinalizarPreparacionPedido();
        
        public void tomarOpcionFinalizarPedido()
        {
                for (int j = 0; j < dgvPedidosEnPreparacion.Rows.Count; j++)
                {
                    if ((bool)dgvPedidosEnPreparacion.Rows[j].Cells[0].Value && dgvPedidosEnPreparacion.Rows[j].Visible)
                    {
                        dgvPedidosEnPreparacion.Rows[j].Visible = false;
                    }
                } 
        }


        public void cargarGrilla()
        {
            Menu menu = new Menu("Veggi");
            Menu menu1 = new Menu("No Aplica");
            Menu menu2 = new Menu("Sabor a campo");
            Menu menu3 = new Menu("Un toque marino");
            Menu menu4 = new Menu("Veggie");
            Menu menu5 = new Menu("De la abuela");

            Producto producto = new Producto("Sorrentino");
            Producto producto1 = new Producto("Zapallitos rellenos");
            Producto producto2 = new Producto("Matambre de cerdo");
            Producto producto3 = new Producto("Langostinos");
            Producto producto4 = new Producto("Ensalada caesar");
            Producto producto5 = new Producto("Ensalada caprese");
            Producto producto6 = new Producto("Guiso de lentejas");
            Producto producto7 = new Producto("Fideos con tuco");
            Producto producto8 = new Producto("Bondiola de cerdo");
            Producto producto9 = new Producto("Arroz con albondigas");
            Producto producto10 = new Producto("Flan");

            Mesa mesa = new Mesa(5);
            Mesa mesa1 = new Mesa(3);
            Mesa mesa2 = new Mesa(14);
            Mesa mesa3 = new Mesa(7);
            Mesa mesa4 = new Mesa(2);
            Mesa mesa5 = new Mesa(9);
            Mesa mesa6 = new Mesa(10);
            Mesa mesa7 = new Mesa(13);

            Pedido pedido = new Pedido(1, mesa);
            Pedido pedido1 = new Pedido(2, mesa1);
            Pedido pedido2 = new Pedido(3, mesa2);
            Pedido pedido3 = new Pedido(4, mesa3);
            Pedido pedido4 = new Pedido(5, mesa4);
            Pedido pedido5 = new Pedido(6, mesa5);
            Pedido pedido6 = new Pedido(7, mesa6);
            Pedido pedido7 = new Pedido(8, mesa7);
            Pedido pedido8 = new Pedido(9, mesa7);

            DetallePedido detallePedido = new DetallePedido(1,"30:20", menu1, producto, pedido);
            DetallePedido detallePedido1 = new DetallePedido(3, "25:50", menu4, producto1, pedido1);
            DetallePedido detallePedido2 = new DetallePedido(2, "23:30", menu2, producto2, pedido2);
            DetallePedido detallePedido3 = new DetallePedido(3, "20:00", menu3, producto3, pedido3);
            DetallePedido detallePedido4 = new DetallePedido(1, "18:40", menu1, producto4, pedido4);
            DetallePedido detallePedido5 = new DetallePedido(1, "15:10", menu, producto5, pedido5);
            DetallePedido detallePedido6 = new DetallePedido(2, "12:10", menu1, producto6, pedido6);
            DetallePedido detallePedido7 = new DetallePedido(5, "10:10", menu5, producto7, pedido7);
            DetallePedido detallePedido8 = new DetallePedido(7, "05:10", menu1, producto8, pedido8);

            dgvPedidosEnPreparacion.Rows.Add(false, detallePedido.producto.nombre, detallePedido.menu.nombre, detallePedido.cantidad, detallePedido.pedido.mesa.numero, detallePedido.hora);
            dgvPedidosEnPreparacion.Rows.Add(false, detallePedido1.producto.nombre, detallePedido1.menu.nombre, detallePedido1.cantidad, detallePedido1.pedido.mesa.numero, detallePedido1.hora);
            dgvPedidosEnPreparacion.Rows.Add(false, detallePedido2.producto.nombre, detallePedido2.menu.nombre, detallePedido2.cantidad, detallePedido2.pedido.mesa.numero, detallePedido2.hora);
            dgvPedidosEnPreparacion.Rows.Add(false, detallePedido3.producto.nombre, detallePedido3.menu.nombre, detallePedido3.cantidad, detallePedido3.pedido.mesa.numero, detallePedido3.hora);
            dgvPedidosEnPreparacion.Rows.Add(false, detallePedido4.producto.nombre, detallePedido4.menu.nombre, detallePedido4.cantidad, detallePedido4.pedido.mesa.numero, detallePedido4.hora);
            dgvPedidosEnPreparacion.Rows.Add(false, detallePedido5.producto.nombre, detallePedido5.menu.nombre, detallePedido5.cantidad, detallePedido5.pedido.mesa.numero, detallePedido5.hora);
            dgvPedidosEnPreparacion.Rows.Add(false, detallePedido6.producto.nombre, detallePedido6.menu.nombre, detallePedido6.cantidad, detallePedido6.pedido.mesa.numero, detallePedido6.hora);
            dgvPedidosEnPreparacion.Rows.Add(false, detallePedido7.producto.nombre, detallePedido7.menu.nombre, detallePedido7.cantidad, detallePedido7.pedido.mesa.numero, detallePedido7.hora);
            dgvPedidosEnPreparacion.Rows.Add(false, detallePedido8.producto.nombre, detallePedido8.menu.nombre, detallePedido8.cantidad, detallePedido8.pedido.mesa.numero, detallePedido8.hora);
        }
        public static List<DataGridViewRow> rows = new List<DataGridViewRow>();
        private void btnFinalizarPedidos_Click(object sender, EventArgs e)
        {
            DialogResult confirmar = MessageBox.Show("¿Esta seguro que desea finalizar el/los producto/s?", "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmar == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvPedidosEnPreparacion.Rows)
                {
                    if ((bool)row.Cells[0].Value)
                    {
                        gestor.cantidadProducto = int.Parse(row.Cells[4].Value.ToString());
                        gestor.numeroMesa = int.Parse(row.Cells[3].Value.ToString());
                        gestor.confirmarcionElaboracion();
                        rows.Add(row);
                    }
                }
                foreach (DataGridViewRow i in rows)
                {
                    dgvPedidosEnPreparacion.Rows.Remove(i);
                }
                if (rows.Count == 0)
                {
                    MessageBox.Show("Seleccione al menos un pedido para finalizar.");
                }
                else
                {
                    MessageBox.Show("Se notificó con éxito.");
                }
                rows.Clear();
            }
        }

        private void btnFinalizarPreparacion_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel4.Visible = true;
        }

        private void PantallaFinalizarPreparacionPedido_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void dgvPedidosEnPreparacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
