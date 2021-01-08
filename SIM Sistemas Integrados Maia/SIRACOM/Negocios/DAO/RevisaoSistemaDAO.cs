using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using System.Data.OleDb;

namespace Negocios.DAO
{
    public class RevisaoSistemaDAO
    {
        StringBuilder sb;
        ConexaoBanco conexaoBanco = new ConexaoBanco();

        public void Inserir(RevisaoSistema revisaoSistema)
        {
            sb = new StringBuilder();

            sb.Append("INSERT INTO tblRevisaoSistema(DataHora,Modulo,Funcionalidade,Descricao,Situacao)");
            sb.Append("VALUES('");
            sb.Append(revisaoSistema._DataHora);
            sb.Append("','");
            sb.Append(revisaoSistema._Modulo);
            sb.Append("','");
            sb.Append(revisaoSistema._Funcionalidade);
            sb.Append("','");
            sb.Append(revisaoSistema._Descricao);
            sb.Append("','");
            sb.Append(revisaoSistema._Situacao);
            sb.Append("')");

            conexaoBanco.manterCRUD(sb.ToString());
        }
    }
}
