using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB220155
{
    [Table("GradoviIB220155")]
    public class GradIB220155
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public bool Status { get; set; }
        public DrzavaIB220155 Drzava { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
