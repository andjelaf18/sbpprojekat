using FluentNHibernate.Mapping;
using IznajmljivanjeVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznajmljivanjeVozila.Mapiranja
{
    class RezervacijaMapiranja : ClassMap<Rezervacija>
    {
        public RezervacijaMapiranja() {

            Table("REZERVACIJA");

            Id(x => x.IdRezervacije).Column("ID_REZERVACIJE").GeneratedBy.Assigned();

            Map(x => x.PlaniranaLokacijaVracanja).Column("PLANIRANA_LOKACIJA_VRACANJA");
            Map(x => x.PlaniranaLokacijaPreuzimanja).Column("PLANIRANA_LOKACIJA_PREUZIMANJA");
            Map(x => x.PlaniranoVremeZavrsetka).Column("PLANIRANO_VREME_ZAVRSETKA");
            Map(x => x.PlaniranoVremePocetka).Column("PLANIRANO_VREME_POCETKA");
            Map(x => x.Tip).Column("TIP");
            Map(x => x.Status).Column("STATUS");

            References(x => x.Korisnik).Column("ID_K");
            References(x => x.FizickaLica).Column("ID_VOZACA");
            References(x => x.Vozilo).Column("ID_VOZILA");

        }

    }
}
