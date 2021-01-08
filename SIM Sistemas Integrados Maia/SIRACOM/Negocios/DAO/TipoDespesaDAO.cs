using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Negocios.TIPO;
using System.Data;

namespace Negocios.DAO
{
    public class TipoDespesaDAO
    {
        ConexaoBanco conexaoBanco;
        StringBuilder sb;

        public void InserirTipoDespesa(TipoDespesa tipoDespesa)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();

            sb.Append("INSERT INTO tblTipoDespesa(NomeTipoDespesa,ClasseDespesaID)VALUES('");
            sb.Append(tipoDespesa.NomeTipoDespesa);
            sb.Append("','");
            sb.Append(tipoDespesa.ClasseDespesaID);
            sb.Append("')");

            conexaoBanco.manterCRUD(sb.ToString());
        }

        public void AlterarTipoDespesa(TipoDespesa tipoDespesa)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();

            sb.Append("UPDATE tblTipoDespesa SET ");
            sb.Append("NomeTipoDespesa = '" + tipoDespesa.NomeTipoDespesa + "',");
            sb.Append("ClasseDespesaID = '" + tipoDespesa.ClasseDespesaID + "' ");
            sb.Append("WHERE TipoDespesaID = " + tipoDespesa.TipoDespesaID);

            conexaoBanco.manterCRUD(sb.ToString());
        }

        public TipoDespesa SelecionarTipoDespesaID(int tipoDespesaID)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();
            TipoDespesa tipoDespesa = new TipoDespesa();

            sb.Append("SELECT * FROM tblTipoDespesa WHERE TipoDespesaID = " + tipoDespesaID);

            OleDbDataReader leitor = conexaoBanco.selectDR(sb.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();

                tipoDespesa.TipoDespesaID = (int)leitor["TipoDespesaID"];
                tipoDespesa.NomeTipoDespesa = (string)leitor["NomeTipoDespesa"];
                tipoDespesa.ClasseDespesaID = (int)leitor["ClasseDespesaID"];
            }
            else
            {
                tipoDespesa = null;
            }
            return tipoDespesa;
        }

        public DataTable CriaDataTableTipoDespesas(string parametro)
        {
            conexaoBanco = new ConexaoBanco();
            DataTable dt = new DataTable();
            sb = new StringBuilder();

            if (string.IsNullOrEmpty(parametro))
            {
                sb.Append(string.Format("SELECT * FROM ViewTipoDespesas order by NomeClasse ASC"));
            }
            else
            {
                sb.Append("SELECT * FROM ViewTipoDespesas WHERE NomeTipoDespesa LIKE '%" + parametro + "%' order by NomeClasse ASC");
            }

            OleDbDataReader leitor = conexaoBanco.selectDR(sb.ToString());

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

        public DataTable CriaDataTableTipoDespesas(int classeDespesaID)
        {
            conexaoBanco = new ConexaoBanco();
            DataTable dt = new DataTable();
            sb = new StringBuilder();

            if (classeDespesaID == 0)
            {
                sb.Append("SELECT * FROM tblTipoDespesa");
            }
            else
            {
                sb.Append("SELECT * FROM tblTipoDespesa WHERE ClasseDespesaID =" + classeDespesaID);
            }

            OleDbDataReader leitor = conexaoBanco.selectDR(sb.ToString());

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
    }
}
