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
using Timer = System.Windows.Forms.Timer;
using FIT.Data;
using FIT.Data.IB220155;
using Microsoft.EntityFrameworkCore;

namespace FIT.WinForms.IB220155
{
    public partial class frmDrzaveIB220155 : Form
    {
        DLWMSDbContext db = KonekcijaNaBazuIB220155.baza;
        private Timer timer;
        List<DrzavaIB220155> listaDrzava = new List<DrzavaIB220155>();
        public frmDrzaveIB220155()
        {
            InitializeComponent();
            dgvDrzave.AutoGenerateColumns = false;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, e) => lblTrenutnoVrijeme.Text = $"Trenutno vrijeme : {DateTime.Now.ToString("HH:mm:ss")}";
            timer.Start();

        }

        private void ucitajDrzave()
        {
            dgvDrzave.DataSource = null;
            dgvDrzave.DataSource = listaDrzava;
        }

        private void frmDrzaveIB220155_Load(object sender, EventArgs e)
        {
            listaDrzava = db.DrzaveIB220155.ToList();
            foreach (var drzava in listaDrzava)
            {
                int brojGradova = db.GradoviIB220155.Include(x => x.Drzava).Count(x => x.Drzava.Id == drzava.Id);
                drzava.BrojGradova = brojGradova;
            }
            ucitajDrzave();

        }

        private void btnNovaDrzava_Click(object sender, EventArgs e)
        {
            frmNovaDrzavaIB220155 frm = new frmNovaDrzavaIB220155();
            frm.ShowDialog();
            ucitajDrzave();
        }

        private void dgvDrzave_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 4)
            {
                var drzava = dgvDrzave.Rows[e.RowIndex].DataBoundItem as DrzavaIB220155;
                var frm = new frmNovaDrzavaIB220155(drzava);
                frm.ShowDialog();
                ucitajDrzave();
            }
        }
    }
}
