namespace FIT.WinForms.IB220155
{
    partial class frmNovaDrzavaIB220155
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
            label1 = new Label();
            label2 = new Label();
            txtNaziv = new TextBox();
            checkBox1 = new CheckBox();
            btnSpasi = new Button();
            err = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)pbZastava).BeginInit();
            ((System.ComponentModel.ISupportInitialize)err).BeginInit();
            SuspendLayout();
            // 
            // pbZastava
            // 
            pbZastava.Location = new Point(36, 50);
            pbZastava.Name = "pbZastava";
            pbZastava.Size = new Size(334, 183);
            pbZastava.SizeMode = PictureBoxSizeMode.Zoom;
            pbZastava.TabIndex = 0;
            pbZastava.TabStop = false;
            pbZastava.DoubleClick += pbZastava_DoubleClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 27);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 1;
            label1.Text = "Zastava :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 250);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Naziv";
            // 
            // txtNaziv
            // 
            txtNaziv.Location = new Point(36, 273);
            txtNaziv.Name = "txtNaziv";
            txtNaziv.Size = new Size(334, 27);
            txtNaziv.TabIndex = 3;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(36, 320);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(80, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Aktivna";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnSpasi
            // 
            btnSpasi.Location = new Point(276, 320);
            btnSpasi.Name = "btnSpasi";
            btnSpasi.Size = new Size(94, 29);
            btnSpasi.TabIndex = 5;
            btnSpasi.Text = "Spasi";
            btnSpasi.UseVisualStyleBackColor = true;
            btnSpasi.Click += btnSpasi_Click;
            // 
            // err
            // 
            err.ContainerControl = this;
            // 
            // frmNovaDrzavaIB220155
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 400);
            Controls.Add(btnSpasi);
            Controls.Add(checkBox1);
            Controls.Add(txtNaziv);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pbZastava);
            Name = "frmNovaDrzavaIB220155";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Podaci o drzavi";
            Load += frmNovaDrzavaIB220155_Load;
            ((System.ComponentModel.ISupportInitialize)pbZastava).EndInit();
            ((System.ComponentModel.ISupportInitialize)err).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbZastava;
        private Label label1;
        private Label label2;
        private TextBox txtNaziv;
        private CheckBox checkBox1;
        private Button btnSpasi;
        private ErrorProvider err;
    }
}