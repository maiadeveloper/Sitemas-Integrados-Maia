using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios
{
    public class CadastroFuncionarios
    {
        DateTime DataCadastro;
        string Nome, Mes, Endereco_Rua, Bairro, Estado, Cidade, Telefone_Fixo, Telefone_Residencial, Obs, Cep, foto;

        public string _Foto
        {
            get { return foto; }
            set { foto = value; }
        }
        int Dia, Ano, Endereco_Numero, CodigoLavador;

        public int _CodigoLavador
        {
            get { return CodigoLavador; }
            set { CodigoLavador = value; }
        }

        public DateTime _DataCadastro
        {
            get { return DataCadastro; }
            set { DataCadastro = value; }
        }
   
       public string _Nome
       {
           get { return Nome; }
           set { Nome = value; }
       }

       public string _Mes
       {
           get { return Mes; }
           set { Mes = value; }
       }

       public string _Endereco_Rua
       {
           get { return Endereco_Rua; }
           set { Endereco_Rua = value; }
       }

       public string _Bairro
       {
           get { return Bairro; }
           set { Bairro = value; }
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

       public string _Telefone_Fixo
       {
           get { return Telefone_Fixo; }
           set { Telefone_Fixo = value; }
       }

       public string _Telefone_Residencial
       {
           get { return Telefone_Residencial; }
           set { Telefone_Residencial = value; }
       }

       public string _Obs
       {
           get { return Obs; }
           set { Obs = value; }
       }

       public string _Cep
       {
           get { return Cep; }
           set { Cep = value; }
       }

       public int _Dia
       {
           get { return Dia; }
           set { Dia = value; }
       }

       public int _Ano
       {
           get { return Ano; }
           set { Ano = value; }
       }

       public int _Endereco_Numero
       {
           get { return Endereco_Numero; }
           set { Endereco_Numero = value; }
       }
               
    }
}
