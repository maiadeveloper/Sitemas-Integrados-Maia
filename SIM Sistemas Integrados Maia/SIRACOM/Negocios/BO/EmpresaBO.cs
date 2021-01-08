using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using Negocios.DAO;
using System.Data;

namespace Negocios.BO
{
    public class EmpresaBO
    {
        EmpresaDAO empresaDao;

        public Empresa SelecionaUltimoRegistroEmpresa()
        {
            empresaDao = new EmpresaDAO();
            return empresaDao.SelecionaUltimoRegistroEmpresa();
        }

        public void AlterarLogoEmpresa(Empresa empresa)
        {
            empresaDao = new EmpresaDAO();
            empresaDao.AlterarLogoEmpresa(empresa);
        }

        public void AlterarConfirmaImpressao(Empresa empresa)
        {
            empresaDao = new EmpresaDAO();
            empresaDao.AlterarConfirmaImpressao(empresa);
        }

        public void AlterarEmpresa(Empresa empresa)
        {
            empresaDao = new EmpresaDAO();
            empresaDao.AlterarEmpresa(empresa);
        }

        public void AlterarQtdeImpressaoRecibo(Empresa empresa)
        {
            empresaDao = new EmpresaDAO();
            empresaDao.AlterarQtdeImpressaoRecibo(empresa);
        }

        public DataTable CriaDataTableEmpresa()
        {
            empresaDao = new EmpresaDAO();
            return empresaDao.CriaDataTableEmpresa();
        }
    }
}
