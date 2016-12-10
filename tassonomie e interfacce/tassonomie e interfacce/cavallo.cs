using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie_e_interfacce
{
    class cavallo:Mammifero_terrestre,Quadrupede,Animale_peloso
    {
        public cavallo():base("cavallo","Mammifero terrestre","praterie",0,"")
        {
            
        }
        public void setMantoPeloso()
        {
            manto = "pelo";
        }
        public void setZampe()
        {
            numerozampe = 4;
        }
    }
}
