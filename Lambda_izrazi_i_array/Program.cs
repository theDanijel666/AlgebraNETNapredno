using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_izrazi_i_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] brojevi = { 1, 2, 3, 4, 5, 6, 10, 13, 17 };
            Console.WriteLine("Brojevi:");
            foreach (int x in brojevi) Console.Write($"{x} ");

            Console.WriteLine();
            Console.WriteLine();

            int[] parni = brojevi.Where(x => x % 2 == 0).ToArray();
            Console.WriteLine("Parni brojevi iz polja: ");
            foreach (int x in parni) Console.Write($"{x} ");

            Console.WriteLine();
            Console.WriteLine();

            int[] neparni = brojevi.Where(x => x % 2 != 0).ToArray();
            Console.WriteLine("Neparni brojevi iz polja: ");
            foreach (int x in neparni) Console.Write($"{x} ");

            Console.WriteLine();
            Console.WriteLine();

            List<string> osobe= new List<string> {
                "Marko","Ivana","Ana","Ivan","Anastasija","Nikola","Krešimir","Silvija","Filip"
            };

            List<string> ime_pocinje_s_a=osobe.Where(o=>o.StartsWith("A")).ToList();
            foreach(string o in ime_pocinje_s_a) Console.Write(o+" ");
        }
    }
}
