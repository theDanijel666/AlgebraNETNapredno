using Kolekcije_i_hijerarhija.Sucelja;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcije_i_hijerarhija.Models
{
    public class MojaLista<T> : DodajUkloniIzKolekcije<T>, IMojaLista<T>
    {
        public IReadOnlyCollection<T> Kolekcija
        {
            get
            {
                return this.Podaci as IReadOnlyCollection<T>;
            }
        }

        public override T Ukloni()
        {
            var prvi_element = this.Podaci.Last();
            this.Podaci = new Stack<T>(this.Podaci.Take(this.Podaci.Count - 1).Reverse());
            return prvi_element;
        }
    }
}
