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
    public partial class VoziloServisiKvaroviForm : Form
    {
        private int idVozila;
        public VoziloServisiKvaroviForm(int id)
        {
            InitializeComponent();
            idVozila = id;
            popuniPodacimaZaServis();
            popuniPodacimaZaKvarove();
        }

        public void popuniPodacimaZaServis() //za listView
        {

            listViewServisi.Items.Clear();
            List<ServisiView> podaci = DTOManager.VratiServise(idVozila);

            foreach (ServisiView s in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    s.Id.ToString(),
                    s.ServisniCentar,
                    s.DatumPrijema.ToString(),
                    s.DatumZavrsetka.ToString(),
                    s.OpisRadova,
                    s.ZamenjeniDelovi,
                    s.Status,
                    s.Tip,
                    s.Troskovi.ToString()
                });
                listViewServisi.Items.Add(item);

            }

            listViewServisi.Refresh();
        }

        public void popuniPodacimaZaKvarove() //za listView
        {

            listViewKvar.Items.Clear();
            List<KvaroviView> podaci = DTOManager.VratiKvarove(idVozila);

            foreach (KvaroviView k in podaci)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    k.Id.ToString(),
                    k.PrijavioKvar,
                    k.OpisProblema,
                    k.ProcenaOzbiljnosti,
                    k.Status,
                    k.DatumPrijave.ToString(),
                    k.DatumOtklanjanja.ToString()
                });
                listViewKvar.Items.Add(item);

            }

            listViewKvar.Refresh();
        }


    }
}
