using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.TIPO
{
    public class ItensOrcamento
    {
        int itemOrcamentoID;

        public int _ItemOrcamentoID
        {
            get { return itemOrcamentoID; }
            set { itemOrcamentoID = value; }
        }
        int item;

        public int _Item
        {
            get { return item; }
            set { item = value; }
        }
        int qtde;

        public int _Qtde
        {
            get { return qtde; }
            set { qtde = value; }
        }
        decimal vlorUnitario;

        public decimal _VlorUnitario
        {
            get { return vlorUnitario; }
            set { vlorUnitario = value; }
        }
        decimal total;

        public decimal _Total
        {
            get { return total; }
            set { total = value; }
        }
        int orcamentoID;

        public int _OrcamentoID
        {
            get { return orcamentoID; }
            set { orcamentoID = value; }
        }
        int produtoID;

        public int _ProdutoID
        {
            get { return produtoID; }
            set { produtoID = value; }
        }
    }
}
