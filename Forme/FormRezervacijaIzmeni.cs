using IznajmljivanjeVozila.Entiteti;
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
    public partial class FormRezervacijaIzmeni : Form
    {
        public RezervacijaView rezervacija;

        public FormRezervacijaIzmeni(RezervacijaView r)
        {
            InitializeComponent();
            this.rezervacija = r;
            popuniComboKorisnici();
            popuniComboVozaci();
            popuniComboVozila();
        }
        private void popuniComboKorisnici()
        {
            comboBoxKorisnik.DataSource =
                DTOManager.VratiKorisnikeZaCombo();

            comboBoxKorisnik.DisplayMember = "Prikaz";
            comboBoxKorisnik.ValueMember = "Id";
        }

        private void popuniComboVozaci()
        {
            comboBoxVozac.DataSource =
                DTOManager.VratiVozacaCombo();

            comboBoxVozac.DisplayMember = "Podaci";
            comboBoxVozac.ValueMember = "Id";
        }

        private void popuniComboVozila()
        {
            comboBoxVozilo.DataSource =
                DTOManager.VratiVoziloZaCombo();

            comboBoxVozilo.DisplayMember = "Prikaz";
            comboBoxVozilo.ValueMember = "Id";
        }
        private void popuniPodacima()
        {
            textBoxId.Text = rezervacija.Id.ToString();
            textBoxId.Enabled = false;

            comboBoxKorisnik.SelectedValue =
                rezervacija.IdKorisnika;

            comboBoxVozac.SelectedValue =
                rezervacija.IdVozaca;

            comboBoxVozilo.SelectedValue =
                rezervacija.IdVozila;

            textBoxLokPreuzimanja.Text =
                rezervacija.PlaniranaLokacijaPreuzimanja;

            textBoxLokVracanja.Text =
                rezervacija.PlaniranaLokacijaVracanja;

            comboBoxTip.Text = rezervacija.Tip;
            comboBoxStatus.Text = rezervacija.Status;

            dateTimePickerPocetak.Value =
                rezervacija.PlaniranoVremePocetka;

            dateTimePickerKraj.Value =
                rezervacija.PlaniranoVremeZavrsetka;
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
                   KorisnikCombo korisnik =
                comboBoxKorisnik.SelectedItem as KorisnikCombo;

            VozacCombo vozac =
                comboBoxVozac.SelectedItem as VozacCombo;

            VoziloVoznjaCombo vozilo =
                comboBoxVozilo.SelectedItem as VoziloVoznjaCombo;

            if (korisnik == null ||
                vozac == null ||
                vozilo == null)
            {
                MessageBox.Show(
                    "Izaberite korisnika, vozača i vozilo.");
                return;
            }

            rezervacija.IdKorisnika = korisnik.Id;
            rezervacija.IdVozaca = vozac.Id;
            rezervacija.IdVozila = vozilo.Id;

            rezervacija.PlaniranaLokacijaPreuzimanja =
                textBoxLokPreuzimanja.Text;

            rezervacija.PlaniranaLokacijaVracanja =
                textBoxLokVracanja.Text;

            rezervacija.Tip = comboBoxTip.Text;
            rezervacija.Status = comboBoxStatus.Text;

            rezervacija.PlaniranoVremePocetka =
                dateTimePickerPocetak.Value;

            rezervacija.PlaniranoVremeZavrsetka =
                dateTimePickerKraj.Value;

            bool uspesno =
                DTOManager.IzmeniRezervaciju(rezervacija);

            if (uspesno)
            {
                MessageBox.Show(
                    "Ažuriranje rezervacije je uspešno izvršeno!");

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void FormRezervacijaIVoznjaIzmeni_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
    }
}
