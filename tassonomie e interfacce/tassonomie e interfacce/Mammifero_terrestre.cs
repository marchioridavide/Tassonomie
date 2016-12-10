using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie_e_interfacce
{
    class Mammifero_terrestre:Animale_terrestre
    {
        public Mammifero_terrestre(string nome, string specie, string abitat, int zampe,string mantz):base(nome,"mammifero terrestre",abitat,zampe,mantz)
        {
            
        }
        public override void siMuove()
        {
            Console.WriteLine("cammino");
        }
    }
}
