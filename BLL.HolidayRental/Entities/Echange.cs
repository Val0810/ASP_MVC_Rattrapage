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
        public int idBien { get; set; }
        public Membre Membre { get; set; }
        public Bien Bien { get; set; }

        public Echange(int IdEchange, int NumeroReservation, DateTime DateReservation, DateTime DateEntree, DateTime DateSortie, DateTime DateReglement, string MoyenPaiement, string StatusEchange, int IdMembre, int IdBien, Membre membre, Bien bien)
        {
            idEchange = IdEchange;
            numeroReservation = NumeroReservation;
            dateReservation = DateReservation;
            dateEntree = DateEntree;
            dateReglement = DateReglement;
            moyenPaiement = MoyenPaiement;
            statutEchange = StatusEchange;
            Membre = membre;
            if (membre == null) throw new ArgumentNullException(nameof(idMembre));
            idMembre = IdMembre;
            Bien = bien;
            if (bien == null) throw new ArgumentNullException(nameof(idBien));
            idBien = IdBien;
        }

        public Echange(int IdEchange, int NumeroReservation, DateTime DateReservation, DateTime DateEntree, DateTime DateSortie, DateTime DateReglement, string MoyenPaiement, string StatusEchange, int IdMembre, int IdBien)
        {
            idEchange = IdEchange;
            numeroReservation = NumeroReservation;
            dateReservation = DateReservation;
            dateEntree = DateEntree;
            dateReglement = DateReglement;
            moyenPaiement = MoyenPaiement;
            statutEchange = StatusEchange;
            idMembre = IdMembre;
            idBien = IdBien;
            Membre = null;
            Bien = null;
        }
    }
}
