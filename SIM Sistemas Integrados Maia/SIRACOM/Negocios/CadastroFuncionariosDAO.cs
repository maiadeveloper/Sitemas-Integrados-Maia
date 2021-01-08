using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace Negocios
{
    public class CadastroFuncionariosDAO
    {
        ConexaoBanco conexao = new ConexaoBanco();
        string comandSql;

        public void insertFuncionrios(CadastroFuncionarios cdFuncionarios)
        {
               comandSql = "INSERT INTO CadastroLavador(DataCadastro,NomeFuncionario,Dia,Mes,Ano,Endereco_Rua,Cep,Endereco_Numero,Bairro,Cidade,Estado,Telefone_Fixo,Telefone_Residencial,Obs,Foto)VALUES('"
              + cdFuncionarios._DataCadastro + "','" + cdFuncionarios._Nome + "','" + cdFuncionarios._Dia + "','" + cdFuncionarios._Mes + "','"
              + cdFuncionarios._Ano + "','" + cdFuncionarios._Endereco_Rua + "','" + cdFuncionarios._Cep + "','" + cdFuncionarios._Endereco_Numero + "','"
              + cdFuncionarios._Bairro + "','" + cdFuncionarios._Cidade + "','" + cdFuncionarios._Estado + "','" + cdFuncionarios._Telefone_Fixo + "','"
              + cdFuncionarios._Telefone_Residencial + "','" + cdFuncionarios._Obs + "','" + cdFuncionarios._Foto + "')";

               conexao.manterCRUD(comandSql);
        }

        public CadastroFuncionarios localizar(CadastroFuncionarios cdFuncionarios)
        {
            comandSql = "SELECT * FROM CadastroLavador" + " WHERE CodigoFuncionario = " + cdFuncionarios._CodigoLavador;
            OleDbDataReader leitor = conexao.selectDR(comandSql);

            if (leitor.HasRows)//Caso encontre registro na linha
            {
                leitor.Read(); // Ler o dado do registro

                cdFuncionarios._CodigoLavador = (int)leitor["CodigoFuncionario"];
                cdFuncionarios._Nome = (string)leitor["NomeFuncionario"];
            }
            else // Caso nao encontre o arquivo
            {
                cdFuncionarios = null;
            }
            return cdFuncionarios;
        }
    }
}
