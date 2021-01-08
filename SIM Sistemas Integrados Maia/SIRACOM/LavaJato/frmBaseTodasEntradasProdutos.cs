using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.BO;
using Negocios.TIPO;
using Negocios;
using Negocios.ProdTipo;
using Negocios.ProdBo;

namespace LavaJato
{
    public partial class frmBaseTodasEntradasProdutos : Form
    {
        public frmBaseTodasEntradasProdutos()
        {
            InitializeComponent();
            HabilitaTitulosToolBar();
            txtDateInicial.Text = "01/01/2010";
            txtDataFinal.Text = "01/01/2020";
        }

        int contLinha = 0;
        int qtdeItem, entradaID;
        decimal vlrTotalFrete, vlrTotalDespesa, vlrTotalGeral, vlrTotalDesconto;

        private void HabilitaTitulosToolBar()
        {
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
        }

        private void toolStripSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtono_Click(object sender, EventArgs e)
        {
            using (frmEntradasProdutos frm = new frmEntradasProdutos())
            {
                frm.ShowDialog();
                CarregaListagemEntradaMercadorias();
            }
        }

        private void frmBaseTodasEntradasProdutos_Load(object sender, EventArgs e)
        {
            CarregaListagemEntradaMercadorias();
            PopularFornecedores();
        }

        public void PopularFornecedores()
        {
            CadastroFornecedoresBO fornecedoresBO = new CadastroFornecedoresBO();

            txtNomeFornecedor.DataSource = fornecedoresBO.CriaDataFornecedores();
            txtNomeFornecedor.ValueMember = "CodigoFornecedor";
            txtNomeFornecedor.DisplayMember = "Nome_Fantasia";
        }

        private void CarregaListagemEntradaMercadorias()
        {
            DataSet ds = new DataSet();
            EntradaProdutoBO entradaProdutoBO = new EntradaProdutoBO();
            lwEntradaMercadorias.Items.Clear();
            ZerarTotalizadores();

            ds = entradaProdutoBO.SelecionaEntradaMercadoirasDataSet(DateTime.Parse(txtDateInicial.Text), DateTime.Parse(txtDataFinal.Text), int.Parse("0"));

            if (ds != null)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    lwEntradaMercadorias.Items.Add(row["CodigoEntrada"].ToString());
                    lwEntradaMercadorias.Items[contLinha].SubItems.Add(Convert.ToDateTime(row["DataEntrada"]).ToString("dd/MM/yyyy"));
                    lwEntradaMercadorias.Items[contLinha].SubItems.Add(row["CNPJ"].ToString());
                    lwEntradaMercadorias.Items[contLinha].SubItems.Add(row["Nome_Fantasia"].ToString());
                    lwEntradaMercadorias.Items[contLinha].SubItems.Add(row["NumeroDocumento"].ToString());
                    lwEntradaMercadorias.Items[contLinha].SubItems.Add(Convert.ToDecimal(row["ValorFrete"]).ToString("C"));
                    lwEntradaMercadorias.Items[contLinha].SubItems.Add(Convert.ToDecimal(row["OutrasDespesas"]).ToString("C"));
                    lwEntradaMercadorias.Items[contLinha].SubItems.Add(Convert.ToDecimal(row["Desconto"]).ToString("C"));
                    lwEntradaMercadorias.Items[contLinha].SubItems.Add(Convert.ToDecimal(row["TotaldaNota"]).ToString("C"));

                    contLinha++;

                    qtdeItem = Convert.ToInt32(lwEntradaMercadorias.Items.Count);
                    vlrTotalGeral += Convert.ToDecimal(row["TotaldaNota"]);
                    vlrTotalFrete += Convert.ToDecimal(row["ValorFrete"]);
                    vlrTotalDespesa += Convert.ToDecimal(row["OutrasDespesas"]);
                    vlrTotalDesconto += Convert.ToDecimal(row["Desconto"]);
                }

                SomaTotalizares();
            }
        }

        private void ZerarTotalizadores()
        {
            lwEntradaMercadorias.Items.Clear();
            vlrTotalDesconto = 0;
            vlrTotalDespesa = 0;
            vlrTotalFrete = 0;
            vlrTotalGeral = 0;
            qtdeItem = 0;
            contLinha = 0;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ZerarTotalizadores();
            CarregaListagemEntradaMercadorias();
        }

        private void SomaTotalizares()
        {
            txtTotalItem.Text = qtdeItem.ToString();
            txtTotalVlrFrete.Text = vlrTotalFrete.ToString("C");
            txtVlrTotalDesconto.Text = vlrTotalDesconto.ToString("C");
            txtVlrTotalDespesas.Text = vlrTotalDespesa.ToString("C");
            txtVlrTotalGeral.Text = vlrTotalGeral.ToString("C");
        }

        private void btnLimparBusca_Click(object sender, EventArgs e)
        {
            ZerarTotalizadores();

            txtDateInicial.Text = "01/01/2010";
            txtDataFinal.Text = "01/01/2020";

            CarregaListagemEntradaMercadorias();
        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma estorno desta entrada - Nº " + entradaID + " ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (entradaID > 0)
                {
                    EntradaProdutoBO entradaProdutoBO = new EntradaProdutoBO();
                    EntradaProduto entradaProduto = new EntradaProduto();

                    ItemEntradaProdutoBO itemEntradaProdutoBO = new ItemEntradaProdutoBO();
                    ItemEntradaProduto itemEntradaProduto = new ItemEntradaProduto();

                    //Recupera dados referente entrada
                    entradaProduto = entradaProdutoBO.SelecinaEntradaProdutoID(entradaID);

                    if (entradaProduto != null)
                    {
                        //Atualiza quantidade estoque
                        //Altera a quantidade de produtos no estoque
                        DataTable dtItens = itemEntradaProdutoBO.CriaDataTableSelecionaItensEntradaMercadoria(entradaID);

                        foreach (DataRow item in dtItens.Rows)
                        {
                            ProdutosTipo produto = new ProdutosTipo();
                            ProdutosBO produtoBO = new ProdutosBO();

                            produto._CodigoProduto = Convert.ToInt32(item["CodigoProduto"]);
                            produto._QtdeEstoque = Convert.ToInt32(item["Qtde"]);

                            produtoBO.BaixarQtdeProdutoEstoque(produto._CodigoProduto, produto._QtdeEstoque);
                        }

                        //ExcluirEntrada
                        entradaProdutoBO.ExcluirEntradaProduto(entradaID);

                        //Excluir Itens da entrada
                        itemEntradaProdutoBO.ExcluirItensEntradaProduto(entradaID);

                        MessageBox.Show("Entrada estornada com sucesso", "Estorno bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CarregaListagemEntradaMercadorias();
                    }
                    else
                    {
                        MessageBox.Show("Não e possivel realizar exclusão selecione uma opção", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void lwEntradaMercadorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lwEntradaMercadorias.Items.Count > 0)
            {
                entradaID = int.Parse(lwEntradaMercadorias.FocusedItem.SubItems[0].Text);
            }
        }

        private void frmBaseTodasEntradasProdutos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void lwEntradaMercadorias_DoubleClick(object sender, EventArgs e)
        {
            if (lwEntradaMercadorias.Items.Count > 0)
            {
                using (frmEntradasProdutos frm = new frmEntradasProdutos())
                {
                    frm.ExibirDadosSelecionadasEntradaMercadorias(Convert.ToInt32(lwEntradaMercadorias.FocusedItem.SubItems[0].Text));
                    frm.ShowDialog();
                }
            }
        }
    }
}
