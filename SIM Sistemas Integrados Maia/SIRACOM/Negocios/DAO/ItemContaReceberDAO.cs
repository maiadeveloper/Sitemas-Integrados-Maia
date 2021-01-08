using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using Negocios.TIPO;

namespace Negocios.DAO
{
    public class ItemContaReceberDAO
    {
        StringBuilder sbsql;
        ConexaoBanco conexaoBanco;

        /// <summary>
        /// Método faz inserção das parcelas referente a conta a receber
        /// </summary>
        /// <param name="itemContaReceber"></param>
        public void InserirItemContaReceber(ItemContaReceber itemContaReceber)
        {
            conexaoBanco = new ConexaoBanco();
            sbsql = new StringBuilder();

            sbsql.Append("INSERT INTO tbItemConta_a_Receber(contaReceberID,numeroParcela,valorParcela,valorAberto,valorPago,valorMulta,valorJuros,valorCobrado,diasAtraso,dataVencimento,status)");
            sbsql.Append("VALUES('");
            sbsql.Append(itemContaReceber._ContaReceber._ContaReceberID + "','");
            sbsql.Append(itemContaReceber._NumeroParcela + "','");
            sbsql.Append(itemContaReceber._ValorParcela + "','");
            sbsql.Append(itemContaReceber.ValorAberto + "','");
            sbsql.Append(itemContaReceber._ValorPago + "','");
            sbsql.Append(itemContaReceber.ValorMulta + "','");
            sbsql.Append(itemContaReceber._Juros + "','");
            sbsql.Append(itemContaReceber.ValorCobrado + "','");
            sbsql.Append(itemContaReceber.DiasAtraso + "','");
            sbsql.Append(itemContaReceber._DataVencimento + "','");
            sbsql.Append(itemContaReceber._Status + "')");

            conexaoBanco.manterCRUD(sbsql.ToString());
        }

        public void EfetuarPagamentoContaReceberParcela(ItemContaReceber itemContaReceber)
        {
            conexaoBanco = new ConexaoBanco();
            sbsql = new StringBuilder();

            sbsql.Append("UPDATE tbItemConta_a_Receber SET ");
            sbsql.Append("valorJuros = '" + itemContaReceber._Juros + "',");
            sbsql.Append("dataPgto = '" + itemContaReceber._DataPagamento + "',");
            sbsql.Append("valorPago = '" + itemContaReceber._ValorPago + "',");
            sbsql.Append("valorAberto = '" + itemContaReceber.ValorAberto + "',");
            sbsql.Append("status = '" + itemContaReceber._Status + "' ");
            sbsql.Append("WHERE itemContaReceberID = " + itemContaReceber._ItemContaReceberID);

            conexaoBanco.manterCRUD(sbsql.ToString());
        }

        public void AlterarStatusNegociacao(int id, string situacao)
        {
            conexaoBanco = new ConexaoBanco();
            sbsql = new StringBuilder();

            sbsql.Append("UPDATE tbItemConta_a_Receber SET ");
            sbsql.Append("negociacao = '" + situacao);
            sbsql.Append("' WHERE itemContaReceberID = " + id);

            conexaoBanco.manterCRUD(sbsql.ToString());
        }


        public void AlterarVlrPago(ItemContaReceber itemContaReceber)
        {
            conexaoBanco = new ConexaoBanco();
            sbsql = new StringBuilder();

            sbsql.Append("UPDATE tbItemConta_a_Receber SET ");
            sbsql.Append("valorPago = '" + itemContaReceber._ValorPago + "' ");
            sbsql.Append("WHERE itemContaReceberID = " + itemContaReceber._ItemContaReceberID);

            conexaoBanco.manterCRUD(sbsql.ToString());
        }

        public void EstornarRecebimento(int itemContaReceberID, decimal vlrPago, decimal vlrAberto, string status)
        {
            conexaoBanco = new ConexaoBanco();
            sbsql = new StringBuilder();

            sbsql.Append("UPDATE tbItemConta_a_Receber SET ");

            sbsql.Append("valorPago = valorPago - " + vlrPago + ",");

            if (vlrAberto != 0)
            {
                sbsql.Append("valorAberto = valorAberto + valorPago,");
            }
            else
            {
                sbsql.Append("valorAberto = valorCobrado - " + vlrPago + ",");
            }

            sbsql.Append("status = '" + status + "'");
            sbsql.Append(" WHERE itemContaReceberID = " + itemContaReceberID);

            conexaoBanco.manterCRUD(sbsql.ToString());
        }

