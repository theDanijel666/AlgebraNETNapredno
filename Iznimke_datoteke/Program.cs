using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iznimke_datoteke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dat = "C:\\Program Files\\primjer.txt";
            try
            {
                if (File.Exists(dat))
                {
                    File.Delete(dat);
                }
                Console.WriteLine("Stvaranje datoteke na disku ako postoji:");
                using (FileStream fs = File.Create(dat))
                {
                    Console.WriteLine("Datoteka stvorena s imenom " + dat);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Greška: " + e.Message);
            }
        }
    }
}
