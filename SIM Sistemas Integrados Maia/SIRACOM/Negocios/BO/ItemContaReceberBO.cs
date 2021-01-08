using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using Negocios.DAO;
using System.Data;

namespace Negocios.BO
{
    public class ItemContaReceberBO
    {
        ItemContaReceberDAO itemContaReceberDao;

        /// <summary>
        /// Método faz inserção das parcelas referente a conta a receber
        /// </summary>
        /// <param name="itemContaReceber"></param>
        public void InserirItemContaReceber(ItemContaReceber itemContaReceber)
        {
            itemContaReceberDao = new ItemContaReceberDAO();
            itemContaReceberDao.InserirItemContaReceber(itemContaReceber);
        }

        public void EstornarRecebimento(int itemContaReceberID, decimal vlrPago, decimal vlrAberto, string status)
        {
            itemContaReceberDao = new ItemContaReceberDAO();
            itemContaReceberDao.EstornarRecebimento(itemContaReceberID, vlrPago, vlrAberto, status);
        }

        public void AlterarStatusNegociacao(int id, string situacao)
        {
            itemContaReceberDao = new ItemContaReceberDAO();
            itemContaReceberDao.AlterarStatusNegociacao(id, situacao);
        }

        public void ExcluirItemContaReceber(string parametro, int id)
        {
            itemContaReceberDao = new ItemContaReceberDAO();
            itemContaReceberDao.ExcluirItemContaReceber(parametro, id);
        }

        /// <summary>
        /// Cria um datatable
        /// </summary>
        /// <returns></returns>
        public DataTable CriaDataTableSelecionaItemContasReceber(int codConta)
        {
            itemContaReceberDao = new ItemContaReceberDAO();
            return itemContaReceberDao.CriaDataTableSelecionaItemContasReceber(codConta);
        }

        public DataSet CriaDataSetItensContaRecebida(int? cod, DateTime dataInicial, DateTime dataFinal)
        {
            itemContaReceberDao = new ItemContaReceberDAO();
            return itemContaReceberDao.CriaDataSetItensContaRecebida(cod, dataInicial, dataFinal);
        }

        public DataSet ItensContaRecebida(DateTime dataInicial, DateTime dataFinal)
        {
            itemContaReceberDao = new ItemContaReceberDAO();
            return itemContaReceberDao.ItensContaRecebida(dataInicial, dataFinal);
        }

        public DataSet SelecionaListagemItensContaReceberDataSet(DateTime dataInicial, DateTime dataFinal, string cliente, string query)
        {
            itemContaReceberDao = new ItemContaReceberDAO();
            return itemContaReceberDao.SelecionaListagemItensContaReceberDataSet(dataInicial, dataFinal, cliente, query);
        }

        public ItemContaReceber SelecionarItemContaReceberID(int itemContaReceberID)
        {
            itemContaReceberDao = new ItemContaReceberDAO();
            return itemContaReceberDao.SelecionarItemContaReceberID(itemContaReceberID);
        }

        public ItemContaReceber SelecionarContaReceberID(int contaReceberID)
        {
            itemContaReceberDao = new ItemContaReceberDAO();
            return itemContaReceberDao.SelecionarContaReceberID(contaReceberID);
        }

        public void EfetuarPagamentoContaReceberParcela(ItemContaReceber itemContaReceber)
        {
            itemContaReceberDao = new ItemContaReceberDAO();
            itemContaReceberDao.EfetuarPagamentoContaReceberParcela(itemContaReceber);
        }

        public void AlterarVlrPago(ItemContaReceber itemContaReceber)
        {
            itemContaReceberDao = new ItemContaReceberDAO();
            itemContaReceberDao.AlterarVlrPago(itemContaReceber);
        }

        public void AlterarStatusItemContaReceber(ItemContaReceber itemContaReceber)
        {
            itemContaReceberDao = new ItemContaReceberDAO();
            itemContaReceberDao.AlterarStatusItemContaReceber(itemContaReceber);
        }

        public void AlterarTotalCobradotemContaReceber(ItemContaReceber itemContaReceber)
        {
            itemContaReceberDao = new ItemContaReceberDAO();
            itemContaReceberDao.AlterarTotalCobradotemContaReceber(itemContaReceber);
        }

        public void AlterarTotalAberto(int codigo)
        {
            itemContaReceberDao = new ItemContaReceberDAO();
            itemContaReceberDao.AlterarTotalAberto(codigo);
        }

        public DataTable CriaDataTableSelecionarTodasItemContasReceber()
        {
            itemContaReceberDao = new ItemContaReceberDAO();
            return itemContaReceberDao.CriaDataTableSelecionarTodasItemContasReceber();
        }
    }
}
