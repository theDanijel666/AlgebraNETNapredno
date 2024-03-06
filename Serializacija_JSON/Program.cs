using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Globalization;

namespace Serializacija_JSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zaposlenik z = new Zaposlenik
            {
                ID = 1,
                Ime = "Nikola",
                Prezime = "Tesla",
                DatumRodjenja = new DateTime(1856, 7, 18)
            };

            Console.WriteLine("Sadržaj objekta: ");
            Console.WriteLine(z.ToString());
            Console.WriteLine();
            string json = JsonSerializer.Serialize(z);
            Console.WriteLine(json);

            string datoteka = "serializirano.txt";

            System.IO.File.WriteAllText(datoteka,json);

            string procitano_json=System.IO.File.ReadAllText(datoteka);
            Console.WriteLine("Pročitano iz datoteke: "+procitano_json);

            Zaposlenik novi_zaposlenik=JsonSerializer.Deserialize<Zaposlenik>(procitano_json);
            Console.WriteLine("Sadržaj deserializiranog objekta:");
            Console.WriteLine(novi_zaposlenik.ToString());
        }
    }
}
