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

        public MembreController(IMembreRepository<Membre> membreService)
        {
            _membreService = membreService;
        }
        public IActionResult Index()
        {
            IEnumerable<MembreListItem> model = _membreService.Get().Select(m => m.ToListItem());
            return View(model);
        }

       
    }
}
