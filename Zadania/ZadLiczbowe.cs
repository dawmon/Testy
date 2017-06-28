using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class ZadLiczbowe : Zadanie
    {

        static int Znak()
        {
            int odp;
            while (!int.TryParse (Console.ReadLine (), out odp))
            {
                Console.WriteLine("Nieprawidłowy znak. Proszę użyj cyfr");
            }

            return odp;
        }
    }
}
