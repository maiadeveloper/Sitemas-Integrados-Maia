using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using Negocios;
using System.Data.OleDb;
using System.Data;

namespace Negocios.DAO
{
    public class OrcamentoDAO
    {
        StringBuilder sb;
        ConexaoBanco conexaoBanco;
        Orcamento orcamento;

        public void Gravar(Orcamento orcamento)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();

            sb.Append("INSERT INTO tblOrcamento(dataHoraAbertura,clienteID,vlrDesconto,vlrTotal,status)VALUES('");
            sb.Append(orcamento._DataHoraAbertura);
            sb.Append("','");
            sb.Append(orcamento._ClienteID);
            sb.Append("','");
            sb.Append(orcamento._VlrDesconto);
            sb.Append("','");
            sb.Append(orcamento._VlrTotal);
            sb.Append("','");
            sb.Append(orcamento._Status);
            sb.Append("')");

            conexaoBanco.manterCRUD(sb.ToString());
        }

        public Orcamento SelecionarUltimoOrcamento()
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();

            sb.Append("SELECT TOP 1 * FROM tblOrcamento ORDER BY orcamentoID DESC");

            OleDbDataReader leitor = conexaoBanco.selectDR(sb.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();

                orcamento = new Orcamento();

                orcamento._ClienteID = (int)leitor["clienteID"];
                orcamento._DataHoraAbertura = (DateTime)leitor["dataHoraAbertura"];
                orcamento._OrcamentoID = (int)leitor["orcamentoID"];
                orcamento._Status = (int)leitor["status"];
                orcamento._VlrDesconto = (decimal)leitor["vlrDesconto"];
                orcamento._VlrTotal = (decimal)leitor["vlrTotal"];
            }
            else
            {
                orcamento = null;
            }

            leitor.Close();

            return orcamento;
        }

        public Orcamento SelecionarOrcamentoID(int orcamentoID)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();

            sb.Append("SELECT * FROM tblOrcamento where orcamentoID =" + orcamentoID);

            OleDbDataReader leitor = conexaoBanco.selectDR(sb.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();

                orcamento = new Orcamento();

                orcamento._ClienteID = (int)leitor["clienteID"];
                orcamento._DataHoraAbertura = (DateTime)leitor["dataHoraAbertura"];
                orcamento._OrcamentoID = (int)leitor["orcamentoID"];
                orcamento._Status = (int)leitor["status"];
                orcamento._VlrDesconto = (decimal)leitor["vlrDesconto"];
                orcamento._VlrTotal = (decimal)leitor["vlrTotal"];
            }
            else
            {
                orcamento = null;
            }

            leitor.Close();

            return orcamento;
        }

        public DataSet SelecionaOrcamentos(DateTime dataInicial, DateTime dataFinal)
        {
            conexaoBanco = new ConexaoBanco();
            OleDbCommand cmd = new OleDbCommand("", conexaoBanco.conectar());
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataSet ds = new DataSet();

            cmd.CommandText = "SELECT * FROM ViewOrcamento  WHERE (dataHoraAbertura BETWEEN ? and ?) ORDER BY orcamentoID ASC";

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

        public DataTable CriaDataTableSelecionaItensOrcamentos(int orcamentoID)
        {
            conexaoBanco = new ConexaoBanco();

            DataTable dt = new DataTable();

            sb = new StringBuilder();

            sb.Append(string.Format("SELECT * FROM ViewItensOrcamento WHERE orcamentoID = " + orcamentoID));

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
