using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios;
using System.Data;

namespace Negocios
{

    public class CategoriaBO
    {
        CategoriaDAO categoriaDao;

        public void GravarCategoria(Categoria categoria)
        {
            categoriaDao = new CategoriaDAO();
            categoriaDao.GravarCategoria(categoria);
        }

        public DataTable CriaDataTableCategoria()
        {
            categoriaDao = new CategoriaDAO();
            return categoriaDao.CriaDataTableCategoria();
        }
    }
}
