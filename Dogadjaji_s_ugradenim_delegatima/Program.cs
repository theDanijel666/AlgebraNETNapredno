using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadjaji_s_ugradenim_delegatima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tvornica t=new Tvornica();
            t.ProizvodGotov += IdeUProdaju;

            t.PocniProizvodnju();
        }

        public static void IdeUProdaju(object sender,EventArgs e)
        {
            Console.WriteLine("Pakiranje proizvoda...");
            Console.WriteLine("Utovaranje u transport...");
            Console.WriteLine("Dostava u trgovinu...");
            Console.WriteLine("Traženje krajnjeg kupca..");
        }
    }

    class Tvornica
    {
        public event EventHandler ProizvodGotov;

        public void PocniProizvodnju()
        {
            Console.WriteLine("Materijal primjelj...");
            Console.WriteLine("Obrada...");
            // dalje šta treba traditi...
            ProizvodGotov?.Invoke(this, EventArgs.Empty);
        }
    }
}
