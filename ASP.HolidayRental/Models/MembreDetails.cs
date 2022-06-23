using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.HolidayRental.Models
{
    public class MembreDetails
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
        public int idEchange { get; set; }
        public IEnumerable<EchangeDetails> Echanges { get; set; }
    }
}
