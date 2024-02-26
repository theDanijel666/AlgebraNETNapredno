using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dogadjaji_s_prilagodjenim_klasama
{
    internal class KlasaDogadjaja
    {
        public event EventHandler<KlasaZaStatuse> ProcesZavrsen;

        public void ProcesPocinje()
        {
            var podaci = new KlasaZaStatuse();
            podaci.Vrijeme = DateTime.Now;

            try
            {
                Console.WriteLine("Proces je poceo...");

                podaci.Status = true;
            }
            catch (Exception ex)
            {
                podaci.Status = false;
            }
            ProcesZavrsen?.Invoke(this, podaci);
        }
    }
}
