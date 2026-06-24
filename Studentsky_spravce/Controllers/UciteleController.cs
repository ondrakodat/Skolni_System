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
            return View(ucitele);
        }

        public IActionResult Create() {
            return View();
        }

        public IActionResult Edit(int id) {
            Ucitel ucitel = null;
            try
            {
                ucitel = _databaze.Ucitele.FirstOrDefault(u => u.Id == id);              

            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
            }
            return View(ucitel);
        }

        [HttpPost]
        public IActionResult Create(Ucitel ucitel) {
            _databaze.Ucitele.Add(ucitel);
            _databaze.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Edit(Ucitel ucitel) {
            if (ModelState.IsValid) { 
                   _databaze.Ucitele.Update(ucitel);
                   _databaze.SaveChanges();
            }
            return RedirectToAction("Index");
        }

       

    }
}
