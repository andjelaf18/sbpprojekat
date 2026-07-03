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
    public partial class FormZaDodavanjeNacinaPlacanja : Form
    {
        NacinPlacanjaView nacinPlacanja;

        public FormZaDodavanjeNacinaPlacanja()
        {
            InitializeComponent();
        }

        private int idKorisnika;

        public FormZaDodavanjeNacinaPlacanja(int id)
        {
            InitializeComponent();
            nacinPlacanja = new NacinPlacanjaView();
            idKorisnika = id;
            labelKorisnik.Text = "Dodavanje načina plaćanja za korisnika ID: " + idKorisnika;
        }

        private bool ValidacijaUnosa()
        {
            if (string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                MessageBox.Show("Unesite ID načina plaćanja.");
                return false;
            }

            if (!int.TryParse(textBoxId.Text, out _))
            {
                MessageBox.Show("ID mora biti broj.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxTipPlacanja.Text))
            {
                MessageBox.Show("Unesite tip plaćanja.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxStatus.Text))
            {
                MessageBox.Show("Unesite status.");
                return false;
            }

            return true;
        }

        private void buttonDodajNP_Click(object sender, EventArgs e)
        {
            if (!ValidacijaUnosa())
                return; 

            string poruka = "Da li želite da dodate novi način plaćanja?";
            string title = "Pitanje";

            DialogResult result = MessageBox.Show(
                poruka,
                title,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.OK)
            {
                this.nacinPlacanja.Id = int.Parse(textBoxId.Text);
                this.nacinPlacanja.TipPlacanja = textBoxTipPlacanja.Text;
                this.nacinPlacanja.Status = textBoxStatus.Text;
                this.nacinPlacanja.DatumOgranicenja = dateTimePicker1.Value;
                this.nacinPlacanja.IdKorisnika = idKorisnika;

                bool uspesno = DTOManager.DodajNoviNacinPlacanja(this.nacinPlacanja);

                if (uspesno)
                {
                    MessageBox.Show("Uspešno ste dodali novi način plaćanja.");

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
                string obavestenje = "Neuspešno dodavanje novog načina plaćanja.";
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
