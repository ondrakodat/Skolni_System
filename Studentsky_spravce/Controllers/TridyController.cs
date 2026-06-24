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

        public IActionResult Index()
        {           
            var Tridy = _databaze.Tridy.Include(t => t.TridniUcitel).Include(t=> t.Studente).ToList();
            return View(Tridy);
        }


        public IActionResult Create()
        {
            ViewBag.Studenti = _databaze.Studenti.ToList();
            ViewBag.Ucitele = _databaze.Ucitele.ToList();
            return View();
        }


        [HttpPost]
        public IActionResult Create(Trida trida, int tridniUcitel, List<int> vybraniStudenti) {
            try
            {
                var TridniUcitel = _databaze.Ucitele.FirstOrDefault(t => t.Id == tridniUcitel);
                trida.TridniUcitel =  TridniUcitel;
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message.ToString());
            }
            var vybraniStudente = _databaze.Studenti.Where(s => vybraniStudenti.Contains(s.Id)).ToList();
            trida.Studente = vybraniStudente;

           

            _databaze.Tridy.Add(trida);
            _databaze.SaveChanges();

            return RedirectToAction("Index");
        }

       


    }
}
