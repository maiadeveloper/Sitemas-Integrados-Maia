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
using Negocios;
using Negocios.TIPO;
using Negocios.BO;

namespace LavaJato
{
    public partial class frmRealizarOrcamento : Form
    {
        public frmRealizarOrcamento()
        {
            InitializeComponent();
        }

        ProdutosTipo objProdutos;
        ProdutosBO objProdutoBO;

        Orcamento orcamento;
        OrcamentoBO orcamentoBO;

        ItensOrcamento itensOrcamento;
        ItensOrcamentoBO itensOrcamentoBO;

        int countRow = 0;
        int item = 1;
        decimal valorTotalOrcamento = 0;
        int codigoProduto = 0;
        int orcamentoID = 0;
        int inclurItem = 0;
        int posItemRemover;
        bool desconto;

        private void HabilitaTitulos()
        {
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
        }

        private void frmRealizarOrcamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (desconto == true)
                {
                    AplicarDesconto();
                }
                else
                {

                    if (inclurItem <= 0)
                    {
                        BuscarProdutoPorCodigoBarra();
                    }
                    else if (txtSubtotalProduto.Text.Trim() == string.Empty)
                    {
                        if (txtQtde.Text.Trim() == string.Empty)
                        {
                            txtQtde.Focus();
                            MessageBox.Show("Quantidade não pode ser menor que 1", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            txtSubtotalProduto.Text = SubTotalProduto(Convert.ToDecimal(txtPrecoUnitario.Text.Substring(3)), Convert.ToInt32(txtQtde.Text)).ToString("C");
                        }
                    }
                    else if (txtSubtotalProduto.Text != string.Empty)
                    {
                        IncluirProdutoListaOrcamento();
                    }
                }
            }
            else if (e.KeyCode == Keys.F5)
            {
                GravarOrcamento();
            }
            else if (e.KeyCode == Keys.F2)
            {
                PesquisarProduto();
            }
            else if (e.KeyCode == Keys.F3)
            {
                PesquisarCliente();
            }

            else if (e.KeyCode == Keys.F6)
            {
                LimpaCampos();
            }
            else if (e.KeyCode == Keys.F7)
            {
                RemoverUltimoItemLista();
                PecorreListaItensOrcamento();
            }
            else if (e.KeyCode == Keys.F4)
            {
                txtDesconto.Focus();
                txtDesconto.Clear();
            }
        }

