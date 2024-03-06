using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serializacija.Library;

namespace Serializacija.Konzola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MetodeZaSerializaciju nase_metode=new MetodeZaSerializaciju();
            nase_metode.SerializirajNesto();
            nase_metode.DeSerializirajNesto();
        }
    }
}
