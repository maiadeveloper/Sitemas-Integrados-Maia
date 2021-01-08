using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios
{
    public class CadastroUsuarios
    {
        DateTime DataCadastro;
        string SenhaUsuario, NomeUsuario;
        int CodigoUsuario;

        public int _CodigoUsuario
        {
            get { return CodigoUsuario; }
            set { CodigoUsuario = value; }
        }

        public DateTime _DataCadastro
        {
            get { return DataCadastro; }
            set { DataCadastro = value; }
        }

        public string _SenhaUsuario
        {
            get { return SenhaUsuario; }
            set { SenhaUsuario = value; }
        }

        public string _NomeUsuario
        {
            get { return NomeUsuario; }
            set { NomeUsuario = value; }
        }

        public string TipoUsuario { get; set; }

        public bool Ativo { get; set; }
    }
}
