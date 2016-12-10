using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie_e_interfacce
{
    class ippopotamo:Mammifero_fluviale,Quadrupede
    {
         public ippopotamo():base("ippopotamo","Mammifero fluviale","fiume",0,"pelle")
        {
            
        }
         public void setZampe()
         {
             numerozampe = 4;
         }
         public void setMantoPelle()
         {
             manto = "pelle";
         }
    }
}
