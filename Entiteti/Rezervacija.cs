using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IznajmljivanjeVozila.Entiteti
{
    public class Rezervacija
    {
        public virtual int IdRezervacije { get; set; }
       
        public virtual string PlaniranaLokacijaPreuzimanja { get; set; }

        public virtual string PlaniranaLokacijaVracanja { get; set; }

        public virtual string Tip { get; set; }
        
        public virtual string Status { get; set; }

        public virtual DateTime PlaniranoVremePocetka { get; set; } //TIMESTAMP U BAZU

        public virtual DateTime PlaniranoVremeZavrsetka { get; set; } //TIMESTAMP U BAZU

        //fk prema korisnik 1:Npublic virtual int IdKorisnika { get; set; }
        public virtual Korisnik? Korisnik { get; set; }

        //fk prema FizickaLica public virtual int IdVozaca { get; set; }
        public virtual FizickaLica? FizickaLica { get; set; }

        //fk prema vozilo public virtual int IdVozila { get; set; }
        public virtual Vozilo? Vozilo { get; set; }

        public virtual Voznja? Voznja { get; set; }
    }
}
