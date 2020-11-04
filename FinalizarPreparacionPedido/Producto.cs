using System;
using System.Data;

namespace FinalizarPreparacionPedido
{
    public class Producto
    {
        public DateTime fechaCreacion { get; set; }
        public string nombre { get; set; }
        public float precio { get; set; }
        public DateTime tiempoPresen { get; set; }

        public Producto(string nombre)
        {
            this.nombre = nombre;
        }
    }
}