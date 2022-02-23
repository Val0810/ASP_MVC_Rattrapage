using System;
using System.Collections.Generic;
using System.Text;

namespace Common.HolidayRental.Repositories
{
    public interface IMembreRepository<TMembre> : IRepository<TMembre, int>,
        IGetByEchangeRepository<TMembre>
    {
        IEnumerable<TMembre> GetById(int idMembre);
    }
}