        public void AlterarStatusItemContaReceber(ItemContaReceber itemContaReceber)
        {
            conexaoBanco = new ConexaoBanco();
            sbsql = new StringBuilder();

            sbsql.Append("UPDATE tbItemConta_a_Receber SET ");
            sbsql.Append("valorMulta = '" + itemContaReceber.ValorMulta + "',");
            sbsql.Append("valorJuros = '" + itemContaReceber._Juros + "',");
            sbsql.Append("valorCobrado = '" + itemContaReceber.ValorCobrado + "',");
            sbsql.Append("diasAtraso = '" + itemContaReceber.DiasAtraso + "',");
            sbsql.Append("status = '" + itemContaReceber._Status + "' ");
            sbsql.Append("WHERE itemContaReceberID = " + itemContaReceber._ItemContaReceberID);

            conexaoBanco.manterCRUD(sbsql.ToString());
        }

        public void AlterarTotalCobradotemContaReceber(ItemContaReceber itemContaReceber)
        {
            conexaoBanco = new ConexaoBanco();
            sbsql = new StringBuilder();

            sbsql.Append("UPDATE tbItemConta_a_Receber SET ");
            sbsql.Append("valorCobrado = '" + itemContaReceber.ValorCobrado + "' ");
            sbsql.Append("WHERE itemContaReceberID = " + itemContaReceber._ItemContaReceberID);

            conexaoBanco.manterCRUD(sbsql.ToString());
        }

        public void AlterarTotalAberto(int codigo)
        {
            conexaoBanco = new ConexaoBanco();
            sbsql = new StringBuilder();

            sbsql.Append("UPDATE tbItemConta_a_Receber SET ");
            sbsql.Append("valorAberto = valorCobrado - valorPago ");
            sbsql.Append("WHERE itemContaReceberID = " + codigo);

            conexaoBanco.manterCRUD(sbsql.ToString());
        }

        public ItemContaReceber SelecionarItemContaReceberID(int itemContaReceberID)
        {
            conexaoBanco = new ConexaoBanco();
            sbsql = new StringBuilder();
            ItemContaReceber itemContaReceber = new ItemContaReceber();

            sbsql.Append("SELECT * FROM tbItemConta_a_Receber WHERE itemContaReceberID = " + itemContaReceberID);

            OleDbDataReader leitor = conexaoBanco.selectDR(sbsql.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();

                itemContaReceber._ContaReceber._ContaReceberID = (int)leitor["contaReceberID"];
                itemContaReceber._ItemContaReceberID = (int)leitor["itemContaReceberID"];
                itemContaReceber._NumeroParcela = (string)leitor["numeroParcela"];
                itemContaReceber._Status = (string)leitor["status"];
                itemContaReceber.DiasAtraso = leitor["diasAtraso"] != DBNull.Value ? (int)leitor["diasAtraso"] : int.Parse("0");
                itemContaReceber._DataPagamento = leitor["dataPgto"] != DBNull.Value ? (DateTime)leitor["dataPgto"] : Convert.ToDateTime(DateTime.MinValue);
                itemContaReceber._DataVencimento = leitor["dataVencimento"] != DBNull.Value ? (DateTime)leitor["dataVencimento"] : Convert.ToDateTime(DateTime.MinValue);
                itemContaReceber._ValorParcela = leitor["valorParcela"] != DBNull.Value ? (decimal)leitor["valorParcela"] : Convert.ToDecimal(0);
                itemContaReceber._ValorPago = leitor["valorPago"] != DBNull.Value ? (decimal)leitor["valorPago"] : Convert.ToDecimal(0);
                itemContaReceber.ValorAberto = leitor["valorAberto"] != DBNull.Value ? (decimal)leitor["valorAberto"] : Convert.ToDecimal(0);
                itemContaReceber._Juros = leitor["valorJuros"] != DBNull.Value ? (decimal)leitor["valorJuros"] : Convert.ToDecimal(0);
                itemContaReceber.ValorCobrado = leitor["valorCobrado"] != DBNull.Value ? (decimal)leitor["valorCobrado"] : Convert.ToDecimal(0);
                itemContaReceber.ValorMulta = leitor["valorMulta"] != DBNull.Value ? (decimal)leitor["valorMulta"] : Convert.ToDecimal(0);
            }
            else
            {
                itemContaReceber = null;
            }
            return itemContaReceber;
        }

