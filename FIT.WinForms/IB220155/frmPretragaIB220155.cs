using FIT.Data;
using FIT.Data.IB220155;
using FIT.Infrastructure;
using FIT.WinForms.Helpers;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmPretragaIB220155 : Form
    {
        DLWMSDbContext db = KonekcijaNaBazuIB220155.baza;
        public class dtoStudent
        {
            DLWMSDbContext db = KonekcijaNaBazuIB220155.baza;
            public Student Student { get; set; }
            public string Ime => Student.Ime;
            public string Prezime => Student.Prezime;
            public string Grad => Student.Grad.ToString();
            public string Drzava => getDrzava();
            public string Prosjek => getProsjek();

            private string getDrzava()
            {
                return db.DrzaveIB220155.Where(x => x.Id == Student.Grad.Drzava.Id).First().ToString();
            }

            private string getProsjek()
            {
                var lista = db.PolozeniPredmeti.Where(x => x.Student.Id == Student.Id).ToList();
                if (lista.Count() == 0) return "5";

                return lista.Average(x => x.Ocjena).ToString("");
            }
        }

        List<dtoStudent> listaDTOStudenata = new List<dtoStudent>();
        public frmPretragaIB220155()
        {
            InitializeComponent();
            dgvStudenti.AutoGenerateColumns = false;
        }

        private void frmPretragaIB220155_Load(object sender, EventArgs e)
        {
            ucitajDrzave();
            ucitajGradove();
        }

        private void ucitajGradove()
        {
            var drzava = cmbxDrzava.SelectedItem as DrzavaIB220155;
            var gradovi = db.GradoviIB220155.Where(x => x.Drzava == drzava).ToList();
            cmbxGrad.UcitajPodatke(gradovi);

        }

        private void ucitajDrzave()
        {
            var drzave = db.DrzaveIB220155.ToList();
            cmbxDrzava.UcitajPodatke(drzave);

        }

        private void cmbxDrzava_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucitajGradove();
            ucitajStudente();
        }

        private void ucitajStudente()
        {
            dgvStudenti.DataSource = null;
            listaDTOStudenata.Clear();
            var drzava = cmbxDrzava.SelectedItem as DrzavaIB220155;
            var grad = cmbxGrad.SelectedItem as GradIB220155;

            var listaStudenata = db.Studenti.Where(x => x.Grad.Id == grad.Id).ToList();

            foreach (var student in listaStudenata)
                listaDTOStudenata.Add(new dtoStudent() { Student = student });

            dgvStudenti.DataSource = listaDTOStudenata;

            if (listaDTOStudenata.Count() == 0)
                MessageBox.Show($"U bazi nema studenata koji dolaze iz grada {grad.ToString()} u drzavi {drzava.ToString()}");

        }

        private void cmbxGrad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ucitajStudente();
        }
    }
}
