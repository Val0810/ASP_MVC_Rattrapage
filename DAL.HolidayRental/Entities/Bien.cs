namespace DAL.HolidayRental.Entities
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
        public int idEchange { get; set; }

    }
}
