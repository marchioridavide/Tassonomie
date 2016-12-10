using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie_e_interfacce
{
    abstract class Mammifero_marino : Animale_marino
    {
         public Mammifero_marino(string nome, string specie,string abitat, int zampe,string mantz):base(nome,"mammifero marino","mare",0,"pelle")
        {
           
        }
         public override void siMuove()
         {
             Console.WriteLine("nuoto");
         }
         
    }
}
