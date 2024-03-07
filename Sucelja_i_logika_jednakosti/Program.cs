using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sucelja_i_logika_jednakosti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sortirane_osobe = new SortedSet<Osoba>();
            var hashed_osobe=new HashSet<Osoba>(new UpraviteljUsporedjivanjaOsoba());
            PopuniKolekciju(sortirane_osobe, hashed_osobe);

            Console.WriteLine("Sortiranih osoba: "+sortirane_osobe.Count);
            Console.WriteLine("Hashiranih osoba: "+hashed_osobe.Count);

            Console.WriteLine("Sortirane osobe:");
            foreach(var osoba in sortirane_osobe)
            {
                Console.WriteLine($"{osoba.Prezime} {osoba.Ime} {osoba.Dob}");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Hashirane osoboe: ");
            foreach(var o in hashed_osobe)
            {
                Console.WriteLine($"{o.Prezime} {o.Ime} {o.Dob}");
            }
        }

        private static void PopuniKolekciju(SortedSet<Osoba> sortirane_osobe,HashSet<Osoba> hashed_osobe)
        {
            Console.Write("Broj ljudi za unos: ");
            int broj_ljudi=int.Parse(Console.ReadLine());

            while (broj_ljudi > 0)
            {
                try
                {
                    Console.Write("Unesite ime: ");
                    string ime = Console.ReadLine();
                    Console.Write("Unesite prezime: ");
                    string prezime = Console.ReadLine();
                    Console.Write("Unesite godine: ");
                    int dob = int.Parse(Console.ReadLine());
                    //Osoba o = new Osoba(ime, prezime, dob);
                    sortirane_osobe.Add(new Osoba(ime, prezime, dob));
                    hashed_osobe.Add(new Osoba(ime, prezime, dob));

                    broj_ljudi--;
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
