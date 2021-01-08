using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.TIPO
{
    public class Lancamentos
    {
        public int LancamentoID
        {
            get;
            set;
        }

        public string NumParcela
        {
            get;
            set;
        }

        public int EmpresaID
        {
            get;
            set;
        }

        public string TipoLancamento
        {
            get;
            set;
        }

        public int CodClienteFornecedor
        {
            get;
            set;
        }

        public int TipoDocumento
        {
            get;
            set;
        }

        public string Descricao
        {
            get;
            set;
        }

        public string NumDoc
        {
            get;
            set;
        }

        public DateTime DataEmissao
        {
            get;
            set;
        }

        public DateTime DataCadastro
        {
            get;
            set;
        }

        public DateTime DataVencimento
        {
            get;
            set;
        }

        public decimal ValorPrincipal
        {
            get;
            set;
        }

        public decimal ValorJuros
        {
            get;
            set;
        }

        public decimal ValorDesconto
        {
            get;
            set;
        }

        public int TipoDespesaID
        {
            get;
            set;
        }

        public DateTime DataPgto
        {
            get;
            set;
        }

        public string Observacao
        {
            get;
            set;
        }

        public string Situacao
        {
            get;
            set;
        }

        public decimal ValorAberto
        {
            get;
            set;
        }
    }
}
