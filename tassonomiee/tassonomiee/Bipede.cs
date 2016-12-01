using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomiee
{
    abstract class Bipede:Animale_Terrestre
    {
        public Bipede(string nome,string tipo, string abitat,int zampe): base(nome, "Animale Terrestre", abitat, 2)
        { }
    }
}
