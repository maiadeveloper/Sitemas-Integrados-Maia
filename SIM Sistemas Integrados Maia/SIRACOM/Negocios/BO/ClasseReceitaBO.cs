using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.classeReceita;
using Negocios.classeReceitaDao;
using System.Windows.Forms;

namespace Negocios.classeReceitaBo
{
    public class ClasseReceitaBO
    {
        ClasseReceitaDAO objClasseReceitaDao;

        public void InsertClasseBo(ClasseReceita objClasseReceita)
        {
            objClasseReceitaDao = new ClasseReceitaDAO();

            objClasseReceitaDao.InserirDados(objClasseReceita);

            MessageBox.Show("Classe gravada com sucesso", "Gravação OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public ClasseReceita BuscaClasseBo(ClasseReceita objClasseReceita)
        {
            objClasseReceitaDao = new ClasseReceitaDAO();

            return objClasseReceitaDao.BuscaClasse(objClasseReceita);
        }
    }
}
