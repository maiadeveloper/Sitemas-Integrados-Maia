using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.TIPO
{
     public class ItemContaReceberFormaRecebimento
    {
        int itemContaReceberFRID;

        public int _ItemContaReceberFRID
        {
            get { return itemContaReceberFRID; }
            set { itemContaReceberFRID = value; }
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

         private DateTime dataHora;

         public DateTime _DataHora
         {
             get { return dataHora; }
             set { dataHora = value; }
         }


         ItemContaReceber m_ItenContaReceber;

         public ItemContaReceber _ItenContaReceber
         {
             get { return m_ItenContaReceber; }
             set { m_ItenContaReceber = value; }
         }

         public ItemContaReceberFormaRecebimento()
         {
             m_ItenContaReceber = new ItemContaReceber();
         }
    }
}
