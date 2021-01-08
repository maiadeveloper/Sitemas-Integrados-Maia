using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.RVTipo;
using System.Data.OleDb;
using System.Data;

namespace Negocios.RVDao
{
    public class RealizarVendasDAO
    {
        StringBuilder sbsql;
        ConexaoBanco conexaoBanco;

        /// <summary>
        /// Método grava dados referente ao cabecalho da venda
        /// </summary>
        public void GravarCabecalhoVenda(RealizarVendasTipos realizaVenda)
        {
            conexaoBanco = new ConexaoBanco();
            sbsql = new StringBuilder();

            sbsql.Append("INSERT INTO tblRealizarVenda(NumeroVenda,DataVenda,CodigoCliente,FormaPagamento,Descontos,TotalPagar)");
            sbsql.Append("VALUES('");
            sbsql.Append(realizaVenda._NumeroVenda + "','");
            sbsql.Append(realizaVenda._DataVenda + "','");
            sbsql.Append(realizaVenda._CodigoCliente + "','");
            sbsql.Append(realizaVenda._FormaPagamento + "','");
            sbsql.Append(realizaVenda._Descontos + "','");
            sbsql.Append(realizaVenda._TotalPagar + "')");

            conexaoBanco.manterCRUD(sbsql.ToString());
        }

        /// <summary>
        /// Metodo grava os itens de uma determinada venda
        /// </summary>
        /// <param name="realizaVenda"></param>
        public void GravaItensVenda(RealizarVendasTipos realizaVenda)
        {
            conexaoBanco = new ConexaoBanco();
            sbsql = new StringBuilder();

            sbsql.Append("INSERT INTO tblItemVenda(NumeroVenda,Item,CodigoProduto,Descricao,Qtde,PrecoUnitario,Subtotal)");
            sbsql.Append("VALUES('");
            sbsql.Append(realizaVenda._NumeroVenda + "','");
            sbsql.Append(realizaVenda._Item + "','");
            sbsql.Append(realizaVenda._Iuo + "','");
            sbsql.Append(realizaVenda._Descricao + "','");
            sbsql.Append(realizaVenda._Qtde + "','");
            sbsql.Append(realizaVenda._PrecoUnitario + "','");
            sbsql.Append(realizaVenda._SubTotal + "')");

            conexaoBanco.manterCRUD(sbsql.ToString());
        }

        /// <summary>
        /// Método retorna ultimo registro inserido na tabela realiza vendas
        /// </summary>
        /// <returns></returns>
        public RealizarVendasTipos RetornaNumeroVenda()
        {
            conexaoBanco = new ConexaoBanco();
            RealizarVendasTipos realizaVendas;
            sbsql = new StringBuilder();

            sbsql.Append("SELECT TOP 1 * FROM tblRealizarVenda ORDER BY NumeroVenda DESC");

            OleDbDataReader leitor = conexaoBanco.selectDR(sbsql.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();

                realizaVendas = new RealizarVendasTipos();

                realizaVendas._NumeroVenda = (int)leitor["NumeroVenda"];
            }
            else
            {
                realizaVendas = null;
            }
            return realizaVendas;
        }

        public void ExcluirVenda(int vendaID)
        {
            conexaoBanco = new ConexaoBanco();
            sbsql = new StringBuilder();

            sbsql.Append("DELETE FROM tblRealizarVenda WHERE NumeroVenda = " + vendaID);

            conexaoBanco.manterCRUD(sbsql.ToString());
        }


        public void ExcluirItemVenda(int vendaID)
        {
            conexaoBanco = new ConexaoBanco();
            sbsql = new StringBuilder();

            sbsql.Append("DELETE FROM tblItemVenda WHERE NumeroVenda = " + vendaID);
            conexaoBanco.manterCRUD(sbsql.ToString());
        }

        public RealizarVendasTipos RetornaNumeroVenda(int numeroVenda)
        {
            conexaoBanco = new ConexaoBanco();
            RealizarVendasTipos realizaVendas;
            sbsql = new StringBuilder();

            sbsql.Append("SELECT * FROM tblRealizarVenda WHERE NumeroVenda =" + numeroVenda);

            OleDbDataReader leitor = conexaoBanco.selectDR(sbsql.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();

                realizaVendas = new RealizarVendasTipos();

                realizaVendas._NumeroVenda = (int)leitor["NumeroVenda"];
                realizaVendas._DataVenda = (DateTime)leitor["DataVenda"];
                realizaVendas._CodigoCliente = (int)leitor["CodigoCliente"];
                realizaVendas._FormaPagamento = (string)leitor["FormaPagamento"];
                realizaVendas._TotalPagar = (decimal)leitor["TotalPagar"];
            }
            else
            {
                realizaVendas = null;
            }
            return realizaVendas;
        }

