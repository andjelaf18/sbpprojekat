using IznajmljivanjeVozila.Entiteti;
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
    public partial class SteteIzmena : Form
    {
        public SteteView steta;

        public SteteIzmena()
        {
            InitializeComponent();
        }

        public SteteIzmena(SteteView s)
        {
            InitializeComponent();
            this.steta = s;
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            textBoxID.Text = steta.Id.ToString();
            textBoxID.Enabled = false;

            textBoxFoto.Text = steta.Fotografije;
            textBoxZapisnici.Text = steta.Zapisnici;
            textBoxOsiguravajuceKuce.Text = steta.OsiguravajuceKuce;
            textBoxProcenaStete.Text = steta.ProcenaStete;
            textBoxOdgovornosti.Text = steta.Odgovornost;
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            steta.Fotografije = textBoxFoto.Text;
            steta.Zapisnici = textBoxZapisnici.Text;
            steta.OsiguravajuceKuce = textBoxOsiguravajuceKuce.Text;
            steta.ProcenaStete = textBoxProcenaStete.Text;
            steta.Odgovornost  = textBoxOdgovornosti.Text;

            bool uspesno = DTOManager.IzmeniStetu(steta);

            if (uspesno)
            {
                MessageBox.Show("Ažuriranje štete je uspešno izvršeno!");

                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
