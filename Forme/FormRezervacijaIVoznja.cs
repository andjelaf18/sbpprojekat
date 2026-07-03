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
    public partial class FormRezervacijaIVoznja : Form
    {
        public FormRezervacijaIVoznja()
        {
            InitializeComponent();
            popuniPodacima();
        }

        public void popuniPodacima() //za listView
        {

            listView1.Items.Clear();
            List<RezervacijaView> podaci = DTOManager.VratiRezervacije();

            foreach (RezervacijaView r in podaci)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    r.Id.ToString(),
                    r.IdKorisnika.ToString(),
                    r.IdVozaca.ToString(),
                    r.IdVozila.ToString(),
                    r.PlaniranaLokacijaPreuzimanja,
                    r.PlaniranaLokacijaVracanja,
                    r.Tip,
                    r.Status,
                    r.PlaniranoVremePocetka.ToString(),
                    r.PlaniranoVremeZavrsetka.ToString()
                });
                listView1.Items.Add(item);

            }

            listView1.Refresh();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            FormRezervacijaDodavanje forma = new FormRezervacijaDodavanje();

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite rezervaciju koju želite da obrišete!");
                return;
            }

            int idRezervacije = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li želite da obrišete izabranu rezervaciju?";
            string title = "Pitanje";

            DialogResult result = MessageBox.Show(
                poruka,
                title,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiRezervacija(idRezervacije);
                MessageBox.Show("Brisanje rezervacije je uspešno obavljeno!");
                this.popuniPodacima();
            }
            else
            {
                string obavestenje = "Brisanje rezervacije je neuspešno.";
                string naslov = "Pitanje";

                DialogResult prikaz = MessageBox.Show(
                    obavestenje,
                    naslov,
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void vožnjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVoznje voznje = new FormVoznje();
            voznje.ShowDialog();
        }

        private void događajiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRezervacijaIVoznjaDogadjaji forma = new FormRezervacijaIVoznjaDogadjaji();
            forma.Show();
        }

        private void šteteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRezervacijaIVoznjaSteta steta = new FormRezervacijaIVoznjaSteta();
            steta.ShowDialog();
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite rezervaciju za izmenu.");
                return;
            }

            int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            RezervacijaView r = DTOManager.VratiRezervaciju(id);

            FormRezervacijaIzmeni forma = new FormRezervacijaIzmeni(r);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void službenaŠtetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SluzbeneVoznje voznje = new SluzbeneVoznje();
            voznje.Show();
        }
    }
}
