using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.RVTipo;
using Negocios.RVDao;
using Negocios;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;

namespace Negocios.RVBo
{
    public class RealizarVendasBO
    {
        RealizarVendasDAO realizaVendasDao;

        /// <summary>
        /// Método chama método grava dados referente ao cabecalho da venda
        /// </summary>
        public void GravarCabecalhoVenda(RealizarVendasTipos realizaVenda)
        {
            realizaVendasDao = new RealizarVendasDAO();

            realizaVendasDao.GravarCabecalhoVenda(realizaVenda);
        }

        public void ExcluirVenda(int vendaID)
        {
            realizaVendasDao = new RealizarVendasDAO();
            realizaVendasDao.ExcluirVenda(vendaID);
        }

        public void ExcluirItemVenda(int vendaID)
        {
            realizaVendasDao = new RealizarVendasDAO();
            realizaVendasDao.ExcluirItemVenda(vendaID);
        }

        public DataTable CriaDataTableSelecionaTodasVendasRealizadas()
        {
            realizaVendasDao = new RealizarVendasDAO();
            return realizaVendasDao.CriaDataTableSelecionaTodasVendasRealizadas();
        }

        public DataTable CriaDataTableSelecionaItensVendaRealizada(int vendaID)
        {
            realizaVendasDao = new RealizarVendasDAO();
            return realizaVendasDao.CriaDataTableSelecionaItensVendaRealizada(vendaID);
        }

        /// <summary>
        /// Metodo grava os itens de uma determinada venda
        /// </summary>
        /// <param name="realizaVenda"></param>
        public void GravaItensVenda(RealizarVendasTipos realizaVenda)
        {
            realizaVendasDao = new RealizarVendasDAO();
            realizaVendasDao.GravaItensVenda(realizaVenda);
        }

        /// <summary>
        /// Método chama o método responsavel por retorna numero da venda
        /// </summary>
        /// <returns></returns>
        public RealizarVendasTipos RetornaNumerVenda()
        {
            realizaVendasDao = new RealizarVendasDAO();
            return realizaVendasDao.RetornaNumeroVenda();
        }

        /// <summary>
        /// Método retorna numero de uma venda expecifica que foi realizada
        /// </summary>
        /// <param name="realizaVenda"></param>
        /// <returns></returns>
        public RealizarVendasTipos RetornaNumeroVenda(RealizarVendasTipos realizaVenda)
        {
            realizaVendasDao = new RealizarVendasDAO();
            return realizaVendasDao.RetornaNumeroVenda(realizaVenda);
        }

        public RealizarVendasTipos RetornaNumeroVenda(int numeroVenda)
        {
            realizaVendasDao = new RealizarVendasDAO();
            return realizaVendasDao.RetornaNumeroVenda(numeroVenda);
        }

        public RealizarVendasTipos RetornaVendaClienteId(int clienteId)
        {
            realizaVendasDao = new RealizarVendasDAO();
            return realizaVendasDao.RetornaVendaClienteId(clienteId);
        }
        public DataTable RetornaDataTableVendaClienteId(int clienteId)
        {
            realizaVendasDao = new RealizarVendasDAO();
            return realizaVendasDao.RetornaDataTableVendaClienteId(clienteId);
        }


        public OleDbDataAdapter ExibeTodasVendas(int vendaID)
        {
            realizaVendasDao = new RealizarVendasDAO();
            OleDbDataAdapter da = realizaVendasDao.ExibeTodasVendas(vendaID);
            return da;
        }

        public OleDbDataAdapter ExibeItensVendasRealizadas(int vendaID)
        {
            realizaVendasDao = new RealizarVendasDAO();
            return realizaVendasDao.ExibeItensVendasRealizadas(vendaID);
        }

        public DataSet Vendas(DateTime dataInicial, DateTime dataFinal)
        {
            realizaVendasDao = new RealizarVendasDAO();

            DataSet ds = new DataSet();

            ds = realizaVendasDao.Vendas( dataInicial, dataFinal);

            return ds;
        }
    }
}
