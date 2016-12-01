using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomiee
{
    abstract class Animale_Acquatico:Pesce
    {
        public Animale_Acquatico(string nome,string tipo, string abitat,int zampe): base(nome, "Animale Acquatico", abitat, 0)
         {}
       
    }
}
