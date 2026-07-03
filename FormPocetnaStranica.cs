using IznajmljivanjeVozila.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace IznajmljivanjeVozila
{
    public partial class FormPocetnaStranica : Form
    {
        public FormPocetnaStranica()
        {
            InitializeComponent();
        }

        private void buttonKorisnik_Click(object sender, EventArgs e)
        {
            FormKorisnik newForm = new FormKorisnik();
            newForm.Show();
        }

        private void buttonVozilo_Click(object sender, EventArgs e)
        {
            FormVozilo forma = new FormVozilo();
            forma.Show();
        }

        private void buttonRegIVoznje_Click(object sender, EventArgs e)
        {
            FormRezervacijaIVoznja riv = new FormRezervacijaIVoznja();
            riv.Show();
        }
    }
}
