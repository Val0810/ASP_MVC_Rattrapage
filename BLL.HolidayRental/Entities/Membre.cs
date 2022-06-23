using System;
using System.Collections.Generic;

namespace BLL.HolidayRental.Entities
{
    public class Membre
    {
        public int idMembre { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string mail { get; set; }
        public string pays { get; set; }
        public string telephone { get; set; }
        public string identifiant { get; set; }
        public string motDePasse { get; set; }
        public bool CGV { get; set; }
        public IEnumerable<Echange> Echanges { get; set; }

        public Membre(int Id, string Nom, string Prenom, string Mail, string Pays, string Telephone, string Identifiant, string MotDePasse, bool Cgv)
        {
            idMembre = Id;
            nom = Nom;
            prenom = Prenom;
            mail = Mail;
            pays = Pays;
            telephone = Telephone;
            identifiant = Identifiant;
            motDePasse = MotDePasse;
            CGV = Cgv;
        }

        public void AddEchange(DateTime dateDiffusion, int numeroReservation, Bien bien)
        {
            throw new NotImplementedException();
        }

        public void CancelEchange(Echange echange)
        {
            throw new NotImplementedException();
        }


    }
}
