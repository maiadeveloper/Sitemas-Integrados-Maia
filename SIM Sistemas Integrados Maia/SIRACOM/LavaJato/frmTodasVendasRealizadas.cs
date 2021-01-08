using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.RVBo;
using Negocios.RVTipo;
using Negocios.TIPO;
using Negocios.BO;
using Negocios;
using Negocios.ProdTipo;
using Negocios.ProdBo;

namespace LavaJato
{
    public partial class frmTodasVendasRealizadas : Form
    {
        public frmTodasVendasRealizadas()
        {
            InitializeComponent();
        }

        int vendaID;
        int countRow = 0;
        int countRow2 = 0;
        decimal total = 0;
        decimal totalItens = 0;


        private void HabilitaTitulos()
        {
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
        }

        private void toolStripButtonExclusao_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma exclusão da venda Nº " + vendaID + " ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (vendaID > 0)
                {
                    RealizarVendasBO realizaVendasBO = new RealizarVendasBO();
                    realizaVendasBO.ExcluirItemVenda(vendaID);
                    realizaVendasBO.ExcluirVenda(vendaID);
                    CarregaVendasRealizadas();
                    CarregaItensVendas(vendaID);
                }
                else
                {
                    MessageBox.Show("Não e possivel realizar exclusão selecione uma opção", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void frmTodasVendasRealizadas_Load(object sender, EventArgs e)
        {
            CarregaVendasRealizadas();
            HabilitaTitulos();
        }

        private void CarregaVendasRealizadas()
        {
            DataTable dt = new DataTable();

            RealizarVendasBO realizaVendasBO = new RealizarVendasBO();

            dt = realizaVendasBO.CriaDataTableSelecionaTodasVendasRealizadas();

            if (dt != null)
            {
                listViewVendas.Items.Clear();
                total = 0;

                foreach (DataRow row in dt.Rows)
                {
                    //Adiciona os itens do list view
                    listViewVendas.Items.Add(row.ItemArray[0].ToString());//0
                    listViewVendas.Items[countRow].SubItems.Add(Convert.ToDateTime(row.ItemArray[1]).ToString("dd/MM/yyyy"));//1
                    listViewVendas.Items[countRow].SubItems.Add(row.ItemArray[2].ToString());//2
                    listViewVendas.Items[countRow].SubItems.Add(row.ItemArray[3].ToString());//3
                    listViewVendas.Items[countRow].SubItems.Add((row.ItemArray[4]).ToString());//4
                    listViewVendas.Items[countRow].SubItems.Add(Convert.ToDecimal((row.ItemArray[5])).ToString("C"));//5
                    listViewVendas.Items[countRow].SubItems.Add(Convert.ToDecimal((row.ItemArray[6])).ToString("C"));//5

                    total += Convert.ToDecimal(row.ItemArray[6]);

                    countRow++;
                }
                countRow = 0;

                txtQtde.Text = dt.Rows.Count.ToString();
                txtTotal.Text = total.ToString("C");
            }
        }


        private void CarregaItensVendas(int vendaID)
        {
            DataTable dt = new DataTable();

            RealizarVendasBO realizaVendasBO = new RealizarVendasBO();

            dt = realizaVendasBO.CriaDataTableSelecionaItensVendaRealizada(vendaID);
            totalItens = 0;

            if (dt != null)
            {
                listViewItensProdutos.Items.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    //Adiciona os itens do list view
                    listViewItensProdutos.Items.Add(row.ItemArray[1].ToString());//0
                    listViewItensProdutos.Items[countRow2].SubItems.Add(row.ItemArray[2].ToString());//2
                    listViewItensProdutos.Items[countRow2].SubItems.Add(row.ItemArray[3].ToString());//3
                    listViewItensProdutos.Items[countRow2].SubItems.Add((row.ItemArray[4]).ToString());//4
                    listViewItensProdutos.Items[countRow2].SubItems.Add(Convert.ToDecimal((row.ItemArray[5])).ToString("C"));//5
                    listViewItensProdutos.Items[countRow2].SubItems.Add(Convert.ToDecimal((row.ItemArray[6])).ToString("C"));//5

                    totalItens += Convert.ToDecimal(row.ItemArray[6]);

                    countRow2++;
                }
                countRow2 = 0;
            }
        }

        private void listViewVendas_SelectedIndexChanged(object sender, EventArgs e)
        {
            vendaID = int.Parse(listViewVendas.FocusedItem.SubItems[0].Text);
            lblItensVenda.Text = string.Format("Itens relacionados a venda de Nº {0}", vendaID);
            CarregaItensVendas(vendaID);
            CarregaItensTipoRecebimento(vendaID);
        }


        public void CarregaItensTipoRecebimento(int codigo)
        {
            int countRow = 0;

            DataTable dt = new DataTable();
            ItemTipoRecebimentoVendaBO itemTipoRecebimentoVendaBO = new ItemTipoRecebimentoVendaBO();
            dt = itemTipoRecebimentoVendaBO.CriaDataTableSelecionaItemVendaFormaRecebimenoto(codigo);
            listItenFormaRecebimento.Items.Clear();

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    //Adiciona os itens do list view
                    listItenFormaRecebimento.Items.Add(row["formaRecebimento"].ToString());
                    listItenFormaRecebimento.Items[countRow].SubItems.Add(Convert.ToDecimal(row["vlrPago"]).ToString("C"));

                    countRow++;
                }
                countRow = 0;

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
        }

