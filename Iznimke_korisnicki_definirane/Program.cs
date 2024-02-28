﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iznimke_korisnicki_definirane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temperatura temp = new Temperatura();
            try
            {
                temp.PrikaziTemperaturu();
            }
            catch (TemperaturaJeNula e)
            {
                Console.WriteLine("Iznimka : "+e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
