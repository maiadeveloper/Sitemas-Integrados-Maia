using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using Negocios.TIPO;
using Negocios;

namespace Negocios.DAO
{
    public class ContasReceberDAO
    {
        StringBuilder sbsql;
        ConexaoBanco conexaoBanco;
        ContasReceber contasReceber;

        /// <summary>
        /// Método inseri uma nova conta receber
        /// </summary>
        /// <param name="contasReceber"></param>
        public void InserirContasReceber(ContasReceber contasReceber)
        {
            conexaoBanco = new ConexaoBanco();
            sbsql = new StringBuilder();

            sbsql.Append("INSERT INTO tblConta_a_Receber(dataEntrada,numeroVenda,valor_total,situacao)");
            sbsql.Append("VALUES('");
            sbsql.Append(contasReceber._DataEntrada + "','");
            sbsql.Append(contasReceber._RealizarVenda._NumeroVenda + "','");
            sbsql.Append(contasReceber._Valor_total + "','");
            sbsql.Append("Aberto')");
            conexaoBanco.manterCRUD(sbsql.ToString());
        }


        public void AlterarSituacao(ContasReceber contasReceber)
        {
            conexaoBanco = new ConexaoBanco();
            sbsql = new StringBuilder();

            sbsql.Append("UPDATE tblConta_a_Receber SET situacao = 'Fechado' WHERE contaReceberID = " + contasReceber._ContaReceberID);

            conexaoBanco.manterCRUD(sbsql.ToString());
        }

        public void AlterarSituacao(int contaReceberID)
        {
            conexaoBanco = new ConexaoBanco();
            sbsql = new StringBuilder();

            sbsql.Append("UPDATE tblConta_a_Receber SET situacao = 'Aberto' WHERE contaReceberID = " + contaReceberID);

            conexaoBanco.manterCRUD(sbsql.ToString());
        }

        /// <summary>
        /// Método retorna o ultimo registro inserido na tabela
        /// </summary>
        /// <returns></returns>
        public ContasReceber RetornaContaReceberID()
        {
            conexaoBanco = new ConexaoBanco();

            sbsql = new StringBuilder();

            sbsql.Append("SELECT TOP 1 * FROM tblConta_a_Receber ORDER BY contaReceberID DESC");

            OleDbDataReader leitor = conexaoBanco.selectDR(sbsql.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();

                contasReceber = new ContasReceber();

                contasReceber._ContaReceberID = (int)leitor["contaReceberID"];
            }
            else
            {
                contasReceber = null;
            }
            return contasReceber;
        }

        /// <summary>
        /// Conta receber por id
        /// </summary>
        /// <param name="contaReceberID"></param>
        /// <returns></returns>
        public ContasReceber RetornaContaReceberID(int contaReceberID)
        {
            conexaoBanco = new ConexaoBanco();

            sbsql = new StringBuilder();

            sbsql.Append("SELECT * FROM tblConta_a_Receber WHERE contaReceberID = " + contaReceberID);

            OleDbDataReader leitor = conexaoBanco.selectDR(sbsql.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();

                contasReceber = new ContasReceber();

                contasReceber._ContaReceberID = (int)leitor["contaReceberID"];
                contasReceber._DataEntrada = (DateTime)leitor["dataEntrada"];
                contasReceber._NumeroVenda = (int)leitor["numeroVenda"];
                contasReceber._Valor_total = (decimal)leitor["valor_total"];
            }
            else
            {
                contasReceber = null;
            }
            return contasReceber;
        }

