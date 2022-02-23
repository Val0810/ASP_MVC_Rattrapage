using System.Collections.Generic;

namespace Common.HolidayRental.Repositories
{
    public interface IBienRepository<TBien> : IRepository<TBien, int> , IGetByEchangeRepository<TBien>
    {
        public IEnumerable<TBien> GetById(int idBien);
    }
}
