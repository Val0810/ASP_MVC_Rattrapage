using DAL.HolidayRental.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.HolidayRental.Handlers
{
    public static class Mapper
    {
        public static Membre ToMembre(IDataRecord record)
        {
            if (record is null) return null;
            return new Membre
            {
                idMembre = (int)record[nameof(Membre.idMembre)],
                nom = (string)record[nameof(Membre.nom)],
                prenom = (string)record[nameof(Membre.prenom)],
                mail = (string)record[nameof(Membre.mail)],
                pays = (string)record[nameof(Membre.mail)],
                telephone = (string)record[nameof(Membre.telephone)],
                identifiant = (string)record[nameof(Membre.identifiant)],
                motDePasse = (string)record[nameof(Membre.motDePasse)],
                CGV = (bool)record[nameof(Membre.CGV)]
            };
        }
        public static Echange ToEchange(IDataRecord record)
        {
            if (record is null) return null;
            return new Echange
            {
                idEchange = (int)record[nameof(Echange.idEchange)],
                numeroReservation = (int)record[nameof(Echange.numeroReservation)],
                dateReservation = (DateTime)record[nameof(Echange.dateReservation)],
                dateEntree = (DateTime)record[nameof(Echange.dateEntree)],
                dateSortie = (DateTime)record[nameof(Echange.dateSortie)],
                dateReglement = (DateTime)record[nameof(Echange.dateReglement)],
                moyenPaiement = (string)record[nameof(Echange.moyenPaiement)],
                statutEchange = (string)record[nameof(Echange.statutEchange)],
                idMembre = (int)record[nameof(Membre.idMembre)]
            };
        }
        public static Bien ToBien(IDataRecord record)
        {
            if (record is null) return null;
            return new Bien
            {
                idBien = (int)record[nameof(Bien.idBien)],
                descriptionCourte = (string)record[nameof(Bien.descriptionCourte)],
                descriptionLongue = (string)record[nameof(Bien.descriptionLongue)],
                pays = (string)record[nameof(Bien.pays)],
                ville = (string)record[nameof(Bien.ville)],
                rue = (string)record[nameof(Bien.rue)],
                numero = (string)record[nameof(Bien.numero)],
                codePostal = (string)record[nameof(Bien.codePostal)],
                photo = (string)record[nameof(Bien.photo)],
                nombrePersonne = (int)record[nameof(Bien.nombrePersonne)],
                nombreSalleDeBain = (int)record[nameof(Bien.nombreSalleDeBain)],
                nombreWC = (int)record[nameof(Bien.nombreWC)],
                idEchange = (int)record[nameof(Echange.idEchange)]
            };
        }
    }
}
