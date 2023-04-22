using System.ComponentModel.DataAnnotations;

namespace L01P02_2019_MZ_602.Models
{
    public class publicaciones
    {
        [Key]
        public int publicacionId { get; set; }
        [Display(Name = "Título")]
        public string? titulo { get; set; }
        [Display(Name = "Descripción")]
        public string? descripcion { get; set; }
        [Display(Name = "usuarioId")]
        public int? usuarioId { get; set; }
    }
}
