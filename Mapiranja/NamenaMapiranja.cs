using FluentNHibernate.Mapping;
using IznajmljivanjeVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznajmljivanjeVozila.Mapiranja
{
    class NamenaMapiranja : ClassMap<Namena>
    {
        public NamenaMapiranja()
        {
            Table("NAMENA");

            Id(x => x.IdNamene).Column("ID_NAMENE");

            Map(x => x.NamenaVozila).Column("NAMENA_VOZILA");

        }
    }
}
