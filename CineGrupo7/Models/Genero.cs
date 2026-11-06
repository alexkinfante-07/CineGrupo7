using System.ComponentModel.DataAnnotations;

namespace CineGrupo7.Models
{
    public class Genero
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El genero es obligatorio.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El genero debe tener entre 2 y 100 caracteres.")]
        [Display(Name = "Genero")]
        public string Titulo { get; set; } = string.Empty;
    }
}

