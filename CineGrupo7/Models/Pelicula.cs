using System.ComponentModel.DataAnnotations;

namespace CineGrupo7.Models
{
    public class Pelicula
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El título es obligatorio.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El título debe tener entre 2 y 100 caracteres.")]
        [Display(Name = "Título")]
        public string Titulo { get; set; } = string.Empty;

        [Required(ErrorMessage = "El nombre del director es obligatorio.")]
        [StringLength(80, ErrorMessage = "El director no puede exceder 80 caracteres.")]
        [Display(Name = "Director")]
        public string Director { get; set; } = string.Empty;

        [Required(ErrorMessage = "El año de estreno es obligatorio.")]
        [Range(1888, 2030, ErrorMessage = "Ingrese un año válido entre 1888 y 2030.")]
        [Display(Name = "Año de Estreno")]
        public int AnioEstreno { get; set; }

        [Required(ErrorMessage = "El género es obligatorio.")]
        [StringLength(50, ErrorMessage = "El género no puede exceder 50 caracteres.")]
        [Display(Name = "Género")]
        public string Genero { get; set; } = string.Empty;
    }
}