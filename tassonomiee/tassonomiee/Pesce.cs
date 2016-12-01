using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomiee
{
    class Pesce:animale
    {
        public Pesce(string nome,string tipo, string abitat,int zampe): base(nome, "Animale Acquatico", abitat, 0)
         {}
        public override string siMuove()
        {
            return "nuoto";
        }
    }
}
