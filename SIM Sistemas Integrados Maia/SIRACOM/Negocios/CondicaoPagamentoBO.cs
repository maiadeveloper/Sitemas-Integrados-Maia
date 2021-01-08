using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.DAO;
using Negocios.Tipos;

namespace Negocios.BO
{
    public class CondicaoPagamentoBO
    {
        CondicaoPagamentoDAO condicaoPagamentoDao = new CondicaoPagamentoDAO();

        public CodicaoPagamento RecuperaNparcelaCondicaoPagamento(CodicaoPagamento condicaoPagamento)
        {
            if(condicaoPagamento._Iuo != null && condicaoPagamento._Iuo >0)
            {
                condicaoPagamentoDao.RecuperaNparcelaCodicaoPagamento(condicaoPagamento);
            }
            return condicaoPagamento;
        }
    }
}
