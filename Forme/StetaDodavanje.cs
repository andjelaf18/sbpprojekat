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
    public partial class StetaDodavanje : Form
    {
        SteteView steta;

        public StetaDodavanje()
        {
            InitializeComponent();
            steta = new SteteView();
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            string poruka = "Da li želite da dodate novu štetu?";
            string title = "Pitanje";

            DialogResult result = MessageBox.Show(
                poruka,
                title,
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.OK)
            {
                this.steta.Id = int.Parse(textBoxID.Text);
                this.steta.Fotografije = textBoxFoto.Text;
                this.steta.Zapisnici = textBoxZapisnici.Text;
                this.steta.OsiguravajuceKuce = textBoxOsiguravajuceKuce.Text;
                this.steta.ProcenaStete = textBoxProcenaStete.Text;
                this.steta.Odgovornost = textBoxOdgovornosti.Text;

                bool uspesno = DTOManager.DodajStetu(this.steta);

                if (uspesno)
                {
                    MessageBox.Show("Uspešno ste dodali novu štetu.");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Dodavanje nije uspelo.");
                }
            }
            else
            {
                string obavestenje = "Neuspešno dodavanje nove štete.";
                string naslov = "Upozorenje";

                DialogResult greska = MessageBox.Show(
                    obavestenje,
                    naslov,
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning
                );
            }
        }
    }
}
