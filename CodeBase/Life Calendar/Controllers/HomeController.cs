using Database.LifeCalendar;
using Life_Calendar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Life_Calendar.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LifeCalendarContext _lifeCalendarContext;

        public HomeController(ILogger<HomeController> logger, LifeCalendarContext lifeCalendarContext)
        {
            _logger = logger;
            _lifeCalendarContext = lifeCalendarContext;
        }

        public IActionResult Index()
        {
            var persons = _lifeCalendarContext.Persons.Include(p => p.Events).ThenInclude(e => e.EventLabel).ToList();
            ViewBag.PersonCount = persons.Count;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
