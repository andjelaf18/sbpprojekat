using FluentNHibernate.Mapping;
using IznajmljivanjeVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznajmljivanjeVozila.Mapiranja
{
    class ElektricnoVoziloMapiranja : SubclassMap<ElektricnoVozilo>
    {
        public ElektricnoVoziloMapiranja()
        {
            Table("ELEKTRICNO_VOZILO");

            KeyColumn("ID_VOZILA");

            Map(x => x.KapacitetBaterije).Column("KAPACITET_BATERIJE");
            Map(x => x.NivoNapunjenosti).Column("NIVO_NAPUNJENOSTI");
            Map(x => x.TipPunjenja).Column("TIP_PUNJENJA");
            Map(x => x.Autonomija).Column("AUTONOMIJA");
            Map(x => x.BrCiklusaPunjenja).Column("BROJ_CIKLUSA_PUNJENJA");
        }
    }
}
