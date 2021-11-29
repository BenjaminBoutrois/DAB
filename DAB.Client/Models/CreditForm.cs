using System.ComponentModel.DataAnnotations;

namespace DAB.Client.Models
{
    public class CreditForm
    {
        [Required(ErrorMessage = "Le champ Montant est requis.")]
        [Range(10, 1000, ErrorMessage = "Montant invalide (entre 10 et 1000 €).")]
        public int Amount { get; set; }
    }
}
