using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Negocios.TIPO;
using Negocios.DAO;

namespace Negocios.BO
{
    public class LancamentosBaixasBO
    {

        LancamentosBaixasDAO lancamentoBaixasDAO;

        public void InserirLancamentoBaixa(LancamentosBaixas lancamentosBaixas)
        {
            lancamentoBaixasDAO = new LancamentosBaixasDAO();
            lancamentoBaixasDAO.InserirLancamentoBaixa(lancamentosBaixas);
        }

        public LancamentosBaixas SelecionarLancamentoBaixaID(int lancamentoID)
        {
            lancamentoBaixasDAO = new LancamentosBaixasDAO();
            return lancamentoBaixasDAO.SelecionarLancamentoBaixaID(lancamentoID);
        }

        public DataTable CriaDataTableLancamentosBaixas(int lancamentoID)
        {
            lancamentoBaixasDAO = new LancamentosBaixasDAO();
            return lancamentoBaixasDAO.CriaDataTableLancamentosBaixas(lancamentoID);
        }

        public void DeletarLancamentoBaixa(int lancamentoBaixaID)
        {
            lancamentoBaixasDAO = new LancamentosBaixasDAO();
            lancamentoBaixasDAO.DeletarLancamentoBaixa(lancamentoBaixaID);
        }

        public DataSet LancamentosBaixaTodos(DateTime dataInicial, DateTime dataFinal)
        {
            lancamentoBaixasDAO = new LancamentosBaixasDAO();
            return lancamentoBaixasDAO.LancamentosBaixaTodos(dataInicial, dataFinal);
        }
    }
}
