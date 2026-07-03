using FluentNHibernate.Mapping;
using IznajmljivanjeVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznajmljivanjeVozila.Mapiranja
{
    class VerifikacijaMapiranja : ClassMap<Verifikacija>
    {
        public VerifikacijaMapiranja() {

            Table("VERIFIKACIJA");

            Id(x => x.IdVerifikacije).Column("ID_VERIFIKACIJE");

            Map(x => x.DatumVerifikacije).Column("DATUM_VERIFIKACIJE");
            Map(x => x.Izvrsilac).Column("IZVRSILAC_VERIFIKACIJE");
            Map(x => x.Rezultat).Column("REZULTAT");
            Map(x => x.Ogranicenja).Column("OGRANICENJA");

            References(x => x.Korisnik).Column("ID_KORISNIKA");
        }

    }
}
