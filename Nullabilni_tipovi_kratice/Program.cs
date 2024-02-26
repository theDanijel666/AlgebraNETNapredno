using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullabilni_tipovi_kratice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? i = null;
            //int i2 = (int)i;
            int j = i ?? 1;

            Console.WriteLine(j);

        }
    }
}
