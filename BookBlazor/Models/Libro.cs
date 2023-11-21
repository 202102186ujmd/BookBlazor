using System.ComponentModel.DataAnnotations;

namespace BookBlazor.Models
{
    public class Libro
    {
        [Key]
        public int ID { get; set; }
        [StringLength(100)]
        public string? Titulo { get; set; }
        [StringLength(70)]
        public string? Autor { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public int paginas { get; set; }
        public decimal? Precio { get; set; }
        [StringLength(2500)]
        public string? Descripcion { get; set; }
        
    }
}
