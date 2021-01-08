using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.TIPO
{
    public class EntradaProduto
    {
        int entradaID;

        public int _EntradaID
        {
            get { return entradaID; }
            set { entradaID = value; }
        }

        int numeroDocumento;

        public int _NumeroDocumento
        {
            get { return numeroDocumento; }
            set { numeroDocumento = value; }
        }

        int numeroSerie;

        public int _NumeroSerie
        {
            get { return numeroSerie; }
            set { numeroSerie = value; }
        }

        DateTime dataEntrada;

        public DateTime _DataEntrada
        {
            get { return dataEntrada; }
            set { dataEntrada = value; }
        }

        DateTime dataDocumento;

        public DateTime _DataDocumento
        {
            get { return dataDocumento; }
            set { dataDocumento = value; }
        }

        string tipoEntrada;

        public string _TipoEntrada
        {
            get { return tipoEntrada; }
            set { tipoEntrada = value; }
        }

        CadastroFornecedores h_Fornecedor;

        public CadastroFornecedores H_Fornecedor
        {
            get { return h_Fornecedor; }
            set { h_Fornecedor = value; }
        }

        decimal valorFrete;

        public decimal _ValorFrete
        {
            get { return valorFrete; }
            set { valorFrete = value; }
        }

        decimal outrasDespesas;

        public decimal _OutrasDespesas
        {
            get { return outrasDespesas; }
            set { outrasDespesas = value; }
        }

        decimal desconto;

        public decimal _Desconto
        {
            get { return desconto; }
            set { desconto = value; }
        }

        decimal valorServico;

        public decimal _ValorServico
        {
            get { return valorServico; }
            set { valorServico = value; }
        }

        decimal totalNotaFiscal;

        public decimal _TotalNotaFiscal
        {
            get { return totalNotaFiscal; }
            set { totalNotaFiscal = value; }
        }

        public EntradaProduto()
        {
            h_Fornecedor = new CadastroFornecedores();
        }
    }
}
