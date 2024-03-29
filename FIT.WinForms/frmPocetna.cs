﻿using FIT.Infrastructure;
using FIT.WinForms.IB220155;
using FIT.WinForms.Izvjestaji;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIT.WinForms
{
    public partial class frmPocetna : Form
    {
        DLWMSDbContext db = KonekcijaNaBazuIB220155.baza;
        public frmPocetna()
        {
            InitializeComponent();
        }

        private void frmPocetna_Load(object sender, EventArgs e)
        {
            lblKonekcijaInfo.Text = $"Broj studenata u bazi -> {db.Studenti.Count()}";
        }

        private void btnIzvjestaj_Click(object sender, EventArgs e)
        {
            // new frmIzvjestaji().Show();
        }

        private void btnDrzaveGradovi_Click(object sender, EventArgs e)
        {
            frmDrzaveIB220155 frm = new frmDrzaveIB220155();
            frm.ShowDialog();
        }

        private void btnPretraga_Click(object sender, EventArgs e)
        {
            var frm = new frmPretragaIB220155();
            frm.ShowDialog();
        }
    }
}
