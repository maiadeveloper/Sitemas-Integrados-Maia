using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.ProdTipo;
using System.Data.OleDb;
using System.Data;

namespace Negocios.ProdDao
{
    public class ProdutosDAO
    {
        ConexaoBanco conexao = new ConexaoBanco();
        private string comandSql;
        StringBuilder sql;

        public void InserirProduto(ProdutosTipo objProdutoTipo)
        {
            comandSql = "INSERT INTO tblProduto(CodigoBarra,NomeProduto,DescricaoProduto,CategoriaProduto,UnidadeCompra,DataCadastro,EstoqueMinimo,EstoqueMaximo,QtdeEstoque,PrecoCompra,PrecoUnitario,MargemLucro,CaminhoImagem)VALUES('" +
                        objProdutoTipo._CodigoBarra + "','" + objProdutoTipo._NomeProduto + "','" + objProdutoTipo._DescricaoProduto + "','" + objProdutoTipo._CategoriaProduto +
                         "','" + objProdutoTipo._UnidadeCompra +
                         "','" + objProdutoTipo._DataCadastro + "','" + objProdutoTipo._EstoqueMinimo + "','" + objProdutoTipo._EstoqueMaximo + "','0','" + objProdutoTipo._PrecoCompra + "','" + objProdutoTipo._ValorUnitario + "','" + objProdutoTipo._MargemLucro + "','" + objProdutoTipo._CaminhoImagem + "')";

            conexao.manterCRUD(comandSql);
        }

        public void EditarProduto(ProdutosTipo produto)
        {
            sql = new StringBuilder();

            sql.Append("UPDATE tblProduto SET ");
            sql.Append("CodigoBarra = '" + produto._CodigoBarra + "',");
            sql.Append("NomeProduto = '" + produto._NomeProduto + "',");
            sql.Append("DescricaoProduto = '" + produto._DescricaoProduto + "',");
            sql.Append("CategoriaProduto = '" + produto._CategoriaProduto + "',");
            sql.Append("UnidadeCompra = '" + produto._UnidadeCompra + "',");
            sql.Append("DataCadastro = '" + produto._DataCadastro + "',");
            sql.Append("EstoqueMinimo = '" + produto._EstoqueMinimo + "',");
            sql.Append("PrecoUnitario = '" + produto._ValorUnitario + "',");
            sql.Append("PrecoCompra = '" + produto._PrecoCompra + "',");
            sql.Append("MargemLucro = '" + produto._MargemLucro + "',");
            sql.Append("CaminhoImagem = '" + produto._CaminhoImagem + "',");
            sql.Append("EstoqueMaximo = '" + produto._EstoqueMaximo + "' ");
            sql.Append("WHERE CodigoProduto = " + produto._CodigoProduto);

            conexao.manterCRUD(sql.ToString());
        }

        public void AlterarProduto(ProdutosTipo objProdutoTipo)
        {
            comandSql = "UPDATE tblProduto SET QtdeEstoque = '" + objProdutoTipo._QtdeEstoque +
                       "',PrecoUnitario  = '" + objProdutoTipo._ValorUnitario + "',PrecoCompra = '" + objProdutoTipo._PrecoCompra + "',MargemLucro = '" + objProdutoTipo._MargemLucro + "' WHERE CodigoProduto = " + objProdutoTipo._CodigoProduto;

            conexao.manterCRUD(comandSql);
        }

        public ProdutosTipo SelectProduto(ProdutosTipo produto)
        {
            comandSql = "SELECT * FROM tblProduto WHERE CodigoBarra = '" + produto._CodigoBarra + "'";

            OleDbDataReader leitor = conexao.selectDR(comandSql);

            if (leitor.HasRows)
            {
                leitor.Read();

                produto._CodigoProduto = (int)leitor["CodigoProduto"];
                produto._CodigoBarra = (string)leitor["CodigoBarra"];
                produto._NomeProduto = (string)leitor["NomeProduto"];
                produto._DescricaoProduto = (string)leitor["DescricaoProduto"];
                produto._CategoriaProduto = (string)leitor["CategoriaProduto"];
                produto._UnidadeCompra = (string)leitor["UnidadeCompra"];
                produto._DataCadastro = (DateTime)leitor["DataCadastro"];
                produto._EstoqueMinimo = (int)leitor["EstoqueMinimo"];
                produto._EstoqueMaximo = (int)leitor["EstoqueMaximo"];
                produto._QtdeEstoque = (int)leitor["QtdeEstoque"];
                produto._ValorUnitario = (decimal)leitor["PrecoUnitario"];

                if (leitor["MargemLucro"] != DBNull.Value)
                {
                    produto._MargemLucro = (string)leitor["MargemLucro"];
                }
                else
                {
                    produto._MargemLucro = "%";
                }

                produto._PrecoCompra = (decimal)leitor["PrecoCompra"];

                if (leitor["CaminhoImagem"] != DBNull.Value)
                {
                    produto._CaminhoImagem = (string)leitor["CaminhoImagem"];
                }
            }
            else
            {
                produto = null;
            }
            return produto;
        }

