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
            popuniPodacima();
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

        private bool PokusajPreuzetiIdVozila(out int idVozila)
        {
            idVozila = 0;

            if (comboBoxVozilo.SelectedItem
                is VoziloVoznjaCombo vozilo)
            {
                idVozila = vozilo.Id;
                return true;
            }

            if (comboBoxVozilo.SelectedValue != null &&
                int.TryParse(
                    comboBoxVozilo.SelectedValue.ToString(),
                    out idVozila))
            {
                return true;
            }

            return false;
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            KorisnikCombo korisnik = comboBoxKorisnik.SelectedItem as KorisnikCombo;

            VozacCombo vozac = comboBoxVozac.SelectedItem as VozacCombo;

            VoziloVoznjaCombo vozilo = comboBoxVozilo.SelectedItem as VoziloVoznjaCombo;

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

            if (dateTimePickerKraj.Value <=
                dateTimePickerPocetak.Value)
            {
                MessageBox.Show(
                    "Vreme završetka mora biti nakon vremena početka.");

                return;
            }

            if (comboBoxStatus.Text == "Aktivna")
            {
                DostupnostVozilaView dostupnost =
                    DTOManager.ProveriDostupnostVozila(
                        vozilo.Id,
                        dateTimePickerPocetak.Value,
                        dateTimePickerKraj.Value,
                        rezervacija.Id
                    );

                if (!dostupnost.Dostupno)
                {
                    MessageBox.Show(
                        dostupnost.Poruka,
                        "Vozilo nije dostupno",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }
            }

            bool uspesno = DTOManager.IzmeniRezervaciju(rezervacija);

            if (uspesno)
            {
                MessageBox.Show("Ažuriranje rezervacije je uspešno izvršeno!");

                DialogResult = DialogResult.OK;
                Close();
            }
            
        }

        private void buttonDostupnost_Click(object sender, EventArgs e)
        {
            if (!PokusajPreuzetiIdVozila(
            out int idVozila))
            {
                MessageBox.Show(
                    "Prvo izaberite vozilo.");

                return;
            }

            if (dateTimePickerKraj.Value <=
                dateTimePickerPocetak.Value)
            {
                MessageBox.Show(
                    "Vreme završetka mora biti nakon početka.");

                return;
            }

            VoziloView vozilo =
                DTOManager.VratiVozilo(idVozila);

            DostupnostVozila forma =
                new DostupnostVozila(
                    vozilo,
                    dateTimePickerPocetak.Value,
                    dateTimePickerKraj.Value
                );

            forma.ShowDialog(this);

        }

    }
}
