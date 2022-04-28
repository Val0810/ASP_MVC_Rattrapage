using BLL.HolidayRental.Entities;
using BLL.HolidayRental.Handlers;
using Common.HolidayRental.Repositories;
using DAL.HolidayRental.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.HolidayRental.Services
{
    public class MembreService : IMembreRepository<Membre>
    {
        // // Je n'ai pas réussi à corriger les erreurs
        private readonly IMembreRepository<DAL.Entities.Membre> _membreRepository;

        public MembreService(IMembreRepository<DAL.Entities.Membre> repository)
        {
            _membreRepository = repository;
        }

        public void Delete(int id)
        {
            _membreRepository.Delete(id);
        }

        public Membre Get(int id)
        {
            return _membreRepository.Get(id).ToBLL();
        }

        public IEnumerable<Membre> Get()
        {
            return _membreRepository.Get().Select(m => m.ToBLL());
        }

        public Membre GetByEchangeId(int idEchange)
        {
            return _membreRepository.GetByEchangeId(idEchange).ToBLL();
        }

        public IEnumerable<Membre> GetById(int idMembre)
        {
            return _membreRepository.GetByEchangeId(idMembre).Select(m => m.ToBLL());
        }

        public int Insert(Membre entity)
        {
            return _membreRepository.Insert(entity.ToDAL());
        }

        public void Update(int id, Membre entity)
        {
            _membreRepository.Update(id, entity.ToDAL());
        }
    }
}
