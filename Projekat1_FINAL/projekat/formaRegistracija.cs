using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVP_Projekat
{
    public partial class formaRegistracija : Form
    {
        public formaRegistracija()
        {
            InitializeComponent();
            lbPol.DataSource = System.Enum.GetValues(typeof(Pol));
        }

        private void btnRegistruj_Click(object sender, EventArgs e)
        {
            int max_id = 0;
            Regex reg = new Regex("^[a-zA-Z\x20]+$");
            Regex reg1 = new Regex("^[0-9]+$");

            foreach (Kupac kupac in Program.kupci)
                if (max_id < kupac.id)
                    max_id = kupac.id;

            if (txtIme.Text.Length == 0 ||
                txtPrezime.Text.Length == 0 ||
                txtLozinka.Text.Length == 0 ||
                txtKorisnicko.Text.Length == 0 ||
                txtTelefon.Text.Length == 0)
            {
                MessageBox.Show("Popunite sva polja.");
                return;
            }

            if (!reg.IsMatch(txtIme.Text) || !reg.IsMatch(txtPrezime.Text))
            {
                MessageBox.Show("Ime i prezime ne smeju sadržati brojeve.");
                return;
            }

            if (!reg1.IsMatch(txtTelefon.Text))
            {
                MessageBox.Show("Broj telefona ne sme sadržati slova.");
                return;
            }

            foreach (Kupac item in Program.kupci)
            {
                if (txtKorisnicko.Text == item.korisnicko_ime)
                {
                    MessageBox.Show("Korisničko ime je zauzeto.");
                    return;
                }
            }

            Program.kupci.Add(new Kupac(
                max_id + 1,
                txtKorisnicko.Text,
                txtLozinka.Text,
                txtIme.Text,
                txtPrezime.Text,
                dtpRodjendan.Value,
                txtTelefon.Text,
                (Pol) lbPol.SelectedItem
            ));            

            Program.UpisiSve();
            MessageBox.Show("Napravljen novi korisnik!");
            Close();
        }
    }
}
