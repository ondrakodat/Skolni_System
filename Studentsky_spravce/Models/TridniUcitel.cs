namespace Studentsky_spravce.Models
{
    public class TridniUcitel : Ucitel
    {
        public TridniUcitel(string jmeno, string prijmeni, int vek, string email) : base(jmeno, prijmeni, vek, email)
        {
        }
        public TridniUcitel() { }
    }
}