        private void AplicarDesconto()
        {
            try
            {
                if ((!string.IsNullOrEmpty(txtTotalOrcamento.Text) && (!string.IsNullOrEmpty(txtDesconto.Text))))
                {
                    if (desconto == true)
                    {
                        decimal desc = decimal.Parse(txtDesconto.Text);
                        decimal total = decimal.Parse(txtTotalOrcamento.Text.Substring(3));

                        total = total - desc;

                        txtDesconto.Text = Convert.ToDecimal(txtDesconto.Text).ToString("C");
                        txtTotalFinalPagar.Text = total.ToString("C");
                        txtTotalFinalPagar.Focus();
                    }
                }
                else
                {
                    desconto = false;
                    MessageBox.Show("Desconto não pode ser aplicado - Valor insuficiente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigoBarra.Focus();
                }
            }
            catch (Exception MSG)
            {
                GravarOrcamento();
            }
        }

        private void PecorreListaItensOrcamento()
        {
            decimal vlrTotalParcial = 0;

            for (int i = 0; i < listViewProdutos.Items.Count; i++)
            {
                vlrTotalParcial += decimal.Parse(listViewProdutos.Items[i].SubItems[6].Text.Substring(3));
            }

            txtTotalOrcamento.Text = vlrTotalParcial.ToString("C");
            lblQtdeItem.Text = string.Format("Qtde de item: {0}", listViewProdutos.Items.Count);
            
        }

        private void RemoverUltimoItemLista()
        {
            try
            {
                frmRemoverItemVendaPosicao frm = new frmRemoverItemVendaPosicao();
                frm.ShowDialog();

                for (int i = 0; i < listViewProdutos.Items.Count; i++)
                {
                    string codigoSelecionado = listViewProdutos.Items[i].SubItems[2].Text;

                    if (frm.codigoBarra == codigoSelecionado)
                    {
                        posItemRemover = i;
                        countRow = countRow - 1;
                        item = item - 1;
                        listViewProdutos.Items.RemoveAt(posItemRemover);
                    }
                }
            }
            catch (Exception) { }
        }
        private void IncluirProdutoListaOrcamento()
        {
            try
            {
                if (!string.IsNullOrEmpty(txtCodigoBarra.Text))
                {
                    listViewProdutos.Items.Add(item.ToString());//Inclui item
                    listViewProdutos.Items[countRow].SubItems.Add(codigoProduto.ToString());
                    listViewProdutos.Items[countRow].SubItems.Add(txtCodigoBarra.Text);
                    listViewProdutos.Items[countRow].SubItems.Add(txtDescricaoProduto.Text);
                    listViewProdutos.Items[countRow].SubItems.Add(txtPrecoUnitario.Text);
                    listViewProdutos.Items[countRow].SubItems.Add(txtQtde.Text);
                    listViewProdutos.Items[countRow].SubItems.Add(SubTotalProduto(Convert.ToDecimal(txtPrecoUnitario.Text.Substring(3)), Convert.ToInt32(txtQtde.Text)).ToString("C"));

                    valorTotalOrcamento += SubTotalProduto(Convert.ToDecimal(txtPrecoUnitario.Text.Substring(3)), Convert.ToInt32(txtQtde.Text));
                    txtTotalOrcamento.Text = Convert.ToDecimal(valorTotalOrcamento).ToString("C");
                    txtTotalFinalPagar.Text = Convert.ToDecimal(valorTotalOrcamento).ToString("C");

                    countRow++;//incrementa + 1
                    item++;//incrementa + 1;

                    //LimpaCampos
                    txtCodigoBarra.Text = string.Empty;
                    txtDescricaoProduto.Text = string.Empty;
                    txtQtde.Text = string.Empty;
                    txtSubtotalProduto.Text = string.Empty;
                    txtPrecoUnitario.Clear();
                    txtCodigoBarra.Focus();

                    //limpar
                    codigoProduto = 0;
                    inclurItem = 0;

                    lblQtdeItem.Text = string.Format("Qtde de item: {0}", listViewProdutos.Items.Count);
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal SubTotalProduto(decimal valor, int qtde)
        {
            return valor < 0 ? 0 : (Convert.ToDecimal(valor * qtde));
        }

        private void BuscarProdutoPorCodigoBarra()
        {
            if (txtCodigoBarra.Text.Trim() != string.Empty)
            {
                objProdutoBO = new ProdutosBO();
                objProdutos = new ProdutosTipo();

                objProdutos._CodigoBarra = txtCodigoBarra.Text;

                objProdutos = objProdutoBO.SelecioneCodigoProduto(objProdutos);

                if (objProdutos != null)
                {
                    txtCodigoBarra.Text = objProdutos._CodigoBarra;
                    txtDescricaoProduto.Text = objProdutos._NomeProduto;
                    codigoProduto = int.Parse(objProdutos._CodigoProduto.ToString());
                    txtPrecoUnitario.Text = Convert.ToDecimal(objProdutos._ValorUnitario).ToString("C");
                    txtQtde.Focus();
                    inclurItem = 1;
                }
            }
            else
            {
                MessageBox.Show("Digite o código de barra do produto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigoBarra.Focus();
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonSalvar_Click(object sender, EventArgs e)
        {
            GravarOrcamento();
        }

        private void GravarOrcamento()
        {
            try
            {
                if (txtCodigoCliente.Text.Trim() == string.Empty)
                {
                    txtCodigoCliente.Focus();
                    throw (new Exception("Informe o cliente para este orçamento"));
                }

                if (listViewProdutos.Items.Count < 1)
                {
                    txtCodigoBarra.Focus();
                    throw (new Exception("Não existem itens para o orçamento"));
                }

                orcamento = new Orcamento();
                orcamentoBO = new OrcamentoBO();

                orcamento._ClienteID = Convert.ToInt32(txtCodigoCliente.Text);
                orcamento._DataHoraAbertura = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                orcamento._Status = 1;
                orcamento._VlrTotal = decimal.Parse(txtTotalFinalPagar.Text.Substring(3));
                orcamento._VlrDesconto = decimal.Parse(txtDesconto.Text.Substring(3));
              

                if (MessageBox.Show("Deseja salvar este orçamento? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    orcamentoBO.Gravar(orcamento);//grava

                    orcamento = orcamentoBO.SelecionarUltimoOrcamento();//pega ultimo orcamento

                    itensOrcamento = new ItensOrcamento();
                    itensOrcamentoBO = new ItensOrcamentoBO();

                    for (int i = 0; i < listViewProdutos.Items.Count; i++)
                    {
                        itensOrcamento._OrcamentoID = orcamento._OrcamentoID;
                        itensOrcamento._Item = i + 1;
                        itensOrcamento._ProdutoID = int.Parse(listViewProdutos.Items[i].SubItems[1].Text);
                        itensOrcamento._Qtde = int.Parse(listViewProdutos.Items[i].SubItems[5].Text);
                        itensOrcamento._Total = decimal.Parse(listViewProdutos.Items[i].SubItems[6].Text.Substring(3));
                        itensOrcamento._VlorUnitario = decimal.Parse(listViewProdutos.Items[i].SubItems[4].Text.Substring(3));

                        itensOrcamentoBO.Gravar(itensOrcamento);
                    }

                    MessageBox.Show("Orçamento salvo com sucesso", "Gravação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (MessageBox.Show("Deseja imprimir este orçamento ? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        FrmRelatorioOrcamento frmRO = new FrmRelatorioOrcamento();
                        frmRO.SelecionaOrcamentoPorID(orcamento._OrcamentoID);
                        frmRO.ShowDialog();
                    }

                    if (MessageBox.Show("Deseja iniciar outro orçamento ? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LimpaCampos();
                    }
                    else
                    {
                        this.Close();
                    }

                    LimpaCampos();
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PesquisarCliente()
        {
            try
            {
                frmPesquisarCliente frmCliente = new frmPesquisarCliente();
                frmCliente.ShowDialog();

                txtCodigoCliente.Text = frmCliente.codigoCliente.ToString();
                txtNomeCliente.Text = frmCliente.nomeCliente;
                txtCpfCNPJ.Text = frmCliente.cpfCnpj;
                txtCodigoBarra.Focus();
            }
            catch (Exception)
            {
                //erro
            }
        }

        private void PesquisarProduto()
        {
            try
            {
                frmPesquisarProduto frmPProduto = new frmPesquisarProduto();
                frmPProduto.ShowDialog();

                txtCodigoBarra.Text = frmPProduto.codigoBarra;
                txtDescricaoProduto.Text = frmPProduto.nomeProduto;
                codigoProduto = frmPProduto.codigoProduto;
                txtPrecoUnitario.Text = Convert.ToDecimal(frmPProduto.valorUnitario).ToString("C");
                txtQtde.Focus();
            }
            catch (Exception msg)
            {
            }
        }

        private void txtPrecoUnitario_Leave(object sender, EventArgs e)
        {
            txtPrecoUnitario.Text = Convert.ToDecimal(txtPrecoUnitario.Text).ToString("C");
        }

        private void IniciaNovoOrcamento()
        {
            orcamento = new Orcamento();
            orcamentoBO = new OrcamentoBO();

            int numeroOrcamento = 0;
            orcamento = orcamentoBO.SelecionarUltimoOrcamento();

            if (orcamento != null)
            {
                numeroOrcamento = orcamento._OrcamentoID;
                numeroOrcamento += 1;
            }
            else
            {
                numeroOrcamento = 1;
            }

            txtDataOrcamento.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtNumeroOrcamento.Text = preencheNumeros(numeroOrcamento.ToString());
            txtTotalOrcamento.Text = "0,00";
            txtDesconto.Text = "0,00";
        }

        protected string preencheNumeros(string num)
        {
            while (num.Length < 4)
            {
                num = "0" + num;
            }

            return num;
        }

        private void frmRealizarOrcamento_Load(object sender, EventArgs e)
        {
            IniciaNovoOrcamento();
            HabilitaTitulos();
        }

        private void LimpaCampos()
        {
            IniciaNovoOrcamento();
            listViewProdutos.Items.Clear();
            txtCodigoCliente.Clear();
            txtNomeCliente.Clear();
            txtCpfCNPJ.Clear();
            countRow = 0;
            item = 1;
            valorTotalOrcamento = 0;
            codigoProduto = 0;
            txtDesconto.Text = txtTotalFinalPagar.Text = txtTotalOrcamento.Text = "0,00";
            txtCodigoCliente.Focus();
        }

        private void txtDesconto_Enter(object sender, EventArgs e)
        {
            desconto = true;
        }
    }
}
