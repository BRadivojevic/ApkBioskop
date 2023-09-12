namespace TVP_Projekat
{
    partial class formaAdmin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filmoviIzbrisi = new System.Windows.Forms.Button();
            this.filmoviEdituj = new System.Windows.Forms.Button();
            this.filmoviDodaj = new System.Windows.Forms.Button();
            this.lbFilmovi = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saleIzbrisi = new System.Windows.Forms.Button();
            this.saleEdituj = new System.Windows.Forms.Button();
            this.saleDodaj = new System.Windows.Forms.Button();
            this.lbSale = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.projekcijeIzbrisi = new System.Windows.Forms.Button();
            this.projekcijeEdituj = new System.Windows.Forms.Button();
            this.projekcijeDodaj = new System.Windows.Forms.Button();
            this.lbProjekcije = new System.Windows.Forms.ListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbKupci = new System.Windows.Forms.ComboBox();
            this.rezervacijeIzbrisi = new System.Windows.Forms.Button();
            this.rezervacijeEdituj = new System.Windows.Forms.Button();
            this.rezervacijeDodaj = new System.Windows.Forms.Button();
            this.lbRezervacije = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.kupciIzbrisi = new System.Windows.Forms.Button();
            this.kupciEdituj = new System.Windows.Forms.Button();
            this.kupciDodaj = new System.Windows.Forms.Button();
            this.lbKupci = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.filmoviIzbrisi);
            this.groupBox1.Controls.Add(this.filmoviEdituj);
            this.groupBox1.Controls.Add(this.filmoviDodaj);
            this.groupBox1.Controls.Add(this.lbFilmovi);
            this.groupBox1.Font = new System.Drawing.Font("Yu Gothic", 9.75F);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(568, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filmovi:";
            // 
            // filmoviIzbrisi
            // 
            this.filmoviIzbrisi.BackColor = System.Drawing.SystemColors.Window;
            this.filmoviIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filmoviIzbrisi.ForeColor = System.Drawing.Color.Black;
            this.filmoviIzbrisi.Location = new System.Drawing.Point(200, 126);
            this.filmoviIzbrisi.Margin = new System.Windows.Forms.Padding(4);
            this.filmoviIzbrisi.Name = "filmoviIzbrisi";
            this.filmoviIzbrisi.Size = new System.Drawing.Size(78, 25);
            this.filmoviIzbrisi.TabIndex = 3;
            this.filmoviIzbrisi.Text = "Izbriši";
            this.filmoviIzbrisi.UseVisualStyleBackColor = false;
            this.filmoviIzbrisi.Click += new System.EventHandler(this.filmoviIzbrisi_Click);
            // 
            // filmoviEdituj
            // 
            this.filmoviEdituj.BackColor = System.Drawing.SystemColors.Window;
            this.filmoviEdituj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filmoviEdituj.ForeColor = System.Drawing.Color.Black;
            this.filmoviEdituj.Location = new System.Drawing.Point(114, 126);
            this.filmoviEdituj.Margin = new System.Windows.Forms.Padding(4);
            this.filmoviEdituj.Name = "filmoviEdituj";
            this.filmoviEdituj.Size = new System.Drawing.Size(78, 25);
            this.filmoviEdituj.TabIndex = 2;
            this.filmoviEdituj.Text = "Edituj";
            this.filmoviEdituj.UseVisualStyleBackColor = false;
            this.filmoviEdituj.Click += new System.EventHandler(this.filmoviEdituj_Click);
            // 
            // filmoviDodaj
            // 
            this.filmoviDodaj.BackColor = System.Drawing.SystemColors.Window;
            this.filmoviDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filmoviDodaj.ForeColor = System.Drawing.Color.Black;
            this.filmoviDodaj.Location = new System.Drawing.Point(28, 126);
            this.filmoviDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.filmoviDodaj.Name = "filmoviDodaj";
            this.filmoviDodaj.Size = new System.Drawing.Size(78, 25);
            this.filmoviDodaj.TabIndex = 1;
            this.filmoviDodaj.Text = "Dodaj";
            this.filmoviDodaj.UseVisualStyleBackColor = false;
            this.filmoviDodaj.Click += new System.EventHandler(this.filmoviDodaj_Click);
            // 
            // lbFilmovi
            // 
            this.lbFilmovi.BackColor = System.Drawing.SystemColors.Window;
            this.lbFilmovi.FormattingEnabled = true;
            this.lbFilmovi.HorizontalScrollbar = true;
            this.lbFilmovi.ItemHeight = 17;
            this.lbFilmovi.Location = new System.Drawing.Point(28, 29);
            this.lbFilmovi.Margin = new System.Windows.Forms.Padding(4);
            this.lbFilmovi.Name = "lbFilmovi";
            this.lbFilmovi.Size = new System.Drawing.Size(524, 89);
            this.lbFilmovi.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox2.Controls.Add(this.saleIzbrisi);
            this.groupBox2.Controls.Add(this.saleEdituj);
            this.groupBox2.Controls.Add(this.saleDodaj);
            this.groupBox2.Controls.Add(this.lbSale);
            this.groupBox2.Font = new System.Drawing.Font("Yu Gothic", 9.75F);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(15, 516);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(568, 160);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sale:";
            // 
            // saleIzbrisi
            // 
            this.saleIzbrisi.BackColor = System.Drawing.SystemColors.Window;
            this.saleIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saleIzbrisi.ForeColor = System.Drawing.Color.Black;
            this.saleIzbrisi.Location = new System.Drawing.Point(200, 127);
            this.saleIzbrisi.Margin = new System.Windows.Forms.Padding(4);
            this.saleIzbrisi.Name = "saleIzbrisi";
            this.saleIzbrisi.Size = new System.Drawing.Size(78, 25);
            this.saleIzbrisi.TabIndex = 3;
            this.saleIzbrisi.Text = "Izbriši";
            this.saleIzbrisi.UseVisualStyleBackColor = false;
            this.saleIzbrisi.Click += new System.EventHandler(this.saleIzbrisi_Click);
            // 
            // saleEdituj
            // 
            this.saleEdituj.BackColor = System.Drawing.SystemColors.Window;
            this.saleEdituj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saleEdituj.ForeColor = System.Drawing.Color.Black;
            this.saleEdituj.Location = new System.Drawing.Point(114, 127);
            this.saleEdituj.Margin = new System.Windows.Forms.Padding(4);
            this.saleEdituj.Name = "saleEdituj";
            this.saleEdituj.Size = new System.Drawing.Size(78, 25);
            this.saleEdituj.TabIndex = 2;
            this.saleEdituj.Text = "Edituj";
            this.saleEdituj.UseVisualStyleBackColor = false;
            this.saleEdituj.Click += new System.EventHandler(this.saleEdituj_Click);
            // 
            // saleDodaj
            // 
            this.saleDodaj.BackColor = System.Drawing.SystemColors.Window;
            this.saleDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saleDodaj.ForeColor = System.Drawing.Color.Black;
            this.saleDodaj.Location = new System.Drawing.Point(28, 127);
            this.saleDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.saleDodaj.Name = "saleDodaj";
            this.saleDodaj.Size = new System.Drawing.Size(78, 25);
            this.saleDodaj.TabIndex = 1;
            this.saleDodaj.Text = "Dodaj";
            this.saleDodaj.UseVisualStyleBackColor = false;
            this.saleDodaj.Click += new System.EventHandler(this.saleDodaj_Click);
            // 
            // lbSale
            // 
            this.lbSale.BackColor = System.Drawing.SystemColors.Window;
            this.lbSale.FormattingEnabled = true;
            this.lbSale.ItemHeight = 17;
            this.lbSale.Location = new System.Drawing.Point(24, 30);
            this.lbSale.Margin = new System.Windows.Forms.Padding(4);
            this.lbSale.Name = "lbSale";
            this.lbSale.Size = new System.Drawing.Size(524, 89);
            this.lbSale.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox3.Controls.Add(this.projekcijeIzbrisi);
            this.groupBox3.Controls.Add(this.projekcijeEdituj);
            this.groupBox3.Controls.Add(this.projekcijeDodaj);
            this.groupBox3.Controls.Add(this.lbProjekcije);
            this.groupBox3.Font = new System.Drawing.Font("Yu Gothic", 9.75F);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(15, 181);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(568, 160);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Projekcije:";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // projekcijeIzbrisi
            // 
            this.projekcijeIzbrisi.BackColor = System.Drawing.SystemColors.Window;
            this.projekcijeIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.projekcijeIzbrisi.ForeColor = System.Drawing.Color.Black;
            this.projekcijeIzbrisi.Location = new System.Drawing.Point(200, 124);
            this.projekcijeIzbrisi.Margin = new System.Windows.Forms.Padding(4);
            this.projekcijeIzbrisi.Name = "projekcijeIzbrisi";
            this.projekcijeIzbrisi.Size = new System.Drawing.Size(78, 25);
            this.projekcijeIzbrisi.TabIndex = 3;
            this.projekcijeIzbrisi.Text = "Izbriši";
            this.projekcijeIzbrisi.UseVisualStyleBackColor = false;
            this.projekcijeIzbrisi.Click += new System.EventHandler(this.projekcijeIzbrisi_Click);
            // 
            // projekcijeEdituj
            // 
            this.projekcijeEdituj.BackColor = System.Drawing.SystemColors.Window;
            this.projekcijeEdituj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.projekcijeEdituj.ForeColor = System.Drawing.Color.Black;
            this.projekcijeEdituj.Location = new System.Drawing.Point(114, 124);
            this.projekcijeEdituj.Margin = new System.Windows.Forms.Padding(4);
            this.projekcijeEdituj.Name = "projekcijeEdituj";
            this.projekcijeEdituj.Size = new System.Drawing.Size(78, 25);
            this.projekcijeEdituj.TabIndex = 2;
            this.projekcijeEdituj.Text = "Edituj";
            this.projekcijeEdituj.UseVisualStyleBackColor = false;
            this.projekcijeEdituj.Click += new System.EventHandler(this.projekcijeEdituj_Click);
            // 
            // projekcijeDodaj
            // 
            this.projekcijeDodaj.BackColor = System.Drawing.SystemColors.Window;
            this.projekcijeDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.projekcijeDodaj.ForeColor = System.Drawing.Color.Black;
            this.projekcijeDodaj.Location = new System.Drawing.Point(28, 124);
            this.projekcijeDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.projekcijeDodaj.Name = "projekcijeDodaj";
            this.projekcijeDodaj.Size = new System.Drawing.Size(78, 25);
            this.projekcijeDodaj.TabIndex = 1;
            this.projekcijeDodaj.Text = "Dodaj";
            this.projekcijeDodaj.UseVisualStyleBackColor = false;
            this.projekcijeDodaj.Click += new System.EventHandler(this.projekcijeDodaj_Click);
            // 
            // lbProjekcije
            // 
            this.lbProjekcije.BackColor = System.Drawing.SystemColors.Window;
            this.lbProjekcije.FormattingEnabled = true;
            this.lbProjekcije.ItemHeight = 17;
            this.lbProjekcije.Location = new System.Drawing.Point(24, 27);
            this.lbProjekcije.Margin = new System.Windows.Forms.Padding(4);
            this.lbProjekcije.Name = "lbProjekcije";
            this.lbProjekcije.Size = new System.Drawing.Size(524, 89);
            this.lbProjekcije.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox4.Controls.Add(this.cmbKupci);
            this.groupBox4.Controls.Add(this.rezervacijeIzbrisi);
            this.groupBox4.Controls.Add(this.rezervacijeEdituj);
            this.groupBox4.Controls.Add(this.rezervacijeDodaj);
            this.groupBox4.Controls.Add(this.lbRezervacije);
            this.groupBox4.Font = new System.Drawing.Font("Yu Gothic", 9.75F);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(15, 684);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(568, 160);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Rezervacije:";
            // 
            // cmbKupci
            // 
            this.cmbKupci.BackColor = System.Drawing.SystemColors.Window;
            this.cmbKupci.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKupci.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbKupci.ForeColor = System.Drawing.Color.Black;
            this.cmbKupci.FormattingEnabled = true;
            this.cmbKupci.Location = new System.Drawing.Point(21, 20);
            this.cmbKupci.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKupci.Name = "cmbKupci";
            this.cmbKupci.Size = new System.Drawing.Size(539, 25);
            this.cmbKupci.TabIndex = 4;
            this.cmbKupci.SelectedIndexChanged += new System.EventHandler(this.FilterList);
            // 
            // rezervacijeIzbrisi
            // 
            this.rezervacijeIzbrisi.BackColor = System.Drawing.SystemColors.Window;
            this.rezervacijeIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rezervacijeIzbrisi.ForeColor = System.Drawing.Color.Black;
            this.rezervacijeIzbrisi.Location = new System.Drawing.Point(200, 127);
            this.rezervacijeIzbrisi.Margin = new System.Windows.Forms.Padding(4);
            this.rezervacijeIzbrisi.Name = "rezervacijeIzbrisi";
            this.rezervacijeIzbrisi.Size = new System.Drawing.Size(78, 25);
            this.rezervacijeIzbrisi.TabIndex = 3;
            this.rezervacijeIzbrisi.Text = "Izbriši";
            this.rezervacijeIzbrisi.UseVisualStyleBackColor = false;
            this.rezervacijeIzbrisi.Click += new System.EventHandler(this.rezervacijeIzbrisi_Click);
            // 
            // rezervacijeEdituj
            // 
            this.rezervacijeEdituj.BackColor = System.Drawing.SystemColors.Window;
            this.rezervacijeEdituj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rezervacijeEdituj.ForeColor = System.Drawing.Color.Black;
            this.rezervacijeEdituj.Location = new System.Drawing.Point(114, 127);
            this.rezervacijeEdituj.Margin = new System.Windows.Forms.Padding(4);
            this.rezervacijeEdituj.Name = "rezervacijeEdituj";
            this.rezervacijeEdituj.Size = new System.Drawing.Size(78, 25);
            this.rezervacijeEdituj.TabIndex = 2;
            this.rezervacijeEdituj.Text = "Edituj";
            this.rezervacijeEdituj.UseVisualStyleBackColor = false;
            this.rezervacijeEdituj.Click += new System.EventHandler(this.rezervacijeEdituj_Click);
            // 
            // rezervacijeDodaj
            // 
            this.rezervacijeDodaj.BackColor = System.Drawing.SystemColors.Window;
            this.rezervacijeDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rezervacijeDodaj.ForeColor = System.Drawing.Color.Black;
            this.rezervacijeDodaj.Location = new System.Drawing.Point(28, 127);
            this.rezervacijeDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.rezervacijeDodaj.Name = "rezervacijeDodaj";
            this.rezervacijeDodaj.Size = new System.Drawing.Size(78, 25);
            this.rezervacijeDodaj.TabIndex = 1;
            this.rezervacijeDodaj.Text = "Dodaj";
            this.rezervacijeDodaj.UseVisualStyleBackColor = false;
            this.rezervacijeDodaj.Click += new System.EventHandler(this.rezervacijeDodaj_Click);
            // 
            // lbRezervacije
            // 
            this.lbRezervacije.BackColor = System.Drawing.SystemColors.Window;
            this.lbRezervacije.FormattingEnabled = true;
            this.lbRezervacije.ItemHeight = 17;
            this.lbRezervacije.Location = new System.Drawing.Point(21, 20);
            this.lbRezervacije.Margin = new System.Windows.Forms.Padding(4);
            this.lbRezervacije.Name = "lbRezervacije";
            this.lbRezervacije.Size = new System.Drawing.Size(539, 106);
            this.lbRezervacije.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox5.Controls.Add(this.kupciIzbrisi);
            this.groupBox5.Controls.Add(this.kupciEdituj);
            this.groupBox5.Controls.Add(this.kupciDodaj);
            this.groupBox5.Controls.Add(this.lbKupci);
            this.groupBox5.Font = new System.Drawing.Font("Yu Gothic", 9.75F);
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(15, 348);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(568, 160);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Kupci:";
            // 
            // kupciIzbrisi
            // 
            this.kupciIzbrisi.BackColor = System.Drawing.SystemColors.Window;
            this.kupciIzbrisi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kupciIzbrisi.ForeColor = System.Drawing.Color.Black;
            this.kupciIzbrisi.Location = new System.Drawing.Point(200, 126);
            this.kupciIzbrisi.Margin = new System.Windows.Forms.Padding(4);
            this.kupciIzbrisi.Name = "kupciIzbrisi";
            this.kupciIzbrisi.Size = new System.Drawing.Size(78, 25);
            this.kupciIzbrisi.TabIndex = 3;
            this.kupciIzbrisi.Text = "Izbriši";
            this.kupciIzbrisi.UseVisualStyleBackColor = false;
            this.kupciIzbrisi.Click += new System.EventHandler(this.kupciIzbrisi_Click);
            // 
            // kupciEdituj
            // 
            this.kupciEdituj.BackColor = System.Drawing.SystemColors.Window;
            this.kupciEdituj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kupciEdituj.ForeColor = System.Drawing.Color.Black;
            this.kupciEdituj.Location = new System.Drawing.Point(114, 126);
            this.kupciEdituj.Margin = new System.Windows.Forms.Padding(4);
            this.kupciEdituj.Name = "kupciEdituj";
            this.kupciEdituj.Size = new System.Drawing.Size(78, 25);
            this.kupciEdituj.TabIndex = 2;
            this.kupciEdituj.Text = "Edituj";
            this.kupciEdituj.UseVisualStyleBackColor = false;
            this.kupciEdituj.Click += new System.EventHandler(this.kupciEdituj_Click);
            // 
            // kupciDodaj
            // 
            this.kupciDodaj.BackColor = System.Drawing.SystemColors.Window;
            this.kupciDodaj.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.kupciDodaj.ForeColor = System.Drawing.Color.Black;
            this.kupciDodaj.Location = new System.Drawing.Point(28, 126);
            this.kupciDodaj.Margin = new System.Windows.Forms.Padding(4);
            this.kupciDodaj.Name = "kupciDodaj";
            this.kupciDodaj.Size = new System.Drawing.Size(78, 25);
            this.kupciDodaj.TabIndex = 1;
            this.kupciDodaj.Text = "Dodaj";
            this.kupciDodaj.UseVisualStyleBackColor = false;
            this.kupciDodaj.Click += new System.EventHandler(this.kupciDodaj_Click);
            // 
            // lbKupci
            // 
            this.lbKupci.BackColor = System.Drawing.SystemColors.Window;
            this.lbKupci.FormattingEnabled = true;
            this.lbKupci.HorizontalScrollbar = true;
            this.lbKupci.ItemHeight = 17;
            this.lbKupci.Location = new System.Drawing.Point(24, 29);
            this.lbKupci.Margin = new System.Windows.Forms.Padding(4);
            this.lbKupci.Name = "lbKupci";
            this.lbKupci.Size = new System.Drawing.Size(524, 89);
            this.lbKupci.TabIndex = 0;
            // 
            // formaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(593, 848);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Yu Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formaAdmin";
            this.Text = "Admin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbFilmovi;
        private System.Windows.Forms.Button filmoviIzbrisi;
        private System.Windows.Forms.Button filmoviEdituj;
        private System.Windows.Forms.Button filmoviDodaj;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button saleIzbrisi;
        private System.Windows.Forms.Button saleEdituj;
        private System.Windows.Forms.Button saleDodaj;
        private System.Windows.Forms.ListBox lbSale;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button projekcijeIzbrisi;
        private System.Windows.Forms.Button projekcijeEdituj;
        private System.Windows.Forms.Button projekcijeDodaj;
        private System.Windows.Forms.ListBox lbProjekcije;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button rezervacijeIzbrisi;
        private System.Windows.Forms.Button rezervacijeEdituj;
        private System.Windows.Forms.Button rezervacijeDodaj;
        private System.Windows.Forms.ListBox lbRezervacije;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button kupciIzbrisi;
        private System.Windows.Forms.Button kupciEdituj;
        private System.Windows.Forms.Button kupciDodaj;
        private System.Windows.Forms.ListBox lbKupci;
        private System.Windows.Forms.ComboBox cmbKupci;
    }
}