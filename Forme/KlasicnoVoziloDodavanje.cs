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
    public partial class KlasicnoVoziloDodavanje : Form
    {
        KlasicnoVoziloView klasVozilo;
        public KlasicnoVoziloDodavanje()
        {
            InitializeComponent();
            klasVozilo = new KlasicnoVoziloView();
        }

        private void buttonDodajVozilo_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da dodate novo klasično vozilo?";
            string title = "Pitanje";

            DialogResult result = MessageBox.Show(
                poruka,
                title,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.OK)
            {
                this.klasVozilo.Id = int.Parse(textBoxId.Text);
                this.klasVozilo.Registracija = textBoxRegistracija.Text;
                this.klasVozilo.VinBr = textBoxVinBroj.Text;
                this.klasVozilo.Marka = textBoxMarka.Text;
                this.klasVozilo.Model = textBoxModel.Text;
                this.klasVozilo.GodProizvodnje = int.Parse(textBoxGodProizvodnje.Text);
                this.klasVozilo.DatumNabavke = dateTimePickerNabavka.Value;
                this.klasVozilo.Status = textBoxStatus.Text;
                this.klasVozilo.TipKoriscenja = textBoxTipKoriscenja.Text;
                this.klasVozilo.BrSedista = (int)numericUpDownBrSedista.Value;
                this.klasVozilo.StanjeEnterijera = textBoxStanjeEnterijera.Text;
                this.klasVozilo.StanjeEksterijera = textBoxStanjeEksterijera.Text;
                this.klasVozilo.DodatnaOprema = textBoxDodatnaOprema.Text;

                this.klasVozilo.Zapremina = (double)numericUpZapremina.Value;
                this.klasVozilo.ProsecnaPotrosnja = (double)numericUpDownProsecnaPotrosnja.Value;
                this.klasVozilo.TipGoriva = textBoxTipGoriva.Text;

                bool uspesno = DTOManager.DodajKVozilo(this.klasVozilo);

                if (uspesno)
                {
                    MessageBox.Show("Uspešno ste dodali novo klasično vozilo.");

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
                string obavestenje = "Neuspešno dodavanje novog klasičnig vozila.";
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
