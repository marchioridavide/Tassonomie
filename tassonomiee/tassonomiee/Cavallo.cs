using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomiee
{
    class Cavallo:Quadrupede
    {
        public Cavallo(string nome,string tipo, string abitat,int zampe): base("cavallo", "Animale Terrestre", "prateria", 2)
        { }
    }
}
