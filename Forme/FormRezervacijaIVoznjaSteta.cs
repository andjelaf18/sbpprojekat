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
    public partial class FormRezervacijaIVoznjaSteta : Form
    {
        //SteteView steta;

        public FormRezervacijaIVoznjaSteta()
        {
            InitializeComponent();
            popuniPodacima();
        }

        public void popuniPodacima()
        {
            listView1.Items.Clear();

            List<SteteView> podaci =
                DTOManager.VratiStete();

            foreach (SteteView s in podaci)
            {
                ListViewItem item =
                    new ListViewItem(new string[]
                    {
                s.Id.ToString(),
                s.Fotografije ?? "",
                s.Zapisnici ?? "",
                s.OsiguravajuceKuce ?? "",
                s.ProcenaStete ?? "",
                s.Odgovornost ?? "",
                s.IdVoznje == 0
                    ? ""
                    : s.IdVoznje.ToString()
                    });

                listView1.Items.Add(item);
            }

            listView1.Refresh();
        }

        private void buttonDodajDogadjaj_Click(object sender, EventArgs e)
        {

            StetaDodavanje dodavanje = new StetaDodavanje();
            if (dodavanje.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }

        private void buttonIzmeniStetu_Click(object sender, EventArgs e)
        {
            int id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            SteteView s = DTOManager.VratiStetu(id);

            SteteIzmena forma = new SteteIzmena(s);

            if (forma.ShowDialog() == DialogResult.OK)
            {
                popuniPodacima();
            }
        }
    }
}
