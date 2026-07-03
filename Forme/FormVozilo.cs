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
    public partial class FormVozilo : Form
    {
        public FormVozilo()
        {
            InitializeComponent();
            popuniPodacima();
        }

        public void popuniPodacima() //za listView
        {

            listView1.Items.Clear();
            List<VoziloView> podaci = DTOManager.VratiSvaVozila();

            foreach (VoziloView v in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    v.Id.ToString(),
                    v.Registracija,
                    v.VinBr,
                    v.Marka,
                    v.Model,
                    v.GodProizvodnje.ToString(),
                    v.DatumNabavke.ToString(),
                    v.Status,
                    v.TipKoriscenja,
                    v.BrSedista.ToString(),
                    v.StanjeEnterijera,
                    v.StanjeEksterijera,
                    v.DodatnaOprema.ToString()
                });
                listView1.Items.Add(item);

            }

            listView1.Refresh();
        }

        private void buttonObrisiVozilo_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozilo koje želite da obrišete!");
                return;
            }

            int idVozila = Int32.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            string poruka = "Da li želite da obrišete izabrano vozilo?";
            string title = "Pitanje";

            DialogResult result = MessageBox.Show(
                poruka,
                title,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiVozilo(idVozila);
                MessageBox.Show("Brisanje vozila je uspešno obavljeno!");
                this.popuniPodacima();
            }
            else
            {
                string obavestenje = "Brisanje vozila je neuspešno.";
                string naslov = "Pitanje";

                DialogResult prikaz = MessageBox.Show(
                    obavestenje,
                    naslov,
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void buttonDodajVozilo_Click(object sender, EventArgs e)
        {
            VoziloDodavanjeForm forma = new VoziloDodavanjeForm();
            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void buttonIzmeniVozilo_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozilo koje želite da izmenite.");
                return;
            }

            int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            VoziloView k = DTOManager.VratiVozilo(id);

            VoziloIzmenaForm forma = new VoziloIzmenaForm(k);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void pretragaVozilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VoziloPretragaForm form = new VoziloPretragaForm();
            form.Show();
        }

        private void buttonServisiKvarovi_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite vozilo.");
                return;
            }

            int idVozila = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

            VoziloServisiKvaroviForm form = new VoziloServisiKvaroviForm(idVozila);
            form.ShowDialog();
        }
    }
}
