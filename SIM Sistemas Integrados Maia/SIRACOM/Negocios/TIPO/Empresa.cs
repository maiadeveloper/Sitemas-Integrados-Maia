using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.TIPO
{
    public class Empresa
    {
        int idEmpresa;
        string nomeFantasia;
        string razaoSocial;
        string serialLiberacao;
        string cnpj_cpf;
        string logoEmpresa;
        string bairro;

        public string _Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }
        string rua;

        public string _Rua
        {
            get { return rua; }
            set { rua = value; }
        }
        int numero;

        public int _Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        string slogan;

        public string _Slogan
        {
            get { return slogan; }
            set { slogan = value; }
        }
        string email;

        public string _Email
        {
            get { return email; }
            set { email = value; }
        }
        string fone;

        public string _Fone
        {
            get { return fone; }
            set { fone = value; }
        }

        public string _Cep
        {
            get;
            set;
        }

        public string _UF
        {
            get;
            set;
        }

        public string _Cidade
        {
            get;
            set;
        }

        public string _LogoEmpresa
        {
            get { return logoEmpresa; }
            set { logoEmpresa = value; }
        }
        DateTime dataExpirar;
        DateTime dataCadastro;

        public int _IdEmpresa
        {
            get { return idEmpresa; }
            set { idEmpresa = value; }
        }

        public string _NomeFantasia
        {
            get { return nomeFantasia; }
            set { nomeFantasia = value; }
        }

        public string _RazaoSocial
        {
            get { return razaoSocial; }
            set { razaoSocial = value; }
        }

        public string _SerialLiberacao
        {
            get { return serialLiberacao; }
            set { serialLiberacao = value; }
        }

        public string _CnpjCpf
        {
            get { return cnpj_cpf; }
            set { cnpj_cpf = value; }
        }

        public DateTime _DataExpirar
        {
            get { return dataExpirar; }
            set { dataExpirar = value; }
        }

        public DateTime DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }

        public string _Status
        {
            get;
            set;
        }

        public int QtdeImpressaoRecibo { get; set; }

        public int ConfirmaImpressao { get; set; }
    }
}
