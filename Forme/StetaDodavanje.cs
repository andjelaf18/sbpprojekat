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
    public partial class StetaDodavanje : Form
    {
        SteteView steta;
        private string putanjaFotografije = string.Empty;

        public StetaDodavanje()
        {
            InitializeComponent();
            
            steta = new SteteView();

            PopuniComboVoznje();

            comboBoxVoznja.SelectedIndex = -1;
        }

        private void PopuniComboVoznje()
        {
            comboBoxVoznja.DataSource =
                DTOManager.VratiVoznjeZaCombo();

            comboBoxVoznja.DisplayMember =
                "Prikaz";

            comboBoxVoznja.ValueMember =
                "Id";

            comboBoxVoznja.DropDownStyle =
                ComboBoxStyle.DropDownList;
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da dodate novu štetu?";
            string title = "Pitanje";

            DialogResult result = MessageBox.Show(
                poruka,
                title,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.OK)
            {
                this.steta.Id = int.Parse(textBoxID.Text);
                this.steta.Fotografije = putanjaFotografije;
                this.steta.Zapisnici = textBoxZapisnici.Text;
                this.steta.OsiguravajuceKuce = textBoxOsiguravajuceKuce.Text;
                this.steta.ProcenaStete = textBoxProcenaStete.Text;
                this.steta.Odgovornost = textBoxOdgovornosti.Text;
                VoznjaCombo izabranaVoznja = comboBoxVoznja.SelectedItem as VoznjaCombo;

                if (izabranaVoznja == null)
                {
                    MessageBox.Show(
                        "Izaberite vožnju tokom koje je nastala šteta."
                    );

                    return;
                }

                steta.IdVoznje = izabranaVoznja.Id;

                bool uspesno = DTOManager.DodajStetu(this.steta);

                if (uspesno)
                {
                    MessageBox.Show("Uspešno ste dodali novu štetu.");

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
                string obavestenje = "Neuspešno dodavanje nove štete.";
                string naslov = "Upozorenje";

                DialogResult greska = MessageBox.Show(
                    obavestenje,
                    naslov,
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void buttonIzaberiFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Slike (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog1.Multiselect = false;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                putanjaFotografije = openFileDialog1.FileName;
                labelFotografija.Text = "Uspešno ste izabrali\r\nfotografiju.";
                labelFotografija.Visible = true;
            }
        }
    }
}
