using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using Negocios.DAO;
using System.Data;

namespace Negocios.BO
{
    public  class BaixaTiposBO
    {
        BaixaTiposDAO baixaTipos;

        public DataTable CriaDataTableTipoDocumento(string parametro)
        {
            baixaTipos = new BaixaTiposDAO();
            return baixaTipos.CriaDataTableBaixaTipos(parametro);
        }
    }
}
