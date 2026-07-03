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
    public partial class FormPravnaLicaKorisnik : Form
    {
        public FormPravnaLicaKorisnik()
        {
            InitializeComponent();
            listView1.View = View.Details;
            popuniPodacima();
        }
        public void popuniPodacima() //za listView
        {

            listView1.Items.Clear();
            List<PLicaView> podaci = DTOManager.VratiSvaPravnaLica();

            foreach (PLicaView pl in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    pl.Id.ToString(),
                    pl.Naziv,
                    pl.MatBr,
                    pl.Sediste,
                    pl.KontaktOsoba,
                    pl.UgovorniUslovi,
                    pl.Pib.ToString()
                });
                listView1.Items.Add(item);

            }

            listView1.Refresh();
        }

        private void FormPravnaLicaKorisnik_Load(object sender, EventArgs e)
        {

        }
    }
}
