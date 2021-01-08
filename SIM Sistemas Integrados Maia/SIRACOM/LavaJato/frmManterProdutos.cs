using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.ProdTipo;
using Negocios.ProdBo;
using System.Data.OleDb;
using System.IO;
using Negocios;

namespace LavaJato
{
    public partial class frmManterProdutos : Form
    {
        static string exeLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Remove(0, 6);

        public frmManterProdutos()
        {
            InitializeComponent();

            CarregaProdutoSelecionado(codigoProduto);
        }

        EventArgs e;
        ProdutosTipo objProdutos;
        ProdutosBO objProdutoBO;
        ConexaoBanco conexao = new ConexaoBanco();
        public int codigoProduto = 0;
        string caminhoImagem;


        private void SalvarProduto()
        {
            try
            {
                if (txtCodigoBarra.Text.Trim() == string.Empty)
                {
                    txtCodigoBarra.Focus();
                    throw (new Exception("Digite o código de barra para o produto"));
                }

                if (txtNomeProduto.Text.Trim() == string.Empty)
                {
                    txtNomeProduto.Focus();
                    throw (new Exception("Digite o nome do produto"));
                }

                if (txtDescricaoProduto.Text.Trim() == string.Empty)
                {
                    txtDescricaoProduto.Focus();
                    throw (new Exception("Digite a descrição do produto"));
                }
                if (txtCategoriaProduto.Text.Trim() == "Selecione..." || txtCategoriaProduto.Text.Trim() == string.Empty)
                {
                    txtCategoriaProduto.Focus();
                    throw (new Exception("Selecione categoria para o produto"));
                }
                if (txtUnidadeCompra.Text.Trim() == "Selecione..." || txtUnidadeCompra.Text.Trim() == string.Empty)
                {
                    txtUnidadeCompra.Focus();
                    throw (new Exception("Selecione unidade de compra para o produto"));
                }
                if (txtQtdeMax.Text.Trim() == null)
                {
                    txtQtdeMax.Focus();
                    throw (new Exception("Digite quantidade maxima para estoque"));
                }
                if (txtQtdeMin.Text.Trim() == null)
                {
                    txtQtdeMin.Focus();
                    throw (new Exception("Digite quantidade minima para estoque"));
                }

                if (txtValorCompra.Text.Trim() == null)
                {
                    txtValorCompra.Focus();
                    throw (new Exception("Digite valor de compra"));
                }

                if (txtValorVenda.Text.Trim() == null)
                {
                    txtValorVenda.Focus();
                    throw (new Exception("Digite valor de venda"));
                }

                SalvaImagemDiretorio();

                objProdutos = new ProdutosTipo();
                objProdutoBO = new ProdutosBO();

                objProdutos._CodigoProduto = codigoProduto;
                objProdutos._CodigoBarra = codigoProduto.ToString();
                objProdutos._DataCadastro = Convert.ToDateTime(txtDataCadastro.Text);
                objProdutos._CodigoBarra = txtCodigoBarra.Text;
                objProdutos._NomeProduto = txtNomeProduto.Text.Replace("'", "");
                objProdutos._DescricaoProduto = txtDescricaoProduto.Text.Replace("'", "");
                objProdutos._CategoriaProduto = txtCategoriaProduto.Text;
                objProdutos._UnidadeCompra = txtUnidadeCompra.Text;
                objProdutos._EstoqueMaximo = Convert.ToInt32(txtQtdeMax.Text);
                objProdutos._EstoqueMinimo = Convert.ToInt32(txtQtdeMin.Text);
                objProdutos._PrecoCompra = Convert.ToDecimal(txtValorCompra.Text.Substring(3));
                objProdutos._ValorUnitario = Convert.ToDecimal(txtValorVenda.Text.Substring(3));
                objProdutos._MargemLucro = txtMargemLucro.Text;
                objProdutos._CaminhoImagem = caminhoImagem;

                if (MessageBox.Show("Confirma gravação deste produto ?", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    objProdutoBO.InserirProduto(objProdutos);
                    LimparCamposBox(this);

                    MessageBox.Show("Produto gravado com sucesso", "Gravação ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (MessageBox.Show("Deseja realizar outro cadastro de um produto", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Novo();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message, "Atenção usuário - Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void PopulaCategoria()
        {
            CategoriaBO categoriaBO = new CategoriaBO();
            DataTable dt = new DataTable();
            dt = categoriaBO.CriaDataTableCategoria();

            txtCategoriaProduto.Items.Clear();

            foreach (DataRow item in dt.Rows)
            {
                txtCategoriaProduto.Items.Add(item["nome"].ToString());
            }
        }

        private void Novo()
        {
            txtCodigoBarra.Enabled = true;
            txtNomeProduto.Enabled = true;
            txtDataCadastro.Enabled = true;
            txtCodigoBarra.Enabled = true;
            txtDescricaoProduto.Enabled = true;
            txtCategoriaProduto.Enabled = true;
            txtUnidadeCompra.Enabled = true;
            txtCaminhoImagem.Enabled = true;
            txtQtdeMax.Enabled = true;
            txtQtdeMin.Enabled = true;
            txtValorVenda.Enabled = true;
            txtValorCompra.Enabled = true;
            btnAdicionarCategoria.Enabled = true;
            btnSelecionarImagem.Enabled = true;

            txtCodigoBarra.Focus();
        }


        private void frmManterProdutos_Load(object sender, EventArgs e)
        {
            PopulaCategoria();
            HabilitaTitulos();
            Novo();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Utilitarios.iniciaCalc();
        }

        private void btnNovaCategoria_Click(object sender, EventArgs e)
        {
            frmCategoria janelaCategoria = new frmCategoria();
            janelaCategoria.ShowDialog();
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
                txtCategoriaProduto.Text = "Selecione...";
                txtUnidadeCompra.Text = "Selecione...";
            }
        }

        public Boolean ValidaCodigoBarraExistente()
        {
            objProdutos = new ProdutosTipo();
            objProdutoBO = new ProdutosBO();

            objProdutos._CodigoBarra = txtCodigoBarra.Text;

            objProdutos = objProdutoBO.SelecioneCodigoProduto(objProdutos);

            if (objProdutos != null)
            {
                MessageBox.Show("Código de barra ja cadastrado para um produto", "Gravação ok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoBarra.Focus();
                txtCodigoBarra.Clear();
                return true;
            }
            else
            {
                return false;
            }
        }

        private void txtCodigoBarra_Leave(object sender, EventArgs e)
        {
            if (ValidaCodigoBarraExistente() == true)
            {
                txtNomeProduto.Focus();
            }
            else
            {
                return;
            }
        }

        public void CarregaProdutoSelecionado(int codigo)
        {
            if (codigo != 0)
            {

                objProdutos = new ProdutosTipo();
                objProdutoBO = new ProdutosBO();

                objProdutos = objProdutoBO.SelectCodProduto(codigo);

                if (objProdutos != null)
                {
                    codigoProduto = codigo;
                    txtDataCadastro.Text = objProdutos._DataCadastro.ToString("dd/MM/yyyy");
                    txtCodigoBarra.Text = objProdutos._CodigoBarra;
                    txtNomeProduto.Text = objProdutos._NomeProduto;
                    txtDescricaoProduto.Text = objProdutos._DescricaoProduto;
                    txtCategoriaProduto.Text = objProdutos._CategoriaProduto;
                    txtUnidadeCompra.Text = objProdutos._UnidadeCompra;
                    txtQtdeMax.Text = objProdutos._EstoqueMaximo.ToString();
                    txtQtdeMin.Text = objProdutos._EstoqueMinimo.ToString();
                    txtValorCompra.Text = objProdutos._PrecoCompra.ToString("C");
                    txtValorVenda.Text = objProdutos._ValorUnitario.ToString("C");
                    txtMargemLucro.Text = objProdutos._MargemLucro;

                    CalcularLucro();

                    txtCaminhoImagem.Text = objProdutos._CaminhoImagem;

                    ExibirFoto();

                    Novo();
                }
            }
        }

        private void txtNomeFornecedor_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }
        private void frmManterProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNomeProduto.Focus();
            }
        }

        private void txtValorVenda_Leave_1(object sender, EventArgs e)
        {
            try
            {
                txtValorVenda.Text = Convert.ToDecimal(txtValorVenda.Text).ToString("C");

                decimal cValorCusta = Convert.ToDecimal(txtValorCompra.Text.Substring(3));
                decimal m_NovoValor = Convert.ToDecimal(txtValorVenda.Text.Substring(3));
                decimal i_porcentagem = 0;

                i_porcentagem = (m_NovoValor / cValorCusta) - 1;
                i_porcentagem = (i_porcentagem * 100);

                txtMargemLucro.Text = Convert.ToDecimal(string.Format("{0:n2}", i_porcentagem)).ToString();

                CalcularLucro();
            }
            catch (Exception)
            {
                MessageBox.Show("Informe o valor da compra do produto", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorCompra.Focus();
            }
        }

        private void CalcularLucro()
        {
            if ((!string.IsNullOrEmpty(txtValorVenda.Text)) && (!string.IsNullOrEmpty(txtValorCompra.Text)))
            {
                decimal lucro = decimal.Parse(txtValorVenda.Text.Substring(3)) - decimal.Parse(txtValorCompra.Text.Substring(3));
                txtLucro.Text = (lucro).ToString("C");
            }
        }


        private void txtValorCompra_Leave_1(object sender, EventArgs e)
        {
            try
            {
                txtValorCompra.Text = Convert.ToDecimal(txtValorCompra.Text).ToString("C");
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnAdicionarCategoria_Click_1(object sender, EventArgs e)
        {
            frmCategoria categoria = new frmCategoria();
            categoria.ShowDialog();

            txtCategoriaProduto.Items.Clear();
            PopulaCategoria();

            txtCategoriaProduto.Text = categoria.novaCategoria;
        }

        private void btnNovoFornecedor_Click_1(object sender, EventArgs e)
        {
            frmCadastroFornecedores fornecedores = new frmCadastroFornecedores();
            fornecedores.ShowDialog();
            txtNomeFornecedor_SelectedIndexChanged_1(this, e);
        }


        private void txtQtdeMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }

        private void txtQtdeMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && (e.KeyChar != (char)8))
            {
                e.Handled = true;
            }
        }

        private void txtCodigoBarra_Leave_1(object sender, EventArgs e)
        {
            if (codigoProduto == 0)
            {
                if (ValidaCodigoBarraExistente() == true) { } else { return; }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void toolStripButtonSalvar_Click(object sender, EventArgs e)
        {
            SalvarProduto();
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

        public void SalvaImagemDiretorio()
        {
            if (!string.IsNullOrEmpty(txtCaminhoImagem.Text.Trim()))
            {
                //Pega o arquivo de origem
                FileInfo arquivo = new FileInfo(txtCaminhoImagem.Text);

                //Copia arquivo de origem para pasta destinada
                string nomeExtensaoArquivo = Path.GetFileName(dlgOpen.FileName);

                if (File.Exists(exeLocation + "\\ImagensProdutos\\" + nomeExtensaoArquivo))
                {
                    File.Delete(exeLocation + "\\ImagensProdutos\\" + nomeExtensaoArquivo);
                }

                arquivo.CopyTo(exeLocation + "\\ImagensProdutos\\" + nomeExtensaoArquivo);

                caminhoImagem = exeLocation + "\\ImagensProdutos\\" + nomeExtensaoArquivo;
            }
        }

        private void btnSelecionarImagem_Click_1(object sender, EventArgs e)
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

        private void txtNomeProduto_TextChanged(object sender, EventArgs e)
        {
            txtDescricaoProduto.Text = txtNomeProduto.Text;
        }

        private void txtMargemLucro_Leave(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtValorCompra.Text))
                {
                    decimal margemLucro = Convert.ToDecimal(txtMargemLucro.Text);
                    decimal vlrCompra = decimal.Parse(txtValorCompra.Text.Substring(3));
                    decimal vlrLucro = (vlrCompra * margemLucro / 100);

                    txtValorVenda.Text = Convert.ToDecimal(vlrCompra + vlrLucro).ToString("C");

                    CalcularLucro();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Informe o valor da compra do produto", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorCompra.Focus();
            }
        }
    }
}
