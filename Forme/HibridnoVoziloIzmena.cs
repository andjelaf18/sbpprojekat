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
    public partial class HibridnoVoziloIzmena : Form
    {
        public HibridnoVoziloIzmena()
        {
            InitializeComponent();
        }

        public HibridnoVoziloView vozilo;

        public HibridnoVoziloIzmena(HibridnoVoziloView v)
        {
            InitializeComponent();
            this.vozilo = v;
        }

        private void popuniPodacima()
        {
            textBoxId.Text = vozilo.Id.ToString();
            textBoxId.Enabled = false;

            textBoxRegistracija.Text = vozilo.Registracija;
            textBoxVinBroj.Text = vozilo.VinBr.ToString();
            textBoxMarka.Text = vozilo.Marka;
            textBoxModel.Text = vozilo.Model;
            textBoxGodProizvodnje.Text = vozilo.GodProizvodnje.ToString();
            dateTimePickerNabavka.Value = vozilo.DatumNabavke;
            textBoxStatus.Text = vozilo.Status;
            textBoxTipKoriscenja.Text = vozilo.TipKoriscenja;
            numericUpDownBrSedista.Value = vozilo.BrSedista;
            textBoxStanjeEnterijera.Text = vozilo.StanjeEnterijera;
            textBoxStanjeEksterijera.Text = vozilo.StanjeEksterijera;
            textBoxDodatnaOprema.Text = vozilo.DodatnaOprema;

            numericUpDownKapBat.Value = (decimal)vozilo.KapacitetBat;
            textBoxTipHVozila.Text = vozilo.TipHibridnogVozila;

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
            vozilo.DodatnaOprema = textBoxDodatnaOprema.Text;

            vozilo.KapacitetBat = (double)numericUpDownKapBat.Value;
            vozilo.TipHibridnogVozila = textBoxTipHVozila.Text;

            DTOManager.IzmeniHVozilo(vozilo);

            MessageBox.Show("Ažuriranje hibridnog vozila je uspešno izvršeno!");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void HibridnoVoziloIzmena_Load(object sender, EventArgs e)
        {
            popuniPodacima();
        }
    }
}
