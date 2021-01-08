using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.manterBancoDao;
using Negocios.manterBancoTipo;
using System.Data;
using System.Data.OleDb;


namespace Negocios.manterBancoBo
{
    public class ManterBancoBO
    {
        ManterBancoDAO objBancoDao;

        /// <summary>
        /// Método gravarBanco
        /// </summary>
        /// <param name="objBancoTipo">é criado objeto da classe ManterBancoTipo</param>
        public void GravarBanco(ManterBancoTipo objBancoTipo)
        {
            objBancoDao = new ManterBancoDAO();

            if (objBancoTipo._NomeBanco != string.Empty)
            {
                objBancoDao.InsertBanco(objBancoTipo);
            }
        }

        public DataTable CriaDataTableBanco(string parametro)
        {
            objBancoDao = new ManterBancoDAO();
            return objBancoDao.CriaDataTableBanco(parametro);
        }

        public DataTable PopularBanco()
        {
            objBancoDao = new ManterBancoDAO();
            return objBancoDao.PopularBanco();
        }
    }
}
