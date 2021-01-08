using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using Negocios.DAO;
using System.Data;

namespace Negocios.BO
{
    public class EntradaProdutoBO
    {
        EntradaProdutoDAO entradaDao;

        public void InserirEntradaProduto(EntradaProduto entradaProduto)
        {
            entradaDao = new EntradaProdutoDAO();
            entradaDao.InserirEntradaProduto(entradaProduto);
        }

        public EntradaProduto SelecionaUltimoRegistroEntradaProduto()
        {
            entradaDao = new EntradaProdutoDAO();
            return entradaDao.SelecionaUltimoRegistroEntradaProduto();
        }

        public DataSet SelecionaEntradaMercadoirasDataSet(DateTime dataInicial, DateTime dataFinal, int codFornecedor)
        {
            entradaDao = new EntradaProdutoDAO();
            return entradaDao.SelecionaEntradaMercadoirasDataSet(dataInicial, dataFinal, codFornecedor);
        }

        public EntradaProduto SelecinaEntradaProdutoID(int entradaID)
        {
            entradaDao = new EntradaProdutoDAO();
            return entradaDao.SelecinaEntradaProdutoID(entradaID);
        }

        public EntradaProduto SelecinaEntradaCodigoFornecedor(int cod)
        {
            entradaDao = new EntradaProdutoDAO();
            return entradaDao.SelecinaEntradaCodigoFornecedor(cod);
        }

        public void ExcluirEntradaProduto(int entradaID)
        {
            entradaDao = new EntradaProdutoDAO();
            entradaDao.ExcluirEntradaProduto(entradaID);
        }
    }
}
