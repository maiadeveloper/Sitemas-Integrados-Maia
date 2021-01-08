using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.TIPO
{
    public class ItemTipoRecebimentoVenda
    {
        int itemTipoRecebimentoVendaID;

        public int _ItemTipoRecebimentoVendaID
        {
            get { return itemTipoRecebimentoVendaID; }
            set { itemTipoRecebimentoVendaID = value; }
        }
        int vendaID;

        public int _VendaID
        {
            get { return vendaID; }
            set { vendaID = value; }
        }
        int item;

        public int _Item
        {
            get { return item; }
            set { item = value; }
        }
        string formaRecebimento;

        public string _FormaRecebimento
        {
            get { return formaRecebimento; }
            set { formaRecebimento = value; }
        }
        decimal vlrPago;

        public decimal _VlrPago
        {
            get { return vlrPago; }
            set { vlrPago = value; }
        }

        public DateTime DataHora { get; set; }
    }
}
