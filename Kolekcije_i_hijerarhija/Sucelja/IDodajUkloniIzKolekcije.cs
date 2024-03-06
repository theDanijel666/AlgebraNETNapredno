using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcije_i_hijerarhija.Sucelja
{
    public interface IDodajUkloniIzKolekcije<T>:IDodajUKolekciju<T>
    {
        T Ukloni();
    }
}
