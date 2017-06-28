using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadania;
using NTest;

namespace Egzamin
{
    class Program
    {
        static void Main(string[] args)
        {
       
            Zadanie[] tabPyt = new Zadanie[2];
            string[] odp1 = { "a. Antananarywa", "b. Warszawa", "c. Seul", "d. Moskwa" };
            tabPyt[0] = new ZadJednaOdp("Co jest stolicą Madagaskaru?", odp1);
            // tabPyt[0].wyswietl();
            string[] odp2 = { "a. Radom", "b. Gniezno", "c. Kraków", "d. Warszawa" };
            tabPyt[1] = new ZadJednaOdp("Pierwsza stolica Polski", odp2);
            Test t1 = new Test(tabPyt);
            t1.wyswietlTest();
            Console.ReadKey();
        }
    }
}
