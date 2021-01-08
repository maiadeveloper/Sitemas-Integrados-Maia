using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using Negocios.DAO;
using System.Data;

namespace Negocios.BO
{
    public class ContaCorrenteBO
    {
        ContaCorrenteDAO contaCorrenteDAO;

        public void GravarContaCorrente(ContaCorrente contaCorrente)
        {
            contaCorrenteDAO = new ContaCorrenteDAO();
            contaCorrenteDAO.InserirContaCorrente(contaCorrente);
        }

        public void AlterarContaCorrente(ContaCorrente contaCorrente)
        {
            contaCorrenteDAO = new ContaCorrenteDAO();
            contaCorrenteDAO.AlterarContaCorrente(contaCorrente);
        }

        public void AtualizarSaldoDespesa(int contaID, string valor)
        {
            contaCorrenteDAO = new ContaCorrenteDAO();
            contaCorrenteDAO.AtualizarSaldoDespesa(contaID, valor);
        }

        public void AtualizarSaldoDespesaEstorno(int contaID, string valor)
        {
            contaCorrenteDAO = new ContaCorrenteDAO();
            contaCorrenteDAO.AtualizarSaldoDespesaEstorno(contaID, valor);
        }

        public void DeletarContaCorrente(int contaID)
        {
            contaCorrenteDAO = new ContaCorrenteDAO();
            contaCorrenteDAO.DeletarContaCorrente(contaID);
        }

        public ContaCorrente RetornaContaCorrenteID(int contaID)
        {
            contaCorrenteDAO = new ContaCorrenteDAO();
            return contaCorrenteDAO.SelecionarContaCorrenteID(contaID);
        }

        public ContaCorrente SelecionarContaCorrenteBancoID(int bancoID)
        {
            contaCorrenteDAO = new ContaCorrenteDAO();
            return contaCorrenteDAO.SelecionarContaCorrenteBancoID(bancoID);
        }

        public void AtualizarSaldoPositivo(int contaID, string valor)
        {
            contaCorrenteDAO = new ContaCorrenteDAO();
            contaCorrenteDAO.AtualizarSaldoPositivo(contaID, valor);
        }

        public IList<ContaCorrente> RetornaListaContaCorrente()
        {
            contaCorrenteDAO = new ContaCorrenteDAO();
            return contaCorrenteDAO.RetornaListaContaCorrentes();
        }

        public DataTable RetornaDataTableContaCorrente(string parametro)
        {
            contaCorrenteDAO = new ContaCorrenteDAO();
            return contaCorrenteDAO.CriaDataTableContaCorrentes(parametro);
        }
    }
}
