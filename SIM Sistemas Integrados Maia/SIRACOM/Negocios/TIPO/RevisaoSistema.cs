using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.TIPO
{
    public class RevisaoSistema
    {
        int revisaoCod;

        public int _RevisaoCod
        {
            get { return revisaoCod; }
            set { revisaoCod = value; }
        }
        DateTime dataHora;

        public DateTime _DataHora
        {
            get { return dataHora; }
            set { dataHora = value; }
        }
        string modulo;

        public string _Modulo
        {
            get { return modulo; }
            set { modulo = value; }
        }
        string funcionalidade;

        public string _Funcionalidade
        {
            get { return funcionalidade; }
            set { funcionalidade = value; }
        }
        string descricao;

        public string _Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        string situacao;

        public string _Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }
    }
}
