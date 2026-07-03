using FluentNHibernate.Conventions.Inspections;
using FluentNHibernate.Mapping;
using IznajmljivanjeVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IznajmljivanjeVozila.Mapiranja
{
    class DogadjajiMapiranja : ClassMap<Dogadjaji>
    {
        public DogadjajiMapiranja()
        {
            Table("DOGADJAJI");

            Id(x => x.Id).Column("ID_DOGADJAJA").GeneratedBy.Assigned();

            Map(x => x.NagloKocenje).Column("NAGLO_KOCENJE");
            Map(x => x.PrekoracenjeBrzine).Column("PREKORACENJE_BRZINE");
            Map(x => x.DuzeZadrzavanje).Column("DUZE_ZADRZAVANJE");
            Map(x => x.NeovlasceniIzlazak).Column("NEOVLASCENI_IZLAZAK");
            Map(x => x.Sudar).Column("SUDAR");
        }
    }
}
