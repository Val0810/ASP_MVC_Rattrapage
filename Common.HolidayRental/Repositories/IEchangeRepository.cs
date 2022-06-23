using System;
using System.Collections.Generic;

namespace Common.HolidayRental.Repositories
{
    public interface IEchangeRepository<TEchange> : IRepository<TEchange, int>
    {
        public IEnumerable<TEchange> Get(DateTime dateReservation);
        public IEnumerable<TEchange> GetByIdMembre(int idMembre);
        public IEnumerable<TEchange> GetByIdBien(int idBien);
    }
}
