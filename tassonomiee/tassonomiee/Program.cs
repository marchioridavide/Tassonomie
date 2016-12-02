using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomiee
{
    class Program
    {
        static void Main(string[] args)
        {
            Uomo u = new Uomo();
            Pinguino pi = new Pinguino();
            Tonno t = new Tonno();
            Salmone s = new Salmone();
            Corvo c = new Corvo();
            Cavallo ca = new Cavallo();


            u.riepilogo();
            Console.WriteLine(u.siMuove());
            Console.WriteLine("------------------------------");
            

            pi.riepilogo();
            Console.WriteLine(pi.siMuove());
            Console.WriteLine("------------------------------");
            

            t.riepilogo();
            Console.WriteLine(t.siMuove());
            Console.WriteLine("------------------------------");
            

            s.riepilogo();
            Console.WriteLine(s.siMuove());
            Console.WriteLine("------------------------------");
            

            c.riepilogo();
            Console.WriteLine(c.siMuove());
            Console.WriteLine("------------------------------");
            

            ca.riepilogo();
            Console.WriteLine(ca.siMuove());
            Console.WriteLine("------------------------------");
            



            Console.ReadLine();
        }
    }
}
