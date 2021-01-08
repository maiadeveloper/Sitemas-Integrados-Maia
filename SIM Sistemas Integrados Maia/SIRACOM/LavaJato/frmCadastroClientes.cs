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
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();

            CarregaClienteSelecionado(codigoCliente);
        }

        CadastroClientesDAO cdClientesDao = new CadastroClientesDAO();
        public int codigoCliente = 0;

        private void Novo()
        {
            IdentificaTipoPessoa();
            EnabledCampos(true);
        }

        private void HabilitaTitulos()
        {
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
        }

        private void frmCadastroClientes_Load(object sender, EventArgs e)
        {
            HabilitaTitulos();

            if (codigoCliente <= 0)
            {
                EnabledCampos(false);
                Novo();
                rbFisica.Focus();
            }
        }

        public void gravarDados()
        {
            try
            {
                CadastroClientes cdClientes = new CadastroClientes();

                if (rbFisica.Checked == true) { cdClientes._TipoPessoa = "Física"; } else { cdClientes._TipoPessoa = "Jurídica"; }
                cdClientes._Nome = txtNomeFantasia.Text;
                cdClientes._RazaoSocial = txtSobreNomeRazaoSocial.Text;
                cdClientes._Bairro = txtBairro.Text;
                cdClientes._End_Nome_Rua = txtRua.Text;
                cdClientes._End_Numero = Convert.ToInt32(txtNumero.Text);
                cdClientes._Telefone_Fixo = txtTelefone01.Text;
                cdClientes._TelefoneCelular1 = txtTelefone02.Text;
                cdClientes._Complemento = txtComplemento.Text;
                cdClientes._Cidade = txtCidade.Text;
                cdClientes._Estado = txtUF.Text;
                cdClientes._Cep = txtCep.Text;
                cdClientes._Email = txtEmail.Text;
                cdClientes._CPF = txtCpfCnpj.Text;

                cdClientesDao.insertCliente(cdClientes);//Chama o método para gravar

                if (MessageBox.Show("Cliente gravado com sucesso !!!", "Gravação Ok", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    LimparCamposBox(this);
                    EnabledCampos(false);
                }
            }
            catch (Exception erroDao)
            {
                MessageBox.Show("Erro referente: " + erroDao.Message, "Atenção Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void AlterarDados()
        {
            try
            {
                CadastroClientes cdClientes = new CadastroClientes();

                if (rbFisica.Checked == true) { cdClientes._TipoPessoa = "Física"; } else { cdClientes._TipoPessoa = "Jurídica"; }
                cdClientes._CodigoCliente = codigoCliente;
                cdClientes._Nome = txtNomeFantasia.Text;
                cdClientes._RazaoSocial = txtSobreNomeRazaoSocial.Text;
                cdClientes._Bairro = txtBairro.Text;
                cdClientes._End_Nome_Rua = txtRua.Text;
                cdClientes._End_Numero = Convert.ToInt32(txtNumero.Text);
                cdClientes._Telefone_Fixo = txtTelefone01.Text;
                cdClientes._TelefoneCelular1 = txtTelefone02.Text;
                cdClientes._Complemento = txtComplemento.Text;
                cdClientes._Cidade = txtCidade.Text;
                cdClientes._Estado = txtUF.Text;
                cdClientes._Cep = txtCep.Text;
                cdClientes._Email = txtEmail.Text;
                cdClientes._CPF = txtCpfCnpj.Text;

                cdClientesDao.AlterarDadosCliente(cdClientes);//Chama o método para gravar

                if (MessageBox.Show("Cliente alterado com sucesso !!!", "Alteração Ok", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    LimparCamposBox(this);
                    EnabledCampos(false);
                    this.Close();
                }
            }
            catch (Exception erroDao)
            {
                MessageBox.Show("Erro referente: " + erroDao.Message, "Atenção Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public Boolean validarDados()
        {
            if ((rbFisica.Checked == false) && (rbJuridica.Checked == false))
            {
                MessageBox.Show("Selecione tipo de cliente!!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            if (rbFisica.Checked == true)
            {
                if ((txtCpfCnpj.Text == "   .   .   -") || (txtCpfCnpj.Text.Trim() == string.Empty))
                {
                    MessageBox.Show("Informe o número do cpf do cliente !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCpfCnpj.Focus();
                    return false;
                }
            }
            else
            {
                if ((txtCpfCnpj.Text == "  .   .   /    -") || (txtCpfCnpj.Text.Trim() == string.Empty))
                {
                    MessageBox.Show("Informe o número do cnpj do cliente !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCpfCnpj.Focus();
                    return false;
                }
            }

            if (txtNomeFantasia.Text == string.Empty)
            {
                MessageBox.Show("Informe o nome do Cliente !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNomeFantasia.Focus();
                return false;
            }
            if (txtBairro.Text == string.Empty)
            {
                MessageBox.Show("Informe o nome do bairro !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtBairro.Focus();
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
                MessageBox.Show("Informe o número da residencia !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNumero.Focus();
                return false;
            }

            if (txtCep.Text == "#####-###")
            {
                MessageBox.Show("Informe o número do cep!!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCep.Focus();
                return false;
            }
            if (txtCidade.Text == string.Empty)
            {
                MessageBox.Show("Informe o nome da cidade !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCidade.Focus();
                return false;
            }
            if (txtUF.Text == string.Empty)
            {
                MessageBox.Show("Informe o nomeProduto do estado!!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUF.Focus();
                return false;
            }
            if (txtTelefone01.Text.Length != 14)
            {
                MessageBox.Show("Informe o fone 01 para contato !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTelefone01.Focus();
                return false;
            }

            else
            {
                return true;
            }
        }

        private void LimparCamposBox(Control control)
        {
            foreach (Control textBox in control.Controls)
            {
                if (textBox is TextBox)
                {
                    ((TextBox)textBox).Text = string.Empty;
                }
                else if (control.Controls.Count > 0)
                {
                    LimparCamposBox(textBox);
                }

                txtTelefone01.Text = string.Empty;
                txtTelefone02.Text = string.Empty;
                txtCep.Text = string.Empty;
                txtCpfCnpj.Text = string.Empty;
            }
        }

        public void EnabledCampos(Boolean trueFalse)
        {
            rbFisica.Enabled = trueFalse;
            rbJuridica.Enabled = trueFalse;
            txtNomeFantasia.Enabled = trueFalse;
            txtRua.Enabled = trueFalse;
            txtNumero.Enabled = trueFalse;
            txtBairro.Enabled = trueFalse;
            txtTelefone01.Enabled = trueFalse;
            txtTelefone02.Enabled = trueFalse;
            txtComplemento.Enabled = trueFalse;
            txtCidade.Enabled = trueFalse;
            txtUF.Enabled = trueFalse;
            txtCpfCnpj.Enabled = trueFalse;
            txtSobreNomeRazaoSocial.Enabled = trueFalse;
            txtEmail.Enabled = trueFalse;
            txtCep.Enabled = trueFalse;
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            IdentificaTipoPessoa();
        }

        public void IdentificaTipoPessoa()
        {
            if (rbFisica.Checked == true)
            {
                txtCpfCnpj.Focus();
                txtCpfCnpj.Clear();
                lblCpfCnpj.Text = "CPF:";
                lblNomeFantasia.Text = "Nome:";
                lblSobreNomeRazao.Text = "SobreNome:";

                txtCpfCnpj.Mask = "###,###,###-##";
            }
            else
            {
                txtCpfCnpj.Focus();
                txtCpfCnpj.Clear();
                lblCpfCnpj.Text = "CNPJ:";
                lblNomeFantasia.Text = "Nome Fantasia:";
                lblSobreNomeRazao.Text = "Razão social:";

                txtCpfCnpj.Mask = "##,###,###/####-##";
            }
        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            IdentificaTipoPessoa();
        }

        public void CarregaClienteSelecionado(int codigo)
        {
            if (codigo != 0)
            {
                Novo();

                CadastroClientes cliente = new CadastroClientes();
                CadastroClientesDAO clienteDAO = new CadastroClientesDAO();

                cliente = clienteDAO.SelecionaClientePorID(codigo);

                if (cliente != null)
                {
                    codigoCliente = codigo;

                    if (cliente._TipoPessoa == "Física")
                    {
                        rbFisica.Checked = true;
                    }
                    else
                    {
                        rbJuridica.Checked = true;
                    }
            
                    txtBairro.Text = cliente._Bairro;
                    txtCep.Text = cliente._Cep;
                    txtCidade.Text = cliente._Cidade;
                    txtComplemento.Text = cliente._Complemento;
                    txtCpfCnpj.Text = cliente._CPF;
                    txtCpfCnpj.Text = cliente._Cnpj;
                    txtEmail.Text = cliente._Email;
                    txtNomeFantasia.Text = cliente._Nome;
                    txtNumero.Text = cliente._End_Numero.ToString();
                    txtRua.Text = cliente._End_Nome_Rua;
                    txtSobreNomeRazaoSocial.Text = cliente._RazaoSocial;
                    txtTelefone01.Text = cliente._Telefone_Celular;
                    txtTelefone02.Text = cliente._Telefone_Fixo;
                    txtUF.Text = cliente._Estado;
                }
            }
        }

        private void toolStripButtonCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonSalvar_Click_1(object sender, EventArgs e)
        {
            if (validarDados())
            {
                if (codigoCliente > 0)
                {
                    AlterarDados();
                }
                else
                {
                    gravarDados();
                }

                LimparCamposBox(this);
                EnabledCampos(false);
            }
            else
            {
                return;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
