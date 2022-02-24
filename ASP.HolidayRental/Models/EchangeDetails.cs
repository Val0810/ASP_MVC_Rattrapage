using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASP.HolidayRental.Models
{
    public class EchangeDetails
    {
        [ScaffoldColumn(false)]
        [Key]
        public int idEchange { get; set; }
        public int numeroReservation { get; set; }
        public DateTime dateReservation { get; set; }
        public DateTime dateEntree { get; set; }
        public DateTime dateSortie { get; set; }
        public DateTime dateReglement { get; set; }
        public string moyenPaiement { get; set; }
        public string statutEchange { get; set; }
        public int idMembre { get; set; }
        public IEnumerable<MembreDetails> Membres { get; set; }
    }
}
