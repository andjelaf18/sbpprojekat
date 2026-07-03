using FluentNHibernate.Mapping;
using IznajmljivanjeVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznajmljivanjeVozila.Mapiranja
{
    class UlogaMapiranja : ClassMap<Uloga>
    {

        public UlogaMapiranja() {

            Table("ULOGA");

            Id(x => x.IdUloge).Column("ID_ULOGE");

            Map(x => x.NazivUloge).Column("NAZIV_ULOGE");

        }
    }
}
