using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIT.Data.IB220155
{
    [Table("DrzaveIB220155")]
    public class DrzavaIB220155
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public bool Status { get; set; }
        public byte[] Zastava { get; set; }
        [NotMapped]
        public int BrojGradova { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
