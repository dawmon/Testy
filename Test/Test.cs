using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zadania;

namespace NTest
{
    public class Test
    {


        public Test(IEnumerable<Zadanie> zad)
        {

        }


        public string Wyswietl(List<Zadanie> zad)
        {
            string str = null;
            for (int i = 0; i< zad.Count(); i++)
            {
                str += zad[i].Wyswietl();
            }
            return str;
        }

        /*
        public Zadanie[] listaPyt;
        public void wyswietlTest()
        {
            for (int i = 0; i < listaPyt.Count(); i++)
            {
                Console.Write(i+1);
                this.listaPyt[i].wyswietl();
                //Console.WriteLine("Podaj odpowiedz")
            }
                
        }

        public Test(Zadanie[] lista)
        {
            this.listaPyt = lista;
        }

    */
    }
}
