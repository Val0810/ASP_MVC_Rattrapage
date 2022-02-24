using System;

namespace BLL.HolidayRental.Entities
{
    public class Echange
    {
        public int idEchange { get; set; }
        public int numeroReservation { get; set; }
        public DateTime dateReservation { get; set; }
        public DateTime dateEntree { get; set; }
        public DateTime dateSortie { get; set; }
        public DateTime dateReglement { get; set; }
        public string moyenPaiement { get; set; }
        public string statutEchange { get; set; }
        public int idMembre { get; set; }
        public Membre Membre { get; set; }

        public Echange(int IdEchange, int NumeroReservation, DateTime DateReservation, DateTime DateEntree, DateTime DateSortie, DateTime DateReglement, string MoyenPaiement, string StatusEchange, int IdMembre)
        {
            idEchange = IdEchange;
            numeroReservation = NumeroReservation;
            dateReservation = DateReservation;
            dateEntree = DateEntree;
            dateReglement = DateReglement;
            moyenPaiement = MoyenPaiement;
            statutEchange = StatusEchange;
            idMembre = IdMembre;
            Membre = null;
        }
    }
}
