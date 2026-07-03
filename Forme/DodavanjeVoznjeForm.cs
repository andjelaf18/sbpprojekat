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

namespace IznajmljivanjeVozila.Forme
{
    public partial class DodavanjeVoznjeForm : Form
    {
        VoznjeView voznje;
        public DodavanjeVoznjeForm()
        {
            InitializeComponent();
            voznje = new VoznjeView();
        }

        private void DodavanjeVoznjeForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da dodate novu vožnju?";
            string title = "Pitanje";

            DialogResult result = MessageBox.Show(
                poruka,
                title,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.OK)
            {
                this.voznje.Id = int.Parse(textBoxId.Text);
                this.voznje.VremePocetka = dateTimePickerP.Value;
                this.voznje.VremeZavrsetka = dateTimePickerZ.Value;
                this.voznje.Kilometraza = decimal.Parse(textBoxKm.Text);
                this.voznje.Trajanje = decimal.Parse(textBoxTrajanje.Text);
                this.voznje.DodatneNaknade = double.Parse(textBoxDodatneNaknade.Text);
                this.voznje.PocetniNivoGorIliBat = numericUpDown1.Value;
                this.voznje.PocetnaLokacija = textBoxPLokacija.Text;
                this.voznje.ZavrsnaLokacija = textBoxZLokacija.Text;
                this.voznje.ObracunataCena = double.Parse(textBoxObracunaCena.Text);

                bool uspesno = DTOManager.DodajVoznju(this.voznje);

                if (uspesno)
                {
                    MessageBox.Show("Uspešno ste dodali novu vožnju.");

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
                string obavestenje = "Neuspešno dodavanje nove vožnje.";
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
