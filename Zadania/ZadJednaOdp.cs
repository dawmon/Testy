using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania
{
    public class ZadJednaOdp : Zadanie
    {
        protected List<string> odp = new List<string>();        //odpowiedzi zadania
        protected int nrPoprawnejOdp;                           //wskazane która z nich jest poprawna

        public ZadJednaOdp(string tresc, string[] odpo, int val)
        {
            pyt = tresc;
            odp = odpo.ToList();
            nrPoprawnejOdp = val;
        }

        public List<string> Odp
        {
            get { return odp; }
            set { odp.Add(value.ToString()); }
        }

        private string Print(List<string> st)
        {
            string str = null;
            int i = 0;
            char ch;
            foreach (string cos in st)
            {
                str += Environment.NewLine;
                ch = (char)(i++ + 97);
                str += ch.ToString();
                str += ") ";
                str += cos;
            }
            return str;
        }

        public override string Wyswietl()
        {
            string str = null;
            str += pyt;
            str += " ";
            str += Print(odp);
            str += Environment.NewLine;
            return str;
        }

        /* zaczatek do sprawdzania z tekstem
        public override int Sprawdz(string str)
        {
            string i;
            i = odp.Find(x => x == str);
            return 1;
        }
        */

        public override int Sprawdz(string str)
        {
            if ((int)str[0]
        }

    }
}
