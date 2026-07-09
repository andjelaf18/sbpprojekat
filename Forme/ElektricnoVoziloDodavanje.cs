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
    public partial class ElektricnoVoziloDodavanje : Form
    {
        ElektricnoVoziloView elVozilo;

        public ElektricnoVoziloDodavanje()
        {
            InitializeComponent();
            elVozilo = new ElektricnoVoziloView();
        }

        private void buttonDodajVozilo_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da dodate novo električno vozilo?";
            string title = "Pitanje";

            DialogResult result = MessageBox.Show(
                poruka,
                title,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.OK)
            {
                this.elVozilo.Id = int.Parse(textBoxId.Text);
                this.elVozilo.Registracija = textBoxRegistracija.Text;
                this.elVozilo.VinBr = textBoxVinBroj.Text;
                this.elVozilo.Marka = textBoxMarka.Text;
                this.elVozilo.Model = textBoxModel.Text;
                this.elVozilo.GodProizvodnje = int.Parse(textBoxGodProizvodnje.Text);
                this.elVozilo.DatumNabavke = dateTimePickerNabavka.Value;
                this.elVozilo.Status = textBoxStatus.Text;
                this.elVozilo.TipKoriscenja = textBoxTipKoriscenja.Text;
                this.elVozilo.BrSedista = (int)numericUpDownBrSedista.Value;
                this.elVozilo.StanjeEnterijera = textBoxStanjeEnterijera.Text;
                this.elVozilo.StanjeEksterijera = textBoxStanjeEksterijera.Text;
                this.elVozilo.DodatnaOprema = textBoxDodatnaOprema.Text;

                this.elVozilo.Id = int.Parse(textBoxId.Text);
                this.elVozilo.KapacitetBat = (double)numericUpDownKapBat.Value;
                this.elVozilo.NivoNapunjenosti = (double)numericUpDownNivoNapunjenosti.Value;
                this.elVozilo.TipPunjenja = textBoxTipPunjenja.Text;
                this.elVozilo.Autonomija = double.Parse(textBoxAutonomija.Text);
                this.elVozilo.BrCiklusaPunjenja = (double)numericUpDownBrCiklusaPunjenja.Value;

                bool uspesno = DTOManager.DodajEVozilo(this.elVozilo);

                if (uspesno)
                {
                    MessageBox.Show("Uspešno ste dodali novo električno vozilo.");

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
                string obavestenje = "Neuspešno dodavanje novog električnog vozila.";
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
