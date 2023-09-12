namespace TVP_Projekat
{
    partial class formaKupci
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
            this.btnGotovo = new System.Windows.Forms.Button();
            this.txtKorisnicko = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpRodjendan = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbPol = new System.Windows.Forms.ComboBox();
            this.txtLozinka = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGotovo
            // 
            this.btnGotovo.BackColor = System.Drawing.SystemColors.Window;
            this.btnGotovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGotovo.ForeColor = System.Drawing.Color.Black;
            this.btnGotovo.Location = new System.Drawing.Point(18, 365);
            this.btnGotovo.Margin = new System.Windows.Forms.Padding(5);
            this.btnGotovo.Name = "btnGotovo";
            this.btnGotovo.Size = new System.Drawing.Size(281, 37);
            this.btnGotovo.TabIndex = 26;
            this.btnGotovo.Text = "Potvrdi";
            this.btnGotovo.UseVisualStyleBackColor = false;
            this.btnGotovo.Click += new System.EventHandler(this.btnGotovo_Click);
            // 
            // txtKorisnicko
            // 
            this.txtKorisnicko.BackColor = System.Drawing.SystemColors.Window;
            this.txtKorisnicko.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKorisnicko.Location = new System.Drawing.Point(150, 70);
            this.txtKorisnicko.Margin = new System.Windows.Forms.Padding(5);
            this.txtKorisnicko.Name = "txtKorisnicko";
            this.txtKorisnicko.Size = new System.Drawing.Size(149, 33);
            this.txtKorisnicko.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 21);
            this.label6.TabIndex = 25;
            this.label6.Text = "Korisičko ime:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 329);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 21);
            this.label5.TabIndex = 24;
            this.label5.Text = "Pol:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.BackColor = System.Drawing.SystemColors.Window;
            this.txtTelefon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefon.Location = new System.Drawing.Point(150, 283);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(5);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(149, 33);
            this.txtTelefon.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(14, 285);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 21);
            this.label4.TabIndex = 22;
            this.label4.Text = "Telefon:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(14, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 21);
            this.label3.TabIndex = 21;
            this.label3.Text = "Datum rođenja:";
            // 
            // dtpRodjendan
            // 
            this.dtpRodjendan.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtpRodjendan.CalendarMonthBackground = System.Drawing.Color.MintCream;
            this.dtpRodjendan.CalendarTitleBackColor = System.Drawing.Color.DarkSeaGreen;
            this.dtpRodjendan.CalendarTitleForeColor = System.Drawing.Color.MediumSeaGreen;
            this.dtpRodjendan.CalendarTrailingForeColor = System.Drawing.Color.SeaGreen;
            this.dtpRodjendan.CustomFormat = "dd.MM.yyyy.";
            this.dtpRodjendan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRodjendan.Location = new System.Drawing.Point(150, 240);
            this.dtpRodjendan.Margin = new System.Windows.Forms.Padding(5);
            this.dtpRodjendan.Name = "dtpRodjendan";
            this.dtpRodjendan.Size = new System.Drawing.Size(149, 33);
            this.dtpRodjendan.TabIndex = 20;
            this.dtpRodjendan.Value = new System.DateTime(2000, 8, 10, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Prezime:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrezime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrezime.Location = new System.Drawing.Point(150, 197);
            this.txtPrezime.Margin = new System.Windows.Forms.Padding(5);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(149, 33);
            this.txtPrezime.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ime:";
            // 
            // txtIme
            // 
            this.txtIme.BackColor = System.Drawing.SystemColors.Window;
            this.txtIme.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIme.Location = new System.Drawing.Point(150, 154);
            this.txtIme.Margin = new System.Windows.Forms.Padding(5);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(149, 33);
            this.txtIme.TabIndex = 17;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Window;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(150, 25);
            this.txtId.Margin = new System.Windows.Forms.Padding(5);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(149, 33);
            this.txtId.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(14, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 21);
            this.label7.TabIndex = 29;
            this.label7.Text = "ID:";
            // 
            // cmbPol
            // 
            this.cmbPol.BackColor = System.Drawing.SystemColors.Window;
            this.cmbPol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPol.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPol.FormattingEnabled = true;
            this.cmbPol.Location = new System.Drawing.Point(150, 326);
            this.cmbPol.Margin = new System.Windows.Forms.Padding(5);
            this.cmbPol.Name = "cmbPol";
            this.cmbPol.Size = new System.Drawing.Size(149, 29);
            this.cmbPol.TabIndex = 30;
            // 
            // txtLozinka
            // 
            this.txtLozinka.BackColor = System.Drawing.SystemColors.Window;
            this.txtLozinka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLozinka.Location = new System.Drawing.Point(150, 111);
            this.txtLozinka.Margin = new System.Windows.Forms.Padding(5);
            this.txtLozinka.Name = "txtLozinka";
            this.txtLozinka.Size = new System.Drawing.Size(149, 33);
            this.txtLozinka.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(14, 113);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 21);
            this.label8.TabIndex = 32;
            this.label8.Text = "Lozinka:";
            // 
            // formaKupci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(313, 417);
            this.Controls.Add(this.txtLozinka);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbPol);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnGotovo);
            this.Controls.Add(this.txtKorisnicko);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpRodjendan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIme);
            this.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "formaKupci";
            this.Text = "Kupci";
            this.Load += new System.EventHandler(this.frmKupci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGotovo;
        private System.Windows.Forms.TextBox txtKorisnicko;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpRodjendan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPol;
        private System.Windows.Forms.TextBox txtLozinka;
        private System.Windows.Forms.Label label8;
    }
}