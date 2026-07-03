using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznajmljivanjeVozila.Entiteti
{
    public class NacinPlacanja
    {
        public virtual int IdPlacanja { get; set; }

        public virtual string TipPlacanja { get; set; }

        public virtual string Status { get; set; }

        public virtual DateTime DatumDodavanjaOgranicenja { get; set; }

        //fk prema Korisnik, veza je 1:Npublic virtual int IdKorisnika { get; set; }
        public virtual Korisnik Korisnik { get; set; }

    }
}
