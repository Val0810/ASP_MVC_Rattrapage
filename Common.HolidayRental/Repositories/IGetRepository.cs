using System.Collections.Generic;

namespace Common.HolidayRental.Repositories
{
    public interface IGetRepository<TEntity, TId>
    {
        TEntity Get(TId id);
        IEnumerable<TEntity> Get();
    }
}
