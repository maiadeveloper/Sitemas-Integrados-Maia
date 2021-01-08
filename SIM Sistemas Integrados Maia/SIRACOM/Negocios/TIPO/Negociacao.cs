using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.TIPO
{
    public class Negociacao
    {
        public int Id { get; set; }

        public int ClienteId { get; set; }

        public string NumParcela { get; set; }

        public string NumDocRelacionado { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime DataVencimento { get; set; }

        public decimal VlrParcela { get; set; }

        public string Situacao { get; set; }
    }
}
