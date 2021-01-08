using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.TIPO
{
    public class ItemContasReceber
    {
        int itemContaReceberID;
        ContasReceber m_ContasReceber;
        string numeroParcela;

        public string _NumeroParcela
        {
            get { return numeroParcela; }
            set { numeroParcela = value; }
        }
        decimal valorParcela;

        public decimal _ValorParcela
        {
            get { return valorParcela; }
            set { valorParcela = value; }
        }
        DateTime dataVencimento;

        public DateTime _DataVencimento
        {
            get { return dataVencimento; }
            set { dataVencimento = value; }
        }
        string status;

        public string _Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
