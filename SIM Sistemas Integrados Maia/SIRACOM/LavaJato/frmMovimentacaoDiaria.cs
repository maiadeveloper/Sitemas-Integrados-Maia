using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using Negocios.RVBo;
using Negocios.RVTipo;
using Negocios.TIPO;
using Negocios.BO;


namespace LavaJato
{
    public partial class frmMovimentacaoDiaria : Form
    {
        public frmMovimentacaoDiaria()
        {
            InitializeComponent();
        }

        int countRow = 0;
        int countRowItemCR = 0;
        int contDespesa = 0;
        int contPag = 0;
        decimal totalDespesasDinheiro = 0;
        decimal totalDespesaCaixaEmpresa = 0;
        decimal totalPag = 0;
        decimal totalPagoCaixaEmpresa = 0;
        string tipo;
        int itemContaReceberID;
        decimal totalContaReceberFR = 0;


        decimal totalVendasRealizadasDinheiro = 0;
        decimal totalVendasRealizadasBancos = 0;
        decimal totalVendasRealizadasCheque = 0;
        decimal totalVendasRealizadasCartao = 0;

        decimal totalContaPagaDinheiro = 0;

        decimal totalContaRecebidaDinheiro = 0;
        decimal totalContaRecebidaCartao = 0;

        private void frmVendasRealizadas_Load(object sender, EventArgs e)
        {
            txtDateInicial.Text = DateTime.Now.ToString();
            txtDataFinal.Text = DateTime.Now.ToString();

            CarregaVendasRealizadas();
            CarregaItemContasRecebidasFormaRecebimento();
            CarregaDespesasDoDia();
            CarregaLancamentoPago();
            CarregaSaldoRemanescente();

            SaldoCaixa();

            HabilitaTitulos();
        }

        private void SaldoCaixa()
        {
            try
            {
                decimal totalSaida = Convert.ToDecimal(txtTotalDespesasEmDinheiro.Text.Substring(3)) + Convert.ToDecimal(txtTotalContasPagaEmDinheiro.Text.Substring(3));

                if (!string.IsNullOrEmpty(txtTotalVendasRealizadasEmDinheiro.Text))
                {
                    decimal totalEntrada = Convert.ToDecimal(txtTotalVendasRealizadasEmDinheiro.Text.Substring(3)) + Convert.ToDecimal(txtTotalContasRecebidasEmDinheiro.Text.Substring(3));

                    txtSaldoEmDinheiro.Text = (totalEntrada - totalSaida).ToString("C");
                }
                else
                {
                    txtSaldoEmDinheiro.Text = Convert.ToDecimal("0.00").ToString("C");
                }

                txtSaldoEmBancos.Text = Convert.ToDecimal("0.00").ToString("C");
                txtSaldoEmCartoes.Text = Convert.ToDecimal("0.00").ToString("C");
                txtSaldoEmCheque.Text = Convert.ToDecimal("0.00").ToString("C");

            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message);
            }
        }

        private void HabilitaTitulos()
        {
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
        }

