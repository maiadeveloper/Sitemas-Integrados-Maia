using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.DAO;
using Negocios.TIPO;

namespace Negocios.BO
{
    public class BancoBO
    {
        BancoDAO bancoDAO;

        public Banco SelecionaBancoCaixaEmpresa()
        {
            bancoDAO = new BancoDAO();
            return bancoDAO.SelecionaBancoCaixaEmpresa();
        }
    }
}
