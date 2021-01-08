using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace Negocios
{
    public class CadastroTipoServicoDAO
    {
        ConexaoBanco conexao = new ConexaoBanco();
        public string comandSql;

        public void insertTipoServico(CadastroTipoServico cdTipoServico)
        {
            comandSql = "INSERT INTO CadastrarServico(Descricao,Valor)VALUES('"
            + cdTipoServico._Descricao + "','" + cdTipoServico._Valor + "')";

            conexao.manterCRUD(comandSql);
        }

        public CadastroTipoServico localizar(CadastroTipoServico cdTipoServico)
        {
            comandSql = "SELECT * FROM CadastrarServico" + " WHERE CodigoServico = " + cdTipoServico._CodigoServico;
            OleDbDataReader leitor = conexao.selectDR(comandSql);

            if (leitor.HasRows)//Caso encontre registro na linha
            {
                leitor.Read(); // Ler o dado do registro

                cdTipoServico._CodigoServico = (int)leitor["CodigoServico"];
                cdTipoServico._Descricao = (string)leitor["Descricao"];
                cdTipoServico._Valor = (decimal)leitor["Valor"];
            }
            else // Caso nao encontre o arquivo
            {
                cdTipoServico = null;
            }
            return cdTipoServico;
        }
    }
}
