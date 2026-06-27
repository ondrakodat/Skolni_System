namespace Studentsky_spravce.Models
{
    public class RozvrhHodina
    {
        public int Id{ get; set; }

        public Trida Trida { get; set; }    

        public Predmet Predmet { get; set; }

        public Ucitel Ucitel { get; set; } 

        public int DenVTydnu { get; set; }

        public int Hodina { get; set; }

        public RozvrhHodina( Trida trida, Predmet predmet, Ucitel ucitel, int denVTydnu, int hodina)
        {
          
            Trida = trida;
            Predmet = predmet;
            Ucitel = ucitel;
            DenVTydnu = denVTydnu;
            Hodina = hodina;
        }
        public RozvrhHodina()
        {
        }

    }
}
