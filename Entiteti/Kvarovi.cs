using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznajmljivanjeVozila.Entiteti
{
    public class Kvarovi
    {

        public virtual int IdKvara { get; set; }

        public virtual string PrijavioKvar { get; set; }

        public virtual string OpisProblema { get; set; }

        public virtual string ProcenaOzbiljnosti { get; set; }

        public virtual string Status { get; set; }

        public virtual DateTime DatumPrijave { get; set; }

        public virtual DateTime DatumOtklanjanja { get; set; }

        // fk prema Steta: public virtual int IdStete { get; set; }
        public virtual Steta Steta { get; set; }

        //fk prema Vozilo: public virtual int IdVozila { get; set; }
        public virtual Vozilo Vozilo { get; set; }


    }
}
