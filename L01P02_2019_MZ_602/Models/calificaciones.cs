using System.ComponentModel.DataAnnotations;

namespace L01P02_2019_MZ_602.Models
{
    public class calificaciones
    {
        [Key]
        public int calificacionId { get; set; }
        [Display(Name = "ID Publicación")]
        public int? publicacionId { get; set; }
        [Display(Name = "ID Usuario")]
        public int? usuarioId { get; set; }
        [Display(Name = "Calificación")]
        public int? calificacion { get; set; }
    }
}
