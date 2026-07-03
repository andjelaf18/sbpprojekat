using FluentNHibernate.Mapping;
using IznajmljivanjeVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznajmljivanjeVozila.Mapiranja
{
     class KlasnicnoVoziloMapiranja : SubclassMap<KlasicnoVozilo>
     {
        public KlasnicnoVoziloMapiranja()
        {
            Table("KLASICNO_VOZILO");

            KeyColumn("ID_VOZILA");

            Map(x => x.Zapremina).Column("ZAPREMINA_GORIVA");
            Map(x => x.TipGoriva).Column("TIP_GORIVA");
            Map(x => x.ProsecnaPotrosnja).Column("PROSECNA_POTROSNJA");
        }
     }
}
