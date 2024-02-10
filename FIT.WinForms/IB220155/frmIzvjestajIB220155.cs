using FIT.Data.IB220155;
using FIT.Infrastructure;
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
        DLWMSDbContext db = KonekcijaNaBazuIB220155.baza;
        DrzavaIB220155 drzava;
        List<GradIB220155> listaGradova;
        public frmIzvjestajIB220155(DrzavaIB220155 drzava)
        {
            InitializeComponent();
            this.drzava = drzava;
        }

        private void frmIzvjestajIB220155_Load(object sender, EventArgs e)
        {
            var brGradova = db.GradoviIB220155.Count(x => x.Drzava == drzava);
            var rpc = new ReportParameterCollection();
            var rp = new ReportParameter("pBrGradova", brGradova.ToString());
            rpc.Add(rp);

            listaGradova = db.GradoviIB220155.Where(x => x.Drzava == drzava).ToList();

            var tabela = new List<object>();
            for(int i = 0; i < brGradova; i++)
            {
                tabela.Add(new
                {
                    Rb=(i+1).ToString(),
                    Grad = listaGradova[i].ToString(),
                    Drzava=drzava.ToString(),
                    Aktivan = listaGradova[i].Status==true?"DA":"NE",
                });
            }

            var rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = tabela;

            reportViewer1.LocalReport.SetParameters(rpc);
            reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