        public ItemContaReceber SelecionarContaReceberID(int contaReceberID)
        {
            conexaoBanco = new ConexaoBanco();
            sbsql = new StringBuilder();
            ItemContaReceber itemContaReceber = new ItemContaReceber();

            sbsql.Append(string.Format("SELECT * FROM tbItemConta_a_Receber WHERE contaReceberID = {0} AND status <> 'Recebido'", contaReceberID));

            OleDbDataReader leitor = conexaoBanco.selectDR(sbsql.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();

                itemContaReceber._ContaReceber._ContaReceberID = (int)leitor["contaReceberID"];
                itemContaReceber._ItemContaReceberID = (int)leitor["itemContaReceberID"];
                itemContaReceber._NumeroParcela = (string)leitor["numeroParcela"];
                itemContaReceber.DiasAtraso = leitor["diasAtraso"] != DBNull.Value ? (int)leitor["diasAtraso"] : int.Parse("0");
                itemContaReceber._Status = (string)leitor["status"];
                itemContaReceber._DataPagamento = leitor["dataPgto"] != DBNull.Value ? (DateTime)leitor["dataPgto"] : Convert.ToDateTime(null);
                itemContaReceber._DataVencimento = leitor["dataVencimento"] != DBNull.Value ? (DateTime)leitor["dataVencimento"] : Convert.ToDateTime(null);
                itemContaReceber._ValorParcela = leitor["valorParcela"] != DBNull.Value ? (decimal)leitor["valorParcela"] : Convert.ToDecimal(null);
                itemContaReceber._ValorPago = leitor["valorPago"] != DBNull.Value ? (decimal)leitor["valorPago"] : Convert.ToDecimal(null);
                itemContaReceber._Juros = leitor["valorJuros"] != DBNull.Value ? (decimal)leitor["valorJuros"] : Convert.ToDecimal(null);
            }
            else
            {
                itemContaReceber = null;
            }
            return itemContaReceber;
        }

        /// <summary>
        /// Retorna um dataTable
        /// </summary>
        /// <returns></returns>
        public DataTable CriaDataTableSelecionaItemContasReceber(int codConta)
        {
            conexaoBanco = new ConexaoBanco();

            DataTable dt = new DataTable();

            sbsql = new StringBuilder();

            if (codConta != 0)
            {
                sbsql.Append(string.Format("SELECT * FROM ViewItensContasReceber WHERE contaReceberID = {0} AND status <> 'Recebido'", codConta));
            }
            else
            {
                sbsql.Append("SELECT * FROM ViewItensContasReceber WHERE status <> 'Recebido'");
            }

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

        public DataTable CriaDataTableSelecionarTodasItemContasReceber()
        {
            conexaoBanco = new ConexaoBanco();

            DataTable dt = new DataTable();

            sbsql = new StringBuilder();


            sbsql.Append("SELECT * FROM ViewItensContasReceber WHERE status <> 'Recebido'");

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

        public DataSet ItensContaRecebida(DateTime dataInicial, DateTime dataFinal)
        {
            conexaoBanco = new ConexaoBanco();
            OleDbCommand cmd = new OleDbCommand("", conexaoBanco.conectar());
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataSet ds = new DataSet();

            cmd.CommandText = "SELECT * FROM tbItemConta_a_Receber " +
                              "WHERE (dataPgto BETWEEN ? and ?) AND valorPago <> 0";

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

        public DataSet SelecionaListagemItensContaReceberDataSet(DateTime dataInicial, DateTime dataFinal, string cliente, string parametro)
        {
            conexaoBanco = new ConexaoBanco();
            OleDbCommand cmd = new OleDbCommand("", conexaoBanco.conectar());
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataSet ds = new DataSet();

            cmd.CommandText = "SELECT * FROM ViewItensContasReceber " +
                              "WHERE (" + parametro + ") AND NomeFantasia LIKE '%" + cliente + "%' AND dataVencimento BETWEEN ? AND ? ORDER BY dataVencimento ASC";

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

        public DataSet CriaDataSetItensContaRecebida(int? cod, DateTime dataInicial, DateTime dataFinal)
        {
            conexaoBanco = new ConexaoBanco();
            OleDbCommand cmd = new OleDbCommand("", conexaoBanco.conectar());
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataSet ds = new DataSet();

            if (cod != null)
            {
                cmd.CommandText = "SELECT * FROM ViewItensContasReceber WHERE (dataVencimento BETWEEN ? and ?) AND contaReceberID = " + cod + " AND status <> 'Recebido'";
            }
            else
            {
                cmd.CommandText = "SELECT * FROM ViewItensContasReceber WHERE (dataVencimento BETWEEN ? and ?) AND status <> 'Recebido'";
            }
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

        public void ExcluirItemContaReceber(string parametro, int id)
        {
            conexaoBanco = new ConexaoBanco();
            sbsql = new StringBuilder();

            sbsql.Append(string.Format("DELETE FROM tbItemConta_a_Receber WHERE {0} = {1}", parametro, id));

            conexaoBanco.manterCRUD(sbsql.ToString());
        }
    }
}
