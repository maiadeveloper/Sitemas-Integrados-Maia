using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios
{
    public class CadastroFornecedores
    {
        string Razao_Social, Endereco_Rua, Bairro, Cidade, UF, CEP, TelefoneResidencial, TelefoneCelular, Obs, Nome_Fantasia, Fax, CNPJ, Incr_Estadual, Email, Representante, Endereco_Numero;
        int CodigoFornecedor;
        DateTime DataCadastro;

        public string _Representante
        {
            get { return Representante; }
            set { Representante = value; }
        }

        public string _Email
        {
            get { return Email; }
            set { Email = value; }
        }

        public string _Incr_Estadual
        {
            get { return Incr_Estadual; }
            set { Incr_Estadual = value; }
        }

        public string _CNPJ
        {
            get { return CNPJ; }
            set { CNPJ = value; }
        }

        public string _Fax
        {
            get { return Fax; }
            set { Fax = value; }
        }

        public string _Razao_Social
        {
            get { return Razao_Social; }
            set { Razao_Social = value; }
        }

        public int _CodigoFornecedor
        {
            get { return CodigoFornecedor; }
            set { CodigoFornecedor = value; }
        }


        public string _Nome_Fantasia
        {
            get { return Nome_Fantasia; }
            set { Nome_Fantasia = value; }
        }

        public DateTime _DataCadastro
        {
            get { return DataCadastro; }
            set { DataCadastro = value; }
        }

        public string _Endereco_Rua
        {
            get { return Endereco_Rua; }
            set { Endereco_Rua = value; }
        }

        public string _Endereco_Numero
        {
            get { return Endereco_Numero; }
            set { Endereco_Numero = value; }
        }

        public string _Bairro
        {
            get { return Bairro; }
            set { Bairro = value; }
        }

        public string _Cidade
        {
            get { return Cidade; }
            set { Cidade = value; }
        }

        public string _UF
        {
            get { return UF; }
            set { UF = value; }
        }

        public string _CEP
        {
            get { return CEP; }
            set { CEP = value; }
        }

        public string _TelefoneResidencial
        {
            get { return TelefoneResidencial; }
            set { TelefoneResidencial = value; }
        }

        public string _TelefoneCelular
        {
            get { return TelefoneCelular; }
            set { TelefoneCelular = value; }
        }

        public string _Obs
        {
            get { return Obs; }
            set { Obs = value; }
        }                        
    }
}
