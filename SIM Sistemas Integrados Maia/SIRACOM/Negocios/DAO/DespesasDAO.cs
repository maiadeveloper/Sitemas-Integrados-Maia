using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using System.Data.OleDb;
using System.Data;

namespace Negocios.DAO
{
    public class DespesasDAO
    {
        ConexaoBanco conexaoBanco;
        StringBuilder sb;

        public void InserirDespesa(Despesas despesas)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();

            sb.Append("INSERT INTO tblDespesa(Data,TipoDespesaID,DescricaoDespesa,Valor,ContaID)VALUES('");
            sb.Append(despesas.Data + "','");
            sb.Append(despesas.TipoDespesaID + "','");
            sb.Append(despesas.DescricaoDespesa + "','");
            sb.Append(despesas.Valor + "','");
            sb.Append(despesas.ContaID + "')");

            conexaoBanco.manterCRUD(sb.ToString());
        }

        public DataTable CriaDataTableDespesas()
        {
            conexaoBanco = new ConexaoBanco();
            DataTable dt = new DataTable();
            sb = new StringBuilder();

            sb.Append("SELECT * FROM ViewDespesas ORDER BY NomeClasse");

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

        public DataSet TodasDespesas(DateTime dataInicial, DateTime dataFinal)
        {
            conexaoBanco = new ConexaoBanco();
            OleDbCommand cmd = new OleDbCommand("", conexaoBanco.conectar());
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataSet ds = new DataSet();

            cmd.CommandText = "SELECT * FROM ViewDespesas WHERE Data BETWEEN ? and ?  ORDER BY DespesasID ASC";

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

        public OleDbDataAdapter CarregaRelatorioGraficoDespesas()
        {
            conexaoBanco = new ConexaoBanco();
            OleDbDataAdapter da;
            da = new OleDbDataAdapter("SELECT * FROM ViewDespesas", conexaoBanco.conectar());
            return da;
        }
    }
}
