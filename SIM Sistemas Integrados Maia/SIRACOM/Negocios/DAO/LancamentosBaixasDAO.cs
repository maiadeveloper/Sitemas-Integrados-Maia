using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using System.Data.OleDb;
using System.Data;


namespace Negocios.DAO
{
    public class LancamentosBaixasDAO
    {
        ConexaoBanco conexaoBanco;
        StringBuilder sb;

        public void InserirLancamentoBaixa(LancamentosBaixas lancamentosBaixas)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();

            sb.Append("INSERT INTO tblLancamentosBaixas(LancamentoID,NumParcela,Item,ContaID,BaixaTipoID,DataBaixa,VlorBaixa,Descricao)VALUES('");
            sb.Append(lancamentosBaixas.LancamentoID + "','");
            sb.Append(lancamentosBaixas.NumParcela + "','");
            sb.Append(lancamentosBaixas.Item + "','");
            sb.Append(lancamentosBaixas.ContaID + "','");
            sb.Append(lancamentosBaixas.BaixaTipoID + "','");
            sb.Append(lancamentosBaixas.DataBaixa + "','");
            sb.Append(lancamentosBaixas.VlorBaixa + "','");
            sb.Append(lancamentosBaixas.Descricao + "')");

            conexaoBanco.manterCRUD(sb.ToString());
        }

        public void DeletarLancamentoBaixa(int lancamentoBaixaID)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();

            sb.Append("DELETE FROM tblLancamentosBaixas WHERE LancamentoBaixaID = " + lancamentoBaixaID);

            conexaoBanco.manterCRUD(sb.ToString());
        }

        public DataTable CriaDataTableLancamentosBaixas(int lancamentoID)
        {
            conexaoBanco = new ConexaoBanco();
            DataTable dt = new DataTable();
            sb = new StringBuilder();

            sb.Append("SELECT * FROM tblLancamentosBaixas WHERE LancamentoID = " + lancamentoID);
           
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

        public LancamentosBaixas SelecionarLancamentoBaixaID(int lancamentoID)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();
            LancamentosBaixas lancamentosBaixas = new LancamentosBaixas();

            sb.Append("SELECT * FROM tblLancamentosBaixas WHERE LancamentoID = " + lancamentoID);

            OleDbDataReader leitor = conexaoBanco.selectDR(sb.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();

                lancamentosBaixas.LancamentoBaixaID = (int)leitor["LancamentoBaixaID"];
                lancamentosBaixas.LancamentoID = (int)leitor["LancamentoID"];
                lancamentosBaixas.NumParcela = (int)leitor["NumParcela"];
                lancamentosBaixas.Item = (int)leitor["Item"];
                lancamentosBaixas.ContaID = (int)leitor["ContaID"];
                lancamentosBaixas.BaixaTipoID = (int)leitor["BaixaTipoID"];
                lancamentosBaixas.DataBaixa = (DateTime)leitor["DataBaixa"];
                lancamentosBaixas.VlorBaixa = (int)leitor["VlorBaixa"];
                lancamentosBaixas.Descricao = (string)leitor["Descricao"];
            }
            else
            {
                lancamentosBaixas = null;
            }

            leitor.Close();

            return lancamentosBaixas;
        }

        public DataSet LancamentosBaixaTodos(DateTime dataInicial, DateTime dataFinal)
        {
            conexaoBanco = new ConexaoBanco();
            OleDbCommand cmd = new OleDbCommand("", conexaoBanco.conectar());
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataSet ds = new DataSet();

            cmd.CommandText = "SELECT * FROM tblLancamentosBaixas WHERE DataBaixa BETWEEN ? and ?";

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
