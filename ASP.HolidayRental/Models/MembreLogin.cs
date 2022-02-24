using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.HolidayRental.Models
{
    public class MembreLogin
    {
        [ScaffoldColumn(false)]
        [Key]
        public string identifiant { get; set; }
        public string motDePasse { get; set; }
    }
}
