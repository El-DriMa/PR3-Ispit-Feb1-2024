using FIT.Data.IB220155;
using System.Drawing;

namespace FIT.Data
{
    public class Student
    {
        public int Id { get; set; }
        public string Indeks { get; set; }
        public string Lozinka { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public byte[] Slika { get; set; }
        public DateTime DatumRodjenja { get; set; }
        public bool Aktivan { get; set; }        
        public SemestarIB220155 Semestar { get; set; }
        public GradIB220155 Grad { get; set; }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}
