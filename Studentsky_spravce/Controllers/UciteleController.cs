using Microsoft.AspNetCore.Mvc;
using Studentsky_spravce.Data;
using Studentsky_spravce.Models;

namespace Studentsky_spravce.Controllers
{
    public class UciteleController : Controller
    {
        private readonly AppDbContext _databaze;

        public UciteleController(AppDbContext databaze)
        {
            _databaze = databaze;
        }

        public IActionResult Index()
        {   
            var ucitele = _databaze.Ucitele.ToList();

            if (!_databaze.Ucitele.Any()) {
                _databaze.Ucitele.Add(new Ucitel("Sona", "Neradova", 60, "email"));
                _databaze.SaveChanges();
            }
            return View(ucitele);
        }

        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Ucitel ucitel) {
            _databaze.Ucitele.Add(ucitel);
            _databaze.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
