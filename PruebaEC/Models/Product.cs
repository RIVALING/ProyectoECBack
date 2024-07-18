using System.ComponentModel.DataAnnotations;

namespace PruebaEC.Models
{
    public class Product
    {
        [Key]
        public int idProducto { get; set; }
        public required string nombre { get; set; }
        public required int precio { get; set; }
        public required int cantidad { get; set; }
    }
}
