namespace Studentsky_spravce.Models
{
    public class Ucitel : Osoba
    {
        public Ucitel(string jmeno, string prijmeni, int vek, string email) : base(jmeno, prijmeni, vek, email)
        {
        }

        public Ucitel() { }
    }
}
