using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.HolidayRental.Models
{
    public class BienForm
    {
        [ScaffoldColumn(false)]
        [Key]
        public string descriptionCourte { get; set; }
        [Required(ErrorMessage = "Ce champs est obligatoire.")]
        public string descriptionLongue { get; set; }
        [Required(ErrorMessage = "Ce champs est obligatoire.")]
        public string pays { get; set; }
        [Required(ErrorMessage = "Ce champs est obligatoire.")]
        public string ville { get; set; }
        [Required(ErrorMessage = "Ce champs est obligatoire.")]
        public string rue { get; set; }
        [Required(ErrorMessage = "Ce champs est obligatoire.")]
        public string numero { get; set; }
        [Required(ErrorMessage = "Ce champs est obligatoire.")]
        public string codePostal { get; set; }
        [Required(ErrorMessage = "Ce champs est obligatoire.")]
        public string photo { get; set; }
        [Required(ErrorMessage = "Ce champs est obligatoire.")]
        public int nombrePersonne { get; set; }
        [Required(ErrorMessage = "Ce champs est obligatoire.")]
        public int nombreSalleDeBain { get; set; }
        [Required(ErrorMessage = "Ce champs est obligatoire.")]
        public int nombreWC { get; set; }
        [Required(ErrorMessage = "Ce champs est obligatoire.")]
    }
}
