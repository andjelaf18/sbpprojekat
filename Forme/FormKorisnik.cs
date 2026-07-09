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
    public partial class FormKorisnik : Form
    {
        public FormKorisnik()
        {
            InitializeComponent();
            listView1.View = View.Details;
            popuniPodacima();
        }

        public void popuniPodacima() //za listView
        {

            listView1.Items.Clear();
            List<KorisnikView> podaci = DTOManager.VratiSveKorisnike();

            foreach (KorisnikView k in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    k.Id.ToString(),
                    k.Adresa,
                    k.BrojTelefona,
                    k.Email,
                    k.StatusNaloga,
                    k.NacinVerifikacije,
                    k.DatumRegistracije.ToShortDateString()
                });
                listView1.Items.Add(item);

            }

            listView1.Refresh();
        }

        private void nacinPlacanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNacinPlacanjaKorisnika forma = new FormNacinPlacanjaKorisnika();
            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void pravnaLicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPravnaLicaKorisnik forma = new FormPravnaLicaKorisnik();
            forma.ShowDialog();
        }

        private void buttonDodajKorisnika_Click(object sender, EventArgs e)
        {
            FormZaDodavanjeKorisnika forma = new FormZaDodavanjeKorisnika();

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void buttonIzmeniKorisnika_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite korisnika koga želite da izmenite.");
                return;
            }

            int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            KorisnikView k = DTOManager.VratiKorisnika(id);

            FormZaIzmenuKorisnika forma = new FormZaIzmenuKorisnika(k);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void buttonObrisiKorisnika_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite korisnika koga želite da obrišete!");
                return;
            }

            int idKorisnika = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li želite da obrišete izabranog korisnika?";
            string title = "Pitanje";

            DialogResult result = MessageBox.Show(
                poruka,
                title,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.OK)
            {
                bool uspesno =
    DTOManager.ObrisiKorisnikaSvuda(
        idKorisnika
    );

                if (uspesno)
                {
                    MessageBox.Show(
                        "Brisanje korisnika je uspešno obavljeno!"
                    );

                    popuniPodacima();
                }
                else
                {
                    MessageBox.Show(
                        "Korisnik nije obrisan."
                    );
                }
            }
            else
            {
                string obavestenje = "Brisanje korisnika je neuspešno.";
                string naslov = "Pitanje";

                DialogResult prikaz = MessageBox.Show(
                    obavestenje,
                    naslov,
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void FormKorisnik_Load(object sender, EventArgs e)
        {

        }
    }
}
