using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using System.Data;
using System.Data.OleDb;

namespace Negocios.DAO
{
    public class EntradaProdutoDAO
    {
        StringBuilder sb;
        ConexaoBanco conexao;

        public void InserirEntradaProduto(EntradaProduto entradaProduto)
        {
            sb = new StringBuilder();
            conexao = new ConexaoBanco();

            sb.Append("INSERT INTO tblEntradaProduto(DataEntrada,DataDocumento,NumeroDocumento,NumeroSerie,");
            sb.Append("CodigoFornecedor,ValorFrete,OutrasDespesas,Desconto,TotaldaNota)VALUES('");

            sb.Append(entradaProduto._DataEntrada + "','" + entradaProduto._DataDocumento + "','");
            sb.Append(entradaProduto._NumeroDocumento + "','" + entradaProduto._NumeroSerie + "','");
            sb.Append(entradaProduto.H_Fornecedor._CodigoFornecedor + "','");
            sb.Append(entradaProduto._ValorFrete + "','" + entradaProduto._OutrasDespesas + "','");
            sb.Append(entradaProduto._Desconto + "','" + entradaProduto._TotalNotaFiscal + "')");

            conexao.manterCRUD(sb.ToString());
        }

        public void ExcluirEntradaProduto(int entradaID)
        {
            sb = new StringBuilder();
            conexao = new ConexaoBanco();

            sb.Append("DELETE FROM tblEntradaProduto WHERE CodigoEntrada = " + entradaID);

            conexao.manterCRUD(sb.ToString());
        }

        public EntradaProduto SelecionaUltimoRegistroEntradaProduto()
        {
            sb = new StringBuilder();
            conexao = new ConexaoBanco();

            EntradaProduto entradaProduto = new EntradaProduto();

            sb.Append("SELECT TOP 1 * FROM tblEntradaProduto ORDER BY CodigoEntrada DESC");

            OleDbDataReader leitor = conexao.selectDR(sb.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();
                entradaProduto._EntradaID = (int)leitor["CodigoEntrada"];
            }
            else
            {
                entradaProduto = null;
            }

            leitor.Close();

            return entradaProduto;
        }

        public EntradaProduto SelecinaEntradaProdutoID(int entradaID)
        {
            sb = new StringBuilder();
            conexao = new ConexaoBanco();

            EntradaProduto entradaProduto = new EntradaProduto();

            sb.Append("SELECT * FROM tblEntradaProduto WHERE CodigoEntrada = " + entradaID);

            OleDbDataReader leitor = conexao.selectDR(sb.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();
                entradaProduto._EntradaID = (int)leitor["CodigoEntrada"];
                entradaProduto._DataDocumento = (DateTime)leitor["DataDocumento"];
                entradaProduto._NumeroDocumento = (int)leitor["NumeroDocumento"];
                entradaProduto.H_Fornecedor._CodigoFornecedor = (int)leitor["CodigoFornecedor"];
                entradaProduto._TotalNotaFiscal = (decimal)leitor["TotaldaNota"];
            }
            else
            {
                entradaProduto = null;
            }

            leitor.Close();

            return entradaProduto;
        }

        public EntradaProduto SelecinaEntradaCodigoFornecedor(int cod)
        {
            sb = new StringBuilder();
            conexao = new ConexaoBanco();

            EntradaProduto entradaProduto = new EntradaProduto();

            sb.Append("SELECT * FROM tblEntradaProduto WHERE CodigoFornecedor = " + cod);

            OleDbDataReader leitor = conexao.selectDR(sb.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();
                entradaProduto._EntradaID = (int)leitor["CodigoEntrada"];
                entradaProduto._DataDocumento = (DateTime)leitor["DataDocumento"];
                entradaProduto._NumeroDocumento = (int)leitor["NumeroDocumento"];
                entradaProduto.H_Fornecedor._CodigoFornecedor = (int)leitor["CodigoFornecedor"];
                entradaProduto._TotalNotaFiscal = (decimal)leitor["TotaldaNota"];
            }
            else
            {
                entradaProduto = null;
            }

            leitor.Close();

            return entradaProduto;
        }

        public DataSet SelecionaEntradaMercadoirasDataSet(DateTime dataInicial, DateTime dataFinal, int codFornecedor)
        {
            conexao = new ConexaoBanco();
            OleDbCommand cmd = new OleDbCommand("", conexao.conectar());
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataSet ds = new DataSet();

            if (codFornecedor != 0)
            {
                cmd.CommandText = "SELECT * FROM ViewEntradaMercadorias WHERE CodigoFornecedor = " + codFornecedor + " AND dataEntrada BETWEEN ? AND ? ORDER BY dataEntrada DESC";
            }
            else
            {
                cmd.CommandText = "SELECT * FROM ViewEntradaMercadorias WHERE dataEntrada BETWEEN ? AND ? ORDER BY dataEntrada DESC";
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
    }
}
