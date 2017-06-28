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

            //ja tam wole listy 
            //List<Zadanie> zadania = new List<Zadanie>();

            Test test = new Test();


            List<Zadanie> jebac = new List<Zadanie>();

            jebac.Add(new ZadJednaOdp("zupa"));


            /*
            //to majster widzisz ten komentarz? 
       
            Zadanie[] tabPyt = new Zadanie[2];
            string[] odp1 = { "Antananarywa", "Warszawa", "Seul", "Moskwa" };
            tabPyt[0] = new ZadJednaOdp("Co jest stolicą Madagaskaru?", odp1);
            // tabPyt[0].wyswietl();

            string[] odp2 = { "Radom", "Gniezno", "Kraków", "Warszawa" };
            tabPyt[1] = new ZadJednaOdp("Pierwsza stolica Polski", odp2);

            Test t1 = new Test(tabPyt);

            t1.wyswietlTest();
            */





            Console.ReadKey();
        }
    }
}
