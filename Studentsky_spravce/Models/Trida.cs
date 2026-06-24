using System.Runtime.CompilerServices;
using System.Security;

namespace Studentsky_spravce.Models
{
    public class Trida
    {
        public Trida()
        {
        }

        public Trida(string nazev, Ucitel tridniUcitel, List<Student> studente)
        {
            Nazev = nazev;
            TridniUcitel = tridniUcitel;
            Studente = studente;
        }


        public int Id{ get; set; }
        public string Nazev { get; set; } = "";
        public Ucitel? TridniUcitel { get; set; }

        public List<Student> Studente { get; set; } = new();



    }
}
