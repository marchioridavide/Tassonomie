using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie_e_interfacce
{
   abstract class pesce:Animale_marino,Animale_squamoso
    {
        public pesce(string nome, string specie, string abitat, int zampe,string mantz):base(nome,"pesce","mare",0,mantz)
        {
           
        }
        public void setMantoSquamoso()
        {
            manto = "squame";
        }
        public override void siMuove()
        {
            Console.WriteLine("nuoto");
        }
    }
}
