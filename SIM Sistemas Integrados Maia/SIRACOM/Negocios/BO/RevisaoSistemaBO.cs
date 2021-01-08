using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using Negocios.DAO;

namespace Negocios.BO
{
    public class RevisaoSistemaBO
    {
        RevisaoSistemaDAO revisaoSistemaDao = new RevisaoSistemaDAO();

        public void Inserir(RevisaoSistema revisaoSistema)
        {
            revisaoSistemaDao.Inserir(revisaoSistema);
        }
    }
}
