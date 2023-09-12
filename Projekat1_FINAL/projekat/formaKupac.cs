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
    public partial class formaKupac : Form
    {
        public Kupac kupac;
        public formaKupac(Kupac kupac)
        {
            InitializeComponent();
            this.kupac = kupac;
            lbRezervacijeKupca.DataSource = Program.rezervacije.FindAll(x => x.id_kupca == kupac.id);
            lbRezervacijeKupca.DisplayMember = "Korisniku";
            this.Show();
        }
        public void RefreshLb()
        {
            lbRezervacijeKupca.DataSource = null;
            lbRezervacijeKupca.DataSource = Program.rezervacije.FindAll(x => x.id_kupca == kupac.id);
        }

        private void btnNew_Click(object sender, EventArgs e)
        { 
            new formaNovaRezervacija(this); 
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            new formaRezervacije(this, (Rezervacija)lbRezervacijeKupca.SelectedItem);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Program.rezervacije.Remove((Rezervacija)lbRezervacijeKupca.SelectedItem);
            Program.UpisiSve();
            RefreshLb();
            MessageBox.Show("Uspešno izbrisano.");
        }
    }
}
