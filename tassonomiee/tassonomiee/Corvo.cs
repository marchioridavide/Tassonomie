using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomiee
{
    class Corvo:Uccello
    {
        public Corvo(): base("corvo", "Animale Terrestre", "alberi", 2)
        { }
        public override string siMuove()
        {
            return "volo";
        }
    }
}
