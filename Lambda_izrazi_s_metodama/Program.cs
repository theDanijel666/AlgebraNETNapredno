using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_izrazi_s_metodama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> m1 = x => x + 1;
            Console.WriteLine("Metoda 1: {0}",m1.Invoke(200));

            Func<int, int> m2 = x => {
                int rez = x+1;
                return rez; 
            };
            Console.WriteLine("Metoda 2: {0}", m2.Invoke(200));

            Func<int, int> m3 = (int x) => x + 1;
            Console.WriteLine("Metoda 3: {0}", m3.Invoke(200));

            Func<int, int> m4 = (int x) =>
            {
                return x + 1;
            };
            Console.WriteLine("Metoda 4: {0}", m4.Invoke(200));

            Func<int, int, int> m5 = (x, y) => x * y;
            Console.WriteLine("Rezultat: {0}", m5(13, 3));

            Action poz = () => Console.WriteLine("Pozdrav ljudi");
            poz();
        }
    }
}
