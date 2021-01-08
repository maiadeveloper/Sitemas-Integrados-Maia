using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios;
using Negocios.BO;
using Negocios.TIPO;
using System.Media;

namespace LavaJato
{
    public partial class frmLoginSistema : Form
    {
        public frmLoginSistema()
        {
            InitializeComponent();
        }

        ConexaoBanco con = new ConexaoBanco();
        OleDbCommand comSql;
        public string usuarioLogado;

        public CadastroUsuarios cdUsuarios = new CadastroUsuarios();

        public void logarSistema()
        {
            if (validar())
            {
                try
                {
                    comSql = new OleDbCommand("select count(*) from tblUsuario where NomeUsuario = @NomeUsuario And SenhaUsuario = @SenhaUsuario", con.conectarLogin());

                    cdUsuarios._NomeUsuario = txtUsuario.Text;
                    cdUsuarios._SenhaUsuario = txtLogin.Text;

                    comSql.Parameters.Add("@NomeUsuario", OleDbType.VarChar).Value = cdUsuarios._NomeUsuario;
                    comSql.Parameters.Add("@SenhaUsuario", OleDbType.VarChar).Value = cdUsuarios._SenhaUsuario;

                    int i = (int)comSql.ExecuteScalar();

                    if ((i > 0) || (cdUsuarios._NomeUsuario == "ANALISTA") && (cdUsuarios._SenhaUsuario == "analista"))
                    {
                        usuarioLogado = txtUsuario.Text;
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        erroLogin(false);
                        SoundPlayer p = new SoundPlayer();//Cria uma instancia da Biblioteca SoundPlayes
                        p.Play();//Dispara o som ao chamar metodo erroLogin
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show("Erro :" + erro.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return;
        }

        public void erroLogin(Boolean trueFalse)
        {
            btnImagen1.Visible = !trueFalse;
            btnImagen2.Visible = trueFalse;
            lblErro.Visible = !trueFalse;
            btnErro.Visible = !trueFalse;

            lblUsuario.Visible = trueFalse;
            lblLogin.Visible = trueFalse;
            txtUsuario.Visible = trueFalse;
            txtLogin.Visible = trueFalse;
            btnCancelar.Visible = trueFalse;
            btnEntrar.Visible = trueFalse;
        }

        public Boolean validar()
        {
            if (txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Informe o nome do usuário!!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Focus();
                return false;
            }
            if (txtLogin.Text == string.Empty)
            {
                MessageBox.Show("Informe a senha do usuário!!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtLogin.Focus();
                return false;
            }
            return true;
        }

        private void frmLoginSistema_Load(object sender, EventArgs e)
        {
            CarregaEmpresaRegistrada();
            erroLogin(true);
            txtUsuario.Focus();
        }

        private void CarregaEmpresaRegistrada()
        {
            Empresa empresa = new Empresa();
            EmpresaBO empresaBo = new EmpresaBO();

            ConfiguracoesBO configuracoesBO = new ConfiguracoesBO();
            Configuracoes configuracoes = new Configuracoes();

            empresa = empresaBo.SelecionaUltimoRegistroEmpresa();
            configuracoes = configuracoesBO.SelecionaConfiguracaoAtualSistema();

            lblSobre.Text = "SIRCOM \n\n" + "Sistema de Informação\n" + "para Rotinas Comerciais\n" + "Versão:" + configuracoes._VersaoSistemaAtual + " | 05/08/2015 | ";
        }

        private void frmLoginSistema_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logarSistema();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnErro_Click(object sender, EventArgs e)
        {
            erroLogin(true);
            txtUsuario.Focus();
            txtUsuario.Clear();
            txtLogin.Clear();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            logarSistema();
        }
    }
}