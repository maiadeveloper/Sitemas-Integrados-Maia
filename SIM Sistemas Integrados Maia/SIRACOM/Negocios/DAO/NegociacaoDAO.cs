using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using Negocios.TIPO;

namespace Negocios.DAO
{
    public class NegociacaoDAO
    {
        ConexaoBanco conexaoBanco;
        StringBuilder sb;

        public void InserirNegociacao(Negociacao negociacao)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();

            sb.Append("INSERT INTO tblNegociacao(ClienteId,NumParcela,NumDocRelacionado,DataCadastro,DataVencimento,VlrParcela,Situacao)VALUES('");
            sb.Append(negociacao.ClienteId);
            sb.Append("','");
            sb.Append(negociacao.NumParcela);
            sb.Append("','");
            sb.Append(negociacao.NumDocRelacionado);
            sb.Append("','");
            sb.Append(negociacao.DataCadastro);
            sb.Append("','");
            sb.Append(negociacao.DataVencimento);
            sb.Append("','");
            sb.Append(negociacao.VlrParcela);
            sb.Append("','");
            sb.Append(negociacao.Situacao);
            sb.Append("')");

            conexaoBanco.manterCRUD(sb.ToString());
        }

        public void AlterarSituacao(int cod)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();

            sb.Append("UPDATE tblNegociacao SET Situacao = 'Fechado' WHERE Id =" + cod);

            conexaoBanco.manterCRUD(sb.ToString());
        }

        public Negociacao SelecionaNegociacaoId(int id)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();
            Negociacao negociacao = new Negociacao();

            sb.Append("SELECT * FROM tblNegociacao WHERE Id = " + id);

            OleDbDataReader leitor = conexaoBanco.selectDR(sb.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();

                negociacao.Id = (int)leitor["Id"];
                negociacao.ClienteId = (int)leitor["ClienteId"];
            }
            else
            {
                negociacao = null;
            }
            return negociacao;
        }

        public DataTable ListaNegociacoes(string parametro,string situacao)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();
            DataTable dt = new DataTable();

            if (string.IsNullOrEmpty(situacao))
            {
                sb.Append("SELECT * FROM ViewNegociacoes WHERE NomeFantasia LIKE '%" + parametro + "%' ORDER BY DataVencimento ASC");
            }
            else
            {
                sb.Append("SELECT * FROM ViewNegociacoes WHERE NomeFantasia LIKE '%" + parametro + "%' AND Situacao = '" + situacao + "' ORDER BY DataVencimento ASC");
            }
          
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
