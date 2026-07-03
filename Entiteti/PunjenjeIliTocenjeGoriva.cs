using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IznajmljivanjeVozila.Entiteti
{
    public class PunjenjeIliTocenjeGoriva
    {
        public virtual DateTime DatumDopune { get; set; }

        public virtual int IdDopune { get; set; }

        public virtual double Kolicina { get; set; }

        public virtual double Cena { get; set; }

        public virtual string Lokacija { get; set; }

        public virtual string NacinEvidentiranja { get; set; }

        public virtual string TipDopune { get; set; }

        public virtual string IzvrsilacDopune { get; set; }

        // fk prema Vozilo, 1:N public virtual int IdDopunjenogVozila { get; set; }
        public virtual Vozilo Vozilo { get; set; }

    }
}
