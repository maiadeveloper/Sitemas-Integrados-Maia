using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using System.Data.OleDb;
using System.Data;

namespace Negocios.DAO
{
    public class ItemEntradaProdutoDAO
    {
        StringBuilder sb;
        ConexaoBanco conexao;

        public void InserirItensEntradaProduto(ItemEntradaProduto itemEntradaProduto)
        {
            sb = new StringBuilder();
            conexao = new ConexaoBanco();

            sb.Append("INSERT INTO tblItensEntradaProdutos(CodigoEntrada,CodigoProduto,Qtde,Lote,DataVencimento,PrecoUnitario,Subtotal)VALUES");
            sb.Append("('" + itemEntradaProduto.H_EntradaProduto._EntradaID + "','");
            sb.Append(itemEntradaProduto.H_Produto._CodigoProduto + "','");
            sb.Append(itemEntradaProduto._Quantidade + "','");
            sb.Append(itemEntradaProduto.Lote + "','");
            sb.Append(itemEntradaProduto.DataVencimento + "','");
            sb.Append(itemEntradaProduto._PrecoUnitario + "','");
            sb.Append(itemEntradaProduto._PrecoParcial + "')");

            conexao.manterCRUD(sb.ToString());
        }

        public void ExcluirItensEntradaProduto(int entradaID)
        {
            sb = new StringBuilder();
            conexao = new ConexaoBanco();

            sb.Append("DELETE FROM tblItensEntradaProdutos WHERE CodigoEntrada = " + entradaID);

            conexao.manterCRUD(sb.ToString());
        }

        public ItemEntradaProduto SelecinaEntradaCodigoProduto(int cod)
        {
            sb = new StringBuilder();
            conexao = new ConexaoBanco();

            ItemEntradaProduto itemEntradaProduto = new ItemEntradaProduto();

            sb.Append("SELECT * FROM tblItensEntradaProdutos WHERE CodigoProduto = " + cod);

            OleDbDataReader leitor = conexao.selectDR(sb.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();
                itemEntradaProduto.H_Produto._CodigoProduto = (int)leitor["CodigoProduto"];
            }
            else
            {
                itemEntradaProduto = null;
            }

            leitor.Close();

            return itemEntradaProduto;
        }


        public DataTable CriaDataTableSelecionaItensEntradaMercadoria(int entradaID)
        {
            sb = new StringBuilder();
            conexao = new ConexaoBanco();

            DataTable dt = new DataTable();

            sb = new StringBuilder();

            sb.Append(string.Format("SELECT * FROM tblItensEntradaProdutos WHERE CodigoEntrada = " + entradaID));

            OleDbDataReader leitor = conexao.selectDR(sb.ToString());

            if (leitor != null)
            {
                dt.Load(leitor);
            }
            else
            {
                leitor = null;
            }

            return dt;
        }

        public OleDbDataAdapter ExibeProdutosPorDataVencimento(string parametro)
        {
            OleDbDataAdapter da = null;
            conexao = new ConexaoBanco();

            da = new OleDbDataAdapter("SELECT * FROM ViewItensEntradaProdutos WHERE " + parametro, conexao.conectar());

            return da;
        }
    }
}
