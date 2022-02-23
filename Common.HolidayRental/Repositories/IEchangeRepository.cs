using System;
using System.Collections.Generic;
using System.Text;

namespace Common.HolidayRental.Repositories
{
    public interface IEchangeRepository<TEchange> : IRepository<TEchange, int>
    {
        public IEnumerable<TEchange> Get(DateTime dateReservation);
        public IEnumerable<TEchange> GetByIdMembre(int idMembre);
    }
}
