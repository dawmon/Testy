﻿using System;
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

        public List<string> Odpowiedz
        {
            get { return odp; }
        }

        public ZadJednaOdp(string tresc)
        {
            pyt = tresc;
        }




        /*

        protected override bool sprPyt(string[] poprOdp)
        {
            if (this.odp == poprOdp)
                return true;
            else
                return false;
        }

        public ZadJednaOdp(string tresc, string[] odpowiedzi) : base(tresc, odpowiedzi) { }

    */


    }
}
