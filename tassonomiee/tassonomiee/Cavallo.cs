using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomiee
{
    class Cavallo:Quadrupede
    {
        public Cavallo(): base("cavallo", "Animale Terrestre", "prateria", 4)
        { }
        public override string siMuove()
        {
            return "cammino";
        }
    }
}
