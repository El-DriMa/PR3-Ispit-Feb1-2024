using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB220155
{
    [Table("PolozeniPredmeti")]
    public class PolozeniPredmetiIB220155
    {
        public int Id { get; set; }
        public Student Student { get; set; }
        public PredmetIB220155 Predmet { get; set; }
        public int Ocjena { get; set; }
        public DateTime DatumPolaganja { get; set; }
        public string Napomena { get; set; }
    }
}
