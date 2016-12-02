using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomiee
{
    abstract class Animale_Terrestre:animale
    {
        public Animale_Terrestre(string nome,string tipo, string abitat,int zampe): base(nome, "Animale Terrestre", abitat, zampe)
        { }
        
    }
}
