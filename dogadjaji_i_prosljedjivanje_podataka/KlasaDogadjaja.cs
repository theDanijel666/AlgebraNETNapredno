using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dogadjaji_i_prosljedjivanje_podataka
{
    internal class KlasaDogadjaja
    {
        public event EventHandler<bool> ProcesZavrsen;

        public void ProcesPocinje()
        {
            try
            {
                Console.WriteLine("Proces je počeo");
                //kod vezan uz proces...
                KadProcesZavrsi(true);
            }
            catch(Exception ex)
            {
                KadProcesZavrsi(false);
            }
        }

        protected virtual void KadProcesZavrsi(bool status_procesa)
        {
            ProcesZavrsen?.Invoke(this, status_procesa);
        }
    }
}
