using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rijecnik_uvod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string,string> rijecnik=new Dictionary<string,string>();
            //rijecnik.Add("ključ", "ključ");
            //Dictionary<string,string> rijecnik_en=new Dictionary<string,string>();
            //rijecnik_en.Add("ključ", "key");

            //Console.WriteLine("Za ključ \"ključ\" vrijednosti su:  " + rijecnik["ključ"]+" " + rijecnik_en["ključ"]);

            Dictionary<string, string> dictionary_en = new Dictionary<string, string>();
            Dictionary<string, string> dictionary_de = new Dictionary<string, string>();
            Dictionary<string, string> dictionary_hr = new Dictionary<string, string>();

            dictionary_en.Add("venom", "venom");
            dictionary_en.Add("poison", "poison");

            dictionary_hr.Add("venom", "otrov");
            dictionary_hr.Add("poison", "otrov");
            

            dictionary_en.Add("The difference between venom and poison?", "The difference between venom and poison?");
            dictionary_hr.Add("The difference between venom and poison?", "Koja je razlika između različitih vrsta otrova?");

            Dictionary<string, string> d;

            Console.WriteLine("Unesite kraticu jezika koji želite: ");
            string jezik=Console.ReadLine();

            switch (jezik.ToLower())
            {
                case "en":
                    d = dictionary_en;
                    break;
                case "hr":
                    d = dictionary_hr;
                    break;
                case "de":
                    d = dictionary_de;
                    break;
                default:
                    d= dictionary_en;
                    break;
            }

            string rez=d.Where(x => x.Value == "neka vrijednost").FirstOrDefault().Value;
        }
    }
}
