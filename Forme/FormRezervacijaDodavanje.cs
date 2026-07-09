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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IznajmljivanjeVozila.Forme
{
    public partial class FormRezervacijaDodavanje : Form
    {
        RezervacijaView rezervacija;

        public FormRezervacijaDodavanje()
        {
            InitializeComponent();
            rezervacija = new RezervacijaView();
            popuniComboKorisnici();
            popuniComboVozaci();
            popuniComboVozila();
            comboBoxKorisnik.SelectedIndex = -1;
            comboBoxVozac.SelectedIndex = -1;
            comboBoxVozilo.SelectedIndex = -1;
            comboBoxTip.SelectedIndex = -1;
            comboBoxStatus.SelectedIndex = -1;
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

        private void buttonDodaj_Click(object sender, EventArgs e)
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

            if (string.IsNullOrWhiteSpace(textBoxId.Text) ||
                string.IsNullOrWhiteSpace(
                    textBoxLokPreuzimanja.Text) ||
                string.IsNullOrWhiteSpace(
                    textBoxLokVracanja.Text))
            {
                MessageBox.Show("Popunite sva polja.");
                return;
            }

            string poruka =
                "Da li želite da dodate novu rezervaciju?";

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
                        dateTimePickerKraj.Value
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

                DialogResult result = MessageBox.Show(
                poruka,
                "Pitanje",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

                if (result != DialogResult.OK)
                    return;

                rezervacija.Id = int.Parse(textBoxId.Text);

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
                    DTOManager.DodajRezervaciju(rezervacija);

                if (uspesno)
                {
                    MessageBox.Show(
                        "Uspešno ste dodali novu rezervaciju.");

                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Dodavanje nije uspelo.");
                }
            }
        }

        private void FormRezervacijaIVoznjaDodavanje_Load(object sender, EventArgs e)
        {
        }

        private void buttonProveriDostupnost_Click(object sender, EventArgs e)
        {
            VoziloVoznjaCombo izabranoVozilo =
         comboBoxVozilo.SelectedItem
             as VoziloVoznjaCombo;

            if (izabranoVozilo == null)
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
                DTOManager.VratiVozilo(
                    izabranoVozilo.Id
                );

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
