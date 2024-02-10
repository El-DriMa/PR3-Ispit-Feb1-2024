namespace FIT.WinForms.Izvjestaji
{
    public partial class frmIzvjestajiIB : Form
    {

        public frmIzvjestajiIB()
        {
            InitializeComponent();
        }

        private void frmIzvjestaji_Load(object sender, EventArgs e)
        {

            reportViewer1.RefreshReport();
        }
    }
}
