using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.TIPO;
using Negocios.BO;
using System.Diagnostics;

namespace LavaJato
{
    public partial class frmConfiguracoesGeraisSistema : Form
    {
        static string exeLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Remove(0, 6);

        public frmConfiguracoesGeraisSistema()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void toolStripButtonSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                AlterarDadosEmpresa();

                GravarPapelParede();

                txtQtde_Leave(this, e);

                AlterarConfirmaImpressa();

                MessageBox.Show("Alterações realizada com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AlterarDadosEmpresa()
        {
            if (MessageBox.Show("Confirma alteração das seguintes informações abaixo ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Empresa empresa = new Empresa();

                empresa._Bairro = txtBairro.Text;
                empresa._Cep = txtCEP.Text;
                empresa._Cidade = txtCidade.Text;
                empresa._CnpjCpf = txtCpfCnpj.Text;
                empresa._Email = txtEmail.Text;
                empresa._Fone = txtTelefone.Text;
                empresa._IdEmpresa = int.Parse(txtCodigo.Text);
                empresa._NomeFantasia = txtNomeFantasia.Text;
                empresa._Numero = int.Parse(txtNumero.Text);
                empresa._RazaoSocial = txtRazaoSocial.Text;
                empresa._Rua = txtRua.Text;
                empresa._Slogan = txtSloganEmpresa.Text;
                empresa._Status = "Ativo";
                empresa._UF = txtUF.Text;
                empresa.DataCadastro = Convert.ToDateTime(DateTime.Now);

                EmpresaBO empresaBO = new EmpresaBO();
                empresaBO.AlterarEmpresa(empresa);
            }
        }

        private void frmConfiguracoesGeraisSistema_Load(object sender, EventArgs e)
        {
            ExibirFotoRegistro();

            Empresa empresa = new Empresa();
            EmpresaBO empresaBO = new EmpresaBO();

            empresa = empresaBO.SelecionaUltimoRegistroEmpresa();

            txtBairro.Text = empresa._Bairro;
            txtCEP.Text = empresa._Cep;
            txtCidade.Text = empresa._Cidade;
            txtCodigo.Text = empresa._IdEmpresa.ToString();
            txtCpfCnpj.Text = empresa._CnpjCpf;
            txtEmail.Text = empresa._Email;
            txtNomeFantasia.Text = empresa._NomeFantasia;
            txtNumero.Text = empresa._Numero.ToString();
            txtRazaoSocial.Text = empresa._RazaoSocial;
            txtRua.Text = empresa._Rua;
            txtSloganEmpresa.Text = empresa._Slogan;
            txtTelefone.Text = empresa._Fone;
            txtUF.Text = empresa._UF;
            txtQtde.SelectedItem = empresa.QtdeImpressaoRecibo.ToString();

            rbSim.Checked = empresa.ConfirmaImpressao == 1 ? true : false;
            rbSim.Checked = empresa.ConfirmaImpressao == 0 ? false : true;
        }

        public void GravarPapelParede()
        {

            if (!string.IsNullOrEmpty(txtCaminhoImagem.Text))
            {
                Empresa empresa = new Empresa();
                EmpresaBO empresaBo = new EmpresaBO();

                empresa = empresaBo.SelecionaUltimoRegistroEmpresa();

                empresa._LogoEmpresa = txtCaminhoImagem.Text;
                empresa._CnpjCpf = empresa._CnpjCpf;

                empresaBo.AlterarLogoEmpresa(empresa);
            }
        }

        private void ExibirFoto()
        {
            // exibe a foto
            if (!txtCaminhoImagem.Text.Equals(""))
            {
                try
                {
                    picItem.Image = Image.FromFile(txtCaminhoImagem.Text);
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

        private void btnSelecionarImagem_Click(object sender, EventArgs e)
        {
            try
            {
                if (dlgOpen.ShowDialog() == DialogResult.OK)
                {
                    txtCaminhoImagem.Text = dlgOpen.FileName;
                    ExibirFoto();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao abrir Foto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void ExibirFotoRegistro()
        {
            try
            {
                Empresa empresa = new Empresa();
                EmpresaBO empresaBo = new EmpresaBO();

                empresa = empresaBo.SelecionaUltimoRegistroEmpresa();

                //Carrega imagem do fundo
                if (!string.IsNullOrEmpty(empresa._LogoEmpresa))
                {
                    picItem.Image = Image.FromFile(empresa._LogoEmpresa);
                }
            }
            catch (Exception)
            { }
        }

        private void rbFisica_CheckedChanged(object sender, EventArgs e)
        {
            IdentificaTipoPessoa();
        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            IdentificaTipoPessoa();
        }

        private void txtQtde_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtQtde.Text.Equals("Selecione..."))
                {
                    MessageBox.Show("Selecione uma opção", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtQtde.Focus();
                    return;
                }
                else
                {
                    Empresa empresa = new Empresa();
                    EmpresaBO empresaBo = new EmpresaBO();

                    empresa = empresaBo.SelecionaUltimoRegistroEmpresa();

                    empresa.QtdeImpressaoRecibo = Convert.ToInt32(txtQtde.Text);
                    empresa._CnpjCpf = empresa._CnpjCpf;
                    empresaBo.AlterarQtdeImpressaoRecibo(empresa);
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AlterarConfirmaImpressa()
        {
            try
            {
                Empresa empresa = new Empresa();
                EmpresaBO empresaBo = new EmpresaBO();

                empresa = empresaBo.SelecionaUltimoRegistroEmpresa();

                empresa.ConfirmaImpressao = rbSim.Checked == true ? 1 : 0;
                empresa._CnpjCpf = empresa._CnpjCpf;
                empresaBo.AlterarConfirmaImpressao(empresa);
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAbrirComprovanteVenda_Click(object sender, EventArgs e)
        {
            string path = exeLocation + "\\Cupom\\ComprovanteVenda.txt";
            Process.Start(path);
        }

        private void btnAbrirCompPgto_Click(object sender, EventArgs e)
        {
            string path = exeLocation + "\\Cupom\\ComprovantePgto.txt";
            Process.Start(path);
        }

        private void btnAbrirReciboPrestacao_Click(object sender, EventArgs e)
        {
            string path = exeLocation + "\\Cupom\\ReciboPrestacao.txt";
            Process.Start(path);
        }

        private void btnAbrirComprovanteMov_Click(object sender, EventArgs e)
        {
            string path = exeLocation + "\\Cupom\\Movimentacao.txt";
            Process.Start(path);
        }
    }
}
