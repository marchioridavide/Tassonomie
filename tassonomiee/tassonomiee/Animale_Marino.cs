using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomiee
{
    abstract class Animale_Marino:Animale_Acquatico
    {
        public Animale_Marino(string nome, string tipo, string abitat, int zampe)
            : base(nome, "Animale Acquatico", "mare", 0)
        { }
    }
}