        private void ExcluirVendatoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma estorno desta venda - Nº " + vendaID + " ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (vendaID > 0)
                {
                    RealizarVendasBO realizaVendasBO = new RealizarVendasBO();
                    ContasReceber contaReceber = new ContasReceber();
                    ContasReceberBO contaReceberBO = new ContasReceberBO();
                    ItemContaReceberBO itemContaReceberBO = new ItemContaReceberBO();
                    ItemContaReceber itemContaReceber = new ItemContaReceber();

                    //Recupera dados referente conta receber baseado na venda id
                    contaReceber = contaReceberBO.RetornaContaReceberNumeroVenda(vendaID);

                    if (contaReceber != null)
                    {
                        //Recupera dados referente item contas receber
                        itemContaReceber = itemContaReceberBO.SelecionarContaReceberID(contaReceber._ContaReceberID);

                        //Excluir item forma recebimento contas a recebe
                        itemContaReceberBO.ExcluirItemContaReceber("contaReceberID", contaReceber._ContaReceberID);

                        //Excluir conta receber
                        contaReceberBO.ExcluirContaReceberNumeroVenda(vendaID);
                    }

                    //Atualiza quantidade estoque
                    //Altera a quantidade de produtos no estoque
                    DataTable dtItens = realizaVendasBO.CriaDataTableSelecionaItensVendaRealizada(vendaID);

                    foreach (DataRow item in dtItens.Rows)
                    {
                        ProdutosTipo produto = new ProdutosTipo();
                        ProdutosBO produtoBO = new ProdutosBO();

                        produto._CodigoProduto = Convert.ToInt32(item["CodigoProduto"]);
                        produto._QtdeEstoque = Convert.ToInt32(item["Qtde"]);

                        produtoBO.AlterarQuantidadeEstoqueProduto(produto);
                    }


                    EstornarSaldoCaixaEmpresa();

                    //ExcluirVenda
                    realizaVendasBO.ExcluirItemVenda(vendaID);

                    //Excluir item venda
                    realizaVendasBO.ExcluirVenda(vendaID);


                    MessageBox.Show("Venda estornada com sucesso", "Estorno bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CarregaVendasRealizadas();
                    CarregaItensVendas(vendaID);
                }
                else
                {
                    MessageBox.Show("Não e possivel realizar exclusão selecione uma opção", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void EstornarSaldoCaixaEmpresa()
        {
            //Atualiza saldo conta corrente caixa empresa
            //Altera a saldo conta corrente

            ItemTipoRecebimentoVenda itemTipoRecVenda = new ItemTipoRecebimentoVenda();
            ItemTipoRecebimentoVendaBO itemTipoRecVendaBO = new ItemTipoRecebimentoVendaBO();

            DataTable dtItensTipoRecVenda = itemTipoRecVendaBO.CriaDataTableSelecionaItemVendaFormaRecebimenoto(vendaID);

            foreach (DataRow itemTipRV in dtItensTipoRecVenda.Rows)
            {
                Banco banco = new Banco();
                BancoBO bancoBO = new BancoBO();
                ContaCorrente contaCorrente = new ContaCorrente();
                ContaCorrenteBO contaCorrenteBO = new ContaCorrenteBO();

                if (itemTipRV["formaRecebimento"].ToString().Equals("01 - Dinheiro"))
                {
                    //VERIFICA SE EXISTE BANCO CAIXA EMPRESA
                    banco = bancoBO.SelecionaBancoCaixaEmpresa();

                    if (banco != null)
                    {
                        //VERIFICA SE EXISTE CONTA CORRENTE RELACIONADA AO BANCO
                        contaCorrente = contaCorrenteBO.SelecionarContaCorrenteBancoID(banco.BancoID);

                        if (contaCorrente != null)
                        {
                            //ATUALIZA O SALDO PERTINENTE A CONTA CORRENTE DE ACORDO COM O BANCO CAIXA EMPRESA
                            contaCorrenteBO.AtualizarSaldoDespesa(contaCorrente.ContaID, itemTipRV["vlrPago"].ToString());
                        }
                    }
                }
            }
        }

        private void frmTodasVendasRealizadas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
