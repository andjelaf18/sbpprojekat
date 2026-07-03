using FluentNHibernate.Mapping;
using IznajmljivanjeVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznajmljivanjeVozila.Mapiranja
{
     class KorisnikUlogaMapiranja : ClassMap<KorisnikUloga>
    {
        public KorisnikUlogaMapiranja()
        {
            Table("KORISNIK_ULOGA");

            CompositeId(x => x.Id)
                .KeyReference(x => x.Korisnik, "ID_KORISNIKA")
                .KeyReference(x => x.Uloga, "ID_ULOGE");
        }
     }
}
