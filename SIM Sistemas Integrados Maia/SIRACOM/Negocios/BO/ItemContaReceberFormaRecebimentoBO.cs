using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using Negocios.DAO;
using System.Data;

namespace Negocios.BO
{
    public class ItemContaReceberFormaRecebimentoBO
    {
        public void Gravar(ItemContaReceberFormaRecebimento itemRCFR)
        {
            ItemContaReceberFormaRecebimentoDAO itemContaRFRDAO = new ItemContaReceberFormaRecebimentoDAO();
            itemContaRFRDAO.Gravar(itemRCFR);
        }
        public DataTable CriaDataTableSelecionaItemContasReceberFormaRecebimenoto(int codigo)
        {
            ItemContaReceberFormaRecebimentoDAO itemContaRFRDAO = new ItemContaReceberFormaRecebimentoDAO();
            return itemContaRFRDAO.CriaDataTableSelecionaItemContasReceberFormaRecebimenoto(codigo);
        }

        public void ExcluirItemFormaRecebimentoContaReceber(int itemContarReceberID)
        {
            ItemContaReceberFormaRecebimentoDAO itemContaRFRDAO = new ItemContaReceberFormaRecebimentoDAO();
            itemContaRFRDAO.ExcluirItemFormaRecebimentoContaReceber(itemContarReceberID);
        }

        public void ExcluirItemFormaRecebimentoContaReceberId(int itemContarReceberFRID)
        {
            ItemContaReceberFormaRecebimentoDAO itemContaRFRDAO = new ItemContaReceberFormaRecebimentoDAO();
            itemContaRFRDAO.ExcluirItemFormaRecebimentoContaReceberId(itemContarReceberFRID);
        }

        public ItemContaReceberFormaRecebimento SelecionarItemFormaRecebimentoId(int itemContarReceberID)
        {
            ItemContaReceberFormaRecebimentoDAO itemContaRFRDAO = new ItemContaReceberFormaRecebimentoDAO();
            return itemContaRFRDAO.SelecionarItemFormaRecebimentoId(itemContarReceberID);
        }

        public DataSet RetornaDataSetContaReceberFormaRecebimento(DateTime dataInicial, DateTime dataFinal)
        {
            ItemContaReceberFormaRecebimentoDAO itemContaRFRDAO = new ItemContaReceberFormaRecebimentoDAO();
            return itemContaRFRDAO.RetornaDataSetContaReceberFormaRecebimento(dataInicial, dataFinal);
        }
    }
}
