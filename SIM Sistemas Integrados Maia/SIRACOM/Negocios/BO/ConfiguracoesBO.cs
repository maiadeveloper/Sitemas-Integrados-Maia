using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Negocios.TIPO;
using Negocios.DAO;

namespace Negocios.BO
{
    public class ConfiguracoesBO
    {
        ConfiguracoesDAO configuracoesDao;

         /// <summary>
        /// Retorna configurações do sistema
        /// </summary>
        /// <returns></returns>
        public Configuracoes SelecionaConfiguracaoAtualSistema()
        {
            configuracoesDao = new ConfiguracoesDAO();
            return configuracoesDao.SelecionaConfiguracaoAtualSistema();
        }

        /// <summary>
        /// Altera situção do backup auto
        /// </summary>
        /// <param name="configuracoes"></param>
        public void AlterarSituacaoBackupAuto(Configuracoes configuracoes)
        {
            configuracoesDao = new ConfiguracoesDAO();
            configuracoesDao.AlterarSituacaoBackupAuto(configuracoes);
        }

        /// <summary>
        /// Altera situção do backup apos fechar
        /// </summary>
        /// <param name="configuracoes"></param>
        public void AlterarSituacaoBackupAposFechar(Configuracoes configuracoes)
        {
            configuracoesDao = new ConfiguracoesDAO();
            configuracoesDao.AlterarSituacaoBackupAposFechar(configuracoes);
        }
    }
}
