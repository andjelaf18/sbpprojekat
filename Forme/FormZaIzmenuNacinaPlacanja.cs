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
    public partial class FormZaIzmenuNacinaPlacanja : Form
    {
        NacinPlacanjaView nacinplacanja;

        public FormZaIzmenuNacinaPlacanja(NacinPlacanjaView np)
        {
            InitializeComponent();
            nacinplacanja = np;
        }

        private void popuniPodacima()
        {
            textBoxId.Text = nacinplacanja.Id.ToString();
            textBoxTipPlacanja.Text = nacinplacanja.TipPlacanja;
            textBoxStatus.Text = nacinplacanja.Status;
            dateTimePicker1.Value = nacinplacanja.DatumOgranicenja;
        }

        private bool ValidacijaUnosa()
        {

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

        private void buttonIzmeniNP_Click(object sender, EventArgs e)
        {
            if (!ValidacijaUnosa())
                return;

            nacinplacanja.TipPlacanja = textBoxTipPlacanja.Text;
            nacinplacanja.Status = textBoxStatus.Text;
            nacinplacanja.DatumOgranicenja = dateTimePicker1.Value;

            DTOManager.IzmenaNacinaPlacanja(nacinplacanja);

            MessageBox.Show("Ažuriranje načina plaćanja je uspešno izvršeno!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FormZaIzmenuNacinaPlacanja_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }

    }
}
