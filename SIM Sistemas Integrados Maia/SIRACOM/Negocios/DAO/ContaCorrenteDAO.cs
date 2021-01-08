using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using Negocios.DAO;
using System.Data.OleDb;
using System.Data;

namespace Negocios.DAO
{
    public class ContaCorrenteDAO
    {
        ConexaoBanco conexaoBanco;
        StringBuilder sb;

        public void InserirContaCorrente(ContaCorrente contaCorrente)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();

            sb.Append("INSERT INTO tblContaCorrente(BancoID,Agencia,ContaCorrente,Saldo)VALUES('");
            sb.Append(contaCorrente.BancoID + "','");
            sb.Append(contaCorrente.Agencia + "','");
            sb.Append(contaCorrente.CC + "','");
            sb.Append(contaCorrente.Saldo);
            sb.Append("')");

            conexaoBanco.manterCRUD(sb.ToString());
        }

        public void AtualizarSaldoDespesa(int contaID,string valor)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();

            sb.Append("UPDATE tblContaCorrente SET Saldo =" + "(Saldo - " + valor.Replace(",",".") + ")");
            sb.Append(" WHERE ContaID =" + contaID);

            conexaoBanco.manterCRUD(sb.ToString());
        }

        public void AtualizarSaldoDespesaEstorno(int contaID, string valor)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();

            sb.Append("UPDATE tblContaCorrente SET Saldo =" + "(Saldo + " + valor.Replace(",", ".") + ")");
            sb.Append(" WHERE ContaID =" + contaID);

            conexaoBanco.manterCRUD(sb.ToString());
        }

        public void AtualizarSaldoPositivo(int contaID, string valor)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();

            sb.Append("UPDATE tblContaCorrente SET Saldo =" + "(Saldo + " + valor.Replace(",", ".") + ")");
            sb.Append(" WHERE ContaID =" + contaID);

            conexaoBanco.manterCRUD(sb.ToString());
        }

        public void AlterarContaCorrente(ContaCorrente contaCorrente)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();

            sb.Append("UPDATE tblContaCorrente SET ");
            sb.Append("BancoID = '" + contaCorrente.BancoID + "',");
            sb.Append("Agencia = '" + contaCorrente.Agencia + "',");
            sb.Append("ContaCorrente = '" + contaCorrente.CC + "',");
            sb.Append("Saldo = '" + contaCorrente.Saldo + "'");
            sb.Append(" WHERE ContaID = " + contaCorrente.ContaID);

            conexaoBanco.manterCRUD(sb.ToString());
        }

        public void DeletarContaCorrente(int contaID)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();

            sb.Append("DELETE FROM tblContaCorrente");
            sb.Append(" WHERE ContaID = " + contaID);

            conexaoBanco.manterCRUD(sb.ToString());
        }

        public ContaCorrente SelecionarContaCorrenteID(int contaID)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();
            ContaCorrente contaCorrente = new ContaCorrente();

            sb.Append("SELECT * FROM tblContaCorrente WHERE ContaID = " + contaID);

            OleDbDataReader leitor = conexaoBanco.selectDR(sb.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();

                contaCorrente.ContaID = (int)leitor["ContaID"];
                contaCorrente.BancoID = (int)leitor["BancoID"];
                contaCorrente.Agencia = (string)leitor["Agencia"];
                contaCorrente.CC = (int)leitor["ContaCorrente"];
                contaCorrente.Saldo = (decimal)leitor["Saldo"];
            }
            else
            {
                contaCorrente = null;
            }
            return contaCorrente;
        }

        public ContaCorrente SelecionarContaCorrenteBancoID(int bancoID)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();
            ContaCorrente contaCorrente = new ContaCorrente();

            sb.Append("SELECT * FROM tblContaCorrente WHERE BancoID = " + bancoID);

            OleDbDataReader leitor = conexaoBanco.selectDR(sb.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();

                contaCorrente.ContaID = (int)leitor["ContaID"];
                contaCorrente.BancoID = (int)leitor["BancoID"];
                contaCorrente.Agencia = (string)leitor["Agencia"];
                contaCorrente.CC = (int)leitor["ContaCorrente"];
                contaCorrente.Saldo = (decimal)leitor["Saldo"];
            }
            else
            {
                contaCorrente = null;
            }
            return contaCorrente;
        }

        public IList<ContaCorrente> RetornaListaContaCorrentes()
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();
            ContaCorrente contaCorrente = new ContaCorrente();

            sb.Append("SELECT * FROM tblContaCorrente");

            OleDbDataReader leitor = conexaoBanco.selectDR(sb.ToString());
            IList<ContaCorrente> ContaCorrentes = new List<ContaCorrente>();

            //Verifica se tem linha
            if (leitor.HasRows)
            {
                //Ler as linhas
                while (leitor.Read())
                {
                    contaCorrente.ContaID = (int)leitor["ContaID"];
                    contaCorrente.BancoID = (int)leitor["BancoID"];
                    contaCorrente.Agencia = (string)leitor["Agencia"];
                    contaCorrente.CC = (int)leitor["ContaCorrente"];
                    contaCorrente.Saldo = (decimal)leitor["Saldo"];

                    ContaCorrentes.Add(contaCorrente);
                }
            }
            else
            {
                ContaCorrentes = null;
            }

            //Fecha a conexao
            leitor.Close();

            //retorna uma lista
            return ContaCorrentes;
        }

        public DataTable CriaDataTableContaCorrentes(string parametro)
        {
            conexaoBanco = new ConexaoBanco();
            DataTable dt = new DataTable();
            sb = new StringBuilder();

            if (string.IsNullOrEmpty(parametro))
            {
                sb.Append(string.Format("SELECT * FROM ViewContaCorrente ORDER BY NomeBanco ASC"));
            }
            else
            {
                sb.Append("SELECT * FROM ViewContaCorrente WHERE NomeBanco LIKE '%" + parametro + "%' ORDER BY NomeBanco ASC");
            }

            OleDbDataReader leitor = conexaoBanco.selectDR(sb.ToString());

            if (leitor != null)
            {
                dt.Load(leitor);
            }
            else
            {
                dt = null;
            }

            return dt;
        }
    }
}
