using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios;

namespace LavaJato
{
    public partial class frmCadastroFuncionarios : Form
    {
        public frmCadastroFuncionarios()
        {
            InitializeComponent();
        }

        CadastroFuncionariosDAO cdFuncionariosDao = new CadastroFuncionariosDAO();

        public void gravarDados()
        {
            try
            {
                    CadastroFuncionarios cdFuncionarios = new CadastroFuncionarios();
                    cdFuncionarios._DataCadastro = DateTime.Parse(txtDataCadastro.Text);
                    cdFuncionarios._Nome = txtNomeFunc.Text;
                    cdFuncionarios._Dia = Convert.ToInt32(txtDia.Text);
                    cdFuncionarios._Mes = txtMes.Text;
                    cdFuncionarios._Ano = Convert.ToInt32(txtAno.Text);
                    cdFuncionarios._Endereco_Rua = txtRua.Text;
                    cdFuncionarios._Cep = txtCep.Text;
                    cdFuncionarios._Endereco_Numero = Convert.ToInt32(txtNumero.Text);
                    cdFuncionarios._Bairro = txtBairro.Text;
                    cdFuncionarios._Cidade = txtCidade.Text;
                    cdFuncionarios._Estado = txtEstado.Text;
                    cdFuncionarios._Telefone_Fixo = txtCelular.Text;
                    cdFuncionarios._Telefone_Residencial = txtFoneResidencial.Text;
                    //cdFuncionarios._Obs = txtObs.Text;
                    cdFuncionarios._Foto = lblFoto.Text;

                    cdFuncionariosDao.insertFuncionrios(cdFuncionarios);//Chama o método para gravar
                    MessageBox.Show("Fucionário gravado com sucesso !!!", "Gravação Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception erroDao)
            {
                MessageBox.Show("Erro referente: " + erroDao.Message, "Atenção Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Boolean validarDados()
        {
            if (txtNomeFunc.Text == string.Empty)
            {
                MessageBox.Show("Informe o nome do funcionário !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNomeFunc.Focus();
                return false;
            }
            if (txtDia.Text == string.Empty)
            {
                MessageBox.Show("Informe o dia do seu nascimento !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtDia.Focus();
                return false;
            }
            if (txtMes.Text == string.Empty)
            {
                MessageBox.Show("Informe o mês do seu nascimento !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMes.Focus();
                return false; 
            }
            if (txtAno.Text == string.Empty)
            {
                MessageBox.Show("Informe o ano do seu nascimento !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAno.Focus();
                return false; 
            }
            if (txtCidade.Text == string.Empty)
            {
                MessageBox.Show("Informe a cidade !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCidade.Focus();
                return false;
            }
            if (txtEstado.Text == string.Empty)
            {
                MessageBox.Show("Informe o estado !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtEstado.Focus();
                return false;
            }
            if (txtRua.Text == string.Empty)
            {
                MessageBox.Show("Informe o nome da rua !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRua.Focus();
                return false; 
            }
            if (txtNumero.Text == string.Empty)
            {
                MessageBox.Show("Informe o número da residência !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumero.Focus();
                return false;
            }
            if (txtBairro.Text == string.Empty)
            {
                MessageBox.Show("Informe o nome do bairro !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBairro.Focus();
                return false;
            }
            if (txtCep.Text.Length != 9)
            {
                MessageBox.Show("Informe o cep da rua !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCep.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void ExibirFoto()
        {
            // exibe a foto
            if (!lblFoto.Text.Equals(""))
            {
                try
                {
                    picItem.Image = Image.FromFile(lblFoto.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro ao carregar Foto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                picItem.Image = null;
            }
        }

        public void limpar()
        {
            txtNomeFunc.Clear();
            txtDia.Text = null;
            txtMes.Text = null;
            txtAno.Text = null;
            txtRua.Clear();
            txtCep.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Text = null;
            txtFoneResidencial.Clear();
            txtCelular.Clear();
            //txtObs.Clear();
            lblFoto.Clear();
            picItem.Image = null;
        }

        public void EnabledCampos(Boolean trueFalse)
        {
            //txtDataCadastro.Enabled = trueFalse;
            txtNomeFunc.Enabled = trueFalse;
            txtDia.Enabled = trueFalse;
            txtMes.Enabled = trueFalse;
            txtAno.Enabled = trueFalse;
            txtRua.Enabled = trueFalse;
            txtCep.Enabled = trueFalse;
            txtNumero.Enabled = trueFalse;
            txtBairro.Enabled = trueFalse;
            txtCidade.Enabled = trueFalse;
            txtEstado.Enabled = trueFalse;
            txtFoneResidencial.Enabled = trueFalse;
            txtCelular.Enabled = trueFalse;
            //txtObs.Enabled = trueFalse;
            lblFoto.Enabled = trueFalse;
            picItem.Enabled = trueFalse;
        }

        public void EnabledBotoes(Boolean trueFalse)
        {
            btnNovo.Enabled = trueFalse;
            btnCancelar.Enabled = !trueFalse;
            btnSalvar.Enabled = !trueFalse;
            btnCarregaFoto.Enabled = !trueFalse;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validarDados())
            {
                gravarDados();
                limpar();
                EnabledCampos(false);
                EnabledBotoes(true);
            }
            else
            {
               return;
            }
        }

        private void frmCadastroFuncionarios_Load(object sender, EventArgs e)
        {
            EnabledCampos(false);
            EnabledBotoes(true);
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            EnabledCampos(true);
            EnabledBotoes(false);
            txtNomeFunc.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCarregaFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dlgOpen.ShowDialog() == DialogResult.OK)
                {
                    lblFoto.Text = dlgOpen.FileName;
                    ExibirFoto();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao abrir Foto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
