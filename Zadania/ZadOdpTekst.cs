using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class ZadOdpTekst : Zadanie
    {
        protected List<string> odp = new List<string>();
        public override int Sprawdz(string str)
        {
            string i;
            i = odp.Find(x => x == str);
            return 1;
        }  
    }
}
