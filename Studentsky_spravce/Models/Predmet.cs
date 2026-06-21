namespace Studentsky_spravce.Models
{
    public class Predmet
    {
        public int IdPredmet { get; set; }
        public string NazevPredmetu { get; set; }
        public Ucitel Ucitel { get; set; }

        public Predmet(int idPredmet, string nazevPredmetu, Ucitel ucitel)
        {
            IdPredmet = idPredmet;
            NazevPredmetu = nazevPredmetu;
            Ucitel = ucitel;
        }

        public Predmet() { } 
    }
}
