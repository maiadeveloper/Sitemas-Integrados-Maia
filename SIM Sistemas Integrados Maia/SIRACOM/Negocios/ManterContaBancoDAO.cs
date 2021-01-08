using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using Negocios.manterContaBanco;

namespace Negocios.manterContaBancoDao
{
    public class ManterContaBancoDAO
    {
        ConexaoBanco conexao = new ConexaoBanco();
        public string comandSql;

        public void InserirContaBanco(ManterContaBanco objManterContaBanco)
        {

        }

        public ManterContaBanco SelecionaContaBanco(ManterContaBanco objManterContaBanco)
        {
            comandSql = "SELECT * FROM tblContasBanco WHERE Senha = '" + objManterContaBanco._Senha + "'";

            OleDbDataReader leitor = conexao.selectDR(comandSql);

            if (leitor.HasRows)
            {
                leitor.Read();

                objManterContaBanco._UsuarioConta = (string)leitor["UserConta"];
                objManterContaBanco._Banco = (string)leitor["Banco"];
                objManterContaBanco._Conta = (string)leitor["TipoConta"];
                objManterContaBanco._Agencia = (string)leitor["Agencia"];
                objManterContaBanco._Conta = (string)leitor["Conta"];
            }
            else
            {
                objManterContaBanco = null;
            }
            return objManterContaBanco;
        }
    }
}
