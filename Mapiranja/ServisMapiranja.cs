using FluentNHibernate.Mapping;
using IznajmljivanjeVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznajmljivanjeVozila.Mapiranja
{
    class ServisMapiranja:ClassMap<Servis>
    {
        public ServisMapiranja() {

            Table("SERVIS");

            Id(x => x.IdServisa).Column("ID_SERVISA");

            Map(x => x.DatumPrijema).Column("DATUM_PRIJEMA");
            Map(x => x.DatumZavrsetka).Column("DATUM_ZAVRSETKA");
            Map(x => x.OpisRadova).Column("OPIS_RADOVA");
            Map(x => x.ZamenjeniDelovi).Column("ZAMENJENI_DELOVI");
            Map(x => x.Troskovi).Column("TROSKOVI");
            Map(x => x.Status).Column("STATUS");
            Map(x => x.TipServisa).Column("TIP_SERVISA");
            Map(x => x.ServisniCentar).Column("SER_CENTAR");

            References(x => x.Vozilo).Column("ID_VOZILA");

        }
    }
}
