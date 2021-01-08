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
    public partial class frmCadastroFornecedores : Form
    {
        public frmCadastroFornecedores()
        {
            InitializeComponent();
        }

        CadastroFornecedoresDAO cdFornecedoresDao = new CadastroFornecedoresDAO();     
        public int codFornecedor;
        public string razaoSocial;
        
        public void gravarDados()
        {
            try
            {
                CadastroFornecedores cdFornecedores = new CadastroFornecedores();

                //caso nao digite nada

                cdFornecedores._Razao_Social = string.IsNullOrEmpty(txtRazaoSocial.Text) ? null : txtRazaoSocial.Text;
                cdFornecedores._Nome_Fantasia = string.IsNullOrEmpty(txtNomeFornec.Text) ? null : txtNomeFornec.Text;
                cdFornecedores._Endereco_Rua = string.IsNullOrEmpty(txtRua.Text) ? null : txtRua.Text;
                cdFornecedores._Endereco_Numero = string.IsNullOrEmpty(txtNumero.Text) ? "0" : txtNumero.Text;
                cdFornecedores._Bairro = string.IsNullOrEmpty(txtBairro.Text) ? null : txtBairro.Text;
                cdFornecedores._Cidade = string.IsNullOrEmpty(txtCidade.Text) ? null : txtCidade.Text;
                cdFornecedores._UF = string.IsNullOrEmpty(txtUF.Text) ? null : txtUF.Text;
                cdFornecedores._CEP = string.IsNullOrEmpty(txtCEP.Text) ? null : txtCEP.Text;
                cdFornecedores._TelefoneResidencial = string.IsNullOrEmpty(txtFoneResidencial.Text) ? null : txtFoneResidencial.Text;
                cdFornecedores._Fax = string.IsNullOrEmpty(txtFax.Text) ? null : txtFax.Text;
                cdFornecedores._TelefoneCelular = string.IsNullOrEmpty(txtFoneCelular.Text) ? null : txtFoneCelular.Text;
                cdFornecedores._CNPJ = string.IsNullOrEmpty(txtCNPJ.Text) ? null : txtCNPJ.Text;
                cdFornecedores._Incr_Estadual = string.IsNullOrEmpty(txtInscEstadual.Text) ? null : txtInscEstadual.Text;
                cdFornecedores._Representante = string.IsNullOrEmpty(txtRepresentante.Text) ? null : txtRepresentante.Text;
                cdFornecedores._Email = string.IsNullOrEmpty(txtEmail.Text) ? null : txtEmail.Text;

                cdFornecedoresDao.insertFornecedores(cdFornecedores);

                razaoSocial = txtRazaoSocial.Text;

                limpar();
                txtCNPJ.Focus();

                MessageBox.Show("Fornecedor gravado com sucesso !!!", "Gravação Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception erroDao)
            {
                MessageBox.Show("Erro referente: " + erroDao.Message, "Atenção Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public Boolean validarDados()
        {
            if (txtCNPJ.Text.Length != 18)
            {
                MessageBox.Show("Informe o número do cnpj da empresa !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtCNPJ.Focus();
                return false;
            }

            if (txtRazaoSocial.Text == string.Empty)
            {
                MessageBox.Show("Informe a razão social do fornecedor !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRazaoSocial.Focus();
                return false;
            }
            if (txtNomeFornec.Text == string.Empty)
            {
                MessageBox.Show("Informe o nome fantasia  do fornecedor !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNomeFornec.Focus();
                return false;
            }
            //if (txtInscEstadual.Text == string.Empty)
            //{
            //    MessageBox.Show("Informe o número da inscrição estadual do fornecedor !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    txtInscEstadual.Focus();
            //    return false;
            //}
            //if (txtRua.Text == string.Empty)
            //{
            //    MessageBox.Show("Informe o nome da rua ou avenida !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    txtRua.Focus();
            //    return false;
            //}
            //if (txtNumero.Text == string.Empty)
            //{
            //    MessageBox.Show("Informe o número do estabelecimento !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    txtNumero.Focus();
            //    return false;
            //}
            //if (txtBairro.Text == string.Empty)
            //{
            //    MessageBox.Show("Informe o nome do bairro !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    txtBairro.Focus();
            //    return false;
            //}
            //if (txtCidade.Text == string.Empty)
            //{
            //    MessageBox.Show("Informe o nome da cidade !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    txtCidade.Focus();
            //    return false;
            //}
            //if (txtUF.Text == string.Empty)
            //{
            //    MessageBox.Show("Informe o estado !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    txtUF.Focus();
            //    return false;
            //}
            //if (txtCEP.Text.Length != 9)
            //{
            //    MessageBox.Show("Informe o cep !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    txtCEP.Focus();
            //    return false;
            //}

            //if (txtFoneResidencial.Text.Length != 15)
            //{
            //    MessageBox.Show("Informe o fone 01 para contato !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    txtFoneResidencial.Focus();
            //    return false;
            //}
            //if (txtFoneCelular.Text.Length != 15)
            //{
            //    MessageBox.Show("Informe o fone 02 para contato !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    txtFoneCelular.Focus();
            //    return false;
            //}
            //if (txtFax.Text.Length != 15)
            //{
            //    MessageBox.Show("Informe o número do fax !!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    txtFax.Focus();
            //    return false;
            //}
            //if (txtRepresentante.Text == string.Empty)
            //{
            //    MessageBox.Show("Informe o nome do representante !!!", "Atenção - campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    txtRepresentante.Focus();
            //    return false;
            //}
            else
            {
                return true;
            }
        }

        public void limpar()
        {
            txtNomeFornec.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtUF.Text = null;
            txtCEP.Clear();
            txtFoneResidencial.Clear();
            txtFoneCelular.Clear();
            txtRazaoSocial.Clear();
            txtFax.Clear();
            txtCNPJ.Clear();
            txtInscEstadual.Clear();
            txtEmail.Clear();
            txtRepresentante.Clear();
            txtInscMunicipal.Clear();
            txtCidade.Clear();
            txtCelular.Clear();
            txtSite.Clear();
        }


        public void CarregaDadosAlteracao(CadastroFornecedores fornecedores)
        {
            txtRazaoSocial.Text = fornecedores._Razao_Social;
            txtNomeFornec.Text = fornecedores._Nome_Fantasia;
        }

        private void frmCadastroFornecedores_Load(object sender, EventArgs e)
        {
            CadastroFornecedores cadForn = new CadastroFornecedores();
            CarregaDadosAlteracao(cadForn);
            HabilitaTitulos();
            txtCNPJ.Focus();
        }


        private void HabilitaTitulos()
        {
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonSalvar_Click(object sender, EventArgs e)
        {
            if (validarDados())
            {
                gravarDados();
            }
            else
            {
                return;
            }
        }
    }
}
