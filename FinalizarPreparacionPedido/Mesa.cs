namespace FinalizarPreparacionPedido
{
    public class Mesa
    {
        public int numero { get; set; }
        public int capacidadComensales { get; set; }
        public int espacioQueOcupa { get; set; }
        public int estado { get; set; }
        public int filaEnPlano { get; set; }
        public int forma { get; set; }
        public int ordenEnPlano { get; set; }
        public Pedido pedido { get; set; }
    }
}