using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using System.Data;
using Negocios.DAO;
using System.Data.OleDb;

namespace Negocios.BO
{
    public class ContasReceberBO
    {
        ContasReceberDAO contaReceberDao;
         /// <summary>
        /// Método inseri uma nova conta receber
        /// </summary>
        /// <param name="contasReceber"></param>
        public void InserirContasReceber(ContasReceber contasReceber)
        {
            contaReceberDao = new ContasReceberDAO();
            contaReceberDao.InserirContasReceber(contasReceber);
        }
        public void AlterarSituacao(int contaReceberID)
        {
            contaReceberDao = new ContasReceberDAO();
            contaReceberDao.AlterarSituacao(contaReceberID);
        }

        public void ExcluirContaReceber(int contaReceberID)
        {
            contaReceberDao = new ContasReceberDAO();
            contaReceberDao.ExcluirContaReceber(contaReceberID);
        }

        public void ExcluirContaReceberNumeroVenda(int numeroVenda)
        {
            contaReceberDao = new ContasReceberDAO();
            contaReceberDao.ExcluirContaReceberNumeroVenda(numeroVenda);
        }

         /// <summary>
        /// Método retorna o ultimo registro inserido na tabela
        /// </summary>
        /// <returns></returns>
        public ContasReceber RetornaContaReceberID()
        {
            contaReceberDao = new ContasReceberDAO();
            return contaReceberDao.RetornaContaReceberID();
        }

        public ContasReceber RetornaContaReceberNumeroVenda(int numeroVenda)
        {
            contaReceberDao = new ContasReceberDAO();
            return contaReceberDao.RetornaContaReceberNumeroVenda(numeroVenda);
        }

        /// <summary>
        /// Método conta receber por id
        /// </summary>
        /// <returns></returns>
        public ContasReceber RetornaContaReceberID(int contaReceberID)
        {
            contaReceberDao = new ContasReceberDAO();
            return contaReceberDao.RetornaContaReceberID(contaReceberID);
        }

        public void AlterarSituacao(ContasReceber contasReceber)
        {
            contaReceberDao = new ContasReceberDAO();
            contaReceberDao.AlterarSituacao(contasReceber);
        }

        /// <summary>
        /// Cria um datatable
        /// </summary>
        /// <returns></returns>
        public DataTable CriaDataTableSelecionaContasReceber(string parametro)
        {
            contaReceberDao = new ContasReceberDAO();
            return contaReceberDao.CriaDataTableSelecionaContasReceber(parametro);
        }

        public DataTable CriaDataTableSelecionaContasReceberNumeroVenda(int numeroVenda)
        {
            contaReceberDao = new ContasReceberDAO();
            return contaReceberDao.CriaDataTableSelecionaContasReceberNumeroVenda(numeroVenda);
        }

        public OleDbDataAdapter ExibeTodasContasReceberDetalhada(string status, string cliente, DateTime dataInicial, DateTime dataFinal)
        {
            contaReceberDao = new ContasReceberDAO();
            return contaReceberDao.ExibeTodasContasReceberDetalhada(status, cliente,dataInicial,dataFinal);
        }
    }
}
