using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.TIPO
{
    public class LancamentosBaixas
    {
        public int LancamentoBaixaID
        {
            get;
            set;
        }

        public int LancamentoID
        {
            get;
            set;
        }

        public int NumParcela
        {
            get;
            set;
        }

        public int Item
        {
            get;
            set;
        }

        public int ContaID
        {
            get;
            set;
        }

        public DateTime DataBaixa
        {
            get;
            set;
        }

        public decimal VlorBaixa
        {
            get;
            set;
        }

        public string Descricao
        {
            get;
            set;
        }

        public int BaixaTipoID
        {
            get;
            set;
        }
    }
}
