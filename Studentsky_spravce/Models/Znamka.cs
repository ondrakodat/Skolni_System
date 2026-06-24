namespace Studentsky_spravce.Models
{
    public class Znamka
    {
        public Znamka()
        {
        }

        public Znamka(int hodnota, Student student, DateTime datum, Predmet predmet)
        {
            Hodnota = hodnota;
            Student = student;
            Datum = datum;
            Predmet = predmet;
        }

        public int Id { get; set; }

        public int Hodnota { get; set; }

        public Student Student { get; set; }

        public DateTime Datum { get; set; }

        public Predmet Predmet  { get; set; }



    }
}
