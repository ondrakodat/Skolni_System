namespace Studentsky_spravce.Models
{
    public class Znamka
    {
        public int IdZnamka { get; set; }

        public int Hodnota { get; set; }

        public Student Student { get; set; }

        public DateTime Datum { get; set; }

        public Predmet Predmet  { get; set; }


    }
}
