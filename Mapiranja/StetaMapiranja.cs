using FluentNHibernate.Mapping;
using IznajmljivanjeVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznajmljivanjeVozila.Mapiranja
{
    class StetaMapiranja: ClassMap<Steta>
    {
        public StetaMapiranja() {

            Table("STETA");

            Id(x => x.IdStete).Column("ID_STETE").GeneratedBy.Assigned();

            Map(x => x.Zapisnici).Column("ZAPISNICI");
            Map(x => x.Foto).Column("FOTOGRAFIJE");
            Map(x => x.OsiguravajuceKuce).Column("OSIGURAVAJUCE_KUCE");
            Map(x => x.ProcenaStete).Column("PROCENA_STETE");
            Map(x => x.Odgovornost).Column("ODGOVORNOST");

            References(x => x.Voznja).Column("ID_VOZNJE");
        }


    }
}
