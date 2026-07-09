using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IznajmljivanjeVozila.Forme
{
    public partial class FormDogadjajDodavanje : Form
    {
        DogadjajiView dogadjaji;

        public FormDogadjajDodavanje()
        {
            InitializeComponent();
            dogadjaji = new DogadjajiView();
            PopuniComboVoznje();
            comboBoxVoznje.SelectedIndex = -1;
        }

        private void PopuniComboVoznje()
        {
            comboBoxVoznje.DataSource =
                DTOManager.VratiVoznjeZaCombo();

            comboBoxVoznje.DisplayMember =
                "Prikaz";

            comboBoxVoznje.ValueMember =
                "Id";

            comboBoxVoznje.DropDownStyle =
                ComboBoxStyle.DropDownList;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da dodate novi događaj?";
            string title = "Pitanje";

            DialogResult result = MessageBox.Show(
                poruka,
                title,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.OK)
            {
                this.dogadjaji.Id = int.Parse(textBoxID.Text);
                this.dogadjaji.NagloKocenje = textBoxNagloKocenje.Text;
                this.dogadjaji.PrekoracenjeBrzine = textBoxPrekoracenjeBrzine.Text;
                this.dogadjaji.DuzeZadrzavanje = textBoxDuzeZadrzavanje.Text;
                this.dogadjaji.NeovlasceniIzlazak = textBoxNeovlasceniIzlazak.Text;
                this.dogadjaji.Sudar = textBoxSudar.Text;

                VoznjaCombo izabranaVoznja = comboBoxVoznje.SelectedItem as VoznjaCombo;

                if (izabranaVoznja == null)
                {
                    MessageBox.Show("Izaberite vožnju.");
                    return;
                }

                dogadjaji.IdVoznje = izabranaVoznja.Id;

                bool uspesno =
                    DTOManager.DodajDogadjaj(dogadjaji);

                if (izabranaVoznja == null)
                {
                    MessageBox.Show(
                        "Izaberite vožnju."
                    );

                    return;
                }

                if (uspesno)
                {
                    MessageBox.Show("Uspešno ste dodali novi događaj.");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Dodavanje nije uspelo.");
                }
            }
            else
            {
                string obavestenje = "Neuspešno dodavanje novog događaja.";
                string naslov = "Upozorenje";

                DialogResult greska = MessageBox.Show(
                    obavestenje,
                    naslov,
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}
