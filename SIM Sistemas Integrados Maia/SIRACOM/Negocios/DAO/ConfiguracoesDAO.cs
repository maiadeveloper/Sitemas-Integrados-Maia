using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using Negocios.TIPO;
using Negocios;

namespace Negocios.DAO
{
    public class ConfiguracoesDAO
    {
        StringBuilder sbsql;
        ConexaoBanco conexaoBanco;
        ContasReceber contasReceber;

        /// <summary>
        /// Retorna configurações do sistema
        /// </summary>
        /// <returns></returns>
        public Configuracoes SelecionaConfiguracaoAtualSistema()
        {
            sbsql = new StringBuilder();
            conexaoBanco = new ConexaoBanco();

            Configuracoes configuracoes = new  Configuracoes();

            sbsql.Append("SELECT * FROM tblConfiguracoes");

            OleDbDataReader leitor = conexaoBanco.selectDR(sbsql.ToString());

            if (leitor.HasRows)
            {
                leitor.Read();

                configuracoes._BackupAutomatico = (string)leitor["criarBackupAuto"];
                configuracoes._BackupAposFechar = (string)leitor["criarBackupAposFechar"];
                configuracoes._NomeSistema = (string)leitor["NomeSistema"];
                configuracoes._VersaoSistemaAtual = (string)leitor["VersaoSistemaAtual"];
                configuracoes._DataUltimaVersao = (DateTime)leitor["DataUltimaVersao"];
                configuracoes._DataVersaoAtual = (DateTime)leitor["DataVersaoAtual"];

            }
            else
            {
                configuracoes = null;
            }

            leitor.Close();

            return configuracoes;
        }

        /// <summary>
        /// Altera situção do backup auto
        /// </summary>
        /// <param name="configuracoes"></param>
        public void AlterarSituacaoBackupAuto(Configuracoes configuracoes)
        {
            conexaoBanco = new ConexaoBanco();
            sbsql = new StringBuilder();

            sbsql.Append("UPDATE tblConfiguracoes SET criarBackupAuto ='" + configuracoes._BackupAutomatico + "' ");
            sbsql.Append("WHERE configuracoesID = 1");

            conexaoBanco.manterCRUD(sbsql.ToString());
        }

        /// <summary>
        /// Altera situção do backup auto
        /// </summary>
        /// <param name="configuracoes"></param>
        public void AlterarSituacaoBackupAposFechar(Configuracoes configuracoes)
        {
            conexaoBanco = new ConexaoBanco();
            sbsql = new StringBuilder();

            sbsql.Append("UPDATE tblConfiguracoes SET criarBackupAposFechar ='" + configuracoes._BackupAposFechar + "' ");
            sbsql.Append("WHERE configuracoesID = 1");

            conexaoBanco.manterCRUD(sbsql.ToString());
        }
    }
}
