using System.Collections.Generic;

namespace Common.HolidayRental.Repositories
{
    public interface IMembreRepository<TMembre> : IRepository<TMembre, int>,
        IGetByEchangeRepository<TMembre>
    {
        IEnumerable<TMembre> GetById(int idMembre);
    }
}
