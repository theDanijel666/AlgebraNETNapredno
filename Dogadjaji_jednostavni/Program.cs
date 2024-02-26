using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadjaji_jednostavni
{
    public delegate void DelegatEventHandler();
    internal class Program
    {
        public static event DelegatEventHandler dodaj;
        static void Main(string[] args)
        {
            dodaj += new DelegatEventHandler(Njemacka);
            dodaj += new DelegatEventHandler(Austrija);
            dodaj += new DelegatEventHandler(Engleska);
            dodaj.Invoke();
        }

        static void Njemacka()
        {
            Console.WriteLine("Deutschland");
        }

        static void Austrija()
        {
            Console.WriteLine("Ostereich");
        }

        static void Engleska()
        {
            Console.WriteLine("England");
        }
    }
}
