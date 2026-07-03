using FluentNHibernate.Mapping;
using IznajmljivanjeVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznajmljivanjeVozila.Mapiranja
{
    class PravnaLicaMapiranja : ClassMap<PravnaLica>
    {
        public PravnaLicaMapiranja() {

           Table("PRAVNA_LICA");

            Id(x => x.IdPLica).Column("ID_PL").GeneratedBy.Assigned();

            Map(x => x.Naziv).Column("NAZIV");
            Map(x => x.Pib).Column("PIB");
            Map(x => x.MatBr).Column("MATICNI_BROJ");
            Map(x => x.Sediste).Column("SEDISTE");
            Map(x => x.KontaktOsoba).Column("KONTAKT_OSOBA");
            Map(x => x.UgovorniUslovi).Column("UGOVORNI_USLOVI");

            References(x => x.Korisnik).Column("ID_KORISNIKA");
        }
    }
}
