using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznajmljivanjeVozila.Entiteti
{
    public class HibridnoVozilo : Vozilo
    {
        public virtual int IdVozila { get; set; }

        public virtual double KapacitetBat { get; set; }

        public virtual string TipHibridnogVozila { get; set; }


    }
}
