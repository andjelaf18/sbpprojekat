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
    public partial class FormVoznje : Form
    {
        public FormVoznje()
        {
            InitializeComponent();
            popuniPodacima();
        }

        public void popuniPodacima() //za listView
        {

            listView1.Items.Clear();
            List<VoznjeView> podaci = DTOManager.VratiSveVoznje();

            foreach (VoznjeView v in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    v.Id.ToString(),
                    v.VremePocetka.ToString(),
                    v.VremeZavrsetka.ToString(),
                    v.Kilometraza.ToString(),
                    v.Trajanje.ToString(),
                    v.PocetniNivoGorIliBat.ToString(),
                    v.PocetnaLokacija,
                    v.ZavrsnaLokacija,
                    v.ObracunataCena.ToString(),
                    v.DodatneNaknade.ToString()
                });
                listView1.Items.Add(item);

            }

            listView1.Refresh();
        }

        private void buttonDodajVoznju_Click(object sender, EventArgs e)
        {
            DodavanjeVoznjeForm d = new DodavanjeVoznjeForm();
            if (d.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void buttonIzmeniVoznju_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vožnju koju želite da izmenite.");
                return;
            }

            int idVoznje = int.Parse(
                listView1.SelectedItems[0].SubItems[0].Text
            );

            VoznjeView izabranaVoznja =
                DTOManager.VratiVoznju(idVoznje);

            if (izabranaVoznja == null)
            {
                MessageBox.Show("Izabrana vožnja nije pronađena.");
                return;
            }

            IzmenaVoznjeForm forma =
                new IzmenaVoznjeForm(izabranaVoznja);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void buttonObrisiVoznju_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vožnju koju želite da obrišete!");
                return;
            }

            int idVoznje = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li želite da obrišete izabranu vožnju?";
            string title = "Pitanje";

            DialogResult result = MessageBox.Show(
                poruka,
                title,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiVoznju(idVoznje);
                MessageBox.Show("Brisanje vožnje je uspešno obavljeno!");
                this.popuniPodacima();
            }
            else
            {
                string obavestenje = "Brisanje vožnje je neuspešno.";
                string naslov = "Pitanje";

                DialogResult prikaz = MessageBox.Show(
                    obavestenje,
                    naslov,
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}
