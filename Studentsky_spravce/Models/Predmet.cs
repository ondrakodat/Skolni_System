namespace Studentsky_spravce.Models
{
    public class Predmet
    {
        public int Id { get; set; }
        public string NazevPredmetu { get; set; }
        public Ucitel Ucitel { get; set; }

        public Predmet( string nazevPredmetu, Ucitel ucitel)
        {
            
            NazevPredmetu = nazevPredmetu;
            Ucitel = ucitel;
        }

        public Predmet() { } 
    }
}
