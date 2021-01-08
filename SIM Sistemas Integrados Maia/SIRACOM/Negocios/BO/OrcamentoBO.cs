using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.DAO;
using Negocios.TIPO;
using System.Data;

namespace Negocios.BO
{
    public class OrcamentoBO
    {
        OrcamentoDAO orcamentoDAO = new OrcamentoDAO();

         public void Gravar(Orcamento orcamento)
        {
            orcamentoDAO.Gravar(orcamento);
        }

         public Orcamento SelecionarUltimoOrcamento()
         {
             return orcamentoDAO.SelecionarUltimoOrcamento();
         }

         public Orcamento SelecionarOrcamentoID(int orcamentoID)
         {
             return orcamentoDAO.SelecionarOrcamentoID(orcamentoID);
         }

         public DataSet SelecionaOrcamentos(DateTime dataInicial, DateTime dataFinal)
         {
             DataSet ds = new DataSet();

             ds = orcamentoDAO.SelecionaOrcamentos(dataInicial, dataFinal);

             return ds;
         }

         public DataTable CriaDataTableSelecionaItensOrcamentos(int orcamentoID)
         {
             return orcamentoDAO.CriaDataTableSelecionaItensOrcamentos(orcamentoID);
         }
    }
}
