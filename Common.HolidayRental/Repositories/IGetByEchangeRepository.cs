namespace Common.HolidayRental.Repositories
{
    public interface IGetByEchangeRepository<TEntity>
    {
        public TEntity GetByEchangeId(int idEchange);
    }
}
