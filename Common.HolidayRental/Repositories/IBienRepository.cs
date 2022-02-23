using System;
using System.Collections.Generic;
using System.Text;

namespace Common.HolidayRental.Repositories
{
    public interface IBienRepository<TBien> : IRepository<TBien, int> , IGetByEchangeRepository<TBien>
    {
        public IEnumerable<TBien> GetById(int idBien);
    }
}
