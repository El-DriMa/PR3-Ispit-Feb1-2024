using FIT.Data;
using FIT.Data.IB220155;
using FIT.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms.IB220155
{
    public partial class frmGradoviIB220155 : Form
    {
        DLWMSDbContext db = KonekcijaNaBazuIB220155.baza;
        DrzavaIB220155 drzava;
        public frmGradoviIB220155(DrzavaIB220155 drzava)
        {
            InitializeComponent();
            dgvGradovi.AutoGenerateColumns = false;
            this.drzava = drzava;
        }

        private void frmGradoviIB220155_Load(object sender, EventArgs e)
        {
            pbZastava.Image = Helpers.Ekstenzije.ToImage(drzava.Zastava);
            lblNazivDrzave.Text = drzava.Naziv;
            ucitajGradove();
        }

        private void ucitajGradove()
        {
            dgvGradovi.DataSource = null;
            dgvGradovi.DataSource = db.GradoviIB220155.Where(x => x.Drzava.Id == drzava.Id).ToList();
        }

        private void dgvGradovi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == 2)
            {
                var grad = dgvGradovi.Rows[e.RowIndex].DataBoundItem as GradIB220155;
                grad.Status = !grad.Status;
                db.GradoviIB220155.Update(grad);
                db.SaveChanges();
                ucitajGradove();
            }

        }

        private void btnDodajGrad_Click(object sender, EventArgs e)
        {
            var nazivGrada = txtNazivGrada.Text;
            if (Validiraj())
            {
                var grad = new GradIB220155()
                {
                    Naziv = nazivGrada,
                    Drzava = drzava,
                    Status = true,
                };
                db.GradoviIB220155.Add(grad);
                db.SaveChanges();
                ucitajGradove();
            }

        }
        
        private bool Validiraj()
        {
            var nazivGrada = txtNazivGrada.Text;
            if (!Helpers.Validator.ProvjeriUnos(txtNazivGrada, err, Kljucevi.ReqiredValue))
                return false;

            var postojeciGradovi = db.GradoviIB220155.FirstOrDefault(x => x.Naziv == nazivGrada && x.Drzava == drzava);
            if (postojeciGradovi != null)
            {
                MessageBox.Show("U bazi vec postoji taj grad !!!");
                return false;
            }

            return true;
        }
    }
}
