using System.ComponentModel.DataAnnotations;


namespace ASP.HolidayRental.Models
{
    public class MembreListItem
    {
        [ScaffoldColumn(false)]
        [Key]
        public int idMembre { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string mail { get; set; }
        public string pays { get; set; }
        public string telephone { get; set; }
        public string identifiant { get; set; }
        public string motDePasse { get; set; }
        public bool CGV { get; set; }
    }
}
