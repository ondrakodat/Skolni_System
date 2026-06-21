namespace Studentsky_spravce.Models
{
    public class RozvrhHodina
    {
        public int IdHodina { get; set; }

        public Trida Trida { get; set; }    

        public Predmet Predmet { get; set; }

        public Ucitel Ucitel { get; set; } 

        int DenVTydnu { get; set; }

        int Hodina { get; set; }

        public RozvrhHodina(int idHodina, Trida trida, Predmet predmet, Ucitel ucitel, int denVTydnu, int hodina)
        {
            IdHodina = idHodina;
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
