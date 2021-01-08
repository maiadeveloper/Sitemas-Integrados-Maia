using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.TIPO
{
    public class Caixa
    {
        public int CaixaID
        {
            get;
            set;
        }

        public DateTime DataAbertura
        {
            get;
            set;
        }

        public DateTime DataFechamento
        {
            get;
            set;
        }

        public DateTime DataReabertura
        {
            get;
            set;
        }

        public string Situacao
        {
            get;
            set;
        }

        public decimal SaldoCaixa { get; set; }
    }
}
