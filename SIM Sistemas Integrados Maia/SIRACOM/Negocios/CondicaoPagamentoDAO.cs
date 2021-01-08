using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.Tipos;
using System.Data.OleDb;

namespace Negocios.DAO
{
    public class CondicaoPagamentoDAO
    {
        StringBuilder sql = new StringBuilder();
        OleDbCommand cmd = new OleDbCommand();

        ConexaoBanco conexao = new ConexaoBanco();

        public CodicaoPagamento RecuperaNparcelaCodicaoPagamento(CodicaoPagamento codicaoPagamento)
        {
            sql.Remove(0, sql.Length);
            cmd.Parameters.Clear();

            sql.Append("SELECT * FROM tblCondicaoPagamento WHERE codigo = " + codicaoPagamento._Iuo);

            OleDbDataReader dr = conexao.selectDR(sql.ToString());

            if (dr.HasRows)
            {
                dr.Read();
                codicaoPagamento._NumeroParcela = (int)dr["nParcela"];
            }
            else
            {
                codicaoPagamento = null;
            }
            dr.Close();
            return codicaoPagamento;
        }
    }
}
