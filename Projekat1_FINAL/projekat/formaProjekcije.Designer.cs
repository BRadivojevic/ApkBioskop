namespace TVP_Projekat
{
    partial class formaProjekcije
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpVremeDatum = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCenaKarte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSala = new System.Windows.Forms.ComboBox();
            this.cmbFilm = new System.Windows.Forms.ComboBox();
            this.btnGotovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Window;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(171, 18);
            this.txtId.Margin = new System.Windows.Forms.Padding(6);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(180, 38);
            this.txtId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vreme i datum:";
            // 
            // dtpVremeDatum
            // 
            this.dtpVremeDatum.CustomFormat = "HH:mm dd.MM.yyyy.";
            this.dtpVremeDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpVremeDatum.Location = new System.Drawing.Point(170, 68);
            this.dtpVremeDatum.Margin = new System.Windows.Forms.Padding(6);
            this.dtpVremeDatum.Name = "dtpVremeDatum";
            this.dtpVremeDatum.Size = new System.Drawing.Size(180, 38);
            this.dtpVremeDatum.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sala:";
            // 
            // txtCenaKarte
            // 
            this.txtCenaKarte.BackColor = System.Drawing.SystemColors.Window;
            this.txtCenaKarte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCenaKarte.Location = new System.Drawing.Point(170, 163);
            this.txtCenaKarte.Margin = new System.Windows.Forms.Padding(6);
            this.txtCenaKarte.Name = "txtCenaKarte";
            this.txtCenaKarte.Size = new System.Drawing.Size(180, 38);
            this.txtCenaKarte.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cena karte:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(15, 216);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Film:";
            // 
            // cmbSala
            // 
            this.cmbSala.BackColor = System.Drawing.SystemColors.Window;
            this.cmbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSala.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbSala.FormattingEnabled = true;
            this.cmbSala.Location = new System.Drawing.Point(170, 118);
            this.cmbSala.Margin = new System.Windows.Forms.Padding(6);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.Size = new System.Drawing.Size(180, 33);
            this.cmbSala.TabIndex = 9;
            // 
            // cmbFilm
            // 
            this.cmbFilm.BackColor = System.Drawing.SystemColors.Window;
            this.cmbFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbFilm.FormattingEnabled = true;
            this.cmbFilm.Location = new System.Drawing.Point(170, 213);
            this.cmbFilm.Margin = new System.Windows.Forms.Padding(6);
            this.cmbFilm.Name = "cmbFilm";
            this.cmbFilm.Size = new System.Drawing.Size(180, 33);
            this.cmbFilm.TabIndex = 10;
            // 
            // btnGotovo
            // 
            this.btnGotovo.BackColor = System.Drawing.SystemColors.Window;
            this.btnGotovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGotovo.ForeColor = System.Drawing.Color.Black;
            this.btnGotovo.Location = new System.Drawing.Point(15, 258);
            this.btnGotovo.Margin = new System.Windows.Forms.Padding(6);
            this.btnGotovo.Name = "btnGotovo";
            this.btnGotovo.Size = new System.Drawing.Size(336, 44);
            this.btnGotovo.TabIndex = 11;
            this.btnGotovo.Text = "Potvrdi";
            this.btnGotovo.UseVisualStyleBackColor = false;
            this.btnGotovo.Click += new System.EventHandler(this.btnGotovo_Click);
            // 
            // formaProjekcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(364, 315);
            this.Controls.Add(this.btnGotovo);
            this.Controls.Add(this.cmbFilm);
            this.Controls.Add(this.cmbSala);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCenaKarte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpVremeDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Yu Gothic", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "formaProjekcije";
            this.Text = "Projekcije";
            this.Load += new System.EventHandler(this.frmProjekcije_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpVremeDatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCenaKarte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSala;
        private System.Windows.Forms.ComboBox cmbFilm;
        private System.Windows.Forms.Button btnGotovo;
    }
}