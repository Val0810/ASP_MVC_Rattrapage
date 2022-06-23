using B = BLL.HolidayRental.Entities;
using D = DAL.HolidayRental.Entities;

namespace BLL.HolidayRental.Handlers
{
    public static class Mapper
    {
        public static B.Membre ToBLL(this D.Membre entity)
        {
            if (entity == null) return null;
            return new B.Membre(
                entity.idMembre,
                entity.nom,
                entity.prenom,
                entity.mail,
                entity.pays,
                entity.telephone,
                entity.identifiant,
                entity.motDePasse,
                entity.CGV
                );
        }

        public static D.Membre ToDAL(this B.Membre entity)
        {
            if (entity == null) return null;
            return new D.Membre
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

        public static B.Bien ToBLL(this D.Bien entity)
        {
            if (entity == null) return null;
            return new B.Bien (
                entity.idBien,
                entity.descriptionCourte,
                entity.descriptionLongue,
                entity.pays,
                entity.ville,
                entity.rue,
                entity.numero,
                entity.codePostal,
                entity.photo,
                entity.nombrePersonne,
                entity.nombreSalleDeBain,
                entity.nombreWC,
                entity.idEchange
                );
        }
        public static D.Bien ToDAL(this B.Bien entity)
        {
            if (entity == null) return null;
            return new D.Bien
            {
                idBien = entity.idBien,
                descriptionCourte = entity.descriptionCourte,
                descriptionLongue = entity.descriptionLongue,
                pays = entity.pays,
                ville = entity.ville,
                rue = entity.rue,
                numero = entity.numero,
                codePostal = entity.codePostal,
                photo = entity.photo,
                nombrePersonne = entity.nombrePersonne,
                nombreSalleDeBain = entity.nombreSalleDeBain,
                nombreWC = entity.nombreWC,
                idEchange = entity.idEchange
            };
        }

        public static B.Echange ToBLL(this D.Echange entity)
        {
            if (entity == null) return null;
            return new B.Echange
                (
                entity.idEchange,
                entity.numeroReservation,
                entity.dateReservation,
                entity.dateEntree,
                entity.dateSortie,
                entity.dateReglement,
                entity.moyenPaiement,
                entity.statutEchange,
                entity.idMembre,
                entity.idBien
                );
        }

        public static D.Echange ToDAL(this B.Echange entity)
        {
            if (entity == null) return null;
            return new D.Echange
            {
                idEchange = entity.idEchange,
                numeroReservation = entity.numeroReservation,
                dateReservation = entity.dateReservation,
                dateEntree = entity.dateEntree,
                dateSortie = entity.dateSortie,
                dateReglement = entity.dateReglement,
                moyenPaiement = entity.moyenPaiement,
                statutEchange = entity.statutEchange,
                idMembre = entity.idMembre,
                idBien = entity.idBien
            };
        }        
       
    }
}
