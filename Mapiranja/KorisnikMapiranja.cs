using FluentNHibernate.Mapping;
using IznajmljivanjeVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznajmljivanjeVozila.Mapiranja
{
    class KorisnikMapiranja : ClassMap<Korisnik>
    {
        public KorisnikMapiranja()
        {

            Table("KORISNIK");
                                            //da sama dodajem id a ne baza da generise
            Id(x => x.Id).Column("ID_KORISNIKA").GeneratedBy.Assigned();

            Map(x => x.Adresa).Column("ADRESA");
            Map(x => x.BrojTelefona).Column("BROJ_TELEFONA");
            Map(x => x.Email).Column("EMAIL");
            Map(x => x.DatumRegistracije).Column("DATUM_REGISTRACIJE");
            Map(x => x.StatusNaloga).Column("STATUS_NALOGA");
            Map(x => x.NacinVerifikacije).Column("NACIN_VERIFIKACIJE");

            /*References(x => x.Rezervacije).Column("REZERVACIJE");
            References(x => x.Verifikacije).Column("VERIFIKACIJE");
            References(x => x.NaciniPlacanja).Column("NACINPLACANJA");
            NE MOZE OVAKO JER SU OVO LISTE*/
            HasMany(x => x.Rezervacije).KeyColumn("ID_K").Inverse().Cascade.None();
            HasMany(x => x.Verifikacije).KeyColumn("ID_KORISNIKA").Inverse().Cascade.None();
            HasMany(x => x.NaciniPlacanja).KeyColumn("ID_KORISNIKA").Inverse().Cascade.None();
        }


    }
}
