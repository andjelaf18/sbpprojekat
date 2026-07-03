using FluentNHibernate.Mapping;
using IznajmljivanjeVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznajmljivanjeVozila.Mapiranja
{
    class VoznjaMapiranja : ClassMap<Voznja>
    {
        public VoznjaMapiranja()
        {

            Table("VOZNJA");

            Id(x => x.IdVoznje).Column("ID_VOZNJE").GeneratedBy.Assigned();

            Map(x => x.VremePocetka).Column("VREME_POCETKA");
            Map(x => x.VremeZavrsetka).Column("VREME_ZAVRSETKA");
            Map(x => x.Km).Column("KILOMETRAZA");
            Map(x => x.Trajanje).Column("TRAJANJE");
            Map(x => x.PocetniNivoGorIliBat).Column("POCETNI_NIVO_GOR_ILI_BAT");
            Map(x => x.PocetnaLokacija).Column("POCETNA_LOKACIJA");
            Map(x => x.ZavrsnaLokacija).Column("ZAVRSNA_LOKACIJA");
            Map(x => x.ObracunataCena).Column("OBRACUNATA_CENA");
            Map(x => x.DodatneNaknade).Column("DODATNE_NAKNADE");
           
            References(x => x.SluzbenaVoznja).Column("SLUZBENA_VOZNJA");
            References(x => x.Dogadjaji).Column("ID_DOGADJAJA");
            References(x => x.Vozilo).Column("ID_VOZILA");
            References(x => x.Rezervacija).Column("ID_REZERVACIJE");

        }
    }
}
