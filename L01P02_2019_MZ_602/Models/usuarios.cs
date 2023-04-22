using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace L01P02_2019_MZ_602.Models
{
    public class usuarios
    {
        [Key]
        public int usuarioId { get; set; }
        [Display(Name = "ID Rol")]
        public int rolId { get; set; }
        [Display(Name = "Usuario")]
        public string? nombreUsuario { get; set; }
        [Display(Name = "Clave")]
        public string? clave { get; set; }
        [Display(Name = "Nombre")]
        public string? nombre { get; set; }
        [Display(Name = "Apellido")]
        public string? apellido { get; set; }   

    }
}
