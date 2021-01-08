using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using System.Data.OleDb;
using System.Data;

namespace Negocios.DAO
{
    public class BancoDAO
    {
        ConexaoBanco conexaoBanco;
        StringBuilder sb;

        public Banco SelecionaBancoCaixaEmpresa()
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();

            Banco banco = new Banco();

            sb.Append("SELECT * FROM tblBanco WHERE NomeBanco = 'CAIXA EMPRESA'");

            OleDbDataReader leitor = conexaoBanco.selectDR(sb.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();

                banco.BancoID = (int)leitor["BancoID"];
                banco.NomeBanco = (string)leitor["NomeBanco"];
            }
            else
            {
                banco = null;
            }

            leitor.Close();

            return banco;
        }
    }
}
