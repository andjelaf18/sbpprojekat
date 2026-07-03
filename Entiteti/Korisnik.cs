using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IznajmljivanjeVozila.Entiteti
{
    public class Korisnik
    {
        public virtual int Id { get; set; }

        public virtual string Adresa { get; set; }
        public virtual string BrojTelefona { get; set; }
        public virtual string Email { get; set; }
        public virtual DateTime DatumRegistracije { get; set; }

        public virtual string StatusNaloga { get; set; }

        public virtual string NacinVerifikacije { get; set; }

        public virtual IList<Rezervacija> Rezervacije { get; set; } //veza 1:N korisnik-rezervacija

        public virtual IList<Verifikacija> Verifikacije { get; set; }

        public virtual IList<NacinPlacanja> NaciniPlacanja { get; set; }

        public Korisnik()
        {
            Rezervacije = new List<Rezervacija>();
            Verifikacije = new List<Verifikacija>();
            NaciniPlacanja = new List<NacinPlacanja>();
        }


    }
}
