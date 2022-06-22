using BLL.HolidayRental.Entities;
using BLL.HolidayRental.Handlers;
using Common.HolidayRental.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace BLL.HolidayRental.Services
{
    public class BienService : IBienRepository<Bien>
    {
        
        private readonly IBienRepository<DAL.HolidayRental.Entities.Bien> _bienRepository;

        public BienService (IBienRepository<DAL.HolidayRental.Entities.Bien> repository)
        {
            _bienRepository = repository;
        }

        public void Delete(int id)
        {
            _bienRepository.Delete(id);
        }

        public Bien Get(int id)
        {
            return _bienRepository.Get(id).ToBLL();
        }

        public IEnumerable<Bien> Get()
        {
            return _bienRepository.Get().Select(b => b.ToBLL());
        }

        public Bien GetByEchangeId(int idEchange)
        {
            return _bienRepository.GetByEchangeId(idEchange).ToBLL();
        }

        public IEnumerable<Bien> GetById(int idBien)
        {
            return _bienRepository.GetById(idBien).Select(b => b.ToBLL());
        }

        public int Insert(Bien entity)
        {
            return _bienRepository.Insert(entity.ToDAL());
        }

        public void Update(int id, Bien entity)
        {
            _bienRepository.Update(id, entity.ToDAL());
        }
    }
}
