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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IznajmljivanjeVozila.Forme
{
    public partial class VoziloIzmenaForm : Form
    {
        public VoziloView vozilo;

        public VoziloIzmenaForm(VoziloView v)
        {
            InitializeComponent();
            this.vozilo = v;
        }

        private void popuniPodacima()
        {
            //textBoxId.Text = vozilo.Id.ToString();
            // textBoxId.Enabled = false;

            textBoxRegistracija.Text = vozilo.Registracija;
            textBoxVinBroj.Text = vozilo.VinBr.ToString();
            textBoxMarka.Text = vozilo.Marka;
            textBoxModel.Text = vozilo.Model;
            textBoxGodProizvodnje.Text = vozilo.GodProizvodnje.ToString();
            dateTimePickerNabavka.Text = vozilo.DatumNabavke.ToShortDateString();
            textBoxStatus.Text = vozilo.Status;
            textBoxTipKoriscenja.Text = vozilo.TipKoriscenja;
            numericUpDownBrSedista.Value = vozilo.BrSedista;
            textBoxStanjeEnterijera.Text = vozilo.StanjeEnterijera;
            textBoxStanjeEksterijera.Text = vozilo.StanjeEksterijera;
            textBoxDodatnaOprema.Text = vozilo.DodatnaOprema;
        }


        private void buttonIzmeniVozilo_Click(object sender, EventArgs e)
        {
            vozilo.Registracija = textBoxRegistracija.Text;
            vozilo.VinBr = textBoxVinBroj.Text;
            vozilo.Marka = textBoxMarka.Text;
            vozilo.Model = textBoxModel.Text;
            vozilo.GodProizvodnje = int.Parse(textBoxGodProizvodnje.Text);
            vozilo.DatumNabavke = DateTime.Parse(dateTimePickerNabavka.Text);
            vozilo.Status = textBoxStatus.Text;
            vozilo.TipKoriscenja = textBoxTipKoriscenja.Text;
            vozilo.BrSedista = (int)numericUpDownBrSedista.Value;
            vozilo.StanjeEnterijera = textBoxStanjeEnterijera.Text;
            vozilo.StanjeEksterijera = textBoxStanjeEksterijera.Text;
            //dodatna oprema

            DTOManager.IzmeniVozilo(vozilo);

            MessageBox.Show("Ažuriranje vozila je uspešno izvršeno!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void VoziloIzmenaForm_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
    }
}
