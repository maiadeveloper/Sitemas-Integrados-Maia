using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.DAO;
using Negocios.TIPO;
using System.Data;

namespace Negocios.BO
{
    public class CaixaBO
    {
        CaixaDAO caixaDAO;

        public DataSet CriaDataSetCaixaPeriodos(DateTime dataInicial, DateTime dataFinal)
        {
            caixaDAO = new CaixaDAO();
            return caixaDAO.CriaDataSetCaixaPeriodos(dataInicial, dataFinal);
        }

        public Caixa SelecionaCaixaDia(int caixaID)
        {
            caixaDAO = new CaixaDAO();
            return caixaDAO.SelecionaCaixaDia(caixaID);
        }

        public void ReabrirCaixa(Caixa caixa)
        {
            caixaDAO = new CaixaDAO();
            caixaDAO.ReabrirCaixa(caixa);
        }

        public Caixa SelecionaUltimoCaixa()
        {
            caixaDAO = new CaixaDAO();
            return caixaDAO.SelecionaUltimoCaixa();
        }

        public DataSet SelecionaCaixaDiaDataSet(DateTime dataAbertura)
        {
            caixaDAO = new CaixaDAO();
            return caixaDAO.SelecionaCaixaDiaDataSet(dataAbertura);
        }

        public DataSet SelecionaCaixaPeriodo(DateTime dataInicial, DateTime dataFinal)
        {
            caixaDAO = new CaixaDAO();
            return caixaDAO.SelecionaCaixaPeriodo(dataInicial,dataFinal);
        }

        public void AbrirCaixa(Caixa caixa)
        {
            caixaDAO = new CaixaDAO();
            caixaDAO.AbrirCaixa(caixa);
        }

        public void FecharCaixa(Caixa caixa)
        {
            caixaDAO = new CaixaDAO();
            caixaDAO.FecharCaixa(caixa);
        }
    }
}