        public RealizarVendasTipos RetornaVendaClienteId(int clienteId)
        {
            conexaoBanco = new ConexaoBanco();
            RealizarVendasTipos realizaVendas;
            sbsql = new StringBuilder();

            sbsql.Append("SELECT * FROM tblRealizarVenda WHERE CodigoCliente =" + clienteId);

            OleDbDataReader leitor = conexaoBanco.selectDR(sbsql.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();

                realizaVendas = new RealizarVendasTipos();

                realizaVendas._NumeroVenda = (int)leitor["NumeroVenda"];
                realizaVendas._DataVenda = (DateTime)leitor["DataVenda"];
                realizaVendas._CodigoCliente = (int)leitor["CodigoCliente"];
                realizaVendas._FormaPagamento = (string)leitor["FormaPagamento"];
                realizaVendas._TotalPagar = (decimal)leitor["TotalPagar"];
            }
            else
            {
                realizaVendas = null;
            }
            return realizaVendas;
        }

        public DataTable RetornaDataTableVendaClienteId(int clienteId)
        {
            conexaoBanco = new ConexaoBanco();

            DataTable dt = new DataTable();

            sbsql = new StringBuilder();

            sbsql.Append("SELECT * FROM tblRealizarVenda WHERE CodigoCliente =" + clienteId);

            OleDbDataReader leitor = conexaoBanco.selectDR(sbsql.ToString());

            if (leitor != null)
            {
                dt.Load(leitor);
            }
            else
            {
                leitor = null;
            }

            return dt;
        }

        /// <summary>
        /// Método retorna numero de uma venda expecifica que foi realizada
        /// </summary>
        /// <param name="realizaVenda"></param>
        /// <returns></returns>
        public RealizarVendasTipos RetornaNumeroVenda(RealizarVendasTipos realizaVenda)
        {
            conexaoBanco = new ConexaoBanco();
            sbsql = new StringBuilder();

            sbsql.Append("SELECT * FROM tblRealizarVenda WHERE NumeroVenda = " + realizaVenda._NumeroVenda);

            OleDbDataReader leitor = conexaoBanco.selectDR(sbsql.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();

                realizaVenda = new RealizarVendasTipos();

                realizaVenda._NumeroVenda = (int)leitor["NumeroVenda"];
            }
            else
            {
                realizaVenda = null;
            }
            return realizaVenda;
        }

        public OleDbDataAdapter ExibeTodasVendas(int VendaID)
        {
            conexaoBanco = new ConexaoBanco();
            OleDbDataAdapter da;
            da = new OleDbDataAdapter("SELECT * FROM ViewVendasRealizadas WHERE NumeroVenda =" + VendaID, conexaoBanco.conectar());
            return da;
        }


        public OleDbDataAdapter ExibeItensVendasRealizadas(int vendaID)
        {
            conexaoBanco = new ConexaoBanco();
            OleDbDataAdapter da;
            da = new OleDbDataAdapter("SELECT * FROM tblItemVenda WHERE NumeroVenda =" + vendaID, conexaoBanco.conectar());
            return da;
        }

        public DataSet Vendas(DateTime dataInicial, DateTime dataFinal)
        {
            conexaoBanco = new ConexaoBanco();
            OleDbCommand cmd = new OleDbCommand("", conexaoBanco.conectar());
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataSet ds = new DataSet();

            cmd.CommandText = "SELECT * FROM tblRealizarVenda WHERE (DataVenda BETWEEN ? and ?) ORDER BY NumeroVenda ASC";

            cmd.Parameters.Add("DateIncial", OleDbType.Date);
            cmd.Parameters.Add("DateFinal", OleDbType.Date);

            cmd.Parameters["DateIncial"].Direction = ParameterDirection.Input;
            cmd.Parameters["DateFinal"].Direction = ParameterDirection.Input;

            cmd.Parameters["DateIncial"].Value = dataInicial.ToString("dd/MM/yyyy");
            cmd.Parameters["DateFinal"].Value = dataFinal.ToString("dd/MM/yyyy");

            da.SelectCommand = cmd;

            da.Fill(ds);

            return ds;
        }

        public DataTable CriaDataTableSelecionaTodasVendasRealizadas()
        {
            conexaoBanco = new ConexaoBanco();

            DataTable dt = new DataTable();

            sbsql = new StringBuilder();

            sbsql.Append(string.Format("SELECT * FROM ViewVendasRealizadas ORDER BY NumeroVenda DESC"));

            OleDbDataReader leitor = conexaoBanco.selectDR(sbsql.ToString());

            if (leitor != null)
            {
                dt.Load(leitor);
            }
            else
            {
                leitor = null;
            }

            return dt;
        }

        public DataTable CriaDataTableSelecionaItensVendaRealizada(int vendaID)
        {
            conexaoBanco = new ConexaoBanco();

            DataTable dt = new DataTable();

            sbsql = new StringBuilder();

            sbsql.Append(string.Format("SELECT * FROM tblItemVenda WHERE NumeroVenda = " + vendaID));

            OleDbDataReader leitor = conexaoBanco.selectDR(sbsql.ToString());

            if (leitor != null)
            {
                dt.Load(leitor);
            }
            else
            {
                leitor = null;
            }

            return dt;
        }
    }
}
