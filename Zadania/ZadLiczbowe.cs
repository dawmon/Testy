using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    class ZadLiczbowe : Zadanie
    {
        /*  protected override bool sprPyt(string[] poprOdp)
         {
             if (this.odp == poprOdp)
                 return true;    
             else
                 return false;
         }*/
        Random Losowaliczba = new Random();
        int liczba1;
        int liczba2;
        public void liczby {
            liczba1 = Losowaliczba.Next(51);
            liczba2 = Losowaliczba.Next(51);
        }
        private bool odpowiedzi()
        {
            if ((liczba1 + liczba2 == suma.Value)
                 (liczba1 - liczba2 == minus.Value)
                 (liczba1 * liczba2 == mno.Value)
                 (liczba1 / liczba2 == dzie.Value))
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
