using Kolekcije_i_hijerarhija.Sucelja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kolekcije_i_hijerarhija.Models;

namespace Kolekcije_i_hijerarhija.Controller
{
    public class KontrolnaKlasa
    {
        private IDodajUKolekciju<string> dodaj_u_kolekciju;
        private IDodajUkloniIzKolekcije<string> dodaj_ukloni_iz_kolekcije;
        private IMojaLista<string> moja_lista;
        private StringBuilder rezultat_za_ispis;

        public KontrolnaKlasa()
        {
            this.dodaj_u_kolekciju = new DodajKolekciju<string>();
            this.dodaj_ukloni_iz_kolekcije = new DodajUkloniIzKolekcije<string>();
            this.moja_lista = new MojaLista<string>();
            this.rezultat_za_ispis = new StringBuilder();
        }

        public void PokreniProces()
        {
            Console.Write("Unesite nekoliko riječi ili dužu rečenicu: ");
            var input = Console.ReadLine().Split();
            this.PopuniKolekciju(ref input, this.dodaj_u_kolekciju);
            this.PopuniKolekciju(ref input, this.dodaj_ukloni_iz_kolekcije);
            this.PopuniKolekciju(ref input, this.moja_lista);

            Console.Write("Unesite broj elemenata za uklanjanje: ");
            var broj=int.Parse(Console.ReadLine());
            this.OperacijaUklanjanja(broj, this.dodaj_ukloni_iz_kolekcije);
            this.OperacijaUklanjanja(broj,this.moja_lista);

            Console.WriteLine(this.rezultat_za_ispis.ToString().Trim());
        }

        private void OperacijaUklanjanja<T>(int broj_elemenata_za_uklanjanje,IDodajUkloniIzKolekcije<T> kolekcija)
        {
            while (broj_elemenata_za_uklanjanje > 0)
            {
                var removedElement = kolekcija.Ukloni();
                this.rezultat_za_ispis.Append(removedElement + " ");
                broj_elemenata_za_uklanjanje--;
            }

            this.rezultat_za_ispis.Remove(this.rezultat_za_ispis.Length - 1, 1).AppendLine();
        }

        private void PopuniKolekciju(ref string[] input,IDodajUKolekciju<string> kolekcija)
        {
            foreach(var str in input)
            {
                var index = kolekcija.Dodaj(str);
                this.rezultat_za_ispis.Append($"{index} ");
            }

            this.rezultat_za_ispis.Remove(this.rezultat_za_ispis.Length - 1, 1).AppendLine();
        }
    }
}
