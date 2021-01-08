using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.tipoReceita;
using System.Data.OleDb;
using System.Data;

namespace Negocios.tipoReceitaDao
{
    public class TipoReceitaDAO
    {
        ConexaoBanco conexao = new ConexaoBanco();
        public string comandSql;

        public void InserirTipoReceita(TipoReceita objTipoReceita)
        {
            comandSql = "INSERT INTO tblTipoReceita(descricao,classe)VALUES('" + objTipoReceita._Descricao + "','" + objTipoReceita._Classe + "')";

            conexao.manterCRUD(comandSql);
        }

        public TipoReceita LocalizarTipoReceita(TipoReceita objTipoReceita)
        {
            comandSql = "SELECT * FROM tblTipoReceita WHERE codTipoReceita = " + objTipoReceita._Iuo;
            OleDbDataReader leitor = conexao.selectDR(comandSql);

            if (leitor.HasRows)
            {
                leitor.Read();

                objTipoReceita._Descricao = (string)leitor["descricao"];
                objTipoReceita._Classe = (string)leitor["classe"];
            }
            else
            {
                objTipoReceita = null;
            }
            return objTipoReceita;
        }
    }
}
