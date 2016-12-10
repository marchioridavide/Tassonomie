using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tassonomie_e_interfacce
{
    class Program
    {
        static void Main(string[] args)
        {
            Uomo u = new Uomo();
            cavallo c = new cavallo();
            ippopotamo i = new ippopotamo();
            corvo co = new corvo();
            pinguino pi = new pinguino();
            balena ba = new balena();
            tonno t = new tonno();
            salmone s = new salmone();


            u.setZampe();
            u.setMantoPeloso();
            u.riepilogo();
            u.siMuove();
            Console.WriteLine("_________________________________________");
            c.setZampe();
            c.setMantoPeloso();
            c.riepilogo();
            c.siMuove();
            Console.WriteLine("_________________________________________");
            i.setZampe();
            i.setMantoPelle();
            i.riepilogo();
            i.siMuove();
            Console.WriteLine("_________________________________________");
            co.setMantoPiumoso();
            co.setZampe();
            co.riepilogo();
            co.siMuove();
            Console.WriteLine("_________________________________________");
            pi.setMantoPiumoso();
            pi.setZampe();
            pi.riepilogo();
            pi.siMuove();
            Console.WriteLine("_________________________________________");
            ba.setMantoPelle(); 
            ba.riepilogo();
            ba.siMuove();
            Console.WriteLine("_________________________________________");
            t.setMantoSquamoso();
            t.riepilogo();
            t.siMuove();
            Console.WriteLine("_________________________________________");
            s.setMantoSquamoso();
            s.riepilogo();
            s.siMuove();
            Console.ReadLine();
        }
    }
}
