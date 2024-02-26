﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullabilni_tipovi_primjer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> i = null;

            //Console.WriteLine(i.Value);
            if (i != null)
            {
                Console.WriteLine(i.Value);
            }
            else
            {
                Console.WriteLine("Vrijednost je null!");
            }

            Console.WriteLine("==============");

            Console.WriteLine(i.GetValueOrDefault());
        }
    }
}
