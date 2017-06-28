using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class ZadLiczbowe : Zadanie
    {
         protected override bool sprPyt(string[] poprOdp)
        {
            if (this.odp == poprOdp)
                return true;
            else
                return false;
        }
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
