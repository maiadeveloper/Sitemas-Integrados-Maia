using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using Negocios.DAO;
using System.Data;

namespace Negocios.BO
{
    public class TipoDespesaBO
    {
        TipoDespesaDAO tipoDespesaDAO;

        public void GravarTipoDespesa(TipoDespesa tipoDespesa)
        {
            tipoDespesaDAO = new TipoDespesaDAO();
            tipoDespesaDAO.InserirTipoDespesa(tipoDespesa);
        }

        public void AlteraTipoDespesa(TipoDespesa tipoDespesa)
        {
            tipoDespesaDAO = new TipoDespesaDAO();
            tipoDespesaDAO.AlterarTipoDespesa(tipoDespesa);
        }

        public TipoDespesa SelecionaTipoDespesaID(int tipoDespesaID)
        {
            tipoDespesaDAO = new TipoDespesaDAO();
            return tipoDespesaDAO.SelecionarTipoDespesaID(tipoDespesaID);
        }

        public DataTable CriaDataTableTipoDespesa(string parametro)
        {
            tipoDespesaDAO = new TipoDespesaDAO();
            return tipoDespesaDAO.CriaDataTableTipoDespesas(parametro);
        }

        public DataTable CriaDataTableTipoDespesas(int classeDespesaID)
        {
            tipoDespesaDAO = new TipoDespesaDAO();
            return tipoDespesaDAO.CriaDataTableTipoDespesas(classeDespesaID);
        }
    }
}
