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
    }
}
