using System;
using System.Collections.Generic;
using System.Text;

namespace Common.HolidayRental.Repositories
{
    public interface IMembreRepository<TMembre> : IRepository<TMembre, string>,
        IGetByEchangeRepository<TMembre>
    {
        IEnumerable<TMembre> GetByIdentifiant(string identifiant);
    }
}
