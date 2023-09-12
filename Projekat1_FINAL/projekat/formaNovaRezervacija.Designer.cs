namespace TVP_Projekat
{
    partial class formaNovaRezervacija
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
            this.dtpPocetni = new System.Windows.Forms.DateTimePicker();
            this.dtpKrajnji = new System.Windows.Forms.DateTimePicker();
            this.cmbSala = new System.Windows.Forms.ComboBox();
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.nudBrMesta = new System.Windows.Forms.NumericUpDown();
            this.lbProjekcije = new System.Windows.Forms.ListBox();
            this.txtUkupnaCena = new System.Windows.Forms.TextBox();
            this.btnRezervisi = new System.Windows.Forms.Button();
            this.btnPrikaz = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrMesta)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpPocetni
            // 
            this.dtpPocetni.CustomFormat = "dd.MM.yyyy.";
            this.dtpPocetni.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPocetni.Location = new System.Drawing.Point(173, 16);
            this.dtpPocetni.Margin = new System.Windows.Forms.Padding(6);
            this.dtpPocetni.Name = "dtpPocetni";
            this.dtpPocetni.Size = new System.Drawing.Size(144, 38);
            this.dtpPocetni.TabIndex = 0;
            // 
            // dtpKrajnji
            // 
            this.dtpKrajnji.CustomFormat = "dd.MM.yyyy.";
            this.dtpKrajnji.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpKrajnji.Location = new System.Drawing.Point(173, 66);
            this.dtpKrajnji.Margin = new System.Windows.Forms.Padding(6);
            this.dtpKrajnji.Name = "dtpKrajnji";
            this.dtpKrajnji.Size = new System.Drawing.Size(144, 38);
            this.dtpKrajnji.TabIndex = 1;
            // 
            // cmbSala
            // 
            this.cmbSala.BackColor = System.Drawing.SystemColors.Window;
            this.cmbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSala.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Location = new System.Drawing.Point(173, 116);
            this.cmbSala.Margin = new System.Windows.Forms.Padding(6);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(144, 33);
            this.cmbSala.TabIndex = 2;
            // 
            // cmbFilm
            // 
            this.cmbFilm.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFilm.FormattingEnabled = true;
            this.cmbFilm.Location = new System.Drawing.Point(173, 161);
            this.cmbFilm.Margin = new System.Windows.Forms.Padding(6);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(144, 33);
            this.cmbFilm.TabIndex = 3;
            // 
            // nudBrMesta
            // 
            this.nudBrMesta.BackColor = System.Drawing.SystemColors.Window;
            this.nudBrMesta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudBrMesta.Location = new System.Drawing.Point(22, 294);
            this.nudBrMesta.Margin = new System.Windows.Forms.Padding(6);
            this.nudBrMesta.Name = "nudBrMesta";
            this.nudBrMesta.Size = new System.Drawing.Size(200, 38);
            this.nudBrMesta.TabIndex = 4;
            this.nudBrMesta.ValueChanged += new System.EventHandler(this.updateCena);
            // 
            // lbProjekcije
            // 
            this.lbProjekcije.BackColor = System.Drawing.SystemColors.Window;
            this.lbProjekcije.Font = new System.Drawing.Font("Yu Gothic", 12F);
            this.lbProjekcije.FormattingEnabled = true;
            this.lbProjekcije.ItemHeight = 21;
            this.lbProjekcije.Location = new System.Drawing.Point(329, 16);
            this.lbProjekcije.Margin = new System.Windows.Forms.Padding(6);
            this.lbProjekcije.Name = "lbProjekcije";
            this.lbProjekcije.Size = new System.Drawing.Size(532, 382);
            this.lbProjekcije.TabIndex = 5;
            this.lbProjekcije.SelectedValueChanged += new System.EventHandler(this.updateCena);
            // 
            // txtUkupnaCena
            // 
            this.txtUkupnaCena.BackColor = System.Drawing.SystemColors.Window;
            this.txtUkupnaCena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUkupnaCena.Enabled = false;
            this.txtUkupnaCena.Location = new System.Drawing.Point(24, 369);
            this.txtUkupnaCena.Margin = new System.Windows.Forms.Padding(6);
            this.txtUkupnaCena.Name = "txtUkupnaCena";
            this.txtUkupnaCena.ReadOnly = true;
            this.txtUkupnaCena.Size = new System.Drawing.Size(198, 38);
            this.txtUkupnaCena.TabIndex = 6;
            // 
            // btnRezervisi
            // 
            this.btnRezervisi.BackColor = System.Drawing.SystemColors.Window;
            this.btnRezervisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRezervisi.ForeColor = System.Drawing.Color.Black;
            this.btnRezervisi.Location = new System.Drawing.Point(24, 419);
            this.btnRezervisi.Margin = new System.Windows.Forms.Padding(6);
            this.btnRezervisi.Name = "btnRezervisi";
            this.btnRezervisi.Size = new System.Drawing.Size(837, 69);
            this.btnRezervisi.TabIndex = 7;
            this.btnRezervisi.Text = "Potvrdi";
            this.btnRezervisi.UseVisualStyleBackColor = false;
            this.btnRezervisi.Click += new System.EventHandler(this.btnRezervisi_Click);
            // 
            // btnPrikaz
            // 
            this.btnPrikaz.BackColor = System.Drawing.SystemColors.Window;
            this.btnPrikaz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrikaz.ForeColor = System.Drawing.Color.Black;
            this.btnPrikaz.Location = new System.Drawing.Point(22, 206);
            this.btnPrikaz.Margin = new System.Windows.Forms.Padding(6);
            this.btnPrikaz.Name = "btnPrikaz";
            this.btnPrikaz.Size = new System.Drawing.Size(295, 51);
            this.btnPrikaz.TabIndex = 8;
            this.btnPrikaz.Text = "Prikaži dostupne projekcije";
            this.btnPrikaz.UseVisualStyleBackColor = false;
            this.btnPrikaz.Click += new System.EventHandler(this.btnPrikaz_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(15, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Broj mesta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(19, 338);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ukupna cena:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(15, 25);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 25);
            this.label7.TabIndex = 9;
            this.label7.Text = "Pocetni datum:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(15, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "Krajnji datum:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(17, 119);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Sala:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(15, 164);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 25);
            this.label10.TabIndex = 12;
            this.label10.Text = "Naziv:";
            // 
            // formaNovaRezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(875, 511);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPrikaz);
            this.Controls.Add(this.btnRezervisi);
            this.Controls.Add(this.txtUkupnaCena);
            this.Controls.Add(this.lbProjekcije);
            this.Controls.Add(this.nudBrMesta);
            this.Controls.Add(this.cmbFilm);
            this.Controls.Add(this.cmbSala);
            this.Controls.Add(this.dtpKrajnji);
            this.Controls.Add(this.dtpPocetni);
            this.Font = new System.Drawing.Font("Yu Gothic", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "formaNovaRezervacija";
            this.Text = "Nova Rezervacija";
            this.Load += new System.EventHandler(this.formaNovaRezervacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBrMesta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpPocetni;
        private System.Windows.Forms.DateTimePicker dtpKrajnji;
        private System.Windows.Forms.ComboBox cmbSala;
        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.NumericUpDown nudBrMesta;
        private System.Windows.Forms.ListBox lbProjekcije;
        private System.Windows.Forms.TextBox txtUkupnaCena;
        private System.Windows.Forms.Button btnRezervisi;
        private System.Windows.Forms.Button btnPrikaz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}