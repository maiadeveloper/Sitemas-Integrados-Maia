using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using Negocios;
using System.Data.OleDb;


namespace Negocios.DAO
{
    public class ItensOrcamentoDAO
    {
        StringBuilder sb;
        ConexaoBanco conexaoBanco;

        public void Gravar(ItensOrcamento itensOrcamento)
        {
            sb = new StringBuilder();
            conexaoBanco = new ConexaoBanco();

            sb.Append("INSERT INTO tblItensOrcamento(orcamentoID,produtoID,item,qtde,vlorUnitario,total)VALUES('");
            sb.Append(itensOrcamento._OrcamentoID);
            sb.Append("','");
            sb.Append(itensOrcamento._ProdutoID);
            sb.Append("','");
            sb.Append(itensOrcamento._Item);
            sb.Append("','");
            sb.Append(itensOrcamento._Qtde);
            sb.Append("','");
            sb.Append(itensOrcamento._VlorUnitario);
            sb.Append("','");
            sb.Append(itensOrcamento._Total);
            sb.Append("')");

            conexaoBanco.manterCRUD(sb.ToString());
        }

        public OleDbDataAdapter SelecionaOrcamentoPorID(int orcamentoID)
        {
            conexaoBanco = new ConexaoBanco();
            OleDbDataAdapter da;
            da = new OleDbDataAdapter("SELECT * FROM ViewItensOrcamento WHERE orcamentoID = " + orcamentoID, conexaoBanco.conectar());
            return da;
        }
    }
}
