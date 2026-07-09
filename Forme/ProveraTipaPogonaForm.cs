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
    public partial class ProveraTipaPogonaForm : Form
    {
        public ProveraTipaPogonaForm()
        {
            InitializeComponent();
        }

        private void buttonHVozilo_Click(object sender, EventArgs e)
        {
            HibridnoVoziloDodavanje forma = new HibridnoVoziloDodavanje();

            if (forma.ShowDialog() == DialogResult.OK)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void buttonKVozilo_Click(object sender, EventArgs e)
        {
            KlasicnoVoziloDodavanje kv = new KlasicnoVoziloDodavanje();
            if (kv.ShowDialog() == DialogResult.OK)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void buttonEVozilo_Click(object sender, EventArgs e)
        {
            ElektricnoVoziloDodavanje ev = new ElektricnoVoziloDodavanje();
            if (ev.ShowDialog() == DialogResult.OK)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
