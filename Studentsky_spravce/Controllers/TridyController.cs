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
            ViewBag.Studenti = _databaze.Studenti.ToList().Where(s => s.Trida == null);
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

        [HttpGet]
        public IActionResult Edit(int id) {
            var trida = _databaze.Tridy
                .Include(t => t.TridniUcitel)
                .Include(t => t.Studente)
                .FirstOrDefault(t => t.Id == id);

            if (trida == null) {
                return NotFound();
            }

            ViewBag.Studenti = _databaze.Studenti.ToList();
            ViewBag.Ucitele = _databaze.Ucitele.ToList();


            return View(trida);
        }

        [HttpPost]
        public IActionResult Edit(List<int>? Vybranistudenti, int ucitel, Trida trida) {
            var existujiciTrida = _databaze.Tridy
                 .Include(t => t.TridniUcitel)
                 .Include(t => t.Studente)
                 .FirstOrDefault(t => t.Id == trida.Id);

            if (existujiciTrida == null) {
                return NotFound();
            }

            existujiciTrida.Nazev = trida.Nazev;

            if (Vybranistudenti == null) {
                  Vybranistudenti = new List<int>();
            }

            var studente =  _databaze.Studenti
                .Where(s => Vybranistudenti
                .Contains(s.Id))
                .ToList();

            var vybranyUcitel = _databaze.Ucitele.FirstOrDefault(u => u.Id == ucitel);


            existujiciTrida.Studente.Clear();
            existujiciTrida.Studente.AddRange(studente);
            existujiciTrida.TridniUcitel = vybranyUcitel;

            _databaze.Tridy.Update(existujiciTrida);
            _databaze.SaveChanges();


            return RedirectToAction("Index");
        }

    
       


    }
}
