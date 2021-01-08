using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.manterContaBanco;
using Negocios.manterContaBancoDao;

namespace Negocios.manterContaBancoBo
{
    public class ManterContaBancoBO
    {
        ManterContaBancoDAO objManterContaDao;

        public ManterContaBanco BuscaContaBanco(ManterContaBanco objManterContaBanco)
        {
            objManterContaDao = new ManterContaBancoDAO();

            if (objManterContaBanco != null)
            {
                objManterContaBanco = objManterContaDao.SelecionaContaBanco(objManterContaBanco);
            }
            return objManterContaBanco;
        }
    }
}
