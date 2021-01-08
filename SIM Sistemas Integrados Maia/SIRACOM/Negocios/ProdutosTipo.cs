using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.ProdTipo
{
    public class ProdutosTipo
    {
        int codigoProduto;

        public int _CodigoProduto
        {
            get { return codigoProduto; }
            set { codigoProduto = value; }
        }
        int codigoFornecedor;

        public int _CodigoFornecedor
        {
            get { return codigoFornecedor; }
            set { codigoFornecedor = value; }
        }

        string nomeProduto;

        public string _NomeProduto
        {
            get { return nomeProduto; }
            set { nomeProduto = value; }
        }
        string descricaoProduto;

        public string _DescricaoProduto
        {
            get { return descricaoProduto; }
            set { descricaoProduto = value; }
        }

        private string categoriaProduto;

        public string _CategoriaProduto
        {
            get { return categoriaProduto; }
            set { categoriaProduto = value; }
        }
        private string nomeFornecedor;

        public string _NomeFornecedor
        {
            get { return nomeFornecedor; }
            set { nomeFornecedor = value; }
        }
        private string unidadeCompra;

        public string _UnidadeCompra
        {
            get { return unidadeCompra; }
            set { unidadeCompra = value; }
        }
        private DateTime dataCadastro;

        public DateTime _DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }
        private int estoqueMaximo;

        public int _EstoqueMaximo
        {
            get { return estoqueMaximo; }
            set { estoqueMaximo = value; }
        }
        private int estoqueMinimo;

        public int _EstoqueMinimo
        {
            get { return estoqueMinimo; }
            set { estoqueMinimo = value; }
        }

        int qtdeEstoque;

        public int _QtdeEstoque
        {
            get { return qtdeEstoque; }
            set { qtdeEstoque = value; }
        }

        public decimal _Lucro { get; set; }

        decimal valorUnitario;

        public decimal _ValorUnitario
        {
            get { return valorUnitario; }
            set { valorUnitario = value; }
        }

        string codigoBarra;

        public string _CodigoBarra
        {
            get { return codigoBarra; }
            set { codigoBarra = value; }
        }

        decimal PrecoCompra;

        public decimal _PrecoCompra
        {
            get { return PrecoCompra; }
            set { PrecoCompra = value; }
        }

        string margemLucro;

        public string _MargemLucro
        {
            get { return margemLucro; }
            set { margemLucro = value; }
        }

        public string _CaminhoImagem
        {
            get;
            set;
        }
    }
}
