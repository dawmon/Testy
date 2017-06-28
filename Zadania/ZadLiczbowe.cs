using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class ZadLiczbowe : Zadanie
    {

        static int Znak()   //sprawdzamy czy wpisana odpowiedz w liczbowym jest cyfrą   
        {
            int odp;    
            while (!int.TryParse (Console.ReadLine (), out odp))  //fosujemy użycie cyfry 
            {
                Console.WriteLine("Nieprawidłowy znak. Proszę użyj cyfr");
            }

            return odp;
        }
    }
}
