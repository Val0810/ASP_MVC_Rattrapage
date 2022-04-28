using System.ComponentModel.DataAnnotations;

namespace ASP.HolidayRental.Models
{
    public class MembreLogin
    {
        [ScaffoldColumn(false)]
        [Key]

        [Required(ErrorMessage = "Ce champs est obligatoire.")]
        public string identifiant { get; set; }

        [Required(ErrorMessage = "Ce champs est obligatoire.")]
        public string motDePasse { get; set; }
    }
}
