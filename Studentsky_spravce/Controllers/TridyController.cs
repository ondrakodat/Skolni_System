using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Studentsky_spravce.Data;
using Studentsky_spravce.Models;
using System.Security.Cryptography;

namespace Studentsky_spravce.Controllers
{
    public class TridyController : Controller
    {
        private readonly AppDbContext _databaze;

        public TridyController(AppDbContext databaze)
        {
            _databaze = databaze;
        }

        Student S1 = new Student("Ondra", "Kodat", 22, "email");
        Student S2 = new Student("Tereza", "Hudcova", 19, "email");
        Student S3 = new Student("Ivana", "Anastasová", 47, "email");
        Student S4 = new Student("Bohumil", "Kodat", 51, "email");
        public List<Student> students = new List<Student>();
        
       
        
        


        public IActionResult Index()
        {
            if (!_databaze.Tridy.Any()) {
                students.Add(S1);
                students.Add(S2);
                students.Add(S3);
                students.Add(S4);
                _databaze.Tridy.Add(new Models.Trida("Trida", new Models.TridniUcitel("Ucitel", "Prijmeni", 150, "email"), students));
                _databaze.SaveChanges(); 
            }
            var Tridy = _databaze.Tridy.Include(t => t.TridniUcitel).Include(t=> t.Studente).ToList();
            return View(Tridy);
        }


        public IActionResult Create() { 
            return View();
        }

        [HttpPost]
        public IActionResult Create(Trida trida) {
            _databaze.TridniUcitele.Add(trida.TridniUcitel);
            _databaze.Tridy.Add(trida);
            _databaze.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
