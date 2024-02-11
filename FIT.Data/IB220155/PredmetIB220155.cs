using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB220155
{
    [Table("Predmeti")]
    public class PredmetIB220155
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public SemestarIB220155 Semestar { get; set; }
    }
}
