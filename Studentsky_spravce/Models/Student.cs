namespace Studentsky_spravce.Models
{
    public class Student : Osoba
    {
        public Student()
        {
        }

        public Student(string jmeno, string prijmeni, int vek, string email) : base(jmeno, prijmeni, vek, email)
        {
        }
        
        public Trida? Trida { get; set; }



    
    }
}
