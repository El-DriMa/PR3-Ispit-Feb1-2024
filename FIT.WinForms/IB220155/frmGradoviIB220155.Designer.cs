namespace FIT.WinForms.IB220155
{
    partial class frmGradoviIB220155
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
            pbZastava = new PictureBox();
            lblNazivDrzave = new Label();
            label2 = new Label();
            txtNazivGrada = new TextBox();
            dgvGradovi = new DataGridView();
            NazivGrada = new DataGridViewTextBoxColumn();
            Aktivan = new DataGridViewCheckBoxColumn();
            PromijeniStatus = new DataGridViewButtonColumn();
            btnDodajGrad = new Button();
            groupBox1 = new GroupBox();
            txtIspis = new TextBox();
            btnGenerisi = new Button();
            chkAktivnostGrada = new CheckBox();
            txtBrGradova = new TextBox();
            label3 = new Label();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(21, 25);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(133, 69);
            pbZastava.SizeMode = PictureBoxSizeMode.Zoom;
            pbZastava.TabIndex = 0;
            pbZastava.TabStop = false;
            // 
            // lblNazivDrzave
            // 
            lblNazivDrzave.AutoSize = true;
            lblNazivDrzave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblNazivDrzave.Location = new Point(184, 51);
            lblNazivDrzave.Name = "lblNazivDrzave";
            lblNazivDrzave.Size = new Size(66, 28);
            lblNazivDrzave.TabIndex = 1;
            lblNazivDrzave.Text = "Naziv";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 131);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 2;
            label2.Text = "Naziv novog grada :";
            // 
            // txtNazivGrada
            // 
            txtNazivGrada.Location = new Point(162, 128);
            txtNazivGrada.Name = "txtNazivGrada";
            txtNazivGrada.Size = new Size(313, 27);
            txtNazivGrada.TabIndex = 3;
            // 
            // dgvGradovi
            // 
            dgvGradovi.AllowUserToAddRows = false;
            dgvGradovi.AllowUserToDeleteRows = false;
            dgvGradovi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGradovi.Columns.AddRange(new DataGridViewColumn[] { NazivGrada, Aktivan, PromijeniStatus });
            dgvGradovi.Location = new Point(21, 180);
            dgvGradovi.Name = "dgvGradovi";
            dgvGradovi.ReadOnly = true;
            dgvGradovi.RowHeadersWidth = 51;
            dgvGradovi.RowTemplate.Height = 29;
            dgvGradovi.Size = new Size(569, 188);
            dgvGradovi.TabIndex = 4;
            dgvGradovi.CellClick += dgvGradovi_CellClick;
            // 
            // NazivGrada
            // 
            NazivGrada.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NazivGrada.DataPropertyName = "Naziv";
            NazivGrada.HeaderText = "Naziv grada";
            NazivGrada.MinimumWidth = 6;
            NazivGrada.Name = "NazivGrada";
            NazivGrada.ReadOnly = true;
            // 
            // Aktivan
            // 
            Aktivan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Aktivan.DataPropertyName = "Status";
            Aktivan.HeaderText = "Aktivan";
            Aktivan.MinimumWidth = 6;
            Aktivan.Name = "Aktivan";
            Aktivan.ReadOnly = true;
            Aktivan.Resizable = DataGridViewTriState.True;
            Aktivan.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // PromijeniStatus
            // 
            PromijeniStatus.HeaderText = "";
            PromijeniStatus.MinimumWidth = 6;
            PromijeniStatus.Name = "PromijeniStatus";
            PromijeniStatus.ReadOnly = true;
            PromijeniStatus.Text = "Promijeni status";
            PromijeniStatus.UseColumnTextForButtonValue = true;
            PromijeniStatus.Width = 125;
            // 
            // btnDodajGrad
            // 
            btnDodajGrad.Location = new Point(496, 131);
            btnDodajGrad.Name = "btnDodajGrad";
            btnDodajGrad.Size = new Size(94, 29);
            btnDodajGrad.TabIndex = 5;
            btnDodajGrad.Text = "Dodaj";
            btnDodajGrad.UseVisualStyleBackColor = true;
            btnDodajGrad.Click += btnDodajGrad_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtIspis);
            groupBox1.Controls.Add(btnGenerisi);
            groupBox1.Controls.Add(chkAktivnostGrada);
            groupBox1.Controls.Add(txtBrGradova);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(21, 400);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(569, 199);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Generator";
            // 
            // txtIspis
            // 
            txtIspis.Location = new Point(8, 85);
            txtIspis.Multiline = true;
            txtIspis.Name = "txtIspis";
            txtIspis.Size = new Size(544, 108);
            txtIspis.TabIndex = 8;
            // 
            // btnGenerisi
            // 
            btnGenerisi.Location = new Point(458, 27);
            btnGenerisi.Name = "btnGenerisi";
            btnGenerisi.Size = new Size(94, 29);
            btnGenerisi.TabIndex = 7;
            btnGenerisi.Text = "Generisi";
            btnGenerisi.UseVisualStyleBackColor = true;
            btnGenerisi.Click += btnGenerisi_Click;
            // 
            // chkAktivnostGrada
            // 
            chkAktivnostGrada.AutoSize = true;
            chkAktivnostGrada.Location = new Point(256, 35);
            chkAktivnostGrada.Name = "chkAktivnostGrada";
            chkAktivnostGrada.Size = new Size(80, 24);
            chkAktivnostGrada.TabIndex = 2;
            chkAktivnostGrada.Text = "Aktivan";
            chkAktivnostGrada.UseVisualStyleBackColor = true;
            // 
            // txtBrGradova
            // 
            txtBrGradova.Location = new Point(114, 32);
            txtBrGradova.Name = "txtBrGradova";
            txtBrGradova.Size = new Size(125, 27);
            txtBrGradova.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 32);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 0;
            label3.Text = "Broj gradova :";
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmGradoviIB220155
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 611);
            Controls.Add(groupBox1);
            Controls.Add(btnDodajGrad);
            Controls.Add(dgvGradovi);
            Controls.Add(txtNazivGrada);
            Controls.Add(label2);
            Controls.Add(lblNazivDrzave);
            Controls.Add(pbZastava);
            Name = "frmGradoviIB220155";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Podaci o gradovima ";
            Load += frmGradoviIB220155_Load;
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGradovi).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbZastava;
        private Label lblNazivDrzave;
        private Label label2;
        private TextBox txtNazivGrada;
        private DataGridView dgvGradovi;
        private Button btnDodajGrad;
        private GroupBox groupBox1;
        private TextBox txtIspis;
        private Button btnGenerisi;
        private CheckBox chkAktivnostGrada;
        private TextBox txtBrGradova;
        private Label label3;
        private DataGridViewTextBoxColumn NazivGrada;
        private DataGridViewCheckBoxColumn Aktivan;
        private DataGridViewButtonColumn PromijeniStatus;
        private ErrorProvider err;
    }
}