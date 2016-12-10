using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie_e_interfacce
{
    class balena:Mammifero_marino
    {
        public balena():base("balena","mammifero marino","mare",0,"")
        {
           
        }
        public void setMantoPelle()
        {
            manto = "pelle";
        }
    }
}
