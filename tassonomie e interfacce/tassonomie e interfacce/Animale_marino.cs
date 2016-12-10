using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie_e_interfacce
{
    abstract class Animale_marino : Animale
    {
        public Animale_marino(string nome, string specie, string abitat, int zampe,string mantz):base(nome,specie,"mare",zampe,mantz)
        {
           
        }
    }
}
