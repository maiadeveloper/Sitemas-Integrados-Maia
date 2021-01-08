using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using System.Data;
using Negocios.DAO;
using System.Data.OleDb;

namespace Negocios.BO
{
    public class DespesasBO
    {
        DespesasDAO despesasDAO;

        public void InserirDespesa(Despesas despesas)
        {
            despesasDAO = new DespesasDAO();
            despesasDAO.InserirDespesa(despesas);
        }

        public DataTable CriaDataTableDespesas()
        {
            despesasDAO = new DespesasDAO();
            return despesasDAO.CriaDataTableDespesas();
        }

        public DataSet TodasDespesas(DateTime dataInicial, DateTime dataFinal)
        {
            despesasDAO = new DespesasDAO();
            return despesasDAO.TodasDespesas(dataInicial, dataFinal);
        }
    }
}
