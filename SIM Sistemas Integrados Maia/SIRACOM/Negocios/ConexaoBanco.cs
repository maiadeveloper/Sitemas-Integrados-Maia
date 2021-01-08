using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Negocios
{
    public class ConexaoBanco
    {
        static string exeLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Remove(0, 6);

        //string conexaoString = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + exeLocation + "\\Dados\\BancoSirad_luismaia.accdb");
        string conexaoString = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source =" + exeLocation + "\\Dados\\BancoSirad.accdb");
 
        public OleDbConnection conectarLogin()
        {   
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            conexao.Open();
            return conexao;
        }

        public OleDbConnection conectar()
        {
            OleDbConnection conexao = new OleDbConnection(conexaoString);
            return conexao;
        }

        public void manterCRUD(string sql)
        {
            OleDbConnection con = conectar();
            OleDbCommand comando = new OleDbCommand(sql, con);
            con.Open();
            comando.ExecuteNonQuery();
            con.Close();
        }

         public OleDbDataReader select(string sql)
        {
            OleDbConnection con = conectar();
            OleDbCommand comando = new OleDbCommand(sql, con);
            con.Open();

            OleDbDataReader leitor = comando.ExecuteReader(CommandBehavior.CloseConnection);

            return leitor;
        }

        public OleDbDataReader selectDR(string sql)
        {
            //Montar string de conexão
            OleDbConnection con = conectar();

            //Cria um DataReader para ser usado no retorno do método
            OleDbDataReader leitor = null;

            try
            {
                OleDbCommand comando = new OleDbCommand(sql, con);
                con.Open();
                leitor = comando.ExecuteReader(); // Executa o comando do Sql e retorna um objto do Reader
            }
            catch (Exception)
            {        
            }
            return leitor; // Retorna 
        }  //Método  para executa um Sql(Select) retorna um DataSet
      
        public  DataSet selectDS(string sql)
        {
            OleDbConnection con = conectar();

            DataSet ds = new DataSet();//Cria um DataSet para  ser usado     no retorno do metodo

            try
            {
                OleDbCommand comando = new OleDbCommand(sql, con);
                con.Open();
                //Cria um objeto DataAdapter com o Comando SQL e Conexão    
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(comando);

                dataAdapter.Fill(ds); //Executa a SQL e preenche o DataSet
            }
            catch (Exception e)
            {
                throw new ArgumentException("Erro select - " + e.Message);
            }
            finally
            {
                con.Close();
            }
            return ds;
        }
    }//Fim Classe
 }
