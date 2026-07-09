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
    public partial class DostupnostVozila : Form
    {
        private VoziloView vozilo;

        public DostupnostVozila()
        {
            InitializeComponent();
        }
        public DostupnostVozila(VoziloView vozilo)
          : this()
        {
            this.vozilo = vozilo;

            PrikaziPodatkeOVozilu();

            dateTimePickerPocetak.Value =
                DateTime.Now;

            dateTimePickerKraj.Value =
                DateTime.Now.AddHours(1);

            labelRezultat.Visible = false;
        }

        public DostupnostVozila(
            VoziloView vozilo,
            DateTime pocetak,
            DateTime kraj)
            : this(vozilo)
        {
            dateTimePickerPocetak.Value = pocetak;
            dateTimePickerKraj.Value = kraj;
        }

        private void PrikaziPodatkeOVozilu()
        {
            if (vozilo == null)
                return;

            labelPodaciVozilo.Text =
                $"{vozilo.Id} - " +
                $"{vozilo.Marka} " +
                $"{vozilo.Model} " +
                $"({vozilo.Registracija})";
        }

        private void buttonProvera_Click(object sender, EventArgs e)
        {
            if (vozilo == null)
            {
                MessageBox.Show(
                    "Vozilo nije izabrano.");

                return;
            }

            DateTime pocetak =
                dateTimePickerPocetak.Value;

            DateTime kraj =
                dateTimePickerKraj.Value;

            if (kraj <= pocetak)
            {
                MessageBox.Show(
                    "Vreme završetka mora biti nakon početka.");

                return;
            }

            DostupnostVozilaView rezultat =
                DTOManager.ProveriDostupnostVozila(
                    vozilo.Id,
                    pocetak,
                    kraj
                );

            labelRezultat.Text = rezultat.Poruka;
            labelRezultat.Visible = true;

            if (rezultat.Dostupno)
            {
                labelRezultat.ForeColor =
                    Color.DarkGreen;
            }
            else
            {
                labelRezultat.ForeColor =
                    Color.DarkRed;
            }
        }
    }
}
