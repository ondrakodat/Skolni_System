using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Studentsky_spravce.Data;

namespace Studentsky_spravce.Controllers
{
    public class RozvrhController : Controller
    {
        private readonly AppDbContext _databaze;

        public RozvrhController(AppDbContext databaze)
        {
            _databaze = databaze;
        }

        public IActionResult Index(int id)
        {
            ViewBag.Hodina = _databaze.Hodiny.ToList();
            ViewBag.Predmet = _databaze.Predmety.ToList();
            ViewBag.Ucitel = _databaze.Ucitele.ToList();

            var rozvrh = _databaze.Rozvrhy
                .Include(r => r.Hodiny).ThenInclude(h => h.Predmet)
                .Include(r => r.Hodiny).ThenInclude(h => h.Ucitel)
                .FirstOrDefault(r => r.Id  == id);

            if (rozvrh == null) {
                return NotFound();
            }

            return View(rozvrh);
        }
    }
}
