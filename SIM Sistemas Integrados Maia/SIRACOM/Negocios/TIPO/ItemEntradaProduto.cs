using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.ProdTipo;

namespace Negocios.TIPO
{
    public class ItemEntradaProduto
    {
        int itemEntradaProdutoID;

        public int _ItemEntradaProdutoID
        {
            get { return itemEntradaProdutoID; }
            set { itemEntradaProdutoID = value; }
        }

        EntradaProduto h_EntradaProduto;

        public EntradaProduto H_EntradaProduto
        {
            get { return h_EntradaProduto; }
            set { h_EntradaProduto = value; }
        }

        ProdutosTipo h_Produto;

        public ProdutosTipo H_Produto
        {
            get { return h_Produto; }
            set { h_Produto = value; }
        }

        int quantidade;

        public int _Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        decimal precoUnitario;

        public decimal _PrecoUnitario
        {
            get { return precoUnitario; }
            set { precoUnitario = value; }
        }

        decimal precoParcial;

        public decimal _PrecoParcial
        {
            get { return precoParcial; }
            set { precoParcial = value; }
        }

        public DateTime DataVencimento { get; set; }
        public string Lote { get; set; }

        public ItemEntradaProduto()
        {
            h_EntradaProduto = new EntradaProduto();
            h_Produto = new ProdutosTipo();
        }
    }
}
