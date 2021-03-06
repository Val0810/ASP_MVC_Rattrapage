using BLL.HolidayRental.Entities;
using BLL.HolidayRental.Handlers;
using Common.HolidayRental.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL.HolidayRental.Services
{
    public class EchangeService : IEchangeRepository<Echange>
    {
        
        private readonly IEchangeRepository<DAL.HolidayRental.Entities.Echange> _echangeRepository;
        private readonly IMembreRepository<DAL.HolidayRental.Entities.Membre> _membreRepository;
        private readonly IBienRepository<DAL.HolidayRental.Entities.Bien> _bienRepository;

        public EchangeService(
            IEchangeRepository<DAL.HolidayRental.Entities.Echange> echangeRepository,
            IMembreRepository<DAL.HolidayRental.Entities.Membre> membreRepository,
            IBienRepository<DAL.HolidayRental.Entities.Bien> bienRepository)
        {
            _echangeRepository = echangeRepository;
            _membreRepository = membreRepository;
            _bienRepository = bienRepository;
        }

        public void Delete(int id)
        {
            _echangeRepository.Delete(id);
        }

        public IEnumerable<Echange> Get(DateTime dateReservation)
        {
            return _echangeRepository.Get(dateReservation).Select(e =>
            {
                Echange result = e.ToBLL();
                result.Membre = _membreRepository.Get(result.idMembre).ToBLL();
                result.Bien = _bienRepository.Get(result.idBien).ToBLL();
                return result;
            });
        }

        public Echange Get(int id)
        {
            Echange result = _echangeRepository.Get(id).ToBLL();
            result.Membre = _membreRepository.Get(result.idMembre).ToBLL();
            result.Bien = _bienRepository.Get(result.idBien).ToBLL();
            return result;
        }

        public IEnumerable<Echange> Get()
        {
            return _echangeRepository.Get().Select(e => {
                Echange result = e.ToBLL();
                result.Membre = _membreRepository.Get(result.idMembre).ToBLL();
                result.Bien = _bienRepository.Get(result.idBien).ToBLL();
                return result;
            });
        }

        public IEnumerable<Echange> GetByIdMembre(int idMembre)
        {
            return _echangeRepository.GetByIdMembre(idMembre).Select(e =>
            {
                Echange result = e.ToBLL();
                result.Membre = _membreRepository.Get(result.idMembre).ToBLL();
                result.Bien = _bienRepository.Get(result.idBien).ToBLL();
                return result;
            });
        }

        public int Insert(Echange entity)
        {
            return _echangeRepository.Insert(entity.ToDAL());
        }

        public void Update(int id, Echange entity)
        {
            _echangeRepository.Update(id, entity.ToDAL());
        }
    }
}
