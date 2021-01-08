using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios;
using System.Data.OleDb;
using System.Data;

namespace Negocios
{
    public class CategoriaDAO
    {
        StringBuilder sb = new StringBuilder();
        ConexaoBanco conexao = new ConexaoBanco();

        public void GravarCategoria(Categoria categoria)
        {
            sb.Append("INSERT INTO tblCategoria(nome)VALUES(");
            sb.Append("'");
            sb.Append(categoria._Nome);
            sb.Append("')");

            conexao.manterCRUD(sb.ToString());
        }

        public DataTable CriaDataTableCategoria()
        {
            conexao = new ConexaoBanco();
            sb = new StringBuilder();
            DataTable dt = new DataTable();

            sb.Append("SELECT * FROM tblCategoria ORDER BY nome ASC");

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
