using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.HolidayRental.Entities
{
    public class Bien
    {
        public int idBien { get; set; }
        public string descriptionCourte { get; set; }
        public string descriptionLongue { get; set; }
        public string pays { get; set; }
        public string ville { get; set; }
        public string rue { get; set; }
        public string numero { get; set; }
        public string codePostal { get; set; }
        public string photo { get; set; }
        public int nombrePersonne { get; set; }
        public int nombreSalleDeBain { get; set; }
        public int nombreWC { get; set; }
        public Echange Echange { get; set; }

        public Bien(int IdBien, string DescriptionCourte, string DescriptionLongue, string Pays, string Ville, string Rue, string Numero, string CodePostal, string Photo, int NombrePersonne, int NombreSalleDeBain, int NombreWC)
        {
            idBien = IdBien;
            descriptionCourte = DescriptionCourte;
            descriptionLongue = DescriptionLongue;
            pays = Pays;
            ville = Ville;
            rue = Rue;
            numero = Numero;
            codePostal = CodePostal;
            photo = Photo;
            nombrePersonne = NombrePersonne;
            nombreSalleDeBain = NombreSalleDeBain;
            nombreWC = NombreWC;
        }
    }
}
