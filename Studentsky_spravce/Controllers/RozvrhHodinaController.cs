using Microsoft.AspNetCore.Mvc;
using Studentsky_spravce.Data;
using Studentsky_spravce.Models;

namespace Studentsky_spravce.Controllers
{
    public class RozvrhHodinaController : Controller
    {
        
        private readonly AppDbContext _databaze;

        public RozvrhHodinaController(AppDbContext databaze)
        {
            _databaze = databaze;
        }

        public IActionResult Index()
        {
            var Rozvrhy = _databaze.Hodiny.ToList();
            return View(Rozvrhy);
        }

        [HttpGet]
        public IActionResult Create() {
            
            ViewBag.Tridy = _databaze.Tridy.ToList();
            ViewBag.Predmety = _databaze.Predmety.ToList();
            ViewBag.Ucitele = _databaze.Ucitele.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Create(int TridaId, Hodina hodina, List<int>predmetyId, List<int> UciteleId) {
          
            _databaze.Add(hodina);
            _databaze.SaveChanges();
            return RedirectToAction("Index");
        }

    }

}
