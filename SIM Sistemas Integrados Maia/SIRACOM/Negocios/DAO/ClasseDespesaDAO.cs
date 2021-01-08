using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using System.Data.OleDb;
using System.Data;

namespace Negocios.DAO
{
    public class ClasseDespesaDAO
    {
        ConexaoBanco conexaoBanco;
        StringBuilder sb;

        public void InserirClasseDespesa(ClasseDespesa classeDespesa)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();

            sb.Append("INSERT INTO tblClasseDespesa(NomeClasse)VALUES('");
            sb.Append(classeDespesa.NomeClasse);
            sb.Append("')");

            conexaoBanco.manterCRUD(sb.ToString());
        }

        public void AlterarClasseDespesa(ClasseDespesa classeDepesa)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();

            sb.Append("UPDATE tblClasseDespesa SET ");
            sb.Append("NomeClasse = '" + classeDepesa.NomeClasse + "' ");
            sb.Append("WHERE ClasseDespesaID = " + classeDepesa.ClasseDespesaID);

            conexaoBanco.manterCRUD(sb.ToString());
        }

        public ClasseDespesa SelecionarClasseDespesaID(int classeDespesaID)
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();
            ClasseDespesa classeDespesa = new ClasseDespesa();

            sb.Append("SELECT * FROM tblClasseDespesa WHERE ClasseDespesaID = " + classeDespesaID);

            OleDbDataReader leitor = conexaoBanco.selectDR(sb.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();

                classeDespesa.ClasseDespesaID = (int)leitor["ClasseDespesaID"];
                classeDespesa.NomeClasse = (string)leitor["NomeClasse"];
            }
            else
            {
                classeDespesa = null;
            }
            return classeDespesa;
        }

        public IList<ClasseDespesa> RetornaListaClasseDespesas()
        {
            conexaoBanco = new ConexaoBanco();
            sb = new StringBuilder();
            ClasseDespesa classeDespesa = new ClasseDespesa();

            sb.Append("SELECT * FROM tblClasseDespesa");

            OleDbDataReader dr = conexaoBanco.selectDR(sb.ToString());
            IList<ClasseDespesa> classeDespesas = new List<ClasseDespesa>();

            //Verifica se tem linha
            if (dr.HasRows)
            {
                //Ler as linhas
                while (dr.Read())
                {
                    classeDespesa.ClasseDespesaID = (int)dr["ClasseDespesaID"];
                    classeDespesa.NomeClasse = (string)dr["NomeClasse"];

                    classeDespesas.Add(classeDespesa);
                }
            }
            else
            {
                classeDespesas = null;
            }

            //Fecha a conexao
            dr.Close();

            //retorna uma lista
            return classeDespesas;
        }

        public DataTable CriaDataTableClasseDepesas(string parametro)
        {
            conexaoBanco = new ConexaoBanco();
            DataTable dt = new DataTable();
            sb = new StringBuilder();

            if (string.IsNullOrEmpty(parametro))
            {
                sb.Append(string.Format("SELECT * FROM tblClasseDespesa ORDER BY NomeClasse ASC"));
            }
            else
            {
                sb.Append("SELECT * FROM tblClasseDespesa WHERE NomeClasse LIKE '%" + parametro + "%' ORDER BY NomeClasse ASC");
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
