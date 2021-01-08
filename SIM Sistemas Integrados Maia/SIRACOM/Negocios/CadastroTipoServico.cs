using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios
{
    public class CadastroTipoServico
    {
        int CodigoServico;
        string Descricao;
        decimal Valor;

        public int _CodigoServico
        {
            get { return CodigoServico; }
            set { CodigoServico = value; }
        }
        
        public string _Descricao
        {
            get { return Descricao; }
            set { Descricao = value; }
        }

        public decimal _Valor
        {
            get { return Valor; }
            set { Valor = value; }
        }
    }
}
