using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace IznajmljivanjeVozila.Forme
{
    public partial class VoziloPretragaForm : Form
    {
        public VoziloPretragaForm()
        {
            InitializeComponent();
            comboBoxTipPogona.SelectedIndex = 0;
            comboBoxStatus.SelectedIndex = 0;
            comboBoxNamena.SelectedIndex = 0;
            comboBoxTipKoriscenja.SelectedIndex = 0;
        }

        private void buttonPretrazi_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            List<PretrazenoVozilo> vozila = DTOManager.PretraziVozila(
                textBoxMarka.Text,
                textBoxModel.Text,
                comboBoxStatus.Text,
                comboBoxTipKoriscenja.Text,
                comboBoxNamena.Text,
                comboBoxTipPogona.Text
            );

            foreach (PretrazenoVozilo v in vozila)
            {
                ListViewItem item = new ListViewItem(v.Id.ToString());
                item.SubItems.Add(v.Marka);
                item.SubItems.Add(v.Model);
                item.SubItems.Add(v.Status);
                item.SubItems.Add(v.TipKoriscenja);
                item.SubItems.Add(v.BrSedista.ToString());
                item.SubItems.Add(v.NamenaVozila);
                item.SubItems.Add(v.TipPogona);
                item.SubItems.Add(v.Detalji);

                listView1.Items.Add(item);
            }
        }
    }
}
