using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace Negocios
{
    public class CadastroFornecedoresDAO
    {
        ConexaoBanco conexao = new ConexaoBanco();
        string comandSql;

        public void insertFornecedores(CadastroFornecedores cdFornecedores)
        {
            comandSql = "INSERT INTO tblFornecedor(Nome_Fantasia,Razao_Social,Endereco_Rua,Endereco_Numero,Bairro,Cidade,UF,CEP,TelefoneComercial,Fax,TelefoneCelular,CNPJ,Incr_Estadual,Email,Representante)VALUES('"
            + cdFornecedores._Nome_Fantasia + "','" + cdFornecedores._Razao_Social + "','" + cdFornecedores._Endereco_Rua + "','" + cdFornecedores._Endereco_Numero + "','"
            + cdFornecedores._Bairro + "','" + cdFornecedores._Cidade + "','" + cdFornecedores._UF + "','" + cdFornecedores._CEP + "','" + cdFornecedores._TelefoneResidencial + "','" + cdFornecedores._Fax + "','"
            + cdFornecedores._TelefoneCelular + "','" + cdFornecedores._CNPJ + "','" + cdFornecedores._Incr_Estadual + "','" + cdFornecedores._Email + "','" + cdFornecedores._Representante + "')";

            conexao.manterCRUD(comandSql);
        }

        public void ExcluirFornecedor(int cod)
        {
            comandSql = "DELETE FROM tblFornecedor WHERE CodigoFornecedor = " + cod;
            conexao.manterCRUD(comandSql);
        }

        public CadastroFornecedores localizar(CadastroFornecedores cdFornecedores)
        {
            comandSql = "SELECT * FROM tblFornecedor" + " WHERE CodigoFornecedor = " + cdFornecedores._CodigoFornecedor;
            OleDbDataReader leitor = conexao.selectDR(comandSql);

            if (leitor.HasRows)//Caso encontre registro na linha
            {
                leitor.Read(); // Ler o dado do registro

                cdFornecedores._CodigoFornecedor = (int)leitor["CodigoFornecedor"];
                cdFornecedores._Nome_Fantasia = (string)leitor["Razao_Social"];
                cdFornecedores._Nome_Fantasia = (string)leitor["Nome_Fantasia"];
                /*cdFornecedores._Nome_Fantasia = (string)leitor["Endereco_Rua"];
                cdFornecedores._Nome_Fantasia = (string)leitor["Endereco_Numero"];
                cdFornecedores._Nome_Fantasia = (string)leitor["Bairro"];
                cdFornecedores._Nome_Fantasia = (string)leitor["Cidade"];
                cdFornecedores._Nome_Fantasia = (string)leitor["UF"];
                cdFornecedores._Nome_Fantasia = (string)leitor["CEP"];
                cdFornecedores._Nome_Fantasia = (string)leitor["TelefoneComercial"];
                cdFornecedores._Nome_Fantasia = (string)leitor["Fax"];
                cdFornecedores._Nome_Fantasia = (string)leitor["TelefoneCelular"];
                cdFornecedores._Nome_Fantasia = (string)leitor["CNPJ"];
                cdFornecedores._Nome_Fantasia = (string)leitor["Incr_Estadual"];
                cdFornecedores._Nome_Fantasia = (string)leitor["Email"];
                cdFornecedores._Nome_Fantasia = (string)leitor["Representante"];
                cdFornecedores._Nome_Fantasia = (string)leitor["Foto"];*/
            }
            else // Caso nao encontre o arquivo
            {
                cdFornecedores = null;
            }
            return cdFornecedores;
        }

        public CadastroFornecedores LocaliarFornecedorRazaoSocial(CadastroFornecedores cdFornecedores)
        {
            comandSql = "SELECT * FROM tblFornecedor" + " WHERE Razao_Social = '" + cdFornecedores._Razao_Social + "'";
            OleDbDataReader leitor = conexao.selectDR(comandSql);

            if (leitor.HasRows)//Caso encontre registro na linha
            {
                leitor.Read(); // Ler o dado do registro

                cdFornecedores._CodigoFornecedor = (int)leitor["CodigoFornecedor"];
                cdFornecedores._Nome_Fantasia = (string)leitor["Razao_Social"];
                cdFornecedores._Nome_Fantasia = (string)leitor["Nome_Fantasia"];
            }
            else // Caso nao encontre o arquivo
            {
                cdFornecedores = null;
            }
            return cdFornecedores;
        }

        public DataTable CriaDataFornecedores()
        {
            conexao = new ConexaoBanco();
            DataTable dt = new DataTable();
            StringBuilder sb = new StringBuilder();

            sb.Append("SELECT * FROM tblFornecedor");

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

        /// Retorna um dataTable
        /// </summary>
        /// <returns></returns>
        public DataTable CriaDataFornecedoresParametro(string parametro)
        {
            conexao = new ConexaoBanco();
            DataTable dt = new DataTable();
            StringBuilder sb = new StringBuilder();

            if (!string.IsNullOrEmpty(parametro))
            {
                sb.Append("SELECT * FROM tblFornecedor WHERE Razao_Social LIKE '%" + parametro + "%'");
                sb.Append(" OR Nome_Fantasia LIKE '%" + parametro + "%'");
                sb.Append(" OR CNPJ LIKE '%" + parametro + "%'");
            }
            else
            {
                sb.Append("SELECT * FROM tblFornecedor ORDER BY CodigoFornecedor DESC");
            }

            OleDbDataReader leitor = conexao.selectDR(sb.ToString());

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
