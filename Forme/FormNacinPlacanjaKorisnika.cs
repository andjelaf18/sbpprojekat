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
    public partial class FormNacinPlacanjaKorisnika : Form
    {
        NacinPlacanjaView np;
        public FormNacinPlacanjaKorisnika()
        {
            InitializeComponent();
            popuniComboKorisnici();
            //popuniPodacima();
        }

        private void popuniPodacima()
        {
            listViewNP.Items.Clear();

            KorisnikCombo korisnik = comboBoxKorisnik.SelectedItem as KorisnikCombo;

            if (korisnik == null)
                return;

            List<NacinPlacanjaView> placanja =
                DTOManager.VratiPlacanjaKorisnika(korisnik.Id);

            foreach (NacinPlacanjaView np in placanja)
            {
                ListViewItem item = new ListViewItem(np.Id.ToString());
                item.SubItems.Add(np.TipPlacanja);
                item.SubItems.Add(np.Status);
                item.SubItems.Add(np.DatumOgranicenja.ToShortDateString());
                item.SubItems.Add(np.IdKorisnika.ToString());

                listViewNP.Items.Add(item);
            }
        }

        private void popuniComboKorisnici()
        {
            comboBoxKorisnik.DataSource = DTOManager.VratiKorisnikeZaCombo();
            comboBoxKorisnik.DisplayMember = "Prikaz";
            comboBoxKorisnik.ValueMember = "Id";
            comboBoxKorisnik.SelectedIndex = -1;

            if (comboBoxKorisnik.Items.Count > 0)
                comboBoxKorisnik.SelectedIndex = 0;

            popuniPodacima();
        }

        private void buttonDodajNP_Click(object sender, EventArgs e)
        {
            KorisnikCombo korisnik = comboBoxKorisnik.SelectedItem as KorisnikCombo;

            if (korisnik == null)
            {
                MessageBox.Show("Izaberite korisnika.");
                return;
            }

            FormZaDodavanjeNacinaPlacanja forma =
                new FormZaDodavanjeNacinaPlacanja(korisnik.Id);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void buttonIzmeniNP_Click(object sender, EventArgs e)
        {
            if (listViewNP.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite način plaćanja za izmenu.");
                return;
            }

            int id = int.Parse(listViewNP.SelectedItems[0].SubItems[0].Text);

            NacinPlacanjaView np = DTOManager.VratiNacinPlacanja(id);

            FormZaIzmenuNacinaPlacanja forma = new FormZaIzmenuNacinaPlacanja(np);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void comboBoxKorisnik_SelectedIndexChanged(object sender, EventArgs e)
        {
            popuniPodacima();
        }

     
    }
}
