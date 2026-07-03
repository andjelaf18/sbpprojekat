using FluentNHibernate.Mapping;
using IznajmljivanjeVozila.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznajmljivanjeVozila.Mapiranja
{
    class VoziloMapiranja : ClassMap<Vozilo>
    {
        public VoziloMapiranja()
        {

            Table("VOZILO");

            Id(x => x.IdVozila).Column("ID_VOZILA").GeneratedBy.Assigned();

            Map(x => x.Registracija).Column("REGISTRACIJA");
            Map(x => x.VinBroj).Column("VIN_BROJ");
            Map(x => x.Marka).Column("MARKA");
            Map(x => x.ModelVozila).Column("MODEL_VOZILA");
            Map(x => x.GodProizvodnje).Column("GODINA_PROIZVODNJE");
            Map(x => x.DatumNabavke).Column("DATUM_NABAVKE");
            Map(x => x.Status).Column("STATUS");
            Map(x => x.TipKoriscenja).Column("TIP_KORISCENJA");
            Map(x => x.BrSedista).Column("BROJ_SEDISTA");
            Map(x => x.StanjeEnterijera).Column("STANJE_ENTERIJERA");
            Map(x => x.StanjeEksterijera).Column("STANJE_EKSTERIJERA");
            Map(x => x.DodatnaOprema).Column("DODATNA_OPREMA");

            References(x => x.Namena).Column("NAMENA");
            HasMany(x => x.Servisi).KeyColumn("ID_VOZILA").Inverse().Cascade.None();
            HasMany(x => x.Kvarovi).KeyColumn("ID_VOZILA").Inverse().Cascade.None();
            HasMany(x => x.Punjenja).KeyColumn("ID_DOPUNJENOG_VOZILA").Inverse().Cascade.None();
        }
    }
}
