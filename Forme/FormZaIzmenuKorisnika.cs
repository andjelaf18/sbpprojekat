using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IznajmljivanjeVozila.Forme
{
    public partial class FormZaIzmenuKorisnika : Form
    {
        public KorisnikView korisnik;

        public FormZaIzmenuKorisnika(KorisnikView k)
        {
            InitializeComponent();
            this.korisnik = k;

        }
        public FormZaIzmenuKorisnika()
        {
            InitializeComponent();
        }

        private void popuniPodacima()
        {
            textBoxId.Text = korisnik.Id.ToString();
            textBoxId.Enabled = false;

            textBoxAdresa.Text = korisnik.Adresa;
            textBoxBrTelefona.Text = korisnik.BrojTelefona;
            textBoxEmail.Text = korisnik.Email;
            dateTimePickerRegistracija.Value = korisnik.DatumRegistracije;
            textBoxNacinVerifikacije.Text = korisnik.NacinVerifikacije;

            radioButtonAktivan.Checked = korisnik.StatusNaloga == "Aktivan";
            radioButtonNeaktivan.Checked = korisnik.StatusNaloga == "Pasivan";
        }

        private void buttonPotvrdiIzmenu_Click(object sender, EventArgs e)
        {
            korisnik.Adresa = textBoxAdresa.Text;
            korisnik.BrojTelefona = textBoxBrTelefona.Text;
            korisnik.Email = textBoxEmail.Text;
            korisnik.DatumRegistracije = dateTimePickerRegistracija.Value;
            korisnik.NacinVerifikacije = textBoxNacinVerifikacije.Text;
            korisnik.StatusNaloga = radioButtonAktivan.Checked ? "Aktivan" : "Pasivan";

            DTOManager.IzmeniKorisnika(korisnik);

            MessageBox.Show("Ažuriranje korisnika je uspešno izvršeno!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormZaIzmenuKorisnika_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
    }
}
