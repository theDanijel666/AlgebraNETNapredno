using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadjaji_s_prilagodjenim_klasama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KlasaDogadjaja kd=new KlasaDogadjaja();
            kd.ProcesZavrsen += Kd_ProcesZavrsen;

            kd.ProcesPocinje();
        }

        private static void Kd_ProcesZavrsen(object sender, KlasaZaStatuse e)
        {
            Console.WriteLine("Proces završio u "+e.Vrijeme.ToString());
            if (e.Status) Console.WriteLine("S dobrim uspjehom");
            else Console.WriteLine("S neuspjehom!");
        }
    }
}
