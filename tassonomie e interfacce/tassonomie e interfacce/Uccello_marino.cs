using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie_e_interfacce
{
    abstract class Uccello_marino:Animale_marino,Animale_piumoso,Bipede
    {
         public Uccello_marino(string nome, string specie, string abitat, int zampe,string mantz):base(nome,"uccello marino",abitat,zampe,mantz)
        {
           
        }
        public void setMantoPiumoso()
        {
            manto="piume";
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
