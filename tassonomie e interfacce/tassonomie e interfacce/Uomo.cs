using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie_e_interfacce
{
    class Uomo:Mammifero_terrestre,Bipede
    {
        public Uomo():base("uomo","Mammifero terrestre","praterie",0,"")
        {
            
        }
        public void setMantoPeloso()
        {
            manto = "pelo";
        }
        public void setZampe()
        {
            numerozampe = 2;
        }
    }
}
