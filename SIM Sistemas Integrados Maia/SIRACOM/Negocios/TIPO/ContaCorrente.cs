using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.TIPO
{
    public class ContaCorrente
    {
        public int ContaID
        {
            get;
            set;
        }

        public int BancoID
        {
            get;
            set;
        }

        public string Agencia
        {
            get;
            set;
        }

        public int CC
        {
            get;
            set;
        }

        public decimal Saldo
        {
            get;
            set;
        }
    }
}
