using FluentNHibernate.Mapping;
using IznajmljivanjeVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznajmljivanjeVozila.Mapiranja
{
    class SluzbenaVoznjaMapiranja : ClassMap<SluzbenaVoznja>
    {
        public SluzbenaVoznjaMapiranja() {

            Table("SLUZBENA_VOZNJA");

            Id(x => x.IdSVoznje).Column("ID_S_VOZNJE").GeneratedBy.Assigned();

            Map(x => x.Razlog).Column("RAZLOG");

            References(x => x.FizickaLica).Column("OVLASCENO_LICE");
           // References(x => x.Voznja).Column("REZERVACIJE");

        }
    }
}
