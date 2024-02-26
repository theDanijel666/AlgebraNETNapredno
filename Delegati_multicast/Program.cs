using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegati_multicast
{
    public delegate void TestDelegat(string poruka);
    internal class Program
    {
        static void Main(string[] args)
        {
            TestDelegat d1 = KlasaA.MetodaA;
            TestDelegat d2 = KlasaB.MetodaB;

            TestDelegat del = d1 + d2;
            del("Prvi poziv!");
            Console.WriteLine("=========");

            TestDelegat d3 = (string p) => Console.WriteLine("Poziv preko lambda izraza: " + p);
            del += d3;
            del("Drugi poziv");
            Console.WriteLine("=========");

            del = del - d2;
            del("Treći poziv");
            Console.WriteLine("=========");

            del -= d2;
            del("Četvrti poziv");
            Console.WriteLine("=========");
            
            del += d1;
            del("Peti poziv.");
            Console.WriteLine("=========");

            del -= d1;
            del("Šesti poziv");
        }
    }

    public class KlasaA
    {
        public static void MetodaA(string poruka)
        {
            Console.WriteLine("Pozvali smo KlasaA.MetodaA() s parametrom: " + poruka);
        }
    }

    public class KlasaB
    {
        public static void MetodaB(string poruka)
        {
            Console.WriteLine("Pozvali smo KlasaB.MetodaB() s parametrom: " + poruka);
        }
    }
}
