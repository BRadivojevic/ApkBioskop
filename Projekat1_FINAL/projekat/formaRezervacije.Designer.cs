namespace TVP_Projekat
{
    partial class formaRezervacije
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
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtBrMesta = new System.Windows.Forms.TextBox();
            this.cmbProjekcija = new System.Windows.Forms.ComboBox();
            this.cmbKupac = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGotovo = new System.Windows.Forms.Button();
            this.lbCena = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Window;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(141, 30);
            this.txtId.Margin = new System.Windows.Forms.Padding(6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(189, 38);
            this.txtId.TabIndex = 0;
            // 
            // txtBrMesta
            // 
            this.txtBrMesta.BackColor = System.Drawing.SystemColors.Window;
            this.txtBrMesta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrMesta.Location = new System.Drawing.Point(141, 170);
            this.txtBrMesta.Margin = new System.Windows.Forms.Padding(6);
            this.txtBrMesta.Name = "txtBrMesta";
            this.txtBrMesta.Size = new System.Drawing.Size(189, 38);
            this.txtBrMesta.TabIndex = 1;
            this.txtBrMesta.TextChanged += new System.EventHandler(this.PromeniUkupnuCenu);
            // 
            // cmbProjekcija
            // 
            this.cmbProjekcija.BackColor = System.Drawing.SystemColors.Window;
            this.cmbProjekcija.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbProjekcija.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbProjekcija.FormattingEnabled = true;
            this.cmbProjekcija.Location = new System.Drawing.Point(141, 80);
            this.cmbProjekcija.Margin = new System.Windows.Forms.Padding(6);
            this.cmbProjekcija.Name = "cmbProjekcija";
            this.cmbProjekcija.Size = new System.Drawing.Size(189, 33);
            this.cmbProjekcija.TabIndex = 2;
            this.cmbProjekcija.SelectedIndexChanged += new System.EventHandler(this.PromeniUkupnuCenu);
            // 
            // cmbKupac
            // 
            this.cmbKupac.BackColor = System.Drawing.SystemColors.Window;
            this.cmbKupac.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbKupac.FormattingEnabled = true;
            this.cmbKupac.Location = new System.Drawing.Point(141, 125);
            this.cmbKupac.Margin = new System.Windows.Forms.Padding(6);
            this.cmbKupac.Name = "cmbKupac";
            this.cmbKupac.Size = new System.Drawing.Size(189, 33);
            this.cmbKupac.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Broj mesta:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kupac:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Projekcija:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnGotovo
            // 
            this.btnGotovo.BackColor = System.Drawing.SystemColors.Window;
            this.btnGotovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGotovo.ForeColor = System.Drawing.Color.Black;
            this.btnGotovo.Location = new System.Drawing.Point(20, 255);
            this.btnGotovo.Margin = new System.Windows.Forms.Padding(6);
            this.btnGotovo.Name = "btnGotovo";
            this.btnGotovo.Size = new System.Drawing.Size(310, 44);
            this.btnGotovo.TabIndex = 8;
            this.btnGotovo.Text = "Potvrdi";
            this.btnGotovo.UseVisualStyleBackColor = false;
            this.btnGotovo.Click += new System.EventHandler(this.btnGotovo_Click);
            // 
            // lbCena
            // 
            this.lbCena.AutoSize = true;
            this.lbCena.ForeColor = System.Drawing.Color.Black;
            this.lbCena.Location = new System.Drawing.Point(15, 224);
            this.lbCena.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbCena.Name = "lbCena";
            this.lbCena.Size = new System.Drawing.Size(133, 25);
            this.lbCena.TabIndex = 9;
            this.lbCena.Text = "Ukupna cena:";
            this.lbCena.Click += new System.EventHandler(this.lbCena_Click);
            // 
            // formaRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(342, 315);
            this.Controls.Add(this.lbCena);
            this.Controls.Add(this.btnGotovo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKupac);
            this.Controls.Add(this.cmbProjekcija);
            this.Controls.Add(this.txtBrMesta);
            this.Controls.Add(this.txtId);
            this.Font = new System.Drawing.Font("Yu Gothic", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "formaRezervacije";
            this.Text = "Rezervacije";
            this.Load += new System.EventHandler(this.frmRezervacije_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtBrMesta;
        private System.Windows.Forms.ComboBox cmbProjekcija;
        private System.Windows.Forms.ComboBox cmbKupac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGotovo;
        private System.Windows.Forms.Label lbCena;
    }
}