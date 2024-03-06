﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_methods_primjer
{
    public static class DodatnaEkstenzija
    {
        public static bool JeVeceOd(this int i, int broj)
        {
            return i > broj;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            bool rez = i.JeVeceOd(100);
            Console.WriteLine(rez);

        }
    }
}
