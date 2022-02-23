using System;
using System.Collections.Generic;
using System.Text;

namespace Common.HolidayRental.Repositories
{
    public interface IGetByEchangeRepository<TEntity>
    {
        public TEntity GetByEchangeId(int idEchange);
    }
}
