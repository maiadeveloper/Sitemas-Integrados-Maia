using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.TIPO
{
    public class Orcamento
    {
        int orcamentoID;

        public int _OrcamentoID
        {
            get { return orcamentoID; }
            set { orcamentoID = value; }
        }
        DateTime dataHoraAbertura;

        public DateTime _DataHoraAbertura
        {
            get { return dataHoraAbertura; }
            set { dataHoraAbertura = value; }
        }
        decimal vlrDesconto;

        public decimal _VlrDesconto
        {
            get { return vlrDesconto; }
            set { vlrDesconto = value; }
        }
        decimal vlrTotal;

        public decimal _VlrTotal
        {
            get { return vlrTotal; }
            set { vlrTotal = value; }
        }
        int status;

        public int _Status
        {
            get { return status; }
            set { status = value; }
        }

        int clienteID;

        public int _ClienteID
        {
            get { return clienteID; }
            set { clienteID = value; }
        }
        int numeroVenda;

        public int _NumeroVenda
        {
            get { return numeroVenda; }
            set { numeroVenda = value; }
        }
    }
}
