using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IznajmljivanjeVozila.Entiteti
{
    public class PravnaLica 
    {
        public virtual int IdPLica { get; set; }

        public virtual string Naziv { get; set; }

        public virtual string MatBr { get; set; }

        public virtual string Sediste { get; set; }

        public virtual string KontaktOsoba { get; set; }

        public virtual string UgovorniUslovi { get; set; }

        public virtual int Pib { get; set; }

        //fk prema korisikapublic virtual int IdKorisnika { get; set; }
        public virtual Korisnik Korisnik { get; set; }


    }
}
