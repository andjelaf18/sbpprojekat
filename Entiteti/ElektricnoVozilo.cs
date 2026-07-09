using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznajmljivanjeVozila.Entiteti
{
    public class ElektricnoVozilo: Vozilo
    {

       // public virtual int IdVozila { get; set; }

        public virtual double KapacitetBaterije { get; set; }

        public virtual double NivoNapunjenosti { get; set; }

        public virtual string TipPunjenja { get; set; }

        public virtual double Autonomija { get; set; }

        public virtual double BrCiklusaPunjenja { get; set; }

    
    }
}
