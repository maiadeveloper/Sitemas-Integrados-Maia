using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using System.Data.OleDb;
using System.Data;

namespace Negocios.DAO
{
    public class ItemContaReceberFormaRecebimentoDAO
    {
        StringBuilder sb;

        public void Gravar(ItemContaReceberFormaRecebimento itemRCFR)
        {
            sb = new StringBuilder();
            ConexaoBanco conexao = new ConexaoBanco();

            sb.Append("INSERT INTO tblItemConta_a_Receber_FormaRecebimento(itemContarReceberID,item,formaRecebimento,vlrPago,dataHora)VALUES('");
            sb.Append(itemRCFR._ItenContaReceber._ItemContaReceberID);
            sb.Append("','");
            sb.Append(itemRCFR._Item);
            sb.Append("','");
            sb.Append(itemRCFR._FormaRecebimento);
            sb.Append("','");
            sb.Append(itemRCFR._VlrPago);
            sb.Append("','");
            sb.Append(itemRCFR._DataHora);
            sb.Append("')");
            conexao.manterCRUD(sb.ToString());
        }

        public void ExcluirItemFormaRecebimentoContaReceber(int itemContarReceberID)
        {
            sb = new StringBuilder();
            ConexaoBanco conexao = new ConexaoBanco();

            sb.Append("DELETE FROM tblItemConta_a_Receber_FormaRecebimento WHERE itemContarReceberID = " + itemContarReceberID);
            conexao.manterCRUD(sb.ToString());
        }

        public void ExcluirItemFormaRecebimentoContaReceberId(int itemContarReceberFRID)
        {
            sb = new StringBuilder();
            ConexaoBanco conexao = new ConexaoBanco();

            sb.Append("DELETE FROM tblItemConta_a_Receber_FormaRecebimento WHERE itemContaReceberFRID = " + itemContarReceberFRID);
            conexao.manterCRUD(sb.ToString());
        }
        public ItemContaReceberFormaRecebimento SelecionarItemFormaRecebimentoId(int itemContarReceberID)
        {
            ConexaoBanco conexao = new ConexaoBanco();
            sb = new StringBuilder();
            ItemContaReceberFormaRecebimento itemContaFR = new ItemContaReceberFormaRecebimento();

            sb.Append("SELECT * FROM tblItemConta_a_Receber_FormaRecebimento WHERE itemContarReceberID = " + itemContarReceberID);

            OleDbDataReader leitor = conexao.selectDR(sb.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();

                itemContaFR._ItemContaReceberFRID = (int)leitor["itemContaReceberFRID"];
                itemContaFR._ItenContaReceber._ItemContaReceberID = (int)leitor["itemContarReceberID"];
                itemContaFR._DataHora = (DateTime)leitor["dataHora"];
                itemContaFR._Item = (int)leitor["Item"];
                itemContaFR._FormaRecebimento = (string)leitor["formaRecebimento"];
                itemContaFR._VlrPago = (decimal)leitor["vlrPago"];
            }
            else
            {
                itemContaFR = null;
            }

            leitor.Close();

            return itemContaFR;
        }


        public DataTable CriaDataTableSelecionaItemContasReceberFormaRecebimenoto(int codigo)
        {
            ConexaoBanco conexao = new ConexaoBanco();

            DataTable dt = new DataTable();
            sb = new StringBuilder();

            sb.Append(string.Format("SELECT * FROM tblItemConta_a_Receber_FormaRecebimento WHERE itemContarReceberID = {0}", codigo));

            OleDbDataReader leitor = conexao.selectDR(sb.ToString());

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

        public DataSet RetornaDataSetContaReceberFormaRecebimento(DateTime dataInicial, DateTime dataFinal)
        {
            ConexaoBanco conexao = new ConexaoBanco();
            OleDbCommand cmd = new OleDbCommand("", conexao.conectar());
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataSet ds = new DataSet();

            cmd.CommandText = "SELECT * FROM tblItemConta_a_Receber_FormaRecebimento " +
                              "WHERE (dataHora BETWEEN ? and ?)";

            cmd.Parameters.Add("DateIncial", OleDbType.Date);
            cmd.Parameters.Add("DateFinal", OleDbType.Date);

            cmd.Parameters["DateIncial"].Direction = ParameterDirection.Input;
            cmd.Parameters["DateFinal"].Direction = ParameterDirection.Input;

            cmd.Parameters["DateIncial"].Value = dataInicial.ToString("dd/MM/yyyy");
            cmd.Parameters["DateFinal"].Value = dataFinal.ToString("dd/MM/yyyy");

            da.SelectCommand = cmd;

            da.Fill(ds);

            return ds;
        }
    }
}
