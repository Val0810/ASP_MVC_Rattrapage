using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.HolidayRental.Repositories
{
    public abstract class ServiceBase
    {
        protected string _connString = @"Data Source=wad-04\sqlexpress;Initial Catalog=HolidayRental.Database;Integrated Security=True";
    }
}
