using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.classeReceita;
using System.Data.OleDb;
using System.Data;

namespace Negocios.classeReceitaDao
{
    public class ClasseReceitaDAO
    {
        ConexaoBanco conexao = new ConexaoBanco();
        public string comandSql;

        public void InserirDados(ClasseReceita objClasseReceita)
        {
            comandSql = "INSERT INTO tblClasseReceita(classe)VALUES('" + objClasseReceita._Classe  + "')";                    
            conexao.manterCRUD(comandSql);
        }

        public ClasseReceita BuscaClasse(ClasseReceita objClasseReceita)
        {
            comandSql = "SELECT * FROM tblClasseReceita WHERE CodigoClasseReceita = " + objClasseReceita._Iuo;

            OleDbDataReader leitor = conexao.selectDR(comandSql);

            if (leitor.HasRows)
            {
                leitor.Read();

                objClasseReceita._Iuo = (int)leitor["CodigoClasseReceita"];
                objClasseReceita._Classe = (string)leitor["classe"];
            }

            else
            {
                objClasseReceita = null;
            }
            leitor.Close();
            return objClasseReceita;
        }
    }
}
