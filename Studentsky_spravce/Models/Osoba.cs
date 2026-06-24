namespace Studentsky_spravce.Models
{
    public class Osoba
    {
        public int Id { get; set; }
        public string Jmeno { get; set; } = "";
        public string Prijmeni { get; set; } = "";
        public int Vek { get; set; }
        public string Email { get; set; } = "";

        public Osoba( string jmeno, string prijmeni, int vek, string email)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            Email = email;
        }

        public Osoba() { }
    }
}
