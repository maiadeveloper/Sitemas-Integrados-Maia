using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using Negocios.TIPO;

namespace Negocios.DAO
{
    public class LancamentosDAO
    {
        ConexaoBanco conexaoBanco;
        StringBuilder sb;

        public void InserirLancamento(Lancamentos lancamentos)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();

            sb.Append("INSERT INTO tblLancamentos(NumParcela,EmpresaID,TipoLancamento,CodClienteFornecedor,TipoDocumento,Descricao,NumDoc,DataEmissao,");
            sb.Append("DataCadastro,DataVencimento,ValorPrincipal,ValorJuros,ValorDesconto,TipoDespesaID,Observacao,Situacao,ValorAberto) VALUES('");
            sb.Append(lancamentos.NumParcela + "','");
            sb.Append(lancamentos.EmpresaID + "','");
            sb.Append(lancamentos.TipoLancamento + "','");
            sb.Append(lancamentos.CodClienteFornecedor + "','");
            sb.Append(lancamentos.TipoDocumento + "','");
            sb.Append(lancamentos.Descricao + "','");
            sb.Append(lancamentos.NumDoc + "','");
            sb.Append(lancamentos.DataEmissao + "','");
            sb.Append(lancamentos.DataCadastro + "','");
            sb.Append(lancamentos.DataVencimento + "','");
            sb.Append(lancamentos.ValorPrincipal + "','");
            sb.Append(lancamentos.ValorJuros + "','");
            sb.Append(lancamentos.ValorDesconto + "','");
            sb.Append(lancamentos.TipoDespesaID + "','");
            sb.Append(lancamentos.Observacao + "','");
            sb.Append(lancamentos.Situacao + "','");
            sb.Append(lancamentos.ValorAberto + "')");

            conexaoBanco.manterCRUD(sb.ToString());
        }

        public void AlterarLancamentoBaixar(Lancamentos lancamentos)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();

            sb.Append("UPDATE tblLancamentos SET DataPgto = '");
            sb.Append(lancamentos.DataPgto + "',");
            sb.Append("Situacao = '");
            sb.Append(lancamentos.Situacao + "',");
            sb.Append("ValorAberto = '");
            sb.Append(lancamentos.ValorAberto + "'");
            sb.Append(" WHERE LancamentoID = " + lancamentos.LancamentoID);

            conexaoBanco.manterCRUD(sb.ToString());
        }

        public Lancamentos SelecionarLancamentoID(int lancamentoID)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();
            Lancamentos lancamentos = new Lancamentos();

            sb.Append("SELECT * FROM tblLancamentos WHERE LancamentoID =" + lancamentoID);

            OleDbDataReader leitor = conexaoBanco.selectDR(sb.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();

                lancamentos.LancamentoID = (int)leitor["LancamentoID"];
                lancamentos.NumParcela = (string)leitor["NumParcela"];
                lancamentos.EmpresaID = (int)leitor["EmpresaID"];
                lancamentos.TipoLancamento = (string)leitor["TipoLancamento"];
                lancamentos.CodClienteFornecedor = (int)leitor["CodClienteFornecedor"];
                lancamentos.TipoDocumento = (int)leitor["TipoDocumento"];
                lancamentos.Descricao = (string)leitor["Descricao"];
                lancamentos.NumDoc = (string)leitor["NumDoc"];
                lancamentos.DataEmissao = (DateTime)leitor["DataEmissao"];
                lancamentos.DataCadastro = (DateTime)leitor["DataCadastro"];
                lancamentos.DataVencimento = (DateTime)leitor["DataVencimento"];
                lancamentos.ValorPrincipal = (decimal)leitor["ValorPrincipal"];
                lancamentos.ValorJuros = (decimal)leitor["ValorJuros"];
                lancamentos.ValorDesconto = (decimal)leitor["ValorDesconto"];
                lancamentos.TipoDespesaID = (int)leitor["TipoDespesaID"];
                lancamentos.Situacao = (string)leitor["Situacao"];
            }
            else
            {
                lancamentos = null;
            }

            leitor.Close();

            return lancamentos;
        }

        public Lancamentos SelecionarLancamentoCodFornecedor(int cod)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();
            Lancamentos lancamentos = new Lancamentos();

            sb.Append("SELECT * FROM tblLancamentos WHERE CodClienteFornecedor =" + cod);

            OleDbDataReader leitor = conexaoBanco.selectDR(sb.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();

                lancamentos.LancamentoID = (int)leitor["LancamentoID"];
                lancamentos.NumParcela = (string)leitor["NumParcela"];
                lancamentos.EmpresaID = (int)leitor["EmpresaID"];
                lancamentos.TipoLancamento = (string)leitor["TipoLancamento"];
                lancamentos.CodClienteFornecedor = (int)leitor["CodClienteFornecedor"];
                lancamentos.TipoDocumento = (int)leitor["TipoDocumento"];
                lancamentos.Descricao = (string)leitor["Descricao"];
                lancamentos.NumDoc = (string)leitor["NumDoc"];
                lancamentos.DataEmissao = (DateTime)leitor["DataEmissao"];
                lancamentos.DataCadastro = (DateTime)leitor["DataCadastro"];
                lancamentos.DataVencimento = (DateTime)leitor["DataVencimento"];
                lancamentos.ValorPrincipal = (decimal)leitor["ValorPrincipal"];
                lancamentos.ValorJuros = (decimal)leitor["ValorJuros"];
                lancamentos.ValorDesconto = (decimal)leitor["ValorDesconto"];
                lancamentos.TipoDespesaID = (int)leitor["TipoDespesaID"];
                lancamentos.Situacao = (string)leitor["Situacao"];
            }
            else
            {
                lancamentos = null;
            }

            leitor.Close();

            return lancamentos;
        }

        public DataSet LancamentosTodos(DateTime dataInicial, DateTime dataFinal, string campo,string situacao)
        {
            conexaoBanco = new ConexaoBanco();
            OleDbCommand cmd = new OleDbCommand("", conexaoBanco.conectar());
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataSet ds = new DataSet();

            if (!string.IsNullOrEmpty(situacao))
            {
                cmd.CommandText = "SELECT * FROM ViewLancamentos WHERE " + campo + " BETWEEN ? and ? and Situacao = '" + situacao + "' ORDER BY LancamentoID ASC";
            }
            else
            {
                cmd.CommandText = "SELECT * FROM ViewLancamentos WHERE " + campo + " BETWEEN ? and ?  ORDER BY LancamentoID ASC";
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

        public DataTable CriaDataTableSelecionaTodosLancamentos()
        {
            conexaoBanco = new ConexaoBanco();
            DataTable dt = new DataTable();
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Format("SELECT * FROM ViewLancamentos WHERE Situacao = 'Aberto'"));

            OleDbDataReader leitor = conexaoBanco.selectDR(sb.ToString());

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
