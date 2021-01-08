using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios.manterContaBanco
{
    public class ManterContaBanco
    {
        int iuo;

        public int _Iuo
        {
            get { return iuo; }
            set { iuo = value; }
        }
        string usuarioConta;

        public string _UsuarioConta
        {
            get { return usuarioConta; }
            set { usuarioConta = value; }
        }
        string banco;

        public string _Banco
        {
            get { return banco; }
            set { banco = value; }
        }
        string tipoConta;

        public string _TipoConta
        {
            get { return tipoConta; }
            set { tipoConta = value; }
        }
        string agencia;

        public string _Agencia
        {
            get { return agencia; }
            set { agencia = value; }
        }
        string conta;

        public string _Conta
        {
            get { return conta; }
            set { conta = value; }
        }
        string senha;

        public string _Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        string senhaComplementa;

        public string _SenhaComplementa
        {
            get { return senhaComplementa; }
            set { senhaComplementa = value; }
        }   
    }
}
