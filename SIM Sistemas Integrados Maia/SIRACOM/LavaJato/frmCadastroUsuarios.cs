using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web.Security;
using Negocios;

namespace LavaJato
{
    public partial class frmCadastroUsuarios : Form
    {
        public frmCadastroUsuarios()
        {
            InitializeComponent();
        }

        CadastroUsuariosDAO cdUsuariosDao = new CadastroUsuariosDAO();

        public void gravarDados()
        {
            try
            {
                CadastroUsuarios cdUsuarios = new CadastroUsuarios();

                cdUsuarios._NomeUsuario = txtNomeUsuario.Text;
                cdUsuarios._SenhaUsuario = txtSenhaUsuario.Text;
                cdUsuarios.TipoUsuario = txtTipoOperador.SelectedItem.ToString();

                cdUsuariosDao.insertUsuarios(cdUsuarios);

                MessageBox.Show("Usuário gravado com sucesso !!!", "Gravação Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpar();
                EnabledCampos(false);
            }
            catch (Exception)
            {
                MessageBox.Show("Login já esta sendo utilizado por outro Usuário!", "Atenção Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeUsuario.Focus();
                txtNomeUsuario.Clear();
                txtConfirmacaoSenhaUs.Clear();
                txtSenhaUsuario.Clear();
            }
        }

        public Boolean validarDados()
        {
            string LoginUsuario, ConfirmaLogin;

            LoginUsuario = txtSenhaUsuario.Text;
            ConfirmaLogin = txtConfirmacaoSenhaUs.Text;

            if (txtTipoOperador.Text == string.Empty)
            {
                MessageBox.Show("Informe o tipo  do usuário !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTipoOperador.Focus();
                return false;
            }

            if (txtNomeUsuario.Text == string.Empty)
            {
                MessageBox.Show("Informe o nome  do usuário !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNomeUsuario.Focus();
                return false;
            }
            if (txtSenhaUsuario.Text == string.Empty)
            {
                MessageBox.Show("Defina uma senha para usuário !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtSenhaUsuario.Focus();
                return false;
            }
            if (txtConfirmacaoSenhaUs.Text == string.Empty)
            {
                MessageBox.Show("Confirme a senha digitada acima !!!", "Atenção - Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtConfirmacaoSenhaUs.Focus();
                return false;
            }
            if (LoginUsuario != ConfirmaLogin)
            {
                MessageBox.Show("Senha digitada não confere !!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmacaoSenhaUs.Focus();
                txtConfirmacaoSenhaUs.Clear();
                return false;
            }
            if (txtSenhaUsuario.Text.Length < 6)
            {
                MessageBox.Show("Você precisar digitar uma senha com 6 caracteres !!!", "Atenção Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenhaUsuario.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public void limpar()
        {
            txtNomeUsuario.Clear();
            txtSenhaUsuario.Clear();
            txtConfirmacaoSenhaUs.Clear();
        }

        public void EnabledCampos(Boolean trueFalse)
        {
            //txtDataCadastroUsuario.Enabled = trueFalse;
            txtNomeUsuario.Enabled = trueFalse;
            txtSenhaUsuario.Enabled = trueFalse;
            txtConfirmacaoSenhaUs.Enabled = trueFalse;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validarDados())
            {
                if (MessageBox.Show("Deseja realmente salvar", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    gravarDados();
                }
            }
            else
            {
                return;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCadastroUsuarios_Load(object sender, EventArgs e)
        {
            txtTipoOperador.Focus();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonSalvar_Click(object sender, EventArgs e)
        {
            btnSalvar_Click(this, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
