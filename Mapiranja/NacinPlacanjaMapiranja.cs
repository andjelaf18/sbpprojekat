using FluentNHibernate.Mapping;
using IznajmljivanjeVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznajmljivanjeVozila.Mapiranja
{
     class NacinPlacanjaMapiranja : ClassMap<NacinPlacanja>
     {
        public NacinPlacanjaMapiranja()
        {
            Table("NACIN_PLACANJA");

            Id(x => x.IdPlacanja).Column("ID_PLACANJA").GeneratedBy.Assigned();

            Map(x => x.TipPlacanja).Column("TIP_PLACANJA");
            Map(x => x.Status).Column("STATUS");
            Map(x => x.DatumDodavanjaOgranicenja).Column("DATUM_DODAVANJA_OGRANICENJA");
            //ovo je fk i ne sme ovako da se mapira, nego kao ovo doleMap(x => x.Korisnik).Column("ID_KORISNIKA");

            References(x => x.Korisnik).Column("ID_KORISNIKA");
        }
     }
}
