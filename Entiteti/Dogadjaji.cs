using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznajmljivanjeVozila.Entiteti
{
    public class Dogadjaji
    {
        public virtual int Id { get; set; }

        public virtual string NagloKocenje { get; set; }

        public virtual string PrekoracenjeBrzine { get; set; }

        public virtual string DuzeZadrzavanje { get; set; }

        public virtual string NeovlasceniIzlazak { get; set; }

        public virtual string Sudar { get; set; }

    }
}
