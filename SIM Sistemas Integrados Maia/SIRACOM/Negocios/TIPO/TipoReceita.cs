using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.tipoReceita
{
    public class TipoReceita
    {
        private int iuo;

        public int _Iuo
        {
            get { return iuo; }
            set { iuo = value; }
        }
        private string descricao;

        public string _Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        private string classe;

        public string _Classe
        {
            get { return classe; }
            set { classe = value; }
        }
    }
}
