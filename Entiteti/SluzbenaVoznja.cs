using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IznajmljivanjeVozila.Entiteti
{
    public class SluzbenaVoznja
    {
        public virtual int IdSVoznje { get; set; }
      
        public virtual string Razlog { get; set; }
        
        //fk prema FizickoLice public virtual int OvlascenoLice { get; set; }
        public virtual FizickaLica? FizickaLica { get; set; }

        public virtual Voznja? Voznja { get; set; }
    }

}
