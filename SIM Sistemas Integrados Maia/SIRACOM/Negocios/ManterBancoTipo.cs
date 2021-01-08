using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.manterBancoTipo
{
    public class ManterBancoTipo
    {
        int iuo;
        string nomeBanco;
        string dataCadastro;

        public int _Iuo
        {
            get { return iuo; }
            set { iuo = value; }
        }

        public string _NomeBanco
        {
            get { return nomeBanco; }
            set { nomeBanco = value; }
        }

        public string _DataCadastro
        {
            get { return dataCadastro; }
            set { dataCadastro = value; }
        }
    }
}
