using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;

namespace Negocios
{
    public class CadastroClientesDAO
    {
        ConexaoBanco conexao = new ConexaoBanco();
        public string comandSql;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="cdClientes"></param>
        public void insertCliente(CadastroClientes cdClientes)
        {
            comandSql = "INSERT INTO tblCliente(TipoPessoa,NomeFantasia,RazaoSobreNome,CpfCnpj,Rua,Numero,Bairro,Complemento,Cidade,Estado,Cep,Telefone01,Telefone02,Email)VALUES('"
                + cdClientes._TipoPessoa + "','" + cdClientes._Nome + "','" + cdClientes._RazaoSocial + "','" + cdClientes._CPF + "','" + cdClientes._End_Nome_Rua
                + "','" + cdClientes._End_Numero + "','" + cdClientes._Bairro + "','" + cdClientes._Complemento + "','" + cdClientes._Cidade + "','" + cdClientes._Estado + "','"
                + cdClientes._Cep + "','" + cdClientes._TelefoneCelular1 + "','" + cdClientes._Telefone_Fixo + "','" + cdClientes._Email + "')";

            conexao.manterCRUD(comandSql);
        }

        public void AlterarDadosCliente(CadastroClientes clientes)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("UPDATE tblCliente SET ");
            sb.Append("TipoPessoa='" + clientes._TipoPessoa + "',");
            sb.Append("NomeFantasia='" + clientes._Nome + "',");
            sb.Append("RazaoSobreNome='" + clientes._RazaoSocial + "',");
            sb.Append("CpfCnpj='" + clientes._CPF + "',");
            sb.Append("Rua='" + clientes._End_Nome_Rua + "',");
            sb.Append("Numero='" + clientes._End_Numero + "',");
            sb.Append("Bairro='" + clientes._Bairro + "',");
            sb.Append("Cidade='" + clientes._Cidade + "',");
            sb.Append("Estado='" + clientes._Estado + "',");
            sb.Append("Cep='" + clientes._Cep + "',");
            sb.Append("Telefone01='" + clientes._TelefoneCelular1 + "',");
            sb.Append("Telefone02='" + clientes._Telefone_Fixo + "',");
            sb.Append("Email='" + clientes._Email + "'");
            sb.Append(" WHERE CodigoCliente =" + clientes._CodigoCliente);

            conexao.manterCRUD(sb.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cdClientes"></param>
        /// <returns></returns>
        public CadastroClientes localizar(CadastroClientes cdClientes)
        {
            comandSql = "SELECT * FROM tblCliente" + " WHERE CodigoCliente = " + cdClientes._CodigoCliente;
            OleDbDataReader leitor = conexao.selectDR(comandSql);

            if (leitor.HasRows)//Caso encontre registro na linha
            {
                leitor.Read(); // Ler o dado do registro

                cdClientes._CodigoCliente = (int)leitor["CodigoCliente"];
                cdClientes._Nome = (string)leitor["Nome"];
                cdClientes._Bairro = (string)leitor["Bairro"];
                cdClientes._Cep = (string)leitor["Cep"];
                cdClientes._Cidade = (string)leitor["Cidade"];
                cdClientes._End_Nome_Rua = (string)leitor["End_Nome_Rua"];
                cdClientes._End_Numero = (int)leitor["End_Numero"];
                cdClientes._Estado = (string)leitor["Estado"];
                cdClientes._Complemento = (string)leitor["Complemento"];
                cdClientes._Telefone_Celular = (string)leitor["Telefone_Fixo"];
                cdClientes._Telefone_Fixo = (string)leitor["Telefone_Celular"];
                cdClientes._CPF = (string)leitor["CPF"];
                cdClientes._InscEstadual = (string)leitor["InscEstadual"];
                cdClientes._RazaoSocial = (string)leitor["RazaoSocial"];
                cdClientes._Cnpj = (string)leitor["CNPJ"];
            }
            else // Caso nao encontre o arquivo
            {
                cdClientes = null;
            }
            return cdClientes;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objCliente"></param>
        /// <returns></returns>
        public CadastroClientes SelectClienteNome(CadastroClientes objCliente)
        {
            comandSql = "SELECT * FROM tblCliente WHERE Nome = '" + objCliente._Nome + "'";

            OleDbDataReader leitor = conexao.selectDR(comandSql);

            if (leitor.HasRows)
            {
                leitor.Read();
                objCliente._CodigoCliente = (int)leitor["CodigoCliente"];
            }
            else
            {
                objCliente = null;
            }
            leitor.Close();
            return objCliente;
        }


        /// <summary>
        /// Retorna um dataTable
        /// </summary>
        /// <returns></returns>
        public DataTable CriaDataTableSelecionaTodosClientes(string parametro)
        {
            conexao = new ConexaoBanco();

            DataTable dt = new DataTable();

            StringBuilder sb = new StringBuilder();

            if (string.IsNullOrEmpty(parametro))
            {
                sb.Append(string.Format("SELECT * FROM tblCliente"));
            }
            else
            {
                sb.Append("SELECT * FROM tblCliente WHERE NomeFantasia LIKE '%" + parametro + "%'");
                sb.Append(" OR RazaoSobreNome LIKE '%" + parametro + "%'");
                sb.Append(" OR CpfCnpj LIKE '%" + parametro + "%'");
                sb.Append(" OR Telefone01 LIKE '%" + parametro + "%'");
                sb.Append(" OR Telefone02 LIKE '%" + parametro + "%'");
            }

            OleDbDataReader leitor = conexao.selectDR(sb.ToString());

            if (leitor != null)
            {
                dt.Load(leitor);
            }
            else
            {
                leitor = null;
            }

            return dt;
        }

        public CadastroClientes SelecionaClientePorID(int clienteID)
        {
            comandSql = "SELECT * FROM tblCliente" + " WHERE CodigoCliente = " + clienteID;
            OleDbDataReader leitor = conexao.selectDR(comandSql);
            CadastroClientes cliente = new CadastroClientes();

            if (leitor.HasRows)//Caso encontre registro na linha
            {
                leitor.Read(); // Ler o dado do registro

                cliente._CodigoCliente = (int)leitor["CodigoCliente"];
                cliente._TipoPessoa = (string)leitor["TipoPessoa"];
                cliente._Nome = (string)leitor["NomeFantasia"];
                cliente._RazaoSocial = (string)leitor["RazaoSobreNome"];
                cliente._CPF = (string)leitor["CpfCnpj"];
                cliente._Cnpj = (string)leitor["CpfCnpj"];
                cliente._End_Nome_Rua = (string)leitor["Rua"];
                cliente._End_Numero = (int)leitor["Numero"];
                cliente._Bairro = (string)leitor["Bairro"];
                cliente._Complemento = (string)leitor["Complemento"];
                cliente._Cidade = (string)leitor["Cidade"];
                cliente._Estado = (string)leitor["Estado"];
                cliente._Cep = (string)leitor["Cep"];
                cliente._Telefone_Fixo = (string)leitor["Telefone01"];
                cliente._Telefone_Celular = (string)leitor["Telefone02"];
                cliente._Email = (string)leitor["Email"];
            }
            else // Caso nao encontre o arquivo
            {
                cliente = null;
            }
            return cliente;
        }
    }
}
