using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios
{
    public class CadastroClientes
    {
        string Nome, End_Nome_Rua, Bairro, Obs, Telefone_Fixo, Telefone_Celular, Complemento, Cidade, Estado, Sexo, CPF, Cep, Email;
        DateTime DataNasc;
        int End_Numero, CodigoCliente;
        private string razaoSocial;

        public string _RazaoSocial
        {
            get { return razaoSocial; }
            set { razaoSocial = value; }
        }
        private string inscMunicipal;

        public string _InscMunicipal
        {
            get { return inscMunicipal; }
            set { inscMunicipal = value; }
        }
        private string inscEstadual;

        public string _InscEstadual
        {
            get { return inscEstadual; }
            set { inscEstadual = value; }
        }
        private string cnpj;

        public string _Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public string _Cep
        {
            get { return Cep; }
            set { Cep = value; }
        }

        public string _Email
        {
            get { return Email; }
            set { Email = value; }
        }

        public string _CPF
        {
            get { return CPF; }
            set { CPF = value; }
        }

        public string _Sexo
        {
            get { return Sexo; }
            set { Sexo = value; }
        }

        public string _Estado
        {
            get { return Estado; }
            set { Estado = value; }
        }

        public string _Cidade
        {
            get { return Cidade; }
            set { Cidade = value; }
        }

        public string _Complemento
        {
            get { return Complemento; }
            set { Complemento = value; }
        }

        public DateTime _DataNasc
        {
            get { return DataNasc; }
            set { DataNasc = value; }
        }

        public int _CodigoCliente
        {
            get { return CodigoCliente; }
            set { CodigoCliente = value; }
        }

        public string _Nome
        {
            get { return Nome; }
            set { Nome = value; }
        }

        public string _End_Nome_Rua
        {
            get { return End_Nome_Rua; }
            set { End_Nome_Rua = value; }
        }

        public string _Bairro
        {
            get { return Bairro; }
            set { Bairro = value; }
        }

        public string _Obs
        {
            get { return Obs; }
            set { Obs = value; }
        }

        public int _End_Numero
        {
            get { return End_Numero; }
            set { End_Numero = value; }
        }

        public string _Telefone_Fixo
        {
            get { return Telefone_Fixo; }
            set { Telefone_Fixo = value; }
        }

        public string _Telefone_Celular
        {
            get { return Telefone_Celular;}
            set { Telefone_Celular = value; }
        }

        private string telefoneCelular1;

        public string _TelefoneCelular1
        {
            get { return telefoneCelular1; }
            set { telefoneCelular1 = value; }
        }

        private string rg;

        public string _Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        private string site;

        public string _Site
        {
            get { return site; }
            set { site = value; }
        }
        private string contato;

        public string _Contato
        {
            get { return contato; }
            set { contato = value; }
        }

        string tipoPessoa;

        public string _TipoPessoa
        {
            get { return tipoPessoa; }
            set { tipoPessoa = value; }
        }
    }
}
