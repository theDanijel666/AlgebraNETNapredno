using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Serializacija.Library
{
    public class MetodeZaSerializaciju
    {
        public void SerializirajNesto()
        {
            List<KlasaZaSerializaciju> kzs=new List<KlasaZaSerializaciju> ();
            kzs.Add(new KlasaZaSerializaciju()
            {
                Ime = "Nikola",
                Prezime = "Tesla",
                Godine=78
            });
            kzs.Add(new KlasaZaSerializaciju()
            {
                Ime = "Tin",
                Prezime = "Ujević",
                Godine = 87
            });
            kzs.Add(new KlasaZaSerializaciju()
            {
                Ime = "Bruce",
                Prezime = "Lee",
                Godine = 36
            });
            kzs.Add(new KlasaZaSerializaciju()
            {
                Ime = "Albert",
                Prezime = "Einstein",
                Godine = 78
            });

            IFormatter format = new BinaryFormatter();
            Stream pohrani = new FileStream("primjer.dat", FileMode.Create, FileAccess.Write);

            format.Serialize(pohrani, kzs);
            pohrani.Close();

        }

        public void DeSerializirajNesto()
        {
            List<KlasaZaSerializaciju> lista;

            IFormatter formatter = new BinaryFormatter();
            Stream procitaj=new FileStream("primjer.dat",FileMode.Open, FileAccess.Read);
            lista=(List<KlasaZaSerializaciju>)formatter.Deserialize(procitaj);
            procitaj.Close();

            foreach(var item in lista)
            {
                Console.WriteLine("Ime i prezime: "+item.Ime+" "+item.Prezime);
                Console.WriteLine("Godine: "+item.Godine);
                Console.WriteLine("Naziv tvrtke: "+KlasaZaSerializaciju.NazivTvrtke);
                Console.WriteLine();
            }

        }
    }
}
