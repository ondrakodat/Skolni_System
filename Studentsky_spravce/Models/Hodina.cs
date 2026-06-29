namespace Studentsky_spravce.Models
{
    public class Hodina
    {
        public int Id{ get; set; }

        public Predmet Predmet { get; set; }

        public Ucitel Ucitel { get; set; } 

        public int DenVTydnu { get; set; }

        public int CisloHodiny { get; set; }

        public Hodina( Predmet predmet, Ucitel ucitel, int denVTydnu, int hodina)
        {
          
            Predmet = predmet;
            Ucitel = ucitel;
            DenVTydnu = denVTydnu;
            CisloHodiny = hodina;
        }
        public Hodina()
        {
        }

    }
}
