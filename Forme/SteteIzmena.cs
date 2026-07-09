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

namespace IznajmljivanjeVozila.Forme
{
    public partial class SteteIzmena : Form
    {
        public SteteView steta;
        private string putanjaFotografije = string.Empty;

        public SteteIzmena()
        {
            InitializeComponent();
        }

        public SteteIzmena(SteteView s)
        {
            InitializeComponent();

            steta = s;

            PopuniComboVoznje();
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            textBoxID.Text = steta.Id.ToString();
            textBoxID.Enabled = false;

            putanjaFotografije = steta.Fotografije;

            if (!string.IsNullOrWhiteSpace(putanjaFotografije))
            {
                labelFotografija.Text = "Fotografija je\r\nveć izabrana.";

                labelFotografija.Visible = true;
            }
            else
            {
                labelFotografija.Visible = false;
            }
            textBoxZapisnici.Text = steta.Zapisnici;
            textBoxOsiguravajuceKuce.Text = steta.OsiguravajuceKuce;
            textBoxProcenaStete.Text = steta.ProcenaStete;
            textBoxOdgovornosti.Text = steta.Odgovornost;
            comboBoxVoznja.SelectedValue = steta.IdVoznje;
            comboBoxVoznja.Enabled = false;
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

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            steta.Fotografije = putanjaFotografije;
            steta.Zapisnici = textBoxZapisnici.Text;
            steta.OsiguravajuceKuce = textBoxOsiguravajuceKuce.Text;
            steta.ProcenaStete = textBoxProcenaStete.Text;
            steta.Odgovornost = textBoxOdgovornosti.Text;
            VoznjaCombo izabranaVoznja =
    comboBoxVoznja.SelectedItem
        as VoznjaCombo;

            if (izabranaVoznja == null)
            {
                MessageBox.Show(
                    "Izaberite vožnju."
                );

                return;
            }

            steta.IdVoznje =
                izabranaVoznja.Id;

            bool uspesno = DTOManager.IzmeniStetu(steta);

            if (uspesno)
            {
                MessageBox.Show("Ažuriranje štete je uspešno izvršeno!");

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void buttonIzaberiFoto_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Slike (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                putanjaFotografije = openFileDialog1.FileName;

                labelFotografija.Text = "Uspešno ste izabrali\r\nnovu fotografiju.";

                labelFotografija.Visible = true;
            }
        }
    }
}
