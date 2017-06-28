using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    public abstract class Zadanie
    {
        protected string pyt;       //treść zadania
        int maxPkt;                 //wartosc liczbowa mowiaca ile mozna zdobyc za zadanie max pkt
        float zdobytePkt;           //wartosc liczbowa mowiaca ile uzytkownik zdobyl za to zadanie

        public string Pytanie
        {
            get { return pyt; }
            set { pyt = value; }
        }

        public virtual string Wyswietl() { return null; }


        //
        /*
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
            {
                Console.Write((char)(i+97));
                Console.Write(" ");
                Console.WriteLine(this.odp[i]);
            }
                
        }
        
    }*/
    }
}