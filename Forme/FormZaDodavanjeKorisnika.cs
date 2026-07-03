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
    public partial class FormZaDodavanjeKorisnika : Form
    {
        KorisnikView korisnik; 

        public FormZaDodavanjeKorisnika()
        {
            InitializeComponent();
            korisnik = new KorisnikView();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da dodate novog korisnika?";
            string title = "Pitanje";

            DialogResult result = MessageBox.Show(
                poruka,
                title,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.OK)
            {
                this.korisnik.Id = int.Parse(textBoxId.Text);
                this.korisnik.Adresa = textBoxAdresa.Text;
                this.korisnik.BrojTelefona = textBoxBrTelefona.Text;
               // this.korisnik.StatusNaloga = textBoxStatusNaloga.Text;
                this.korisnik.NacinVerifikacije = textBoxNacinVerifikacije.Text;
                this.korisnik.Email = textBoxEmail.Text;
                this.korisnik.DatumRegistracije = dateTimePickerRegistracija.Value;

                bool uspesno = DTOManager.DodajKorisnika(this.korisnik);

                if (uspesno)
                {
                    MessageBox.Show("Uspešno ste dodali novog korisnika.");

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
                string obavestenje = "Neuspešno dodavanje novog korisnika.";
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
