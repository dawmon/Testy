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

            List<Zadanie> zad = new List<Zadanie>();

            zad.Add(new ZadJednaOdp("Co jest stolicą Madagaskaru?", new string[] { "Antananarywa", "Warszawa", "Seul", "Moskwa" }));
            zad.Add(new ZadJednaOdp("Pierwsza stolica Polski",      new string[] { "Radom", "Gniezno", "Kraków", "Warszawa" }));

            zad.Last().Wyswietl();


            Console.ReadKey();
        }
    }
}
