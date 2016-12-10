using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie_e_interfacce
{
    class tonno:pesce,Animale_squamoso
    {
        public tonno():base("tonno","pesce","mare",0,"")
        {
           
        }
        public void setMantoSquamoso()
        {
            manto = "squame";
        }
    }
}
