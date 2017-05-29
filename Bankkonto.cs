using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test___Kursprow
{
    class Bankkonto
    {
        //medlemsvariabler
        private string namn = "";
        private int saldo = 0;

        public Bankkonto()
        {
        }

        //kontruktor
        public Bankkonto (string namn, int saldo)
        {
            Namn = namn;
            Saldo = saldo;
        }

        //egenskaper
        public string Namn
        {
            get { return namn; }
            set { namn = Namn; }
        }
        public int Saldo
        {
            get { return saldo; }
            set
            {
                if (value > 0) saldo = value;
                else saldo = -value;
            }
        }

    }
}
