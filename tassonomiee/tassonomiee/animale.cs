using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomiee
{
    abstract class animale
    {
        protected string nomeAnimale;
        protected string tipoAnimale;
        protected string habitat;
        protected int numeroZampe;
        public animale(string nome, string tipo, string abitat, int zampe)
        {
            nomeAnimale = nome;
            tipoAnimale = tipo;
            habitat = abitat;
            numeroZampe = zampe;
        }
        public abstract string siMuove();
        public void riepilogo()
        {
            Console.WriteLine("Nome:"+nomeAnimale);
            Console.WriteLine("Tipo:"+tipoAnimale);
            Console.WriteLine("Habitat:"+habitat);
            Console.WriteLine("Numero di zampe:"+numeroZampe);
        }
    }
}
