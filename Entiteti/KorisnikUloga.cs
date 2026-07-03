using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IznajmljivanjeVozila.Entiteti
{
    public class KorisnikUlogaId
    {
        public virtual Korisnik? Korisnik { get; set; }
        public virtual Uloga? Uloga { get; set; }

        public override bool Equals(object? obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            if (obj == null || obj.GetType() != typeof(KorisnikUlogaId))
                return false;

            KorisnikUlogaId other = (KorisnikUlogaId)obj;

            return Korisnik?.Id == other.Korisnik?.Id &&
                   Uloga?.IdUloge == other.Uloga?.IdUloge;
        }

        public override int GetHashCode()
        {
            return (Korisnik?.Id.GetHashCode() ?? 0) ^
                   (Uloga?.IdUloge.GetHashCode() ?? 0);
        }
    }

    public class KorisnikUloga
    {
        public virtual KorisnikUlogaId Id { get; set; }

        public KorisnikUloga()
        {
            Id = new KorisnikUlogaId();
        }
    }
}
