using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Security.Cryptography;

namespace Serializacija_dodatni_primjer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KorisnickiDetalji kd = new KorisnickiDetalji(1, "Nikola", "Tesla", "Smiljani");
            Console.WriteLine("Prije serializacije objekt sadrži sljedeće podatke: ");
            kd.DohvatiDetalje();
            Console.WriteLine();

            string datoteka = @"D:\Testiranje\serializacijaPrimjer.txt";

            if (File.Exists(datoteka))
            {
                File.Delete(datoteka);
            }

            Stream pohrani=File.Open(datoteka,FileMode.Create);
            BinaryFormatter bf=new BinaryFormatter();
            bf.Serialize(pohrani, kd);
            pohrani.Close();

            Console.WriteLine("Serializacija je uspješna!");

            Stream citaj = File.Open(datoteka, FileMode.Open);
            KorisnickiDetalji novi_detalji=(KorisnickiDetalji)bf.Deserialize(citaj);
            citaj.Close();

            Console.WriteLine();
            Console.WriteLine("Nakon deserializacije objekt sadrži: ");
            novi_detalji.DohvatiDetalje();

            //using (Stream st=File.Open(datoteka,FileMode.Open))
            //{
            //    KorisnickiDetalji novi_detalji2 = (KorisnickiDetalji)bf.Deserialize(citaj);
            //}

            

        }
    }
}
