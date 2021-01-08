using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.TIPO
{
    public class Despesas
    {
        public int DespesasID
        {
            get;
            set;
        }

        public DateTime Data
        {
            get;
            set;
        }

        public int TipoDespesaID
        {
            get;
            set;
        }

        public string DescricaoDespesa
        {
            get;
            set;
        }

        public int ContaID
        {
            get;
            set;
        }

        public decimal Valor
        {
            get;
            set;


        }
    }
}
