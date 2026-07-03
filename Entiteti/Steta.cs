using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IznajmljivanjeVozila.Entiteti
{
    public class Steta
    {
        public virtual int IdStete { get; set; }

        public virtual string Foto { get; set; }

        public virtual string Zapisnici { get; set; }

        public virtual string OsiguravajuceKuce { get; set; }

        public virtual string ProcenaStete { get; set; }

        public virtual string Odgovornost { get; set; }

        //fk prema Voznja 1:N public virtual int IdVoznje { get; set; }
        public virtual Voznja? Voznja { get; set; }

    }
}
