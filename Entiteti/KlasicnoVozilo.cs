using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznajmljivanjeVozila.Entiteti
{
    public class KlasicnoVozilo : Vozilo
    {
        public virtual int IdVozila { get; set; }

        public virtual double Zapremina { get; set; }

        public virtual double ProsecnaPotrosnja { get; set; }

        public virtual string TipGoriva { get; set; }

    }
}
