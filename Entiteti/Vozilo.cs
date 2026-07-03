using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IznajmljivanjeVozila.Entiteti
{
    public class Vozilo 
    {
        public virtual int IdVozila { get; set; }

        public virtual string Registracija { get; set; }
        
        public virtual string VinBroj { get; set; }
       
        public virtual string Marka { get; set; }

        public virtual string ModelVozila { get; set; }

        public virtual int GodProizvodnje { get; set; } 

        public virtual DateTime DatumNabavke { get; set; }

        public virtual string Status { get; set; }

        public virtual string TipKoriscenja { get; set; }   

        public virtual int BrSedista { get;set; }

        public virtual string StanjeEnterijera { get; set; }

        public virtual string StanjeEksterijera { get; set; }

        public virtual string DodatnaOprema { get; set; }

        public virtual IList<Servis> Servisi { get; set; }

        public virtual IList<PunjenjeIliTocenjeGoriva> Punjenja { get; set; }

        public virtual IList<Kvarovi> Kvarovi { get; set; }

        public virtual Namena? Namena { get; set; }

        public Vozilo()
        {
            Servisi = new List<Servis>();
            Punjenja = new List<PunjenjeIliTocenjeGoriva>();
            Kvarovi = new List<Kvarovi>();

        }


    }
}
