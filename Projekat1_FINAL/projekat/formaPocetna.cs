using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVP_Projekat
{
    public partial class formaPocetna : Form
    {
        public formaPocetna()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formaRegistracija frm = new formaRegistracija();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                formaAdmin frm = new formaAdmin();
                frm.Show();
            }
            else if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0)
            {
                MessageBox.Show("Unesite korisničko ime i lozinku.");
            }
            else
            {
                Kupac kupac = null;
                for (int i = 0; i < Program.kupci.Count; i++)
                {
                    if (Program.kupci[i].korisnicko_ime == textBox1.Text && Program.kupci[i].lozinka == textBox2.Text)
                    {
                        kupac = Program.kupci[i];
                        break;
                    }
                }
                if (kupac != null) new formaKupac(kupac);
                else MessageBox.Show("Korisnik ne postoji!");
            }
        }
    }
}
