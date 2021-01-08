using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.TIPO
{
    public class ItemContaReceber
    {
        int itemContaReceberID;
        int item;

        public int Item
        {
            get { return item; }
            set { item = value; }
        }

        public int _ItemContaReceberID
        {
            get { return itemContaReceberID; }
            set { itemContaReceberID = value; }
        }
        ContasReceber m_ContaReceber;

        public ContasReceber _ContaReceber
        {
            get { return m_ContaReceber; }
            set { m_ContaReceber = value; }
        }
        string numeroParcela;

        public string _NumeroParcela
        {
            get { return numeroParcela; }
            set { numeroParcela = value; }
        }
        string status;

        public string _Status
        {
            get { return status; }
            set { status = value; }
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

        public ItemContaReceber()
        {
            m_ContaReceber = new ContasReceber();
        }

        decimal juros;

        public decimal _Juros
        {
            get { return juros; }
            set { juros = value; }
        }
        DateTime dataPagamento;

        public DateTime _DataPagamento
        {
            get { return dataPagamento; }
            set { dataPagamento = value; }
        }
        decimal valorPago;

        public decimal _ValorPago
        {
            get { return valorPago; }
            set { valorPago = value; }
        }
        decimal valorApagar;

        public decimal _ValorApagar
        {
            get { return valorApagar; }
            set { valorApagar = value; }
        }

        public decimal ValorMulta { get; set; }
        public decimal ValorAberto { get; set; }
        public int DiasAtraso { get; set; }
        public decimal ValorCobrado { get; set; }
        public string negociacao { get; set; }
    }
}
