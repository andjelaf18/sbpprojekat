using FluentNHibernate.Mapping;
using IznajmljivanjeVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznajmljivanjeVozila.Mapiranja
{
    class PunjenjeIliTocenjeGorivaMapiranja : ClassMap<PunjenjeIliTocenjeGoriva>
    {
        public PunjenjeIliTocenjeGorivaMapiranja() {

            Table("PUNJENJE_ILI_TOCENJE_GORIVA");

            Id(x => x.IdDopune).Column("ID_DOPUNE");

            Map(x => x.DatumDopune).Column("DATUM_DOPUNE");
            Map(x => x.Lokacija).Column("LOKACIJA");
            Map(x => x.Kolicina).Column("KOLICINA");
            Map(x => x.Cena).Column("CENA");
            Map(x => x.NacinEvidentiranja).Column("NACIN_EVIDENTIRANJA");
            Map(x => x.TipDopune).Column("TIP_DOPUNE");
            Map(x => x.IzvrsilacDopune).Column("IZVRSILAC_DOPUNE");

            References(x => x.Vozilo).Column("ID_DOPUNJENOG_VOZILA");
        }
    }
}
