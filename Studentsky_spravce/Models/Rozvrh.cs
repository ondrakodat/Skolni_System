
namespace Studentsky_spravce.Models
{
    public class Rozvrh 
    {
        public Rozvrh()
        {
        }

        public Rozvrh(int id, List<Hodina> hodiny)
        {
            Id = id;
            Hodiny = hodiny;
        }

        public int Id { get; set; }
        public List<Hodina> Hodiny { get; set; } = new();


    }
}