        /// <summary>
        /// Retorna um dataTable
        /// </summary>
        /// <returns></returns>
        public DataTable CriaDataTableSelecionaContasReceber(string parametro)
        {
            conexaoBanco = new ConexaoBanco();

            DataTable dt = new DataTable();

            sbsql = new StringBuilder();

            if (!string.IsNullOrEmpty(parametro))
            {
                sbsql.Append("SELECT * FROM ViewContasReceber WHERE NomeFantasia LIKE '%" + parametro + "%' AND situacao = 'Aberto'");
                sbsql.Append(" OR RazaoSobreNome LIKE '%" + parametro + "%' AND situacao = 'Aberto'");
                sbsql.Append(" OR CpfCnpj LIKE '%" + parametro + "%' AND situacao = 'Aberto'");
                sbsql.Append(" OR Telefone01 LIKE '%" + parametro + "%' AND situacao = 'Aberto'");
                sbsql.Append(" OR Telefone02 LIKE '%" + parametro + "%' AND situacao = 'Aberto'");
            }
            else
            {
                sbsql.Append("SELECT * FROM ViewContasReceber WHERE situacao = 'Aberto'");
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

        public OleDbDataAdapter ExibeTodasContasReceberDetalhada(string status, string cliente, DateTime dataInicial, DateTime dataFinal)
        {
            conexaoBanco = new ConexaoBanco();
            OleDbCommand cmd = new OleDbCommand("", conexaoBanco.conectar());
            OleDbDataAdapter da = new OleDbDataAdapter();
            StringBuilder sb = new StringBuilder();

            sb.Append("SELECT * FROM ViewContasReceberDetalhada WHERE status LIKE '%" + status + "%' AND NomeFantasia LIKE '%" + cliente + "%' ");
            sb.Append("AND dataVencimento BETWEEN ? AND ? ORDER BY dataVencimento ASC");

            cmd.CommandText = sb.ToString();

            cmd.Parameters.Add("DateIncial", OleDbType.Date);
            cmd.Parameters.Add("DateFinal", OleDbType.Date);

            cmd.Parameters["DateIncial"].Direction = ParameterDirection.Input;
            cmd.Parameters["DateFinal"].Direction = ParameterDirection.Input;

            cmd.Parameters["DateIncial"].Value = dataInicial.ToString("dd/MM/yyyy");
            cmd.Parameters["DateFinal"].Value = dataFinal.ToString("dd/MM/yyyy");

            da.SelectCommand = cmd;

            return da;
        }

        public OleDbDataAdapter CarregaRelatorioGraficoFinanceiro()
        {
            conexaoBanco = new ConexaoBanco();
            OleDbDataAdapter da;
            da = new OleDbDataAdapter("SELECT * FROM ViewContasReceberDetalhada",conexaoBanco.conectar());
            return da;
        }

        public void ExcluirContaReceber(int contaReceberID)
        {
            conexaoBanco = new ConexaoBanco();
            sbsql = new StringBuilder();

            sbsql.Append("DELETE FROM tblConta_a_Receber WHERE contaReceberID =" + contaReceberID);

            conexaoBanco.manterCRUD(sbsql.ToString());
        }

        public void ExcluirContaReceberNumeroVenda(int numeroVenda)
        {
            conexaoBanco = new ConexaoBanco();
            sbsql = new StringBuilder();

            sbsql.Append("DELETE FROM tblConta_a_Receber WHERE numeroVenda =" + numeroVenda);

            conexaoBanco.manterCRUD(sbsql.ToString());
        }

        public ContasReceber RetornaContaReceberNumeroVenda(int numeroVenda)
        {
            conexaoBanco = new ConexaoBanco();

            sbsql = new StringBuilder();

            sbsql.Append("SELECT * FROM tblConta_a_Receber WHERE numeroVenda = " + numeroVenda);

            OleDbDataReader leitor = conexaoBanco.selectDR(sbsql.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();

                contasReceber = new ContasReceber();

                contasReceber._ContaReceberID = (int)leitor["contaReceberID"];
                contasReceber._DataEntrada = (DateTime)leitor["dataEntrada"];
                contasReceber._NumeroVenda = (int)leitor["numeroVenda"];
                contasReceber._Valor_total = (decimal)leitor["valor_total"];
                contasReceber._Situacao = (string)leitor["situacao"];
            }
            else
            {
                contasReceber = null;
            }
            return contasReceber;
        }

        public DataTable CriaDataTableSelecionaContasReceberNumeroVenda(int numeroVenda)
        {
            conexaoBanco = new ConexaoBanco();

            DataTable dt = new DataTable();

            sbsql = new StringBuilder();

            sbsql.Append("SELECT * FROM tblConta_a_Receber WHERE numeroVenda = " + numeroVenda);  

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
