using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IznajmljivanjeVozila.Entiteti
{
    public class FizickaLica 
    {
        public virtual int IdFLica { get; set; }

        public virtual string Ime { get; set; }

        public virtual string Jmbg { get; set; }

        public virtual string Prezime { get; set; }

        public virtual DateTime DatumIzdavanja { get; set; }

        public virtual string KategorijaDozvole { get; set; }

        public virtual int BrVozackeDozvole { get; set; }

        //public virtual int IdKorisnika { get; set; }

        public virtual DateTime DatumIsteka { get; set; }

        public virtual Korisnik? Korisnik { get; set; }

    }
}
