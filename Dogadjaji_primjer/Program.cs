using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadjaji_primjer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KlasaDogadjaja kd = new KlasaDogadjaja();
            kd.ProcesZavrsen += ProcesJeZavrsio;

            kd.ProcesPoceo();
        }

        public static void ProcesJeZavrsio()
        {
            Console.WriteLine("......");
            Console.WriteLine("------");
            Console.WriteLine(",,,,,,");
            Console.WriteLine("Proces je završio");
        }
    }
}
