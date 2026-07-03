using FluentNHibernate.Mapping;
using IznajmljivanjeVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznajmljivanjeVozila.Mapiranja
{
     class KvaroviMapiranja : ClassMap<Kvarovi>
     {
        public KvaroviMapiranja()
        {
            Table("KVAROVI");

            Id(x => x.IdKvara).Column("ID_KVARA");

            Map(x => x.DatumPrijave).Column("DATUM_PRIJAVE");
            Map(x => x.PrijavioKvar).Column("PRIJAVIO_KVAR");
            Map(x => x.OpisProblema).Column("OPIS_PROBLEMA");
            Map(x => x.ProcenaOzbiljnosti).Column("PROCENA_OZBILJNOSTI");
            Map(x => x.Status).Column("STATUS");
            Map(x => x.DatumOtklanjanja).Column("DATUM_OTKLANJANJA");

            References(x => x.Steta).Column("ID_STETE");
            References(x => x.Vozilo).Column("ID_VOZILA");
        }
    }
}
