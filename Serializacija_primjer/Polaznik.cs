using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Serializacija_primjer
{
    [Serializable]
    class Polaznik
    {
        public int ID {  get; set; }
        public string Ime { get; set; }
    }
}
