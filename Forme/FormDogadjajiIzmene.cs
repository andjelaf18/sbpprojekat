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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IznajmljivanjeVozila.Forme
{
    public partial class FormDogadjajiIzmene : Form
    {
        public DogadjajiView dogadjaj;

        public FormDogadjajiIzmene()
        {
            InitializeComponent();
        }

        public FormDogadjajiIzmene(DogadjajiView d)
        {
            InitializeComponent();
            this.dogadjaj = d;
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            textBoxID.Text = dogadjaj.Id.ToString();
            textBoxID.Enabled = false;

            textBoxNagloKocenje.Text = dogadjaj.NagloKocenje;
            textBoxPrekoracenjeBrzine.Text = dogadjaj.PrekoracenjeBrzine;
            textBoxDuzeZadrzavanje.Text = dogadjaj.DuzeZadrzavanje;
            textBoxNeovlasceniIzlazak.Text = dogadjaj.NeovlasceniIzlazak;
            textBoxSudar.Text = dogadjaj.Sudar;
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            dogadjaj.NagloKocenje = textBoxNagloKocenje.Text;
            dogadjaj.PrekoracenjeBrzine = textBoxPrekoracenjeBrzine.Text;
            dogadjaj.DuzeZadrzavanje = textBoxDuzeZadrzavanje.Text;
            dogadjaj.NeovlasceniIzlazak = textBoxNeovlasceniIzlazak.Text;
            dogadjaj.Sudar = textBoxSudar.Text;

            bool uspesno = DTOManager.IzmeniDogadjaj(dogadjaj);

            if (uspesno)
            {
                MessageBox.Show("Ažuriranje događajaja je uspešno izvršeno!");

                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
