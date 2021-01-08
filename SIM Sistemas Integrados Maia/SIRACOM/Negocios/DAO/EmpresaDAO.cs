using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using System.Data.OleDb;
using System.Data;

namespace Negocios.DAO
{
    public class EmpresaDAO
    {
        StringBuilder sb;
        ConexaoBanco conexao;

        public Empresa SelecionaUltimoRegistroEmpresa()
        {
            sb = new StringBuilder();
            conexao = new ConexaoBanco();

            Empresa empresa = new Empresa();

            sb.Append("SELECT TOP 1 * FROM tblEmpresa ORDER BY codigoEmpresa DESC");

            OleDbDataReader leitor = conexao.selectDR(sb.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();

                if (leitor["logoEmpresa"] != DBNull.Value)
                {
                    empresa._LogoEmpresa = (string)leitor["logoEmpresa"];
                }

                empresa._IdEmpresa = (int)leitor["codigoEmpresa"];
                empresa._RazaoSocial = (string)leitor["razaoSocial"];
                empresa._NomeFantasia = (string)leitor["nomeFantasiaEmpresa"];
                empresa._CnpjCpf = (string)leitor["cnpjCpf"];
                empresa._Slogan = (string)leitor["sloganEmpresa"];
                empresa._Rua = (string)leitor["rua"];
                empresa._Numero = (int)leitor["numero"];
                empresa._Bairro = (string)leitor["bairro"];
                empresa._Email = (string)leitor["email"];
                empresa._Fone = (string)leitor["fone"];
                empresa._Cidade = (string)leitor["cidade"];
                empresa._UF = (string)leitor["uf"];
                empresa._Cep = (string)leitor["cep"];

                if (leitor["qtdeImpressaoRecibo"] != DBNull.Value)
                {
                    empresa.QtdeImpressaoRecibo = (int)leitor["qtdeImpressaoRecibo"];
                }

                empresa.ConfirmaImpressao = (int)leitor["confirmaImpressao"];
            }
            else
            {
                empresa = null;
            }

            leitor.Close();

            return empresa;
        }

        public void AlterarLogoEmpresa(Empresa empresa)
        {
            conexao = new ConexaoBanco();
            sb = new StringBuilder();

            sb.Append("UPDATE tblEmpresa SET logoEmpresa = '" + empresa._LogoEmpresa + "' WHERE cnpjCpf = '" + empresa._CnpjCpf + "'");
            conexao.manterCRUD(sb.ToString());
        }

        public void AlterarQtdeImpressaoRecibo(Empresa empresa)
        {
            conexao = new ConexaoBanco();
            sb = new StringBuilder();

            sb.Append("UPDATE tblEmpresa SET qtdeImpressaoRecibo = '" + empresa.QtdeImpressaoRecibo + "' WHERE cnpjCpf = '" + empresa._CnpjCpf + "'");
            conexao.manterCRUD(sb.ToString());
        }

        public void AlterarConfirmaImpressao(Empresa empresa)
        {
            conexao = new ConexaoBanco();
            sb = new StringBuilder();

            sb.Append("UPDATE tblEmpresa SET confirmaImpressao = '" + empresa.ConfirmaImpressao + "' WHERE cnpjCpf = '" + empresa._CnpjCpf + "'");
            conexao.manterCRUD(sb.ToString());
        }

        public void AlterarEmpresa(Empresa empresa)
        {
            conexao = new ConexaoBanco();
            sb = new StringBuilder();

            sb.Append("UPDATE tblEmpresa SET ");
            sb.Append("cnpjCpf = '" + empresa._CnpjCpf + "',");
            sb.Append("bairro = '" + empresa._Bairro + "',");
            sb.Append("rua = '" + empresa._Rua + "',");
            sb.Append("numero = '" + empresa._Numero + "',");
            sb.Append("sloganEmpresa = '" + empresa._Slogan + "',");
            sb.Append("fone = '" + empresa._Fone + "',");
            sb.Append("nomeFantasiaEmpresa = '" + empresa._NomeFantasia + "',");
            sb.Append("email = '" + empresa._Email + "',");
            sb.Append("razaoSocial = '" + empresa._RazaoSocial + "',");
            sb.Append("dataCadastro = '" + empresa.DataCadastro + "',");
            sb.Append("cep = '" + empresa._Cep + "',");
            sb.Append("cidade = '" + empresa._Cidade + "',");
            sb.Append("uf = '" + empresa._UF + "',");
            sb.Append("status = '" + empresa._Status + "' ");
            sb.Append("WHERE codigoEmpresa = " + empresa._IdEmpresa);

            conexao.manterCRUD(sb.ToString());
        }

        public DataTable CriaDataTableEmpresa()
        {
            conexao = new ConexaoBanco();
            sb = new StringBuilder();
            DataTable dt = new DataTable();

            sb.Append("SELECT TOP 1 * FROM tblEmpresa ORDER BY codigoEmpresa DESC");

            OleDbDataReader leitor = conexao.selectDR(sb.ToString());

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
