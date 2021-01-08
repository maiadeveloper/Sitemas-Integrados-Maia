using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Negocios.manterBancoTipo;
using System.Data.OleDb;

namespace Negocios.manterBancoDao
{
    public class ManterBancoDAO
    {
        ////Cria um objeto da classe ConexaoBanco e instacia o mesmo.
        ConexaoBanco conexao = new ConexaoBanco();

        //Cria uma variavel do tipo string para stringSql
        public string comandSql;

        //Cria uma variavel do tipo string para preencher os valores referente ao campo da tabela
        public string valuesSql;

        /// <summary>
        /// Método inserir banco
        /// </summary>
        /// <param name="objBancoTipo">é criado objeto da classe ManterBancoTipo</param>
        public void InsertBanco(ManterBancoTipo objBancoTipo)
        {
            //Variavel string recebe comando sql
            comandSql = "INSERT INTO tblBanco(NomeBanco)VALUES('" + objBancoTipo._NomeBanco + "')";

            //Objeto conexão chama o método manter crud passando como parametro o comando sql
            conexao.manterCRUD(comandSql);
        }

        public DataTable CriaDataTableBanco(string parametro)
        {
            DataTable dt = new DataTable();
            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(parametro))
            {
                sb.Append(string.Format("SELECT * FROM tblBanco"));
            }
            else
            {
                sb.Append("SELECT * FROM tblBanco WHERE NomeBanco LIKE '%" + parametro + "%'");
            }

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

        public DataTable PopularBanco()
        {
            DataTable dt = new DataTable();
            StringBuilder sb = new StringBuilder();

            sb.Append("SELECT BancoID, NomeBanco FROM tblBanco ORDER BY BancoID,NomeBanco");

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
