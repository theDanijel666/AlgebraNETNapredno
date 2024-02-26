using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_izrazi_greske
{
    class Osoba
    {
        public string Ime { get; set; }
        public int Dob { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var array=new int[] {1,2,3,4,5};
            //var rez = Array.Find(array, element => 2); //ne može
            var rez = Array.Find(array, element => element==2);

            var osobe = new Osoba[] {
                new Osoba {Ime="Matko",Dob=20},
                new Osoba {Ime="Ana",Dob=30},
                new Osoba {Ime="Matej",Dob=18},
                new Osoba {Ime="Vedran",Dob=34}
            };
            //var osoba = Array.Find(osobe, o.Dob => 18);
            var osoba = Array.Find(osobe, o => o.Dob == 18);
        }
    }
}
