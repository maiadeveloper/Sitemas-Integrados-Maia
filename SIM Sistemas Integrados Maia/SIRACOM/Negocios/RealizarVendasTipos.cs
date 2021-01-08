using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.RVTipo
{
    public class RealizarVendasTipos
    {

        int codigoVendedor;
        int numeroVenda;
        int item;
        int iuo;
        int qtde;
        int codigoCliente;
        int status;

        string descricao;
        string nome;
        string nomeVendedor;
        string formaPagamento;
        string numeroParcela;
        string numeroVendaCabecalho;
        string resultadoEntrega;
        string situacaoEntrega;
        string statusPagamento;

        decimal subTotal;
        decimal precoUnitario;
        decimal totalPagar;
        decimal totalParcelado;
        decimal juros;
        decimal descontos;

        public string _ResultadoEntrega
        {
            get { return resultadoEntrega; }
            set { resultadoEntrega = value; }
        }

        public string _SituacaoEntrega
        {
            get { return situacaoEntrega; }
            set { situacaoEntrega = value; }
        }

        public int _Status
        {
            get { return status; }
            set { status = value; }
        }

        public string _FormaPagamento
        {
            get { return formaPagamento; }
            set { formaPagamento = value; }
        }

        public int _NumeroVenda
        {
            get { return numeroVenda; }
            set { numeroVenda = value; }
        }

        public decimal _TotalParcelado
        {
            get { return totalParcelado; }
            set { totalParcelado = value; }
        }

        DateTime dataVenda;
        DateTime dtVenc;

        public decimal _Juros
        {
            get { return juros; }
            set { juros = value; }
        }

        public decimal _Descontos
        {
            get { return descontos; }
            set { descontos = value; }
        }
 

        public DateTime _DtVenc
        {
            get { return dtVenc; }
            set { dtVenc = value; }
        }

       

        public string _NomeVendedor
        {
            get { return nomeVendedor; }
            set { nomeVendedor = value; }
        }

        public int _CodigoVendedor
        {
            get { return codigoVendedor; }
            set { codigoVendedor = value; }
        }

        public int _CodigoCliente
        {
            get { return codigoCliente; }
            set { codigoCliente = value; }
        }

        public string _Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public DateTime _DataVenda
        {
            get { return dataVenda; }
            set { dataVenda = value; }
        }

        public string _NumeroVendaCabecalho
        {
            get { return numeroVendaCabecalho; }
            set { numeroVendaCabecalho = value; }
        }


        public string _NumeroParcela
        {
            get { return numeroParcela; }
            set { numeroParcela = value; }
        }

        public int _Item
        {
            get { return item; }
            set { item = value; }
        }

        public int _Iuo
        {
            get { return iuo; }
            set { iuo = value; }
        }

        public string _Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public int _Qtde
        {
            get { return qtde; }
            set { qtde = value; }
        }

        public decimal _PrecoUnitario
        {
            get { return precoUnitario; }
            set { precoUnitario = value; }
        }

        public decimal _SubTotal
        {
            get { return subTotal; }
            set { subTotal = value; }
        }

        public decimal _TotalPagar
        {
            get { return totalPagar; }
            set { totalPagar = value; }
        }

        public string _StatusPagamento
        {
            get { return statusPagamento; }
            set { statusPagamento = value; }
        }
    }
}
