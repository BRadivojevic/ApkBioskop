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
    public partial class formaKupci : Form
    {
        public Kupac kupac;
        public formaAdmin adminFrm;        
        public formaKupci(formaAdmin adminFrm)
        {
            InitializeComponent();
            this.adminFrm = adminFrm;
            this.kupac = null;
            cmbPol.DataSource = System.Enum.GetValues(typeof(Pol));
            this.Show();
        }
        public formaKupci(formaAdmin adminFrm, Kupac kupac)
        {
            InitializeComponent();
            this.adminFrm = adminFrm;
            this.kupac = kupac;
            cmbPol.DataSource = System.Enum.GetValues(typeof(Pol));
            this.Show();
        }

        private void frmKupci_Load(object sender, EventArgs e)
        {
            if (kupac != null)
            {
                txtId.Text = kupac.id.ToString();
                txtKorisnicko.Text = kupac.korisnicko_ime;
                txtLozinka.Text = kupac.lozinka;
                txtIme.Text = kupac.ime;
                txtPrezime.Text = kupac.prezime;
                dtpRodjendan.Value = kupac.datum_rodjenja;
                txtTelefon.Text = kupac.telefon;
                cmbPol.SelectedItem = kupac.pol;
            }
            else
            {
                txtId.Text = Program.IdKupci(Program.kupci).ToString();
            }        
        }

        private void btnGotovo_Click(object sender, EventArgs e)
        {
            int id = Program.IdKupci(Program.kupci);
            Regex reg = new Regex("^[a-zA-Z]+$");
            Regex reg1 = new Regex("^[0-9]+$");

            if (txtKorisnicko.Text.Length == 0 ||
                txtLozinka.Text.Length == 0 ||
                txtIme.Text.Length == 0 ||
                txtPrezime.Text.Length == 0 ||
                txtTelefon.Text.Length == 0)
            {
                MessageBox.Show("Morate popuniti sva polja.");
                return;
            }

            if (!reg.IsMatch(txtIme.Text) ||
                !reg.IsMatch(txtPrezime.Text))
            {
                MessageBox.Show("Ime i prezime ne smeju sadržati brojeve.");
                return;
            }

            if (!reg1.IsMatch(txtTelefon.Text))
            {
                MessageBox.Show("Broj telefona ne sme sadržati slova.");
                return;
            }

            try
            {
                if (kupac == null)
                {
                    Program.kupci.Add(new Kupac(
                            id,
                            txtKorisnicko.Text,
                            txtLozinka.Text,
                            txtIme.Text,
                            txtPrezime.Text,
                            dtpRodjendan.Value,
                            txtTelefon.Text,
                            (Pol)cmbPol.SelectedItem
                        ));
                }
                else
                {
                    kupac.id = int.Parse(txtId.Text);
                    kupac.korisnicko_ime = txtKorisnicko.Text;
                    kupac.lozinka = txtLozinka.Text;
                    kupac.ime = txtIme.Text;
                    kupac.prezime = txtPrezime.Text;
                    kupac.datum_rodjenja = dtpRodjendan.Value;
                    kupac.telefon = txtTelefon.Text;
                    kupac.pol = (Pol)cmbPol.SelectedItem;
                }
                Program.UpisiSve();
                adminFrm.RefreshLbs();
                MessageBox.Show("Sačuvano.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
