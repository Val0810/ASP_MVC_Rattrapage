using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.HolidayRental.Models
{
    public class MembreForm
    {
        [Required(ErrorMessage = "Ce champs est obligatoire.")]
        [StringLength(maximumLength: 16, MinimumLength = 2, ErrorMessage = "La taille doit être comprise entre 2 et 16")]

        [ScaffoldColumn(false)]
        [Key]
        public string nom { get; set; }
        [Required(ErrorMessage = "Ce champs est obligatoire.")]
        [MinLength(2, ErrorMessage = "La taille minimum est de 2.")]
        [MaxLength(16, ErrorMessage = "La taille maximum est de 16.")]
        public string prenom { get; set; }
        [Required(ErrorMessage = "Ce champs est obligatoire.")]
        [MinLength(2, ErrorMessage = "La taille minimum est de 2.")]
        [MaxLength(16, ErrorMessage = "La taille maximum est de 16.")]
        public string mail { get; set; }
        [Required(ErrorMessage = "Ce champs est obligatoire.")]
        public string telephone { get; set; }
        [Required(ErrorMessage = "Ce champs est obligatoire.")]
        public string motDePasse { get; set; }
        [Required(ErrorMessage = "Ce champs est obligatoire.")]
        public bool CGV { get; set; }
        [Required(ErrorMessage = "Ce champs est obligatoire.")]
    
}
