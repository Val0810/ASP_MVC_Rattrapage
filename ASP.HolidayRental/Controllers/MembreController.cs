using ASP.HolidayRental.Handlers;
using ASP.HolidayRental.Models;
using BLL.HolidayRental.Entities;
using Common.HolidayRental.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ASP.HolidayRental.Controllers
{
    public class MembreController : Controller
    {
        private readonly IMembreRepository<Membre> _membreService;
        private readonly IEchangeRepository<Echange> _echangeService;

        public MembreController(IMembreRepository<Membre> membreService,
            IEchangeRepository<Echange> echangeService)
        {
            _membreService = membreService;
            _echangeService = echangeService;
        }
        public IActionResult Index()
        {
            IEnumerable<MembreListItem> model = _membreService.Get().Select(m => m.ToListItem());
            return View(model);
        }

        public IActionResult Details(int id)
        {
            MembreDetails model = _membreService.Get(id).ToDetails();
            model.Echanges = _echangeService.GetByIdMembre(id).Select(d => d.ToDetails());
            return View(model);
        }
    }
}
