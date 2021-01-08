using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.Tipos
{
    public class CodicaoPagamento
    {
        int iuo;
        int numeroParcela;
        string condicaoPagamento;

        public int _Iuo
        {
            get { return iuo; }
            set { iuo = value; }
        }

        public int _NumeroParcela
        {
            get { return numeroParcela; }
            set { numeroParcela = value; }
        }

        public string _CondicaoPagamento
        {
            get { return condicaoPagamento; }
            set { condicaoPagamento = value; }
        }
    }
}