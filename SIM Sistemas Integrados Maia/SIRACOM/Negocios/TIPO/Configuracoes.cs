using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.TIPO
{
    public class Configuracoes
    {
        string backupAutomatico;
        string backupAposFechar;

        public string _BackupAutomatico
        {
            get { return backupAutomatico; }
            set { backupAutomatico = value; }
        }

        public string _BackupAposFechar
        {
            get { return backupAposFechar; }
            set { backupAposFechar = value; }
        }

        string NomeSistema;

        public string _NomeSistema
        {
            get;
            set;
        }

        string VersaoSistemaAtual;

        public string _VersaoSistemaAtual
        {
            get;
            set;
        }

        DateTime DataUltimaVersao;

        public DateTime _DataUltimaVersao
        {
            get;
            set;
        }

        DateTime DataVersaoAtual;

        public DateTime _DataVersaoAtual
        {
            get;
            set;
        }
    }
}
