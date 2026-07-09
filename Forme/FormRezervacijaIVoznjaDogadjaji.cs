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
    public partial class FormRezervacijaIVoznjaDogadjaji : Form
    {
        DogadjajiView dogadjajiView;

        public FormRezervacijaIVoznjaDogadjaji()
        {
            InitializeComponent();
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listView1.Items.Clear();

            List<DogadjajiView> podaci =
                DTOManager.VratiSveDogadjaje();

            foreach (DogadjajiView d in podaci)
            {
                ListViewItem item =
                    new ListViewItem(new string[]
                    {
                d.Id.ToString(),
                d.NagloKocenje ?? "",
                d.PrekoracenjeBrzine ?? "",
                d.DuzeZadrzavanje ?? "",
                d.NeovlasceniIzlazak ?? "",
                d.Sudar ?? "",
                d.IdVoznje == 0
                    ? ""
                    : d.IdVoznje.ToString()
                    });

                listView1.Items.Add(item);
            }

            listView1.Refresh();
        }


        private void buttonDodajDogadjaj_Click(object sender, EventArgs e)
        {
            FormDogadjajDodavanje dodavanje = new FormDogadjajDodavanje();
            if (dodavanje.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void buttonIzmeniDogadjaj_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite događaj koji želite da izmenite.");
                return;
            }
            int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            DogadjajiView d = DTOManager.VratiDogadjaj(id);

            FormDogadjajiIzmene forma = new FormDogadjajiIzmene(d);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }
    }
}
