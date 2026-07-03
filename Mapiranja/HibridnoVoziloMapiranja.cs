using FluentNHibernate.Mapping;
using IznajmljivanjeVozila.Entiteti;
using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznajmljivanjeVozila.Mapiranja
{
     class HibridnoVoziloMapiranja : SubclassMap<HibridnoVozilo>
    {
        public HibridnoVoziloMapiranja()
        {
            Table("HIBRIDNO_VOZILO");

            KeyColumn("ID_VOZILA");

            Map(x => x.KapacitetBat).Column("KAPACITET_BATERIJE");
            Map(x => x.TipHibridnogVozila).Column("TIP_HIBRIDNOG_VOZILA");
        }
     }
}
