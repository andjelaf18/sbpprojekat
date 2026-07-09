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
    public partial class HibridnoVoziloDodavanje : Form
    {
        HibridnoVoziloView hibrVozilo;

        public HibridnoVoziloDodavanje()
        {
            InitializeComponent();
            hibrVozilo = new HibridnoVoziloView();
        }

        private void buttonDodajVozilo_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da dodate novo hibridno vozilo?";
            string title = "Pitanje";

            DialogResult result = MessageBox.Show(
                poruka,
                title,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.OK)
            {
                this.hibrVozilo.Id = int.Parse(textBoxId.Text);
                this.hibrVozilo.Registracija = textBoxRegistracija.Text;
                this.hibrVozilo.VinBr = textBoxVinBroj.Text;
                this.hibrVozilo.Marka = textBoxMarka.Text;
                this.hibrVozilo.Model = textBoxModel.Text;
                this.hibrVozilo.GodProizvodnje = int.Parse(textBoxGodProizvodnje.Text);
                this.hibrVozilo.DatumNabavke = dateTimePickerNabavka.Value;
                this.hibrVozilo.Status = textBoxStatus.Text;
                this.hibrVozilo.TipKoriscenja = textBoxTipKoriscenja.Text;
                this.hibrVozilo.BrSedista = (int)numericUpDownBrSedista.Value;
                this.hibrVozilo.StanjeEnterijera = textBoxStanjeEnterijera.Text;
                this.hibrVozilo.StanjeEksterijera = textBoxStanjeEksterijera.Text;
                this.hibrVozilo.DodatnaOprema = textBoxDodatnaOprema.Text;

                this.hibrVozilo.KapacitetBat = (double)numericUpDownKapBat.Value;
                this.hibrVozilo.TipHibridnogVozila = textBoxTipHVozila.Text;

                bool uspesno = DTOManager.DodajHVozilo(this.hibrVozilo);

                if (uspesno)
                {
                    MessageBox.Show("Uspešno ste dodali novo hibridno vozilo.");

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
                string obavestenje = "Neuspešno dodavanje novog hibridnog vozila.";
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
