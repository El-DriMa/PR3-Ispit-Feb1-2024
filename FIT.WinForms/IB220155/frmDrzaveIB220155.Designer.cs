namespace FIT.WinForms.IB220155
{
    partial class frmDrzaveIB220155
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
            components = new System.ComponentModel.Container();
            dgvDrzave = new DataGridView();
            Zastava = new DataGridViewImageColumn();
            Drzava = new DataGridViewTextBoxColumn();
            BrojGradova = new DataGridViewTextBoxColumn();
            Aktivna = new DataGridViewCheckBoxColumn();
            Gradovi = new DataGridViewButtonColumn();
            btnNovaDrzava = new Button();
            btnPrintaj = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lblTrenutnoVrijeme = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDrzave).BeginInit();
            SuspendLayout();
            // 
            // dgvDrzave
            // 
            dgvDrzave.AllowUserToAddRows = false;
            dgvDrzave.AllowUserToDeleteRows = false;
            dgvDrzave.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrzave.Columns.AddRange(new DataGridViewColumn[] { Zastava, Drzava, BrojGradova, Aktivna, Gradovi });
            dgvDrzave.Location = new Point(25, 109);
            dgvDrzave.Name = "dgvDrzave";
            dgvDrzave.ReadOnly = true;
            dgvDrzave.RowHeadersWidth = 51;
            dgvDrzave.RowTemplate.Height = 29;
            dgvDrzave.Size = new Size(763, 188);
            dgvDrzave.TabIndex = 0;
            dgvDrzave.CellContentClick += dgvDrzave_CellContentClick;
            dgvDrzave.CellDoubleClick += dgvDrzave_CellDoubleClick;
            // 
            // Zastava
            // 
            Zastava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Zastava.DataPropertyName = "Zastava";
            Zastava.HeaderText = "Zastava";
            Zastava.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Zastava.MinimumWidth = 6;
            Zastava.Name = "Zastava";
            Zastava.ReadOnly = true;
            // 
            // Drzava
            // 
            Drzava.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Drzava.DataPropertyName = "Naziv";
            Drzava.HeaderText = "Drzava";
            Drzava.MinimumWidth = 6;
            Drzava.Name = "Drzava";
            Drzava.ReadOnly = true;
            Drzava.Resizable = DataGridViewTriState.True;
            Drzava.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // BrojGradova
            // 
            BrojGradova.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BrojGradova.DataPropertyName = "BrojGradova";
            BrojGradova.HeaderText = "Broj gradova";
            BrojGradova.MinimumWidth = 6;
            BrojGradova.Name = "BrojGradova";
            BrojGradova.ReadOnly = true;
            // 
            // Aktivna
            // 
            Aktivna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivna.DataPropertyName = "Status";
            Aktivna.HeaderText = "Aktivna";
            Aktivna.MinimumWidth = 6;
            Aktivna.Name = "Aktivna";
            Aktivna.ReadOnly = true;
            // 
            // Gradovi
            // 
            Gradovi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Gradovi.HeaderText = "";
            Gradovi.MinimumWidth = 6;
            Gradovi.Name = "Gradovi";
            Gradovi.ReadOnly = true;
            Gradovi.Text = "Gradovi";
            Gradovi.UseColumnTextForButtonValue = true;
            // 
            // btnNovaDrzava
            // 
            btnNovaDrzava.Location = new Point(633, 74);
            btnNovaDrzava.Name = "btnNovaDrzava";
            btnNovaDrzava.Size = new Size(155, 29);
            btnNovaDrzava.TabIndex = 1;
            btnNovaDrzava.Text = "Nova drzava";
            btnNovaDrzava.UseVisualStyleBackColor = true;
            btnNovaDrzava.Click += btnNovaDrzava_Click;
            // 
            // btnPrintaj
            // 
            btnPrintaj.Location = new Point(694, 313);
            btnPrintaj.Name = "btnPrintaj";
            btnPrintaj.Size = new Size(94, 29);
            btnPrintaj.TabIndex = 2;
            btnPrintaj.Text = "Printaj";
            btnPrintaj.UseVisualStyleBackColor = true;
            btnPrintaj.Click += btnPrintaj_Click;
            // 
            // lblTrenutnoVrijeme
            // 
            lblTrenutnoVrijeme.AutoSize = true;
            lblTrenutnoVrijeme.Location = new Point(25, 377);
            lblTrenutnoVrijeme.Name = "lblTrenutnoVrijeme";
            lblTrenutnoVrijeme.Size = new Size(124, 20);
            lblTrenutnoVrijeme.TabIndex = 3;
            lblTrenutnoVrijeme.Text = "Trenutno vrijeme ";
            // 
            // frmDrzaveIB220155
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 412);
            Controls.Add(lblTrenutnoVrijeme);
            Controls.Add(btnPrintaj);
            Controls.Add(btnNovaDrzava);
            Controls.Add(dgvDrzave);
            Name = "frmDrzaveIB220155";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Drzave";
            Load += frmDrzaveIB220155_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDrzave).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDrzave;
        private Button btnNovaDrzava;
        private Button btnPrintaj;
        private DataGridViewImageColumn Zastava;
        private DataGridViewTextBoxColumn Drzava;
        private DataGridViewTextBoxColumn BrojGradova;
        private DataGridViewCheckBoxColumn Aktivna;
        private DataGridViewButtonColumn Gradovi;
        private System.Windows.Forms.Timer timer1;
        private Label lblTrenutnoVrijeme;
    }
}