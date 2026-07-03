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
    public partial class VoziloDodavanjeForm : Form
    {
        VoziloView vozilo;

        public VoziloDodavanjeForm()
        {
            InitializeComponent();
            vozilo = new VoziloView();
        }

        private void buttonDodajVozilo_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da dodate novo vozilo?";
            string title = "Pitanje";

            DialogResult result = MessageBox.Show(
                poruka,
                title,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.OK)
            {
                this.vozilo.Id = int.Parse(textBoxId.Text);
                this.vozilo.Registracija = textBoxRegistracija.Text;
                this.vozilo.VinBr = textBoxVinBroj.Text;
                this.vozilo.Marka = textBoxMarka.Text;
                this.vozilo.Model = textBoxModel.Text;
                this.vozilo.GodProizvodnje = int.Parse(textBoxGodProizvodnje.Text);
                this.vozilo.DatumNabavke = dateTimePickerNabavka.Value;
                this.vozilo.Status = textBoxStatus.Text;
                this.vozilo.TipKoriscenja = textBoxTipKoriscenja.Text;
                this.vozilo.BrSedista = (int)numericUpDownBrSedista.Value;
                this.vozilo.StanjeEnterijera = textBoxStanjeEnterijera.Text;
                this.vozilo.StanjeEksterijera = textBoxStanjeEksterijera.Text;
                this.vozilo.DodatnaOprema = textBoxDodatnaOprema.Text;

                bool uspesno = DTOManager.DodajVozilo(this.vozilo);

                if (uspesno)
                {
                    MessageBox.Show("Uspešno ste dodali novo vozilo.");

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
                string obavestenje = "Neuspešno dodavanje novog vozila.";
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
