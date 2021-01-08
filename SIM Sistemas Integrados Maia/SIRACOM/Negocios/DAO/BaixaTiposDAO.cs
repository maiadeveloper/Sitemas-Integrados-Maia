using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace Negocios.DAO
{
    public class BaixaTiposDAO
    {
        ConexaoBanco conexaoBanco;
        StringBuilder sb;

        public DataTable CriaDataTableBaixaTipos(string parametro)
        {
            conexaoBanco = new ConexaoBanco();
            DataTable dt = new DataTable();
            sb = new StringBuilder();

            if (string.IsNullOrEmpty(parametro))
            {
                sb.Append(string.Format("SELECT * FROM tblBaixasTipos ORDER BY NomeBaixaTipo ASC"));
            }
            else
            {
                sb.Append("SELECT * FROM tblBaixasTipos WHERE NomeBaixaTipo LIKE '%" + parametro + "%' ORDER BY NomeBaixaTipo ASC");
            }

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
