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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IznajmljivanjeVozila.Forme
{
    public partial class IzmenaVoznjeForm : Form
    {
        public IzmenaVoznjeForm()
        {
            InitializeComponent();
        }

        public VoznjeView voznja;

        public IzmenaVoznjeForm(VoznjeView v)
        {
            InitializeComponent();
            this.voznja = v;

        }

        private void popuniPodacima()
        {
            // textBoxId.Text = voznja.Id.ToString();
            // textBoxId.Enabled = false;

            dateTimePickerP.Value = voznja.VremePocetka;
            dateTimePickerZ.Value = voznja.VremeZavrsetka;
            textBoxKm.Text = voznja.Kilometraza.ToString();
            textBoxTrajanje.Text = voznja.Trajanje.ToString();
            textBoxDodatneNaknade.Text = voznja.DodatneNaknade.ToString();
            numericUpDown1.Value = voznja.PocetniNivoGorIliBat;
            textBoxPLokacija.Text = voznja.PocetnaLokacija;
            textBoxZLokacija.Text = voznja.ZavrsnaLokacija;
            textBoxObracunaCena.Text = voznja.ObracunataCena.ToString();
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {

            voznja.VremePocetka = dateTimePickerP.Value;
            voznja.VremeZavrsetka = dateTimePickerZ.Value;
            voznja.Kilometraza = decimal.Parse(textBoxKm.Text);
            voznja.Trajanje = decimal.Parse(textBoxTrajanje.Text);
            voznja.DodatneNaknade = double.Parse(textBoxDodatneNaknade.Text);
            voznja.PocetniNivoGorIliBat = numericUpDown1.Value;
            voznja.PocetnaLokacija = textBoxPLokacija.Text;
            voznja.ZavrsnaLokacija = textBoxZLokacija.Text;
            voznja.ObracunataCena = double.Parse(textBoxObracunaCena.Text);

            DTOManager.IzmeniVoznju(voznja);

            MessageBox.Show("Ažuriranje vožnje je uspešno izvršeno!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void IzmenaVoznjeForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
    }
}
