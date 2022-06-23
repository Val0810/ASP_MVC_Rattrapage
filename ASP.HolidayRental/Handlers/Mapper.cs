using ASP.HolidayRental.Models;
using BLL.HolidayRental.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.HolidayRental.Handlers
{
    public static class Mapper
    {
        public static MembreListItem ToListItem(this Membre entity)
        {
            if (entity == null) return null;
            return new MembreListItem
            {
                idMembre = entity.idMembre,
                nom = entity.nom,
                prenom = entity.prenom,
                mail = entity.mail,
                pays = entity.pays,
                telephone = entity.telephone,
                identifiant = entity.identifiant,
                motDePasse = entity.motDePasse,
                CGV = entity.CGV
            };            
        }

        public static MembreDetails ToDetails(this Membre entity)
        {
            if (entity == null) return null;
            return new MembreDetails
            {
                idMembre = entity.idMembre,
                nom = entity.nom,
                prenom = entity.prenom,
                mail = entity.mail,
                pays = entity.pays,
                telephone = entity.telephone,
                identifiant = entity.identifiant,
                motDePasse = entity.motDePasse,
                CGV = entity.CGV
            };
        }

        public static EchangeDetails ToDetails(this Echange entity)
        {
            if (entity == null) return null;
            return new EchangeDetails
            {
                idEchange = entity.idEchange,
                numeroReservation = entity.numeroReservation,
                dateReservation = entity.dateReservation,
                dateEntree = entity.dateEntree,
                dateSortie = entity.dateSortie,
                dateReglement = entity.dateReglement,
                moyenPaiement = entity.moyenPaiement,
                statutEchange = entity.statutEchange,
                idMembre = entity.Membre_idMembre
            };
        }
    }
}
