using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Negocios.TIPO;
using Negocios.DAO;

namespace Negocios.BO
{
    public class LancamentosBO
    {
        LancamentosDAO lancamentosDAO;

        public void InserirLancamento(Lancamentos lancamentos)
        {
            lancamentosDAO = new LancamentosDAO();
            lancamentosDAO.InserirLancamento(lancamentos);
        }

        public Lancamentos SelecionarLancamentoCodFornecedor(int cod)
        {
            lancamentosDAO = new LancamentosDAO();
            return lancamentosDAO.SelecionarLancamentoCodFornecedor(cod);
        }

        public Lancamentos SelecionarLancamentoID(int lancamentoID)
        {
            lancamentosDAO = new LancamentosDAO();
            return lancamentosDAO.SelecionarLancamentoID(lancamentoID);
        }

        public DataTable CriaDataTableSelecionaTodosLancamentos()
        {
            lancamentosDAO = new LancamentosDAO();
            return lancamentosDAO.CriaDataTableSelecionaTodosLancamentos();
        }

        public DataSet LancamentosTodos(DateTime dataInicial, DateTime dataFinal,string campo,string situacao)
        {
            lancamentosDAO = new LancamentosDAO();
            return lancamentosDAO.LancamentosTodos(dataInicial, dataFinal, campo,situacao);
        }

        public void AlterarLancamentoBaixar(Lancamentos lancamentos)
        {
            lancamentosDAO = new LancamentosDAO();
            lancamentosDAO.AlterarLancamentoBaixar(lancamentos);
        }
    }
}
