using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.DAO;
using Negocios.TIPO;
using System.Data.OleDb;

namespace Negocios.BO
{
    public class ItensOrcamentoBO
    {
        ItensOrcamentoDAO itensOrcamentoDAO;

        public void Gravar(ItensOrcamento itensOrcamento)
        {
            itensOrcamentoDAO = new ItensOrcamentoDAO();
            itensOrcamentoDAO.Gravar(itensOrcamento);
        }

        public OleDbDataAdapter SelecionaOrcamentoPorID(int orcamentoID)
        {
            itensOrcamentoDAO = new ItensOrcamentoDAO();
            OleDbDataAdapter da = itensOrcamentoDAO.SelecionaOrcamentoPorID(orcamentoID);
            return da;
        }
    }
}