        public void CarregaVendasRealizadas()
        {
            if (ckbVendasRealizadas.Checked == true)
            {
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                RealizarVendasBO realizaVendasBO = new RealizarVendasBO();

                ds = realizaVendasBO.Vendas(DateTime.Parse(txtDateInicial.Text), DateTime.Parse(txtDataFinal.Text));

                totalVendasRealizadasDinheiro = 0;
                totalVendasRealizadasBancos = 0;
                totalVendasRealizadasCartao = 0;
                totalVendasRealizadasCheque = 0;

                if (ds != null)
                {
                    listViewVendas.Items.Clear();
                    countRow = 0;
                    dt = ds.Tables[0];

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            listViewVendas.Items.Add(row.ItemArray[0].ToString());
                            listViewVendas.Items[countRow].SubItems.Add(string.Format("{0:dd/MM/yyyy}", row.ItemArray[1]));
                            listViewVendas.Items[countRow].SubItems.Add(string.Format("{0:C2}", row.ItemArray[7]));
                            countRow++;

                            CalcularComposicaoVenda(Convert.ToInt32(row["NumeroVenda"]));
                        }
                        countRow = 0;
                    }
                    else
                    {
                        txtTotalVendasRealizadasEmDinheiro.Text = string.Format("{0:C2}", totalVendasRealizadasDinheiro);
                        txtTotalVendasRealizadasEmCartoes.Text = string.Format("{0:C2}", totalVendasRealizadasCartao);
                        txtTotalVendasRealizadasEmCheque.Text = Convert.ToDecimal("0.00").ToString("C");
                        txtTotalVendasRealizadasEmBancos.Text = Convert.ToDecimal("0.00").ToString("C");
                    }
                }
            }
            else
            {
                listViewVendas.Items.Clear();
            }
        }

        public void CalcularComposicaoVenda(int numeroVenda)
        {
            DataTable dt = new DataTable();
            ItemTipoRecebimentoVendaBO itemTipoRecebimentoVendaBO = new ItemTipoRecebimentoVendaBO();

            dt = itemTipoRecebimentoVendaBO.CriaDataTableSelecionaItemVendaFormaRecebimenoto(numeroVenda);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["formaRecebimento"].ToString().StartsWith("01 - Dinheiro"))
                    {
                        totalVendasRealizadasDinheiro += Convert.ToDecimal(row["vlrPago"]);
                    }
                    else
                    {
                        totalVendasRealizadasCartao += Convert.ToDecimal(row["vlrPago"]);
                    }
                }

                txtTotalVendasRealizadasEmDinheiro.Text = string.Format("{0:C2}", totalVendasRealizadasDinheiro);
                txtTotalVendasRealizadasEmCartoes.Text = string.Format("{0:C2}", totalVendasRealizadasCartao);
                txtTotalVendasRealizadasEmCheque.Text = Convert.ToDecimal("0.00").ToString("C");
                txtTotalVendasRealizadasEmBancos.Text = Convert.ToDecimal("0.00").ToString("C");
            }
        }


        public void CarregaItemContasRecebidasFormaRecebimento()
        {
            if (ckbContasRecebidas.Checked == true)
            {
                DataSet dsItemCR = new DataSet();
                ItemContaReceberFormaRecebimentoBO itemContaReceberFRBO = new ItemContaReceberFormaRecebimentoBO();

                dsItemCR = itemContaReceberFRBO.RetornaDataSetContaReceberFormaRecebimento(DateTime.Parse(txtDateInicial.Text), DateTime.Parse(txtDataFinal.Text));


                if (dsItemCR != null)
                {
                    listViewItensContaReceber.Items.Clear();
                    countRowItemCR = 0;
                    totalContaRecebidaDinheiro = 0;
                    totalContaRecebidaCartao = 0;

                    foreach (DataRow row in dsItemCR.Tables[0].Rows)
                    {
                        listViewItensContaReceber.Items.Add(row["itemContarReceberID"].ToString());
                        listViewItensContaReceber.Items[countRowItemCR].SubItems.Add(string.Format("{0:dd/MM/yyyy}", row["dataHora"]));
                        listViewItensContaReceber.Items[countRowItemCR].SubItems.Add(string.Format("{0:C2}", row["vlrPago"]));
                        countRowItemCR++;

                        if (row["formaRecebimento"].ToString().StartsWith("01 - Dinheiro"))
                        {
                            totalContaRecebidaDinheiro += Convert.ToDecimal(row["vlrPago"]);
                        }
                        else
                        {
                            totalContaRecebidaCartao += Convert.ToDecimal(row["vlrPago"]);
                        }
                    }

                    countRowItemCR = 0;

                    txtTotalContasRecebidasEmBanco.Text = Convert.ToDecimal("0.00").ToString("C");
                    txtTotalContasRecebidasEmCartoes.Text = totalContaRecebidaCartao.ToString("C");
                    txtTotalContasRecebidasEmCheque.Text = Convert.ToDecimal("0.00").ToString("C");
                    txtTotalContasRecebidasEmDinheiro.Text = totalContaRecebidaDinheiro.ToString("C");
                }
            }
            else
            {
                listViewItensContaReceber.Items.Clear();
            }
        }

        public void CarregaDespesasDoDia()
        {
            if (ckbDespesasDiarias.Checked == true)
            {
                DataSet ds = new DataSet();
                DespesasBO despesasBO = new DespesasBO();
                Banco banco = new Banco();
                BancoBO bancoBO = new BancoBO();

                ds = despesasBO.TodasDespesas(DateTime.Parse(txtDateInicial.Text), DateTime.Parse(txtDataFinal.Text));

                if (ds != null)
                {
                    lsDespesas.Items.Clear();
                    contDespesa = 0;
                    totalDespesasDinheiro = 0;

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        lsDespesas.Items.Add(row.ItemArray[0].ToString());
                        lsDespesas.Items[contDespesa].SubItems.Add(string.Format("{0:dd/MM/yyyy}", row.ItemArray[1]));
                        lsDespesas.Items[contDespesa].SubItems.Add(string.Format("{0:C2}", row.ItemArray[3]));
                        contDespesa++;

                        banco = bancoBO.SelecionaBancoCaixaEmpresa();

                        if (banco.BancoID == Convert.ToInt32(row["BancoID"]))
                        {
                            totalDespesasDinheiro += Convert.ToDecimal(row.ItemArray[3]);
                        }
                    }

                    contDespesa = 0;

                    txtTotalDespesasEmDinheiro.Text = string.Format("{0:C2}", totalDespesasDinheiro);
                    txtTotalDespesasEmBancos.Text = Convert.ToDecimal("0.00").ToString("C");
                    txtTotalDespesasEmCartoes.Text = Convert.ToDecimal("0.00").ToString("C");
                    txtTotalDespesasEmCheque.Text = Convert.ToDecimal("0.00").ToString("C");
                }
            }
            else
            {
                lsDespesas.Items.Clear();
            }
        }

        public void CarregaLancamentoPago()
        {
            if (ckbContasPagas.Checked == true)
            {
                DataSet ds = new DataSet();
                LancamentosBaixasBO lancamentosBaixasBo = new LancamentosBaixasBO();
                Banco banco = new Banco();
                BancoBO bancoBO = new BancoBO();
                ContaCorrente contaCorrente = new ContaCorrente();
                ContaCorrenteBO contaCorrenteBO = new ContaCorrenteBO();

                ds = lancamentosBaixasBo.LancamentosBaixaTodos(DateTime.Parse(txtDateInicial.Text), DateTime.Parse(txtDataFinal.Text));

                if (ds != null)
                {
                    lsContasPagas.Items.Clear();
                    contPag = 0;
                    totalContaPagaDinheiro = 0;


                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        lsContasPagas.Items.Add(row.ItemArray[0].ToString());
                        lsContasPagas.Items[contPag].SubItems.Add(string.Format("{0:dd/MM/yyyy}", row["DataBaixa"]));
                        lsContasPagas.Items[contPag].SubItems.Add(string.Format("{0:C2}", row["VlorBaixa"]));
                        contPag++;

                        banco = bancoBO.SelecionaBancoCaixaEmpresa();

                        contaCorrente = contaCorrenteBO.RetornaContaCorrenteID(Convert.ToInt32(row["ContaID"]));

                        if (banco.BancoID == contaCorrente.BancoID)
                        {
                            totalContaPagaDinheiro += Convert.ToDecimal(row["VlorBaixa"]);
                        }
                    }

                    contPag = 0;

                    txtTotalContasPagaEmDinheiro.Text = totalContaPagaDinheiro.ToString("C");
                    txtTotalContasPagaEmCartoes.Text = Convert.ToDecimal("0.00").ToString("C");
                    txtTotalContasPagaEmCheque.Text = Convert.ToDecimal("0.00").ToString("C");
                    txtTotalContasPagaEmBancos.Text = Convert.ToDecimal("0.00").ToString("C");
                }
            }
            else
            {
                lsContasPagas.Items.Clear();
            }
        }

        private void frmVendasRealizadas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CarregaVendasRealizadas();
                CarregaItemContasRecebidasFormaRecebimento();
                CarregaDespesasDoDia();
                CarregaLancamentoPago();
                SaldoCaixa();
            }
        }

        private void toolStripButtonExclusao_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (listViewItensContaReceber.Items.Count > 0)
            {
                int codigo = Convert.ToInt32(listViewItensContaReceber.FocusedItem.SubItems[0].Text);

                if (e.ClickedItem.Name.Equals("menuItemEstornar"))
                {
                    if (MessageBox.Show("Confirma estorna deste recebimento de Nº " + codigo + " ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        EstornaRecebimento();
                    }
                }
                else
                {
                    tipo = "contaRecebida";
                    frmItemContaRecebidaTipoRecebimento frm = new frmItemContaRecebidaTipoRecebimento();

                    frm.CarregaItensTipoRecebimento(tipo, codigo);

                    frm.ShowDialog();
                }
            }
        }

        public void EstornaRecebimento()
        {
            ItemContaReceberFormaRecebimento itemContaReceberFR = new ItemContaReceberFormaRecebimento();
            ItemContaReceberFormaRecebimentoBO itemContaReceberFRBO = new ItemContaReceberFormaRecebimentoBO();

            ItemContaReceber itemContaReceber = new ItemContaReceber();
            ItemContaReceberBO itemContaReceberBo = new ItemContaReceberBO();

            ContasReceber contaReceber = new ContasReceber();
            ContasReceberBO contaReceberBO = new ContasReceberBO();

            itemContaReceberFR = itemContaReceberFRBO.SelecionarItemFormaRecebimentoId(itemContaReceberID);
            itemContaReceber = itemContaReceberBo.SelecionarItemContaReceberID(itemContaReceberFR._ItenContaReceber._ItemContaReceberID);

            decimal vlrPago = itemContaReceberFR._VlrPago;
            decimal vlrAbert = itemContaReceber.ValorAberto;

            itemContaReceberBo.EstornarRecebimento(itemContaReceber._ItemContaReceberID, vlrPago, vlrAbert, "Prevista");

            itemContaReceberFRBO.ExcluirItemFormaRecebimentoContaReceberId(itemContaReceberFR._ItemContaReceberFRID);

            MessageBox.Show("Recebimento estornado com sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CarregaItemContasRecebidasFormaRecebimento();
        }

        private void listViewItensContaReceber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewItensContaReceber.Items.Count > 0)
            {
                itemContaReceberID = int.Parse(listViewItensContaReceber.Items[0].Text);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listViewVendas.Items.Count > 0)
            {
                int codigo = Convert.ToInt32(listViewVendas.FocusedItem.SubItems[0].Text);
                tipo = "venda";
                frmItemContaRecebidaTipoRecebimento frm = new frmItemContaRecebidaTipoRecebimento();

                frm.CarregaItensTipoRecebimento(tipo, codigo);

                frm.ShowDialog();
            }
        }

        private void btnConsultar_Click_1(object sender, EventArgs e)
        {
            CarregaVendasRealizadas();
            CarregaItemContasRecebidasFormaRecebimento();
            CarregaDespesasDoDia();
            CarregaLancamentoPago();
            SaldoCaixa();
        }

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            frmPreVisualizacaoMovimentacao frm = new frmPreVisualizacaoMovimentacao();
            frm.GerarArquivoTxtMovimentacao(Convert.ToDateTime(txtDateInicial.Text), Convert.ToDateTime(txtDataFinal.Text));
            frm.CarregaArquivoMovimentacao();
            frm.ShowDialog();
        }

        private void ckbVendasRealizadas_CheckedChanged(object sender, EventArgs e)
        {
            btnConsultar_Click_1(this, e);
        }

        private void ckbContasRecebidas_CheckedChanged(object sender, EventArgs e)
        {
            btnConsultar_Click_1(this, e);
        }

        private void ckbContasPagas_CheckedChanged(object sender, EventArgs e)
        {
            btnConsultar_Click_1(this, e);
        }

        private void ckbDespesasDiarias_CheckedChanged(object sender, EventArgs e)
        {
            btnConsultar_Click_1(this, e);
        }

        private void CarregaSaldoRemanescente()
        {
            DataTable dt = new DataTable();
            ContaCorrenteBO contaCorrenteBo = new ContaCorrenteBO();

            dt = contaCorrenteBo.RetornaDataTableContaCorrente("CAIXA EMPRESA");

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["NomeBanco"].ToString().Equals("CAIXA EMPRESA"))
                    {
                        if (Convert.ToDecimal(row["Saldo"]) > 0)
                        {
                            txtSaldoRemanescente.Text = Convert.ToDecimal(row["Saldo"]).ToString("C");
                        }
                        else
                        {
                            txtSaldoRemanescente.Text = Convert.ToDecimal("0.00").ToString("C");
                        }
                    }
                }
            }
        }
    }
}
