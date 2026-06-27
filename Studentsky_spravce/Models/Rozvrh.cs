
namespace Studentsky_spravce.Models
{
    public class Rozvrh 
    {
        public Rozvrh()
        {
        }

        public Rozvrh(int id, Trida trida, List<RozvrhHodina> hodiny)
        {
            Id = id;
            Trida = trida;
            Hodiny = hodiny;
        }

        public int Id { get; set; }
        public Trida Trida { get; set; }
        public List<RozvrhHodina> Hodiny { get; set; } = new();


    }
}
