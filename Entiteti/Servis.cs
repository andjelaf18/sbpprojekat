using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IznajmljivanjeVozila.Entiteti
{
    public class Servis
    {
        public virtual int IdServisa { get; set; }
      
        public virtual string ServisniCentar { get; set; }
       
        public virtual DateTime DatumPrijema { get; set; }
        
        public virtual DateTime DatumZavrsetka { get; set; }
       
        public virtual string OpisRadova { get; set; }
      
        public virtual string ZamenjeniDelovi { get;  set; }

        public virtual string Status { get;  set; }

        public virtual string TipServisa { get;  set; }

        public virtual double Troskovi { get; set; }

        //fk prema Vozilo 1:N   public virtual int IdVozila { get; set; }
        public virtual Vozilo Vozilo { get; set; }
    }


}
