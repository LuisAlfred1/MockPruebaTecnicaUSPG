namespace MockPruebaTecnica.Models
{
    public class Venta
    {
        public long Id { get; set; }

        public DateTime FechaVenta { get; set; }

        public long IdCliente { get; set; }

        public long IdProducto { get; set; }

        public int Cantidad { get; set; }

        public decimal TotalVenta { get; set; }

        public Cliente? Cliente { get; set; }

        public Producto? Producto { get; set; }

    }
}
