using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie_e_interfacce
{
    abstract class Animale_terrestre:Animale
    {
        public Animale_terrestre(string nome, string specie, string abitat, int zampe,string mantz):base(nome,specie,abitat,zampe,mantz)
        {
            
        }
    }
}
