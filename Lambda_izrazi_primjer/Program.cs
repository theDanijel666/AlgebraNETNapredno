using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_izrazi_primjer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> brojevi=new List<int>() { 66, 34, 12, 7, 9, 18, 25, 43, 13, 653, 19, 21 };

            Console.WriteLine("Lista brojeva:");
            foreach(int i in brojevi)
            {
                Console.Write("{0} ",i);
            }

            Console.WriteLine();
            Console.WriteLine();

            var kvadrati_brojeva = brojevi.Select(x => x * x);
            Console.WriteLine("Kvadrati brojeva:");
            foreach(int i in kvadrati_brojeva)
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();
            Console.WriteLine();

            List<int> djeljivi_s_3 = brojevi.FindAll(x => x % 3 == 0);
            Console.WriteLine("Brojevi iz liste djeljivi s 3:");
            foreach(int i in djeljivi_s_3)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
