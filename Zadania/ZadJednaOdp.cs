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

        public ZadJednaOdp(string tresc, string[] odpo)
        {
            pyt = tresc;
            odp = odpo.ToList();
        }

        public List<string> Odp
        {
            get { return odp; }
            set { odp.Add(value.ToString()); }
        }

        private string Print(List<string> st)
        {
            string str = null;
            foreach (string cos in st)
            {
                str += st;
                str += Environment.NewLine;
            }
            return str;
        }

        public override string Wyswietl()
        {
            string str = null;
            str += pyt;
            str += " ";
            str += Print(odp);
            return str;
        }


    }
}
