using System.ComponentModel.DataAnnotations;

namespace L01P02_2019_MZ_602.Models
{
    public class comentarios
    {
        [Key]
        public int cometarioId { get; set; }
        [Display(Name = "ID publicación")]
        public int? publicacionId { get; set; }
        [Display(Name = "Comentario")]
        public string? comentario { get; set; }
        [Display(Name = "ID Usuario")]
        public int? usuarioId { get; set; } 
    }
}
