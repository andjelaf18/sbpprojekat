using FluentNHibernate.Mapping;
using IznajmljivanjeVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznajmljivanjeVozila.Mapiranja
{
     class FizickaLicaMapiranja: ClassMap<FizickaLica>
    {
        public FizickaLicaMapiranja()
        {
            Table("FIZICKA_LICA");

            Id(x => x.IdFLica).Column("ID_FL");

           // Map(x => x.IdKorisnika).Column("ID_KORISNIKA");
            Map(x => x.Jmbg).Column("JMBG");
            Map(x => x.Ime).Column("IME");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.BrVozackeDozvole).Column("BROJ_VOZACKE_DOZVOLE");
            Map(x => x.KategorijaDozvole).Column("KATEGORIJA_DOZVOLE");
            Map(x => x.DatumIzdavanja).Column("DATUM_IZDAVANJA");
            Map(x => x.DatumIsteka).Column("DATUM_ISTEKA");

            References(x => x.Korisnik).Column("ID_KORISNIKA");

        }



    }
}
