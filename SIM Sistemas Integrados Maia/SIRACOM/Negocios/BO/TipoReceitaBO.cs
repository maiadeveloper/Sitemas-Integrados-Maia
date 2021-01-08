using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.tipoReceita;
using Negocios.tipoReceitaDao;

namespace Negocios.tipoReceitaBo
{
    public class TipoReceitaBO
    {
        TipoReceitaDAO objTipoReceitaDao;

        public void InsertTipoReceitaBo(TipoReceita objTipoReceita)
        {
            objTipoReceitaDao = new TipoReceitaDAO();

            objTipoReceitaDao.InserirTipoReceita(objTipoReceita);

            MessageBox.Show("Tipo receita gravada com sucesso", "Gravação OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public TipoReceita LocalizaTipoReceita(TipoReceita objTipoReceita)
        {
            objTipoReceitaDao = new TipoReceitaDAO();

            if (objTipoReceita != null && objTipoReceita._Iuo > 0)
            {
                objTipoReceita = objTipoReceitaDao.LocalizarTipoReceita(objTipoReceita);
            }
            return objTipoReceita;
        }
    }
}
