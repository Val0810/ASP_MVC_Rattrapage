using ASP.HolidayRental.Handlers;
using ASP.HolidayRental.Models;
using BLL.HolidayRental.Entities;
using Common.HolidayRental.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ASP.HolidayRental.Controllers
{
    public class BienController : Controller
    {
        private readonly IBienRepository<Bien> _bienService;
        private readonly IEchangeRepository<Echange> _echangeService;

        public BienController(IBienRepository<Bien> bienService,
            IEchangeRepository<Echange> echangeService)
        {
            _bienService = bienService;
            _echangeService = echangeService;
        }
        public IActionResult Index()
        {
            // bug que je n'ai pas réussi à résoudre
            IEnumerable<BienListItem> model = _bienService.Get().Select(b => b.ToListItem());
            return View(model);
        }

        public IActionResult Details(int id)
        {
            // bug que je n'ai pas réussi à résoudre
            BienDetails model = _bienService.Get(id).ToDetails();
            model.Echanges = _echangeService.GetByIdBien(id).Select(d => d.ToDetails());
            return View(model);
        }
    }
}
