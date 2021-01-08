using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using System.Data;
using System.Data.OleDb;

namespace Negocios.DAO
{
    public class ItemTipoRecebimentoVendaDAO
    {
        public void Gravar(ItemTipoRecebimentoVenda itemTRV)
        {
            StringBuilder sb = new StringBuilder();

            ConexaoBanco conexao = new ConexaoBanco();

            sb.Append("INSERT INTO tblItemTipoRecebimentoVenda(vendaID,dataHora,item,formaRecebimento,vlrPago)VALUES('");
            sb.Append(itemTRV._VendaID);
            sb.Append("','");
            sb.Append(itemTRV.DataHora);
            sb.Append("','");
            sb.Append(itemTRV._Item);
            sb.Append("','");
            sb.Append(itemTRV._FormaRecebimento);
            sb.Append("','");
            sb.Append(itemTRV._VlrPago);
            sb.Append("')");
            conexao.manterCRUD(sb.ToString());
        }

        public DataTable CriaDataTableSelecionaItemVendaFormaRecebimenoto(int codigo)
        {
            ConexaoBanco conexao = new ConexaoBanco();

            DataTable dt = new DataTable();
            StringBuilder sb = new StringBuilder();

            sb.Append(string.Format("SELECT * FROM tblItemTipoRecebimentoVenda WHERE vendaID = {0}", codigo));

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

        public DataSet RetornaDataSetItemVendaFormaRecebimento(DateTime dataInicial, DateTime dataFinal)
        {
            ConexaoBanco conexao = new ConexaoBanco();
            OleDbCommand cmd = new OleDbCommand("", conexao.conectar());
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataSet ds = new DataSet();

            cmd.CommandText = "SELECT * FROM tblItemTipoRecebimentoVenda " +
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
