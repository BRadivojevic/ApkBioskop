namespace TVP_Projekat
{
    partial class formaFilmovi
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtZanr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTrajanje = new System.Windows.Forms.TextBox();
            this.txtGranicaGodina = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGotovo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Window;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(191, 15);
            this.txtID.Margin = new System.Windows.Forms.Padding(6);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(209, 38);
            this.txtID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Žanr:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.BackColor = System.Drawing.SystemColors.Window;
            this.txtNaziv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNaziv.Location = new System.Drawing.Point(191, 65);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(6);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(209, 38);
            this.txtNaziv.TabIndex = 4;
            // 
            // txtZanr
            // 
            this.txtZanr.BackColor = System.Drawing.SystemColors.Window;
            this.txtZanr.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtZanr.Location = new System.Drawing.Point(191, 115);
            this.txtZanr.Margin = new System.Windows.Forms.Padding(6);
            this.txtZanr.Name = "txtZanr";
            this.txtZanr.Size = new System.Drawing.Size(209, 38);
            this.txtZanr.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Trajanje (minuti):";
            // 
            // txtTrajanje
            // 
            this.txtTrajanje.BackColor = System.Drawing.SystemColors.Window;
            this.txtTrajanje.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTrajanje.Location = new System.Drawing.Point(191, 165);
            this.txtTrajanje.Margin = new System.Windows.Forms.Padding(6);
            this.txtTrajanje.Name = "txtTrajanje";
            this.txtTrajanje.Size = new System.Drawing.Size(209, 38);
            this.txtTrajanje.TabIndex = 7;
            // 
            // txtGranicaGodina
            // 
            this.txtGranicaGodina.BackColor = System.Drawing.SystemColors.Window;
            this.txtGranicaGodina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGranicaGodina.Location = new System.Drawing.Point(191, 215);
            this.txtGranicaGodina.Margin = new System.Windows.Forms.Padding(6);
            this.txtGranicaGodina.Name = "txtGranicaGodina";
            this.txtGranicaGodina.Size = new System.Drawing.Size(209, 38);
            this.txtGranicaGodina.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(15, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Granica godina:";
            // 
            // btnGotovo
            // 
            this.btnGotovo.BackColor = System.Drawing.SystemColors.Window;
            this.btnGotovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGotovo.ForeColor = System.Drawing.Color.Black;
            this.btnGotovo.Location = new System.Drawing.Point(20, 265);
            this.btnGotovo.Margin = new System.Windows.Forms.Padding(6);
            this.btnGotovo.Name = "btnGotovo";
            this.btnGotovo.Size = new System.Drawing.Size(380, 44);
            this.btnGotovo.TabIndex = 10;
            this.btnGotovo.Text = "Potvrdi";
            this.btnGotovo.UseVisualStyleBackColor = false;
            this.btnGotovo.Click += new System.EventHandler(this.btnGotovo_Click);
            // 
            // formaFilmovi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(413, 324);
            this.Controls.Add(this.btnGotovo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGranicaGodina);
            this.Controls.Add(this.txtTrajanje);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtZanr);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtID);
            this.Font = new System.Drawing.Font("Yu Gothic", 14.25F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "formaFilmovi";
            this.Text = "Filmovi";
            this.Load += new System.EventHandler(this.frmFilmovi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtZanr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTrajanje;
        private System.Windows.Forms.TextBox txtGranicaGodina;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGotovo;
    }
}