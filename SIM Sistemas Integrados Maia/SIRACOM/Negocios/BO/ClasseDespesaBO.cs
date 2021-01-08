using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using Negocios.DAO;
using System.Data;

namespace Negocios.BO
{
    public class ClasseDespesaBO
    {
        ClasseDespesaDAO classeDespesaDAO;

        public void GravarClasseDespesa(ClasseDespesa classeDespesa)
        {
            classeDespesaDAO = new ClasseDespesaDAO();
            classeDespesaDAO.InserirClasseDespesa(classeDespesa);
        }

        public void AlterarClasseDespesa(ClasseDespesa classeDespesa)
        {
            classeDespesaDAO = new ClasseDespesaDAO();
            classeDespesaDAO.AlterarClasseDespesa(classeDespesa);
        }

        public ClasseDespesa SelecionarClasseDespesaID(int classeDespesaID)
        {
            classeDespesaDAO = new ClasseDespesaDAO();
            return classeDespesaDAO.SelecionarClasseDespesaID(classeDespesaID);
        }

        public IList<ClasseDespesa> RetornaListaClasseDespesas()
        {
            classeDespesaDAO = new ClasseDespesaDAO();
            return classeDespesaDAO.RetornaListaClasseDespesas();
        }

        public DataTable CriaDataTableClasseDespesas(string parametro)
        {
            classeDespesaDAO = new ClasseDespesaDAO();
            return classeDespesaDAO.CriaDataTableClasseDepesas(parametro);
        }
    }
}