        public ProdutosTipo SelectProdutoCodigo(int codigoProduto)
        {
            comandSql = "SELECT * FROM tblProduto WHERE CodigoProduto = " + codigoProduto;

            ProdutosTipo produto = new ProdutosTipo();

            OleDbDataReader leitor = conexao.selectDR(comandSql);

            if (leitor.HasRows)
            {
                leitor.Read();

                produto._CodigoProduto = (int)leitor["CodigoProduto"];
                produto._CodigoBarra = (string)leitor["CodigoBarra"];
                produto._NomeProduto = (string)leitor["NomeProduto"];
                produto._DescricaoProduto = (string)leitor["DescricaoProduto"];
                produto._CategoriaProduto = (string)leitor["CategoriaProduto"];
                produto._UnidadeCompra = (string)leitor["UnidadeCompra"];
                produto._DataCadastro = (DateTime)leitor["DataCadastro"];
                produto._EstoqueMinimo = (int)leitor["EstoqueMinimo"];
                produto._EstoqueMaximo = (int)leitor["EstoqueMaximo"];
                produto._QtdeEstoque = (int)leitor["QtdeEstoque"];
                produto._ValorUnitario = (decimal)leitor["PrecoUnitario"];

                if (leitor["MargemLucro"] != DBNull.Value)
                {
                    produto._MargemLucro = (string)leitor["MargemLucro"];
                }
                else
                {
                    produto._MargemLucro = "%";
                }

                produto._PrecoCompra = (decimal)leitor["PrecoCompra"];
                if (leitor["CaminhoImagem"] != DBNull.Value)
                {
                    produto._CaminhoImagem = (string)leitor["CaminhoImagem"];
                }
            }
            else
            {
                produto = null;
            }
            return produto;
        }

        public ProdutosTipo SelectProdutoNome(ProdutosTipo objProdutoTipo)
        {
            comandSql = "SELECT * FROM tblProduto WHERE DescricaoProduto = '" + objProdutoTipo._DescricaoProduto + "'";

            OleDbDataReader leitor = conexao.selectDR(comandSql);

            if (leitor.HasRows)
            {
                leitor.Read();

                objProdutoTipo._CodigoProduto = (int)leitor["CodigoProduto"];
                objProdutoTipo._DescricaoProduto = (string)leitor["DescricaoProduto"];
                objProdutoTipo._QtdeEstoque = (int)leitor["QtdeEstoque"];
                objProdutoTipo._ValorUnitario = (decimal)leitor["PrecoUnitario"];
                if (leitor["CaminhoImagem"] != DBNull.Value)
                {
                    objProdutoTipo._CaminhoImagem = (string)leitor["CaminhoImagem"];
                }
            }
            else
            {
                objProdutoTipo = null;
            }
            return objProdutoTipo;
        }

        public void AlterarQuantidadeEstoqueProduto(ProdutosTipo produtoTipo)
        {
            comandSql = "UPDATE tblProduto SET QtdeEstoque = QtdeEstoque + " + produtoTipo._QtdeEstoque + " WHERE CodigoProduto = " + produtoTipo._CodigoProduto;
            conexao.manterCRUD(comandSql);
        }

        public void BaixarQtdeProdutoEstoque(int cod, int qtde)
        {
            comandSql = "UPDATE tblProduto SET QtdeEstoque = QtdeEstoque - " + qtde + " WHERE CodigoProduto = " + cod;
            conexao.manterCRUD(comandSql);
        }

        public void AlterarVlrPrecoCompra(ProdutosTipo produtoTipo)
        {
            comandSql = "UPDATE tblProduto SET PrecoCompra = " + produtoTipo._PrecoCompra.ToString().Replace(",", ".") + " WHERE CodigoProduto = " + produtoTipo._CodigoProduto;
            conexao.manterCRUD(comandSql);
        }

        public void ExlcuirProduto(int codigoProduto)
        {
            comandSql = string.Format("DELETE FROM tblProduto WHERE CodigoProduto = {0}", codigoProduto);
            conexao.manterCRUD(comandSql);
        }

        public OleDbDataAdapter ExibeProdutosEstoqueMinimo(string tipo)
        {
            OleDbDataAdapter da = null;

            switch (tipo)
            {
                case "minimo":
                    da = new OleDbDataAdapter("SELECT * FROM tblProduto p WHERE QtdeEstoque <= (SELECT EstoqueMinimo FROM tblProduto WHERE CodigoProduto = P.CodigoProduto)", conexao.conectar());
                    break;
                case "maximo":
                    da = new OleDbDataAdapter("SELECT * FROM tblProduto p WHERE QtdeEstoque >= (SELECT EstoqueMaximo FROM tblProduto WHERE CodigoProduto = P.CodigoProduto)", conexao.conectar());
                    break;
                case "geral":
                    da = new OleDbDataAdapter("SELECT * FROM tblProduto", conexao.conectar());
                    break;
            }
            return da;
        }


        /// <summary>
        /// Retorna um dataTable
        /// </summary>
        /// <returns></returns>
        public DataTable CriaDataTableSelecionaTodosProdutos(string parametro)
        {
            conexao = new ConexaoBanco();

            DataTable dt = new DataTable();

            sql = new StringBuilder();

            if (!string.IsNullOrEmpty(parametro))
            {
                sql.Append("SELECT * FROM tblProduto WHERE CodigoBarra LIKE '%" + parametro + "%'");
                sql.Append(" OR NomeProduto LIKE '%" + parametro + "%'");
                sql.Append(" OR DescricaoProduto LIKE '%" + parametro + "%'");
                sql.Append(" OR CategoriaProduto LIKE '%" + parametro + "%'");
            }
            else
            {
                sql.Append("SELECT * FROM tblProduto ORDER BY CodigoProduto DESC");
            }

            OleDbDataReader leitor = conexao.selectDR(sql.ToString());

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
    }
}
