using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using Negocios.DAO;
using System.Data;
using System.Data.OleDb;

namespace Negocios.BO
{
    public class ItemEntradaProdutoBO
    {
        ItemEntradaProdutoDAO itemEntradaProdutoDao;

        public void InserirItensEntradaProduto(ItemEntradaProduto itemEntradaProduto)
        {
            itemEntradaProdutoDao = new ItemEntradaProdutoDAO();
            itemEntradaProdutoDao.InserirItensEntradaProduto(itemEntradaProduto);
        }

        public ItemEntradaProduto SelecinaEntradaCodigoProduto(int cod)
        {
            itemEntradaProdutoDao = new ItemEntradaProdutoDAO();
            return itemEntradaProdutoDao.SelecinaEntradaCodigoProduto(cod);
        }

        public void ExcluirItensEntradaProduto(int entradaID)
        {
            itemEntradaProdutoDao = new ItemEntradaProdutoDAO();
            itemEntradaProdutoDao.ExcluirItensEntradaProduto(entradaID);
        }

        public OleDbDataAdapter ExibeProdutosPorDataVencimento(string parametro)
        {
            itemEntradaProdutoDao = new ItemEntradaProdutoDAO();
            return itemEntradaProdutoDao.ExibeProdutosPorDataVencimento(parametro);
        }

        public DataTable CriaDataTableSelecionaItensEntradaMercadoria(int entradaID)
        {
            itemEntradaProdutoDao = new ItemEntradaProdutoDAO();
            return itemEntradaProdutoDao.CriaDataTableSelecionaItensEntradaMercadoria(entradaID);
        }
    }
}
