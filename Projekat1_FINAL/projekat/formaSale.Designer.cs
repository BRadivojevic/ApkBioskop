namespace TVP_Projekat
{
    partial class formaSale
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
            this.txtBrSale = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBrSedista = new System.Windows.Forms.TextBox();
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
            this.txtId.Location = new System.Drawing.Point(151, 18);
            this.txtId.Margin = new System.Windows.Forms.Padding(6);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(135, 38);
            this.txtId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Broj sale:";
            // 
            // txtBrSale
            // 
            this.txtBrSale.BackColor = System.Drawing.SystemColors.Window;
            this.txtBrSale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrSale.Location = new System.Drawing.Point(151, 68);
            this.txtBrSale.Margin = new System.Windows.Forms.Padding(6);
            this.txtBrSale.Name = "txtBrSale";
            this.txtBrSale.Size = new System.Drawing.Size(135, 38);
            this.txtBrSale.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Broj sedista:";
            // 
            // txtBrSedista
            // 
            this.txtBrSedista.BackColor = System.Drawing.SystemColors.Window;
            this.txtBrSedista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBrSedista.Location = new System.Drawing.Point(151, 118);
            this.txtBrSedista.Margin = new System.Windows.Forms.Padding(6);
            this.txtBrSedista.Name = "txtBrSedista";
            this.txtBrSedista.Size = new System.Drawing.Size(135, 38);
            this.txtBrSedista.TabIndex = 5;
            // 
            // btnGotovo
            // 
            this.btnGotovo.BackColor = System.Drawing.SystemColors.Window;
            this.btnGotovo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGotovo.ForeColor = System.Drawing.Color.Black;
            this.btnGotovo.Location = new System.Drawing.Point(20, 168);
            this.btnGotovo.Margin = new System.Windows.Forms.Padding(6);
            this.btnGotovo.Name = "btnGotovo";
            this.btnGotovo.Size = new System.Drawing.Size(266, 44);
            this.btnGotovo.TabIndex = 6;
            this.btnGotovo.Text = "Potvrdi";
            this.btnGotovo.UseVisualStyleBackColor = false;
            this.btnGotovo.Click += new System.EventHandler(this.btnGotovo_Click);
            // 
            // formaSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(299, 224);
            this.Controls.Add(this.btnGotovo);
            this.Controls.Add(this.txtBrSedista);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBrSale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Yu Gothic", 14.25F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "formaSale";
            this.Text = "Sale";
            this.Load += new System.EventHandler(this.frmSale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrSale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBrSedista;
        private System.Windows.Forms.Button btnGotovo;
    }
}