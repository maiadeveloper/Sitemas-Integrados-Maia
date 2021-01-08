using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using System.Data.OleDb;
using System.Data;

namespace Negocios.DAO
{
    public class CaixaDAO
    {
        ConexaoBanco conexaoBanco;
        StringBuilder sb;

        public void AbrirCaixa(Caixa caixa)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();

            sb.Append("INSERT INTO tblCaixa(DataAbertura,Situacao,SaldoCaixa)VALUES('");
            sb.Append(caixa.DataAbertura + "','");
            sb.Append(caixa.Situacao + "','");
            sb.Append(caixa.SaldoCaixa + "')");

            conexaoBanco.manterCRUD(sb.ToString());
        }

        public void FecharCaixa(Caixa caixa)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();

            sb.Append("UPDATE tblCaixa SET DataFechamento = '");
            sb.Append(caixa.DataFechamento + "',");
            sb.Append("SaldoCaixa = '");
            sb.Append(caixa.SaldoCaixa + "',");
            sb.Append("Situacao = '" + caixa.Situacao);
            sb.Append("' WHERE CaixaID = " + caixa.CaixaID);

            conexaoBanco.manterCRUD(sb.ToString());
        }

        public void ReabrirCaixa(Caixa caixa)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();

            sb.Append("UPDATE tblCaixa SET DataReabertura = '");
            sb.Append(caixa.DataReabertura + "',");
            sb.Append("Situacao = '" + caixa.Situacao);
            sb.Append("' WHERE CaixaID = " + caixa.CaixaID);

            conexaoBanco.manterCRUD(sb.ToString());
        }

        public DataSet SelecionaCaixaDiaDataSet(DateTime dataAbertura)
        {
            conexaoBanco = new ConexaoBanco();
            OleDbCommand cmd = new OleDbCommand("", conexaoBanco.conectar());
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataSet ds = new DataSet();

            cmd.CommandText = "SELECT * FROM tblCaixa WHERE DataAbertura" + " BETWEEN ? and ?";

            cmd.Parameters.Add("DateIncial", OleDbType.Date);
            cmd.Parameters.Add("DateFinal", OleDbType.Date);

            cmd.Parameters["DateIncial"].Direction = ParameterDirection.Input;
            cmd.Parameters["DateFinal"].Direction = ParameterDirection.Input;

            cmd.Parameters["DateIncial"].Value = dataAbertura.ToString("dd/MM/yyyy");
            cmd.Parameters["DateFinal"].Value = dataAbertura.ToString("dd/MM/yyyy");

            da.SelectCommand = cmd;

            da.Fill(ds);

            return ds;
        }

        public Caixa SelecionaUltimoCaixa()
        {
            sb = new StringBuilder();
            conexaoBanco = new ConexaoBanco();

            Caixa caixa = new Caixa();

            sb.Append("SELECT TOP 1 * FROM tblCaixa ORDER BY CaixaID DESC");

            OleDbDataReader leitor = conexaoBanco.selectDR(sb.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();
                caixa.Situacao = (string)leitor["Situacao"];
                caixa.CaixaID = (int)leitor["CaixaID"];

                if (leitor["SaldoCaixa"] != DBNull.Value)
                {
                    caixa.SaldoCaixa = (decimal)leitor["SaldoCaixa"];
                }
            }
            else
            {
                caixa = null;
            }

            leitor.Close();

            return caixa;
        }

        public DataSet SelecionaCaixaPeriodo(DateTime dataInicial, DateTime dataFinal)
        {
            conexaoBanco = new ConexaoBanco();
            OleDbCommand cmd = new OleDbCommand("", conexaoBanco.conectar());
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataSet ds = new DataSet();

            cmd.CommandText = "SELECT * FROM tblCaixa WHERE DataAbertura" + " BETWEEN ? and ? ORDER BY CaixaID DESC";

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


        public Caixa SelecionaCaixaDia(int caixaID)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();

            Caixa caixa = new Caixa();

            sb.Append("SELECT * FROM tblCaixa WHERE CaixaID = " + caixaID);

            OleDbDataReader leitor = conexaoBanco.selectDR(sb.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();

                caixa.CaixaID = (int)leitor["CaixaID"];
                caixa.DataAbertura = (DateTime)leitor["DataAbertura"];
                caixa.Situacao = (string)leitor["Situacao"];

                if (leitor["SaldoCaixa"] != DBNull.Value)
                {
                    caixa.SaldoCaixa = (decimal)leitor["SaldoCaixa"];
                }
            }
            else
            {
                caixa = null;
            }

            leitor.Close();

            return caixa;
        }

        public DataSet CriaDataSetCaixaPeriodos(DateTime dataInicial, DateTime dataFinal)
        {
            conexaoBanco = new ConexaoBanco();
            OleDbCommand cmd = new OleDbCommand("", conexaoBanco.conectar());
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataSet ds = new DataSet();

            cmd.CommandText = "SELECT * FROM tblCaixa WHERE (dataVencimento BETWEEN ? and ?) AND status <> 'Recebido'";

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
    }
}
