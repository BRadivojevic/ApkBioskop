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
    public partial class formaSale : Form
    {
        public Sala sala;
        public formaAdmin adminFrm;
        public formaSale(formaAdmin adminFrm)
        {
            InitializeComponent();
            this.adminFrm = adminFrm;
            this.sala = null;
            this.Show();
        }

        public formaSale(formaAdmin adminFrm, Sala sala)
        {
            InitializeComponent();
            this.adminFrm = adminFrm;
            this.sala = sala;
            this.Show();
        }

        private void frmSale_Load(object sender, EventArgs e)
        {
            if (sala != null)
            {
                txtId.Text = sala.id.ToString();
                txtBrSale.Text = sala.broj_sale.ToString();
                txtBrSedista.Text = sala.broj_sedista.ToString();
            }
            else
            {
                txtId.Text = Program.IdSale(Program.sale).ToString();
            }
        }

        private void btnGotovo_Click(object sender, EventArgs e)
        {
            int id = Program.IdSale(Program.sale);
            int brsale = 0;
            int brsedista = 0;

            if (txtBrSale.Text.Length == 0 || txtBrSedista.Text.Length == 0) 
            {
                MessageBox.Show("Morate popuniti sva polja.");
                return;
            }

            if (!int.TryParse(txtBrSale.Text, out brsale) || !int.TryParse(txtBrSedista.Text, out brsedista))
            {
                MessageBox.Show("Broj sale i sedišta moraju biti broj.");
                return;
            }
            try
            {
                if (sala == null)
                {
                    Program.sale.Add(new Sala(
                            id,
                            brsale,
                            brsedista
                        ));
                }
                else
                {
                    sala.id = int.Parse(txtId.Text);
                    sala.broj_sale = brsale;
                    sala.broj_sedista = brsedista;                    
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
