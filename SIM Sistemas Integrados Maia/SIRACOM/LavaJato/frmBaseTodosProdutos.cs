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
using Negocios.TIPO;
using Negocios.BO;


namespace LavaJato
{
    public partial class frmBaseTodosProdutos : Form
    {
        public frmBaseTodosProdutos()
        {
            InitializeComponent();
            CarregaProdutos();
        }

        int totalItem = 0;
        int qtdeItem = 0;
        decimal totalEmProduto = 0;
        int countRow = 0;
        string campo;
        string parametro;
        int qtdeEstMax = 0;
        int qtdeEstMin = 0;
        int qtdeEstAtual = 0;

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HabilitaTitulos()
        {
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
        }

        private void CarregaProdutos()
        {
            DataTable dt = new DataTable();
            ProdutosTipo produtos = new ProdutosTipo();
            ProdutosBO produtosBo = new ProdutosBO();

            dt = produtosBo.CriaDataTableSelecionaTodosProdutos(txtBusca.Text);

            if (dt != null)
            {
                listViewProdutos.Items.Clear();

                qtdeItem = 0;
                qtdeEstAtual = 0;
                qtdeEstMax = 0;
                qtdeEstMin = 0;
                totalEmProduto = 0;

                foreach (DataRow row in dt.Rows)
                {
                    //Adiciona os itens do list view
                    listViewProdutos.Items.Add(row.ItemArray[0].ToString());//0
                    listViewProdutos.Items[countRow].SubItems.Add((row.ItemArray[1]).ToString());//1
                    listViewProdutos.Items[countRow].SubItems.Add(row.ItemArray[2].ToString());//2
                    listViewProdutos.Items[countRow].SubItems.Add(row.ItemArray[3].ToString());//3
                    listViewProdutos.Items[countRow].SubItems.Add((row["CategoriaProduto"]).ToString());//4
                    listViewProdutos.Items[countRow].SubItems.Add((row["UnidadeCompra"]).ToString());//6
                    listViewProdutos.Items[countRow].SubItems.Add((row["EstoqueMaximo"]).ToString());//8
                    listViewProdutos.Items[countRow].SubItems.Add((row["EstoqueMinimo"].ToString()));//7   
                    listViewProdutos.Items[countRow].SubItems.Add((row["QtdeEstoque"]).ToString());//9
                    listViewProdutos.Items[countRow].SubItems.Add(Convert.ToDecimal(row["PrecoCompra"]).ToString("C"));
                    listViewProdutos.Items[countRow].SubItems.Add(Convert.ToDecimal(row["PrecoUnitario"]).ToString("C"));

                    countRow++;

                    qtdeItem = dt.Rows.Count; //Recebe a quantidade de contas a receber
                    qtdeEstMin += Convert.ToInt32(row.ItemArray[9]);//Recebe quantidade minima em estoque
                    qtdeEstMax += Convert.ToInt32(row.ItemArray[10]);//Recebe quantidade estoque maximo em estoque   
                    qtdeEstAtual += Convert.ToInt32(row.ItemArray[11]);//Recebe quantidade estoque atual em estoque
                    totalEmProduto += Convert.ToDecimal(row["PrecoUnitario"]);//Recebe valor total de produtos em estoque

                }

                txtTotalemProdutos.Text = totalEmProduto.ToString("C");
                txtQtde.Text = qtdeItem.ToString();
                txtEstoqueMaximo.Text = qtdeEstMax.ToString();
                txtEstoqueMinimo.Text = qtdeEstMin.ToString();
                txtEstoqueAtual.Text = qtdeEstAtual.ToString();
                countRow = 0;
            }
        }

        private void rbCodigoBarra_CheckedChanged(object sender, EventArgs e)
        {
            CarregaProdutos();
            txtBusca.Focus();
            txtBusca.Clear();
        }

        private void rbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            CarregaProdutos();
            txtBusca.Focus();
            txtBusca.Clear();
        }

        private void rbDescricao_CheckedChanged(object sender, EventArgs e)
        {
            CarregaProdutos();
            txtBusca.Focus();
            txtBusca.Clear();
        }

        private void frmBaseTodosProdutos_Load(object sender, EventArgs e)
        {
            txtBusca.Focus();
            HabilitaTitulos();
        }

        private void toolStripSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtonOrcamento_Click(object sender, EventArgs e)
        {
            frmManterProdutos frmProduto = new frmManterProdutos();
            frmProduto.ShowDialog();

            //atualiza lista
            CarregaProdutos();
        }

        private void btnLimparBusca_Click_1(object sender, EventArgs e)
        {
            txtBusca.Clear();
            txtBusca.Focus();
            CarregaProdutos();
        }

        private void txtBusca_TextChanged_1(object sender, EventArgs e)
        {
            CarregaProdutos();
        }

        private void ExcluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewProdutos.Items.Count > 0)
            {
                if (MessageBox.Show("Confirma exclusão deste produto: " + listViewProdutos.FocusedItem.SubItems[2].Text + " ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ProdutosBO produtosBo = new ProdutosBO();

                    if (ConsultaEntradaProdutoCod(int.Parse(listViewProdutos.FocusedItem.SubItems[0].Text)) == false)
                    {
                        produtosBo.ExlcuirProduto(int.Parse(listViewProdutos.FocusedItem.SubItems[0].Text));
                        MessageBox.Show("Produto excluido com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBusca.Clear();
                        CarregaProdutos();
                    }
                    else
                    {
                        MessageBox.Show("Este produto não pode ser excluido pois ele encontra-se vinculado a um evento no sistema", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }
            }
        }

        private bool ConsultaEntradaProdutoCod(int cod)
        {
            bool resp = false;

            if (cod > 0)
            {

                ItemEntradaProduto itemEntradaProduto = new ItemEntradaProduto();
                ItemEntradaProdutoBO itemEntradaProdtuoBO = new ItemEntradaProdutoBO();

                itemEntradaProduto = itemEntradaProdtuoBO.SelecinaEntradaCodigoProduto(cod);

                if (itemEntradaProduto != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return resp;
        }

        private void listViewProdutos_DoubleClick_1(object sender, EventArgs e)
        {
            int codigoProduto = int.Parse(listViewProdutos.FocusedItem.SubItems[0].Text);

            frmManterProdutos frmProduto = new frmManterProdutos();

            frmProduto.CarregaProdutoSelecionado(codigoProduto);

            frmProduto.ShowDialog();

            CarregaProdutos();
        }
    }
}
