using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.ProdTipo;
using System.Data.OleDb;
using Negocios.ProdDao;
using System.Windows.Forms;
using Negocios;
using System.Data;

namespace Negocios.ProdBo
{
    public class ProdutosBO
    {
        ProdutosDAO objProdutosDao;
        ConexaoBanco conexao = new ConexaoBanco();

        //Método inserir produto responsavel por fazer a regra de negocio
        public void InserirProduto(ProdutosTipo objProdutoTipo)
        {
            objProdutosDao = new ProdutosDAO();

            if (objProdutoTipo._CodigoProduto != 0)
            {
                objProdutosDao.EditarProduto(objProdutoTipo);
            }
            else
            {
                objProdutosDao.InserirProduto(objProdutoTipo);
            }
        }

        //Método responsavel por busca produto
        public ProdutosTipo SelecioneCodigoProduto(ProdutosTipo objProdutoTipo)
        {
            if (null != objProdutoTipo)
            {
                objProdutosDao = new ProdutosDAO();
            }
            return objProdutosDao.SelectProduto(objProdutoTipo);
        }

        //Método responsavel por busca produto
        public ProdutosTipo SelectCodProduto(int codigo)
        {
            if (null != codigo)
            {
                objProdutosDao = new ProdutosDAO();
            }
            return objProdutosDao.SelectProdutoCodigo(codigo);
        }


        public ProdutosTipo SelectProdutoNome(ProdutosTipo objProdutoTipo)
        {
            objProdutosDao = new ProdutosDAO();
            return objProdutosDao.SelectProdutoNome(objProdutoTipo);
        }

        public void AlterarProduto(ProdutosTipo objProduto)
        {
            objProdutosDao = new ProdutosDAO();

            if (objProduto != null)
            {
                objProdutosDao.AlterarProduto(objProduto);
            }
        }

        public ProdutosTipo SelectProduto(ProdutosTipo objProdutoTipo)
        {
            objProdutosDao = new ProdutosDAO();
            return objProdutosDao.SelectProduto(objProdutoTipo);
        }

        public void ExlcuirProduto(int codigoProduto)
        {
            objProdutosDao = new ProdutosDAO();
            objProdutosDao.ExlcuirProduto(codigoProduto);
        }

        //Método validar, responsavel por  verificar se os campos estao preenchidos
        public Boolean validarCampos(ProdutosTipo objProdutoTipo)
        {
            if (objProdutoTipo._NomeProduto == string.Empty)
            {
                MessageBox.Show("Informe o nome do produto !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (objProdutoTipo._DescricaoProduto == string.Empty)
            {
                MessageBox.Show("Informe a descrição do produto!!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (objProdutoTipo._CategoriaProduto == string.Empty)
            {
                MessageBox.Show("Informe a categoria do produto!!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (objProdutoTipo._UnidadeCompra == string.Empty)
            {
                MessageBox.Show("Informe a unidade de compra deste produto!!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (objProdutoTipo._EstoqueMaximo <= 0)
            {
                MessageBox.Show("Informe a quantidade maxima para estoque deste produto!!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (objProdutoTipo._EstoqueMinimo <= 0)
            {
                MessageBox.Show("Informe a quantidade minima para estoque deste produto!!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (objProdutoTipo._CodigoFornecedor <= 0)
            {
                MessageBox.Show("Informe o código do fornecedor!!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        public void AlterarQuantidadeEstoqueProduto(ProdutosTipo produtoTipo)
        {
            ProdutosDAO produtoDao = new ProdutosDAO();
            produtoDao.AlterarQuantidadeEstoqueProduto(produtoTipo);
        }


        public void AlterarVlrPrecoCompra(ProdutosTipo produtoTipo)
        {
            ProdutosDAO produtoDao = new ProdutosDAO();
            produtoDao.AlterarVlrPrecoCompra(produtoTipo);
        }

        public void BaixarQtdeProdutoEstoque(int cod, int qtde)
        {
            ProdutosDAO produtoDao = new ProdutosDAO();
            produtoDao.BaixarQtdeProdutoEstoque(cod, qtde);
        }

        public OleDbDataAdapter ExibeProdutosEstoqueMinimo(string tipo)
        {
            ProdutosDAO produtoDao = new ProdutosDAO();
            OleDbDataAdapter da = produtoDao.ExibeProdutosEstoqueMinimo(tipo);
            return da;
        }

        /// <summary>
        /// Cria um datatable
        /// </summary>
        /// <returns></returns>
        public DataTable CriaDataTableSelecionaTodosProdutos(string paramentro)
        {
            ProdutosDAO produtoDao = new ProdutosDAO();

            DataTable dt = new DataTable();

            dt = produtoDao.CriaDataTableSelecionaTodosProdutos(paramentro);

            return dt;
        }
    }
}
