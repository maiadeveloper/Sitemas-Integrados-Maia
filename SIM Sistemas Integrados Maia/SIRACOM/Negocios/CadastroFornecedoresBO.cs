using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios;
using System.Data;

namespace Negocios
{
    public class CadastroFornecedoresBO
    {
        CadastroFornecedoresDAO cadastroFornecedoresDao = new CadastroFornecedoresDAO();

        public CadastroFornecedores SelecionaFornecedores(CadastroFornecedores cadastroFornecedores)
        {
            if (cadastroFornecedores != null)
            {
                cadastroFornecedores = cadastroFornecedoresDao.localizar(cadastroFornecedores);
            }
            return cadastroFornecedores;
        }

        public void ExcluirFornecedor(int cod)
        {
            if (cod > 0)
            {
                cadastroFornecedoresDao.ExcluirFornecedor(cod);
            }
        }

        public CadastroFornecedores LocaliarFornecedorRazaoSocial(CadastroFornecedores cdFornecedores)
        {
            return cadastroFornecedoresDao.LocaliarFornecedorRazaoSocial(cdFornecedores);
        }


        public DataTable CriaDataFornecedores()
        {
            return cadastroFornecedoresDao.CriaDataFornecedores();
        }

        public DataTable CriaDataFornecedoresParametro(string parametro)
        {
            return cadastroFornecedoresDao.CriaDataFornecedoresParametro(parametro);
        }
    }
}
