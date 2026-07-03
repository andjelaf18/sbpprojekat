using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace IznajmljivanjeVozila.Entiteti
{
    public class Voznja
    {

        public virtual int IdVoznje { get; set; }

        public virtual DateTime VremePocetka { get; set; }  //  OVO JE U BAZU TIP PODATKA TIMESTAMP(6)

        public virtual DateTime VremeZavrsetka { get; set; }  //  OVO JE U BAZU TIP PODATKA TIMESTAMP(6)

        public virtual decimal Km { get; set; }

        public virtual decimal Trajanje { get; set; }

        public virtual decimal PocetniNivoGorIliBat { get; set; }

        public virtual string PocetnaLokacija { get; set; }

        public virtual string ZavrsnaLokacija { get; set; }

        public virtual double ObracunataCena { get; set; }

        public virtual double DodatneNaknade { get; set; }

        //fk prema SluzbenuVoznju public virtual int SVoznja { get; set; }
        public virtual SluzbenaVoznja? SluzbenaVoznja { get; set; }

        //fk prema Dogadjaj 1:N public virtual int IdDogadjaja { get; set; }
        public virtual Dogadjaji? Dogadjaji { get; set; }

        //fk prema Vozilo 1:N public virtual int IdVozila { get; set; }
        public virtual Vozilo Vozilo { get; set; }

        //fk prema Rezervaciju public virtual int IdRezervacije { get; set; }
        public virtual Rezervacija? Rezervacija { get; set; }
    }
}
