using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomiee
{
    class Pinguino:Uccello
    {
        public Pinguino(): base("pinguino", "Animale Terrestre", "ghiaccio", 2)
        { }
        public override string siMuove()
        {
            return "cammino";
        }
    }
}
