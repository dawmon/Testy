using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    public class Zadanie
    {

        //zmiana na życzenie

        protected string pyt;
        //protected int ilePopr;

        //do odpowiedniej klasy
        protected string[] odp;
        protected string poprOdp;

        protected virtual bool sprPyt(string[] poprOdp) { return false; }
        public Zadanie(string tresc, string[] odpowiedzi)
        {
            this.pyt = tresc;
            this.odp = odpowiedzi;
        }

        public void wyswietl()
        {
            Console.WriteLine(this.pyt);
            for (int i = 0; i < odp.Count(); i++)
                Console.WriteLine(this.odp[i]);
        }
    }
}
