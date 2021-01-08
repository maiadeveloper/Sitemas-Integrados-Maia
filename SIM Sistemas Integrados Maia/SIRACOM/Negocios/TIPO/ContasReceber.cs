using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.RVTipo;

namespace Negocios.TIPO
{
    public class ContasReceber
    {
        int contaReceberID;

        public int _ContaReceberID
        {
            get { return contaReceberID; }
            set { contaReceberID = value; }
        }
        DateTime dataEntrada;

        public DateTime _DataEntrada
        {
            get { return dataEntrada; }
            set { dataEntrada = value; }
        }
        RealizarVendasTipos m_RealizarVenda;

        public RealizarVendasTipos _RealizarVenda
        {
            get { return m_RealizarVenda; }
            set { m_RealizarVenda = value; }
        }
        decimal valor_total;

        public decimal _Valor_total
        {
            get { return valor_total; }
            set { valor_total = value; }
        }
        DateTime dataVencimento;

        public DateTime _DataVencimento
        {
            get { return dataVencimento; }
            set { dataVencimento = value; }
        }

        int numeroVenda;

        public int _NumeroVenda
        {
            get { return numeroVenda; }
            set { numeroVenda = value; }
        }

        public ContasReceber()
        {
            m_RealizarVenda = new RealizarVendasTipos();
        }

        string situacao;

        public string _Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }
    }
}
