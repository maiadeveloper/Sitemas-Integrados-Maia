using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using Negocios.TIPO;

namespace Negocios.DAO
{
    public class TipoDocumentoDAO
    {
        ConexaoBanco conexaoBanco;
        StringBuilder sb;

        public DataTable CriaDataTableTipoDocumento(string parametro)
        {
            conexaoBanco = new ConexaoBanco();
            DataTable dt = new DataTable();
            sb = new StringBuilder();

            if (string.IsNullOrEmpty(parametro))
            {
                sb.Append(string.Format("SELECT * FROM  TipoDocumento"));
            }
            else
            {
                sb.Append("SELECT * FROM TipoDocumento WHERE NomeTipoDocumento LIKE '%" + parametro + "%' ORDER BY NomeTipoDocumento ASC");
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

        public TipoDocumento SelecionarTipoDocumentoID(int tipoDocumentoID)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();
            TipoDocumento tipoDocumento = new TipoDocumento();

            sb.Append("SELECT * FROM TipoDocumento WHERE TipoDocumentoID =" + tipoDocumentoID);

            OleDbDataReader leitor = conexaoBanco.selectDR(sb.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();

                tipoDocumento.TipoDocumentoID = (int)leitor["TipoDocumentoID"];
                tipoDocumento.NomeTipoDocumento = (string)leitor["NomeTipoDocumento"];
            }
            else
            {
                tipoDocumento = null;
            }

            leitor.Close();

            return tipoDocumento;
        }
    }
}
