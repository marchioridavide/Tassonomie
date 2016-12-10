using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie_e_interfacce
{
   abstract class Uccello:Animale_terrestre,Bipede,Animale_piumoso
    {
        public Uccello(string nome, string specie, string abitat, int zampe,string mantz):base(nome,"uccello","terra",zampe,mantz)
        {
            
        }
        public void setMantoPiumoso()
        {
            manto = "piume";
        }
        public void setZampe()
        {
            numerozampe = 2;
        }
        public override void siMuove()
        {
            Console.WriteLine("volo");
        }
    }
}
