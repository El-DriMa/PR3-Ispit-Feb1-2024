using FIT.Data;
using FIT.Data.IB220155;
using FIT.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IB220155
{
    public partial class frmNovaDrzavaIB220155 : Form
    {
        DLWMSDbContext db = KonekcijaNaBazuIB220155.baza;
        DrzavaIB220155 drzava;
        bool Update = false;
        public frmNovaDrzavaIB220155()
        {
            InitializeComponent();
        }
        public frmNovaDrzavaIB220155(DrzavaIB220155 drzava)
        {
            InitializeComponent();
            this.drzava = drzava;
            Update = true;
            ucitajDrzavu();

        }

        private void ucitajDrzavu()
        {
            pbZastava.Image = Helpers.Ekstenzije.ToImage(drzava.Zastava);
            txtNaziv.Text = drzava.Naziv;
            checkBox1.Checked = drzava.Status;
        }

        private void frmNovaDrzavaIB220155_Load(object sender, EventArgs e)
        {

        }

        private void pbZastava_DoubleClick(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                pbZastava.Image = Image.FromFile(fd.FileName);
            }
        }
        private bool Validiraj()
        {
            return Helpers.Validator.ProvjeriUnos(pbZastava, err, Kljucevi.ReqiredValue) &&
                Helpers.Validator.ProvjeriUnos(txtNaziv, err, Kljucevi.ReqiredValue);
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (Validiraj())
            {
                var naziv = txtNaziv.Text;
                var status = checkBox1.Checked;
                var slika = pbZastava.Image;
                if (Update)
                {
                    drzava.Naziv = naziv;
                    drzava.Zastava = Helpers.Ekstenzije.ToByteArray(slika);
                    drzava.Status = status;
                    db.DrzaveIB220155.Update(drzava);
                }
                else
                {
                    var drzava = new DrzavaIB220155()
                    {
                        Naziv = naziv,
                        Status = status,
                        Zastava = Helpers.Ekstenzije.ToByteArray(slika),
                    };
                    db.DrzaveIB220155.Add(drzava);
                }
                db.SaveChanges();
                this.Close();
            }
        }
    }
}
