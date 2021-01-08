using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using Negocios.DAO;
using System.Data;

namespace Negocios.BO
{
    public class ItemTipoRecebimentoVendaBO
    {
        public void Gravar(ItemTipoRecebimentoVenda itemTRV)
        {
            ItemTipoRecebimentoVendaDAO itemRecebimentoVendaDAO = new ItemTipoRecebimentoVendaDAO();
            itemRecebimentoVendaDAO.Gravar(itemTRV);
        }

        public DataTable CriaDataTableSelecionaItemVendaFormaRecebimenoto(int codigo)
        {
            ItemTipoRecebimentoVendaDAO itemRecebimentoVendaDAO = new ItemTipoRecebimentoVendaDAO();
            return itemRecebimentoVendaDAO.CriaDataTableSelecionaItemVendaFormaRecebimenoto(codigo);
        }

        public DataSet RetornaDataSetItemVendaFormaRecebimento(DateTime dataInicial, DateTime dataFinal)
        {
            ItemTipoRecebimentoVendaDAO itemRecebimentoVendaDAO = new ItemTipoRecebimentoVendaDAO();
            return itemRecebimentoVendaDAO.RetornaDataSetItemVendaFormaRecebimento(dataInicial, dataFinal);
        }
    }
}
