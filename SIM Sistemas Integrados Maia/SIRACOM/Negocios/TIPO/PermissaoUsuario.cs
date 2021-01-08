using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.TIPO
{
    public class PermissaoUsuario
    {
        public int CodPermissao { get; set; }
        public int CodigoUsuario { get; set; }
        public DateTime DataHora { get; set; }
        public bool Alterar { get; set; }
        public bool Excluir { get; set; }
        public bool Incluir { get; set; }
    }
}
