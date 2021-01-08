using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios;

namespace Negocios
{
    public class CadastroUsuariosBO
    {
        public CadastroUsuarios SelectUserLogado(CadastroUsuarios usuario)
        {
            if(usuario != null)
            {
                CadastroUsuariosDAO usuarioDao = new CadastroUsuariosDAO();
                usuario = usuarioDao.localizarUsuario(usuario);
            }
            else
            {
                usuario = null;
            }
            return usuario;
        }
    }
}
