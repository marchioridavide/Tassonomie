using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie_e_interfacce
{
    abstract class Animale
    {
        protected string nomeanimale;
        protected string specieanimale;
        protected string habitat;
        protected int numerozampe;
        protected string manto;

        public Animale(string nome, string specie, string abitat, int zampe,string mantz)
        {
            nomeanimale = nome;
            specieanimale = specie;
            habitat = abitat;
            numerozampe = zampe;
        }

        public abstract void siMuove();

        public void riepilogo() 
        {
            Console.WriteLine("nome:" + nomeanimale);
            Console.WriteLine("specie:" + specieanimale);
            Console.WriteLine("habitat:" + habitat);
            Console.WriteLine("zampe:" + numerozampe);
            Console.WriteLine("manto:" + manto);
        }
    }
}
