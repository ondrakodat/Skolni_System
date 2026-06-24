using Microsoft.AspNetCore.Mvc;
using Studentsky_spravce.Data;
using Studentsky_spravce.Models;

namespace Studentsky_spravce.Controllers
{
    public class StudentiController : Controller
    {
        private readonly AppDbContext _databaze;

        public StudentiController(AppDbContext databaze)
        {
            _databaze = databaze;
        }

        public IActionResult Index()
        {
            if (!_databaze.Studenti.Any()) {
                _databaze.Studenti.Add(new Student("Ondra", "Kodat", 15, "aa"));
                _databaze.SaveChanges();
            }

            var studenti = _databaze.Studenti.ToList();
            return View(studenti);
        }

        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student) {
            _databaze.Studenti.Add(student);
            _databaze.SaveChanges();


            return RedirectToAction("Index");
        }



    }
}
