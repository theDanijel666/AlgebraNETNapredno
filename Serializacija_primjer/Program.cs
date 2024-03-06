using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serializacija_primjer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Polaznik p = new Polaznik();
            p.ID = 1;
            p.Ime = "Marko";

            IFormatter form = new BinaryFormatter();
            Stream pohrani = new FileStream("primjer.txt",
                FileMode.Create, FileAccess.Write);

            form.Serialize(pohrani, p);
            pohrani.Close();

            Stream procitaj=new FileStream("primjer.txt",
                FileMode.Open, FileAccess.Read);
            Polaznik novi_polaznik = (Polaznik)form.Deserialize(procitaj);

            Console.WriteLine("Nakon deserializacije:");
            Console.WriteLine("ID = " + novi_polaznik.ID);
            Console.WriteLine("Ime = " + novi_polaznik.Ime);
        }
    }
}
