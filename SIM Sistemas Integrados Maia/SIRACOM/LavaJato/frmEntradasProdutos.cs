using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Negocios.BO;
using Negocios.TIPO;
using Negocios.ProdTipo;
using Negocios.ProdBo;
using Negocios;

namespace LavaJato
{
    public partial class frmEntradasProdutos : Form
    {
        public frmEntradasProdutos()
        {
            InitializeComponent();
            HabilitaTitulosToolBar();
            PopularFornecedores();
        }

        EntradaProduto entradaProduto = new EntradaProduto();
        EntradaProdutoBO entradaProdutoBO = new EntradaProdutoBO();

        ItemEntradaProduto itemEntradaProduto = new ItemEntradaProduto();
        ItemEntradaProdutoBO itemEntradaProdutoBo = new ItemEntradaProdutoBO();

        ProdutosTipo produto = new ProdutosTipo();
        ProdutosBO produtoBo = new ProdutosBO();

        int codProduto;
        int contLinha = 0;
        int item = 1;
        int qtdeProduto;
        bool focoCodigoBarra, focoQtde, focoPrecoUnitario, focoSubTotal, edit;


        decimal vlrTotalEntrada, vlrTotalUnitario;

        private void HabilitaTitulosToolBar()
        {
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
        }

        public void ExibirDadosSelecionadasEntradaMercadorias(int cod)
        {
            txtDataEmissao.Enabled = false;
            txtNNotaFiscal.Enabled = false;
            txtNomeFornecedor.Enabled = false;
            txtCodigoBarra.Enabled = false;
            txtLote.Enabled = false;
            txtDataVencimento.Enabled = false;
            txtQtde.Enabled = false;
            txtPrecoUnitario.Enabled = false;
            txtSubtotalProduto.Enabled = false;
            edit = true;

            if (cod != null)
            {
                entradaProduto = entradaProdutoBO.SelecinaEntradaProdutoID(cod);

                if (entradaProduto != null)
                {
                    txtNNotaFiscal.Text = entradaProduto._NumeroDocumento.ToString();
                    txtVlrTotalGeral.Text = entradaProduto._TotalNotaFiscal.ToString("C");
                    txtDataEmissao.Text = entradaProduto._DataDocumento.ToString("dd/MM/yyyy");

                    CadastroFornecedores fornecedor = new CadastroFornecedores();
                    CadastroFornecedoresBO fornecedorBO = new CadastroFornecedoresBO();

                    fornecedor._CodigoFornecedor = entradaProduto.H_Fornecedor._CodigoFornecedor;
                    fornecedor = fornecedorBO.SelecionaFornecedores(fornecedor);

                    txtNomeFornecedor.SelectedValue = fornecedor._CodigoFornecedor;

                    DataTable dt = new DataTable();

                    dt = itemEntradaProdutoBo.CriaDataTableSelecionaItensEntradaMercadoria(cod);

                    if (dt != null)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            lwItensEntrada.Items.Add(item.ToString());
                            lwItensEntrada.Items[contLinha].SubItems.Add(row["CodigoProduto"].ToString());

                            produto = new ProdutosTipo();

                            produto = produtoBo.SelectCodProduto(Convert.ToInt32(row["CodigoProduto"]));

                            lwItensEntrada.Items[contLinha].SubItems.Add(produto._CodigoBarra);
                            lwItensEntrada.Items[contLinha].SubItems.Add(produto._DescricaoProduto);

                            lwItensEntrada.Items[contLinha].SubItems.Add(row["Lote"].ToString());
                            lwItensEntrada.Items[contLinha].SubItems.Add(Convert.ToDateTime(row["DataVencimento"]).ToString("dd/MM/yyyy"));
                            lwItensEntrada.Items[contLinha].SubItems.Add(row["Qtde"].ToString());
                            lwItensEntrada.Items[contLinha].SubItems.Add(Convert.ToDecimal(row["PrecoUnitario"]).ToString("C"));
                            lwItensEntrada.Items[contLinha].SubItems.Add(Convert.ToDecimal(row["Subtotal"]).ToString("C"));

                            contLinha++;
                            item++;

                            qtdeProduto += Convert.ToInt32(row["Qtde"]);
                            vlrTotalUnitario += Convert.ToDecimal(row["PrecoUnitario"]);
                            vlrTotalEntrada += Convert.ToDecimal(row["Subtotal"]);

                        }

                        SomaTotalizares();

                    }
                }
            }
        }

        private void SomaTotalizares()
        {
            txtQtdeProduto.Text = qtdeProduto.ToString();
            txtTotalVlrUnitario.Text = vlrTotalUnitario.ToString("C");
            txtVlrTotalGeral.Text = vlrTotalEntrada.ToString("C");
            txtQtdeItem.Text = lwItensEntrada.Items.Count.ToString();
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
            }
        }

        private void frmEntradasProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                PesquisarProduto();
            }
            if (e.KeyCode == Keys.Enter)
            {
                if (focoQtde == true)//Condição para realiar calculo de quantidade * valor unitario
                {
                    CalcularSubTotal();
                    txtPrecoUnitario.Focus();
                }
                if ((focoPrecoUnitario == true) && (!string.IsNullOrEmpty(txtPrecoUnitario.Text)))//Condição para realizar calculo, caso usuário queria alterar o valor do produto
                {
                    if (txtPrecoUnitario.Text.StartsWith("R$"))
                    {
                        this.txtPrecoUnitario.Text = txtPrecoUnitario.Text;
                    }
                    else
                    {
                        txtPrecoUnitario.Text = Convert.ToDecimal(txtPrecoUnitario.Text).ToString("C");
                    }

                    CalcularSubTotal();
                    txtSubtotalProduto.Focus();
                }

                if (txtSubtotalProduto.Focus() == true)//Condição para incluir produto na listagem
                {
                    if (ValidarCamposItens() == true)
                    {
                        if (MessageBox.Show("Confirma inclusão deste item na lista ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            IncluirProdutoListaEntrada();
                        }
                        else
                        {
                            txtPrecoUnitario.Focus();
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
            else if (e.KeyCode == Keys.F5)
            {
                toolStripButtonSalvar_Click(this, e);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void PesquisarProduto()
        {
            try
            {
                if (focoCodigoBarra == true)
                {
                    frmPesquisarProduto frmPProduto = new frmPesquisarProduto();
                    frmPProduto.ShowDialog();

                    txtCodigoBarra.Text = frmPProduto.codigoBarra;
                    produto._CodigoBarra = txtCodigoBarra.Text;

                    produto = produtoBo.SelectProduto(produto);

                    if (produto != null)
                    {
                        codProduto = produto._CodigoProduto;
                        txtDescricaoProduto.Text = produto._NomeProduto;
                        txtPrecoUnitario.Text = produto._PrecoCompra.ToString("C");
                        txtLote.Focus();
                        focoCodigoBarra = false;
                    }
                }
            }
            catch (Exception msg)
            {
            }
        }

        private void txtCodigoBarra_Enter(object sender, EventArgs e)
        {
            focoCodigoBarra = true;
        }

        private void txtQtde_Leave(object sender, EventArgs e)
        {
            CalcularSubTotal();
        }

        private void CalcularSubTotal()
        {
            try
            {
                if ((!string.IsNullOrEmpty(txtQtde.Text) && Convert.ToInt32(txtQtde.Text) != 0))
                {
                    txtSubtotalProduto.Text = (Convert.ToDecimal(txtPrecoUnitario.Text.Substring(3)) * Convert.ToInt32(txtQtde.Text)).ToString("C");
                }
            }
            catch (Exception) { }
        }

        private void IncluirProdutoListaEntrada()
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCodigoBarra.Text))
                {
                    lwItensEntrada.Items.Add(item.ToString());//Inclui item
                    lwItensEntrada.Items[contLinha].SubItems.Add(codProduto.ToString());
                    lwItensEntrada.Items[contLinha].SubItems.Add(txtCodigoBarra.Text);
                    lwItensEntrada.Items[contLinha].SubItems.Add(txtDescricaoProduto.Text);
                    lwItensEntrada.Items[contLinha].SubItems.Add(txtLote.Text);
                    lwItensEntrada.Items[contLinha].SubItems.Add(txtDataVencimento.Text);
                    lwItensEntrada.Items[contLinha].SubItems.Add(txtQtde.Text);
                    lwItensEntrada.Items[contLinha].SubItems.Add(txtPrecoUnitario.Text);
                    lwItensEntrada.Items[contLinha].SubItems.Add(txtSubtotalProduto.Text);

                    contLinha++;//incrementa + 1
                    item++;//incrementa + 1;

                    vlrTotalEntrada += Convert.ToDecimal(txtSubtotalProduto.Text.Substring(3));
                    vlrTotalUnitario += Convert.ToDecimal(txtPrecoUnitario.Text.Substring(3));
                    qtdeProduto += Convert.ToInt32(txtQtde.Text);

                    txtVlrTotalGeral.Text = vlrTotalEntrada.ToString("C");
                    txtTotalVlrUnitario.Text = vlrTotalUnitario.ToString("C");
                    txtQtdeProduto.Text = qtdeProduto.ToString();
                    txtQtdeItem.Text = lwItensEntrada.Items.Count.ToString();

                    //Habilita o campo salvar
                    toolStripButtonSalvar.Enabled = true;

                    //LimpaCampos
                    txtCodigoBarra.Text = string.Empty;
                    txtDescricaoProduto.Text = string.Empty;
                    txtQtde.Text = string.Empty;
                    txtSubtotalProduto.Text = string.Empty;
                    txtDataVencimento.Text = string.Empty;
                    txtLote.Text = string.Empty;
                    txtPrecoUnitario.Text = string.Empty;
                    txtCodigoBarra.Focus();

                    //limpar
                    codProduto = 0;
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PecorreListaItensEntradaProduto()
        {
            vlrTotalEntrada = 0;
            vlrTotalUnitario = 0;
            qtdeProduto = 0;

            for (int i = 0; i < lwItensEntrada.Items.Count; i++)
            {
                vlrTotalEntrada += decimal.Parse(lwItensEntrada.Items[i].SubItems[8].Text.Substring(3));
                vlrTotalUnitario += decimal.Parse(lwItensEntrada.Items[i].SubItems[7].Text.Substring(3));
                qtdeProduto += Convert.ToInt32(lwItensEntrada.Items[i].SubItems[6].Text);
            }

            txtVlrTotalGeral.Text = vlrTotalEntrada.ToString("C");
            txtTotalVlrUnitario.Text = vlrTotalUnitario.ToString("C");
            txtQtdeProduto.Text = qtdeProduto.ToString();
            txtQtdeItem.Text = lwItensEntrada.Items.Count.ToString();
        }

        private void txtQtde_Enter(object sender, EventArgs e)
        {
            focoQtde = true;
        }

        private void txtPrecoUnitario_Enter(object sender, EventArgs e)
        {
            focoPrecoUnitario = true;
        }

        private void txtPrecoUnitario_Leave(object sender, EventArgs e)
        {
            CalcularSubTotal();
        }

        private void txtSubtotalProduto_Enter(object sender, EventArgs e)
        {
            focoSubTotal = true;
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaCabecalhoEntrada() == true)
            {
                GravarEntradaMercadorias();
            }
            else
            {
                return;
            }
        }

        private bool ValidaCabecalhoEntrada()
        {
            if (txtNNotaFiscal.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Informe o número da nota fiscal", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNNotaFiscal.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidarCamposItens()
        {
            if (txtCodigoBarra.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Informe o código de barra do produto", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoBarra.Focus();
                return false;
            }

            if (txtLote.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Informe o lote do produto", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLote.Focus();
                return false;
            }


            if ((txtDataVencimento.Text.Length != 10) && (!string.IsNullOrEmpty(txtDataVencimento.Text)))
            {
                MessageBox.Show("Informe a data de vencimento do produto", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDataVencimento.Focus();
                return false;
            }

            if (txtQtde.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Informe a quantidade de produto", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQtde.Focus();
                return false;
            }

            if (txtPrecoUnitario.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Informe o valor unitário do produto", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrecoUnitario.Focus();
                return false;
            }
            if (txtSubtotalProduto.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Informe o subtotal do produto", "Campo obrigatório", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSubtotalProduto.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void GravarEntradaMercadorias()
        {
            try
            {
                if (txtNomeFornecedor.Text.Trim() == string.Empty)
                {
                    txtNomeFornecedor.Focus();
                    throw (new Exception("Selecione o fornecedor"));
                }

                entradaProduto.H_Fornecedor._CodigoFornecedor = Convert.ToInt32(txtNomeFornecedor.SelectedValue);
                entradaProduto._DataEntrada = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                entradaProduto._DataDocumento = Convert.ToDateTime(txtDataEmissao.Text);
                entradaProduto._Desconto = Convert.ToDecimal("0,00");
                entradaProduto._NumeroDocumento = int.Parse(txtNNotaFiscal.Text);
                entradaProduto._NumeroSerie = int.Parse("0");
                entradaProduto._OutrasDespesas = Convert.ToDecimal("0,00");
                entradaProduto._TotalNotaFiscal = vlrTotalEntrada;
                entradaProduto._ValorFrete = Convert.ToDecimal("0,00");

                if (MessageBox.Show("Deseja salvar esta entrada? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    entradaProdutoBO.InserirEntradaProduto(entradaProduto);

                    entradaProduto = entradaProdutoBO.SelecionaUltimoRegistroEntradaProduto();//pega ultimo orcamento

                    GravarItensEntradaMercadoria();

                    MessageBox.Show("Entrada de mercadoria realizada com com sucesso", "Gravação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (MessageBox.Show("Deseja iniciar uma nova entrada ? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LimpaCampos();
                        LimparCamposBox(this);
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void GravarItensEntradaMercadoria()
        {
            for (int i = 0; i < lwItensEntrada.Items.Count; i++)
            {
                itemEntradaProduto.H_EntradaProduto._EntradaID = entradaProduto._EntradaID;
                itemEntradaProduto.H_Produto._CodigoProduto = int.Parse(lwItensEntrada.Items[i].SubItems[1].Text);
                itemEntradaProduto.Lote = lwItensEntrada.Items[i].SubItems[4].Text;
                itemEntradaProduto.DataVencimento = Convert.ToDateTime(lwItensEntrada.Items[i].SubItems[5].Text);
                itemEntradaProduto._Quantidade = int.Parse(lwItensEntrada.Items[i].SubItems[6].Text);
                itemEntradaProduto._PrecoUnitario = decimal.Parse(lwItensEntrada.Items[i].SubItems[7].Text.Substring(3));
                itemEntradaProduto._PrecoParcial = decimal.Parse(lwItensEntrada.Items[i].SubItems[8].Text.Substring(3));

                //Grava o item
                itemEntradaProdutoBo.InserirItensEntradaProduto(itemEntradaProduto);

                //Altera a quantidade de produtos no estoque
                produto = new ProdutosTipo();

                produto._CodigoProduto = itemEntradaProduto.H_Produto._CodigoProduto;
                produto._QtdeEstoque = itemEntradaProduto._Quantidade;
                produto._PrecoCompra = itemEntradaProduto._PrecoUnitario;

                produtoBo.AlterarQuantidadeEstoqueProduto(produto);
            }
        }

        private void LimpaCampos()
        {
            lwItensEntrada.Items.Clear();
            txtDataEmissao.Focus();
            txtDataVencimento.Text = string.Empty;
            vlrTotalEntrada = 0;
            vlrTotalUnitario = 0;
            qtdeProduto = 0;
            contLinha = 0;
            item = 1;
        }

        public void PopularFornecedores()
        {
            CadastroFornecedoresBO fornecedoresBO = new CadastroFornecedoresBO();

            txtNomeFornecedor.DataSource = fornecedoresBO.CriaDataFornecedores();
            txtNomeFornecedor.ValueMember = "CodigoFornecedor";
            txtNomeFornecedor.DisplayMember = "Nome_Fantasia";
        }

        private void btnNovoFornecedor_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedores fornecedores = new frmCadastroFornecedores();
            fornecedores.ShowDialog();

            PopularFornecedores();

            txtNomeFornecedor.Text = fornecedores.razaoSocial;
        }

        private void frmEntradasProdutos_Load(object sender, EventArgs e)
        {
            if (edit != true)
            {
                NovaEntrada();
            }
        }

        private void NovaEntrada()
        {
            txtDataEmissao.Focus();
            txtTotalVlrUnitario.Text = "0,00";
            txtQtdeProduto.Text = "0";
            txtVlrTotalGeral.Text = "0,00";
            toolStripButtonSalvar.Enabled = false;
        }


        private void txtCodigoBarra_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoBarra.Text))
            {
                produto = new ProdutosTipo();
                produtoBo = new ProdutosBO();

                produto._CodigoBarra = txtCodigoBarra.Text;

                produto = produtoBo.SelectProduto(produto);

                if (produto != null)
                {
                    txtCodigoBarra.Text = produto._CodigoBarra;
                    codProduto = produto._CodigoProduto;
                    txtDescricaoProduto.Text = produto._NomeProduto;
                    txtPrecoUnitario.Text = produto._PrecoCompra.ToString("C");
                }
                else
                {
                    MessageBox.Show("Produto não cadastrado - solicite o cadastro do mesmo", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigoBarra.Focus();
                    txtCodigoBarra.Clear();
                }
            }
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            if (lwItensEntrada.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show("Confirma remover este item ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int index = lwItensEntrada.FocusedItem.Index;
                    lwItensEntrada.Items.RemoveAt(index);
                    PecorreListaItensEntradaProduto();
                    contLinha = contLinha - 1;
                    item = item - 1;
                }
            }
        }

        private void txtDataVencimento_Leave(object sender, EventArgs e)
        {
            try
            {
                DateTime data = Convert.ToDateTime(txtDataVencimento.Text);
            }
            catch (Exception msgErro)
            {
                MessageBox.Show(msgErro.Message + " - " + txtDataVencimento.Text, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDataVencimento.Focus();
                txtDataVencimento.Clear();
            }
        }
    }
}

