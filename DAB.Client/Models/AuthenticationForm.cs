using System.ComponentModel.DataAnnotations;

namespace DAB.Client.Models
{
    public class AuthenticationForm
    {
        [Required(ErrorMessage = "Le champ Numéro est requis.")]
        [StringLength(16, MinimumLength = 16, ErrorMessage = "Le numéro doit contenir 16 caractères.")]
        public string? Number { get; set; }

        [Required(ErrorMessage = "Le champ Code est requis.")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "Le code doit contenir 4 caractères.")]
        public string? Pin { get; set; }
    }
}
