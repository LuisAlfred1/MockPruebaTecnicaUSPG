using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MockPruebaTecnica.Models
{
    public class Producto
    {
        public long Id { get; set; }

        [StringLength(50)]
        public string CodigoBarras { get; set; }

        [StringLength(100)]
        public string NombreProducto { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        [StringLength(50)]
        public string Categoria { get; set; }

        public decimal Precio { get; set; }

    }
}
