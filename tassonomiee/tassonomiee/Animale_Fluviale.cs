using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomiee
{
   abstract class Animale_Fluviale:Animale_Acquatico
    {
        public Animale_Fluviale(string nome, string tipo, string abitat, int zampe)
            : base(nome, "Animale Acquatico", "fiume", 0)
        { }
    }
     
}
