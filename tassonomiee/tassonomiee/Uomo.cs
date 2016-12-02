using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomiee
{
    class Uomo:Bipede
    {
        public Uomo(): base("uomo", "Animale Terrestre", "Terra", 2)
        { }
        public override string siMuove()
        {
            return "cammino";
        }
    }
}
