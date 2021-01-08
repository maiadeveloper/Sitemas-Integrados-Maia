using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace Negocios
{
    public class CadastroUsuariosDAO
    {
        ConexaoBanco conexao = new ConexaoBanco();
        string comandSql;

        public void insertUsuarios(CadastroUsuarios cdUsuarios)
        {
            comandSql = "INSERT INTO tblUsuario(DataCadastro,NomeUsuario,TipoUsuario,AtivoSenhaUsuario)VALUES('" +
            DateTime.Now.ToString() + "','" + cdUsuarios._NomeUsuario + "','" + cdUsuarios.TipoUsuario + "','"  + cdUsuarios.Ativo + "','" + cdUsuarios._SenhaUsuario + "')";

            conexao.manterCRUD(comandSql);
        }

        public CadastroUsuarios localizarUsuario(CadastroUsuarios cdUsuarios)
        {
            comandSql = "SELECT * FROM tblUsuario" + " WHERE SenhaUsuario = '" + cdUsuarios._SenhaUsuario + "'";
            OleDbDataReader leitor = conexao.selectDR(comandSql);

            if (leitor.HasRows)//Caso encontre registro na linha
            {
                leitor.Read(); // Ler o dado do registro

                cdUsuarios._CodigoUsuario = (int)leitor["CodigoUsuario"];
                cdUsuarios._NomeUsuario = (string)leitor["NomeUsuario"];
                cdUsuarios.TipoUsuario = (string)leitor["TipoUsuario"];
                cdUsuarios.Ativo = (bool)leitor["Ativo"];
            }
            else // Caso nao encontre o arquivo
            {
                cdUsuarios = null;
            }
            return cdUsuarios;
        }
    }
}
