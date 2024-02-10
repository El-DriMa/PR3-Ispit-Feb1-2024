namespace FIT.WinForms.IB220155
{
    partial class frmIzvjestajIB220155
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Dock = DockStyle.Top;
            reportViewer1.LocalReport.ReportEmbeddedResource = "FIT.WinForms.Izvjestaji.rptUvjerenje.rdlc";
            reportViewer1.LocalReport.ReportPath = "";
            reportViewer1.Location = new Point(0, 0);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = null;
            reportViewer1.Size = new Size(870, 450);
            reportViewer1.TabIndex = 0;
            // 
            // frmIzvjestajIB220155
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 450);
            Controls.Add(reportViewer1);
            Name = "frmIzvjestajIB220155";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmIzvjestajIB220155";
            Load += frmIzvjestajIB220155_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}