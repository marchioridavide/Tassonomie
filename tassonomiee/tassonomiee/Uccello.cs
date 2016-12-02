using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomiee
{
    abstract class Uccello:Bipede
    {
        public Uccello(string nome,string tipo, string abitat,int zampe): base(nome, "Animale Terrestre", abitat, 2)
        { }
    }
}
