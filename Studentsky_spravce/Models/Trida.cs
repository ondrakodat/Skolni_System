using System.Runtime.CompilerServices;
using System.Security;

namespace Studentsky_spravce.Models
{
    public class Trida
    {
        public int IdTrida { get; set; }
        public string Nazev { get; set; } = "";
        public TridniUcitel TridniUcitel { get; set; }

        public List<Student> Studente { get; set; } = new();


    }
}
