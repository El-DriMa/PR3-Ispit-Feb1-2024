using FIT.Data.IB220155;
using Microsoft.Reporting.WinForms;
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
    public partial class frmIzvjestajIB220155 : Form
    {
        DrzavaIB220155 drzava;
        public frmIzvjestajIB220155(DrzavaIB220155 drzava)
        {
            InitializeComponent();
            this.drzava = drzava;
        }

        private void frmIzvjestajIB220155_Load(object sender, EventArgs e)
        {
            //reportViewer1.LocalReport.ReportPath = "../../rptUvjerenjeIB220155.rdlc";
            this.reportViewer1.RefreshReport();
        }
    }
}
