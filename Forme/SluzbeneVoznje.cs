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
    public partial class SluzbeneVoznje : Form
    {
        public SluzbeneVoznje()
        {
            InitializeComponent();
            popuniComboOvlascenimLicima();

            comboBoxOvlascenoLice.SelectedIndexChanged +=
                comboBoxOvlascenoLice_SelectedIndexChanged;

           // popuniPodacima();
        }

        private void popuniComboOvlascenimLicima()
        {
            comboBoxOvlascenoLice.DataSource =
                DTOManager.VratiOvlascenaLicaZaCombo();

            comboBoxOvlascenoLice.DisplayMember = "Podaci";
            comboBoxOvlascenoLice.ValueMember = "Id";

            comboBoxOvlascenoLice.SelectedIndex = -1;
        }

        private void popuniPodacima()
        {
            listView1.Items.Clear();

            OvlascenoLiceCombo lice =
                comboBoxOvlascenoLice.SelectedItem as OvlascenoLiceCombo;

            if (lice == null)
                return;

            List<SluzbeneVoznjeView> voznje =
                DTOManager.VratiSluzbeneVoznjeOvlascenogLica(lice.Id);

            foreach (SluzbeneVoznjeView sv in voznje)
            {
                ListViewItem item =
                    new ListViewItem(sv.Id.ToString());

                item.SubItems.Add(sv.Razlog);

                listView1.Items.Add(item);
            }
        }

        private void comboBoxOvlascenoLice_SelectedIndexChanged(object sender, EventArgs e)
        {
            popuniPodacima();
        }
    }
}
