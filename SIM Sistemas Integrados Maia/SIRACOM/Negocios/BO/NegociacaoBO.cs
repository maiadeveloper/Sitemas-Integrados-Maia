using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using Negocios.DAO;
using System.Data;

namespace Negocios.BO
{
    public class NegociacaoBO
    {
        public void InserirNegociacao(Negociacao negociacao)
        {
            NegociacaoDAO negociacaoDAO;

            if (negociacao != null)
            {
                negociacaoDAO = new NegociacaoDAO();
                negociacaoDAO.InserirNegociacao(negociacao);
            }
        }

        public DataTable ListaNegociacoes(string parametro, string situacao)
        {
            NegociacaoDAO negociacaoDAO = new NegociacaoDAO();
            return negociacaoDAO.ListaNegociacoes(parametro, situacao);
        }

        public void AlterarSituacao(int cod)
        {
            NegociacaoDAO negociacaoDAO;

            if (cod > 0)
            {
                negociacaoDAO = new NegociacaoDAO();
                negociacaoDAO.AlterarSituacao(cod);
            }
        }

        public Negociacao SelecionaNegociacaoId(int id)
        {
            NegociacaoDAO negociacaoDAO;

            negociacaoDAO = new NegociacaoDAO();
            return negociacaoDAO.SelecionaNegociacaoId(id);
        }
    }
}
