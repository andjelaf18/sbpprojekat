using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IznajmljivanjeVozila.Entiteti
{
    public class Verifikacija
    {
        public virtual int IdVerifikacije { get; set; }
       
        public virtual string Izvrsilac { get; set; }
      
        public virtual string Rezultat { get; set; }
       
        public virtual string Ogranicenja { get; set; }
        
        public virtual DateTime DatumVerifikacije { get; set; }

        //fk prema Korisnik 1:N         public virtual int IdKorisnika { get; set; }
        public virtual Korisnik Korisnik { get; set; }
    }
}
