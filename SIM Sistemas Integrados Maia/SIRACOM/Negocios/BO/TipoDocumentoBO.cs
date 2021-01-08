using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.DAO;
using System.Data;
using Negocios.TIPO;

namespace Negocios.BO
{
    public class TipoDocumentoBO
    {
        TipoDocumentoDAO tipoDocumentoDAO;

        public DataTable CriaDataTableTipoDocumento(string parametro)
        {
            tipoDocumentoDAO = new TipoDocumentoDAO();
            return tipoDocumentoDAO.CriaDataTableTipoDocumento(parametro);
        }

        public TipoDocumento SelecionarTipoDocumentoID(int tipoDocumentoID)
        {
            tipoDocumentoDAO = new TipoDocumentoDAO();
            return tipoDocumentoDAO.SelecionarTipoDocumentoID(tipoDocumentoID);
        }
    }
}
