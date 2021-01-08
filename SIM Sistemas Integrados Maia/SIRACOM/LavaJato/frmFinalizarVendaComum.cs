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

namespace LavaJato
{
    public partial class frmFinalizarVendaComum : Form
    {
        public frmFinalizarVendaComum()
        {
            InitializeComponent();
            txtPagando.Focus();
        }

        int numeroVenda = 0;
        int countRow = 0;
        int item = 1;
        bool desconto;
        bool pagando;
        public bool statusVenda;
        public decimal totalFinalPagar;
        public decimal descontoOferecido;
        public string formaPagamentoVC;
        public bool frmPgtoDinheiro, frmPgtoCD, frmPgtoCC;
        public decimal troco;
        public decimal pagandoDinheiro;

        public void CarregaDadosFinalizarVenda(decimal valorTotalVenda, int parametroNumeroVenda)
        {
            numeroVenda = parametroNumeroVenda;
            listBoxFormaPagamento.SelectedIndex = 0;
            txtPagando.Focus();
            txtTroco.Text = "0,00";
            txtDesconto.Text = "0,00";
            txttotalPago.Text = "0,00";
            txtTotalVenda.Text = string.Format("{0:C2}", valorTotalVenda);
        }

        private void GravarItemTipoRecebimentoVenda()
        {
            if (MessageBox.Show("Confirma finalizar pagamento", "Pagamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ItemTipoRecebimentoVenda itemTRV;
                ItemTipoRecebimentoVendaBO itemTipoRecebimentoBO = new ItemTipoRecebimentoVendaBO();

                for (int i = 0; i < listFormaRecebimento.Items.Count; i++)
                {
                    itemTRV = new ItemTipoRecebimentoVenda();

                    itemTRV._VendaID = numeroVenda;
                    itemTRV._Item = int.Parse(listFormaRecebimento.Items[i].SubItems[0].Text);
                    itemTRV._FormaRecebimento = listFormaRecebimento.Items[i].SubItems[1].Text;
                    itemTRV._VlrPago = decimal.Parse(listFormaRecebimento.Items[i].SubItems[2].Text.Substring(3));
                    itemTRV.DataHora = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"));
                    itemTipoRecebimentoBO.Gravar(itemTRV);
                    AtualizaSaldoContaCorrenteCaixaEmpresa(itemTRV._FormaRecebimento, itemTRV._VlrPago);
                }

                statusVenda = true;
                VerificaTipoPagamento();

                MessageBox.Show("Recebido com sucesso", "Pagamento realizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
        }

        private void AtualizaSaldoContaCorrenteCaixaEmpresa(string tipPagamento, decimal valor)
        {
            ContaCorrente contaCorrente = new ContaCorrente();
            ContaCorrenteBO contaCorrenteBO = new ContaCorrenteBO();

            Banco banco = new Banco();
            BancoBO bancoBO = new BancoBO();

            if (tipPagamento.Equals("01 - Dinheiro"))
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
                        contaCorrenteBO.AtualizarSaldoPositivo(contaCorrente.ContaID, valor.ToString());
                    }
                    else
                    {
                        if (MessageBox.Show("Não existe conta corrente para esta empresa \n" + "É necessário cadastrar uma conta agora\n" + "Deseja cadastrar?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) ;
                        {
                            using (frmContaCorrente frm = new frmContaCorrente())
                            {
                                frm.ShowDialog();
                            }
                        }
                    }
                }
            }
        }

        private void VerificaTipoPagamento()
        {
            for (int i = 0; i < listFormaRecebimento.Items.Count; i++)
            {
                string frmPgto = listFormaRecebimento.Items[i].SubItems[1].Text;
                {
                    if (frmPgto == "01 - Dinheiro")
                    {
                        frmPgtoDinheiro = true;
                    }
                    if (frmPgto == "02 - Cartão de Débito")
                    {
                        frmPgtoCD = true;
                    }
                    if (frmPgto == "03 - Cartão Crédito 1x")
                    {
                        frmPgtoCC = true;
                    }
                }
            }

            if ((frmPgtoDinheiro == true) && (frmPgtoCC == true) && (frmPgtoCD == true))
            {
                formaPagamentoVC = "Dinheiro/Cartão Débito/Cartão Crédito 1x";
            }
            else if ((frmPgtoDinheiro == true) && (frmPgtoCD == true))
            {
                formaPagamentoVC = "Dinheiro/Cartão Débito";
            }
            else if ((frmPgtoCC == true) && (frmPgtoCD == true))
            {
                formaPagamentoVC = "Cartão Débito/Cartão Crédito 1x";
            }
            else if (frmPgtoDinheiro == true)
            {
                formaPagamentoVC = "Dinheiro";
            }
            else if (frmPgtoCD == true)
            {
                formaPagamentoVC = "Cartão Débito";
            }
            else if (frmPgtoCC == true)
            {
                formaPagamentoVC = "Cartão Crédito 1x";
            }
        }

        Boolean VerificaTotalPagarDesconto()
        {
            decimal desconto = txtDesconto.Text.StartsWith("R$") ? Convert.ToDecimal(txtDesconto.Text.Substring(3)) : Convert.ToDecimal(txtDesconto.Text);
            decimal totalVenda = Convert.ToDecimal(txtTotalVenda.Text.Substring(3));
            decimal totalPagar = Convert.ToDecimal(txttotalPago.Text.Substring(3));

            totalPagar += desconto;

            if (totalPagar == totalVenda)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void frmFinalizarVendaComum_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (VerificaTotalPagarDesconto() != true)
                {
                    IncluirTipoRecebimentoVenda();
                }

                AplicarDesconto();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.F2)
            {
                if (HabilitaDesconto() == true)
                {
                    txtDesconto.Focus();
                    txtDesconto.TabStop = true;
                    txtDesconto.ReadOnly = false;
                    desconto = true;
                }
                else
                {
                    return;
                }
            }
            else if (e.KeyCode == Keys.F5)
            {
                FinalizarVendaComum();
            }
        }

        private void FinalizarVendaComum()
        {
            if (listFormaRecebimento.Items.Count > 0)
            {
                CalcularTotalFinalPagar();

                if (totalFinalPagar == Convert.ToDecimal(txttotalPago.Text.Substring(3)))
                {
                    GravarItemTipoRecebimentoVenda();
                    AtualizaSaldoContaCorrente(14, totalFinalPagar.ToString());
                }
                else
                {
                    txtPagando.Focus();
                    MessageBox.Show("Total não confere", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Informe pagamento para esta venda", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPagando.Focus();
            }
        }

        private void IncluirTipoRecebimentoVenda()
        {
            try
            {
                if ((txtPagando.Text != "0,00") || (desconto == true))
                {
                    //if (totalFinalPagar < Convert.ToDecimal(txtTotalVenda.Text.Substring(3)) && (pagando == true))
                    if (pagando == true)
                    {
                        if ((txtPagando.Text != "0,00") && (!string.IsNullOrEmpty(txtPagando.Text) && (pagando == true)))
                        {
                            pagandoDinheiro = Convert.ToDecimal(txtPagando.Text);
                            listFormaRecebimento.Items.Add(item.ToString());//Inclui item
                            listFormaRecebimento.Items[countRow].SubItems.Add((listBoxFormaPagamento.SelectedItem.ToString()));

                            if (Convert.ToDecimal(txtPagando.Text) >= Convert.ToDecimal(txtTotalVenda.Text.Substring(3)))
                            {
                                listFormaRecebimento.Items[countRow].SubItems.Add(txtTotalVenda.Text);//inclui valor pago
                                txttotalPago.Text = txtTotalVenda.Text;
                            }
                            else
                            {
                                listFormaRecebimento.Items[countRow].SubItems.Add(Convert.ToDecimal(txtPagando.Text).ToString("C"));//inclui valor pago
                            }

                            countRow++;//incrementa + 1
                            item++;

                            //aplica troco
                            if (Convert.ToDecimal(txtPagando.Text) > Convert.ToDecimal(txtTotalVenda.Text.Substring(3)))
                            {
                                decimal totalVenda = Convert.ToDecimal(txtTotalVenda.Text.Substring(3));
                                decimal totalPangando = Convert.ToDecimal(txtPagando.Text);
                                txtTroco.Text = (totalPangando - totalVenda).ToString("C");
                                troco = decimal.Parse(txtTroco.Text.Substring(3));
                            }

                            if (Convert.ToDecimal(txtPagando.Text) < Convert.ToDecimal(txtTotalVenda.Text.Substring(3)))
                            {
                                txtPagando.Clear();
                                txtPagando.Focus();
                            }

                            CalcularTotalFinalPagar();
                            FaltaPagar();
                            totalFinalPagar = 0;
                        }
                        else
                        {
                            txtPagando.Focus();
                        }
                    }
                    else
                    {
                        txtPagando.Focus();
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private void CalcularTotalFinalPagar()
        {
            for (int i = 0; i < listFormaRecebimento.Items.Count; i++)
            {
                totalFinalPagar += decimal.Parse(listFormaRecebimento.Items[i].SubItems[2].Text.Substring(3));
                txttotalPago.Text = totalFinalPagar.ToString("C");
            }
        }

        decimal CalcularTotalPagar()
        {
            decimal totalPagar = 0;

            for (int i = 0; i < listFormaRecebimento.Items.Count; i++)
            {
                totalPagar += decimal.Parse(listFormaRecebimento.Items[i].SubItems[2].Text.Substring(3));
            }

            if (totalPagar < 1)
            {
                return totalPagar = 0;
            }
            else
            {
                return totalPagar;
            }
        }

        private void txtPagando_Enter_1(object sender, EventArgs e)
        {
            pagando = true;
        }

        private void txtDesconto_Enter(object sender, EventArgs e)
        {
            desconto = true;
        }

        private void listBoxFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPagando.Focus();
        }

        void AplicarDesconto()
        {
            try
            {
                if (desconto == true)
                {
                    decimal vlrDesconto = txtDesconto.Text.StartsWith("R$") ? Convert.ToDecimal(txtDesconto.Text.Substring(3)) : Convert.ToDecimal(txtDesconto.Text);
                    decimal totalVenda = Convert.ToDecimal(txtTotalVenda.Text.Substring(3));
                    txttotalPago.Text = string.Format("{0:c2}", (totalVenda - vlrDesconto));
                    txtDesconto.Text = Convert.ToDecimal(txtDesconto.Text).ToString("C");
                    descontoOferecido = Convert.ToDecimal(txtDesconto.Text.Substring(3));

                    txtDesconto.TabStop = false;
                    txtDesconto.ReadOnly = true;
                    desconto = false;
                    txtPagando.Focus();

                    listFormaRecebimento.Items.Clear();
                    item = 1;
                    countRow = 0;
                    totalFinalPagar = 0;
                    IncluirTipoRecebimentoVendaDesconto(Convert.ToDecimal(txttotalPago.Text.Substring(3)));
                    AplicaTrocoDesconto();
                }
            }
            catch (Exception) { }
        }

        Boolean HabilitaDesconto()
        {
            if ((Convert.ToDecimal(txtTotalVenda.Text.Substring(3)) == CalcularTotalPagar()) || (Convert.ToDecimal(txttotalPago.Text.Substring(3)) == CalcularTotalPagar()))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Total não confere informe o pagamento antes de aplicar desconto", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDesconto.Text = "0,00";
                txtDesconto.ReadOnly = true;
                txtPagando.Focus();
                return false;
            }
        }

        private void frmFinalizarVendaComum_Load(object sender, EventArgs e)
        {
            txtPagando.Focus();
            HabilitaTitulos();
        }

        void FaltaPagar()
        {
            if (txtDesconto.Text.Equals("0,00"))
            {
                decimal vlrVenda = Convert.ToDecimal(txtTotalVenda.Text.Substring(3));
                decimal totalFaltaPagar = (vlrVenda - totalFinalPagar);

                txtPagando.Text = totalFaltaPagar > 0 ? (string.Format("{0:C2}", totalFaltaPagar).Substring(3)) : string.Format("{0:C2}", txtPagando.Text);

                txtPagando.Focus();
            }
        }

        private void HabilitaTitulos()
        {
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
        }

        private void IncluirTipoRecebimentoVendaDesconto(decimal total)
        {
            try
            {
                listFormaRecebimento.Items.Add(item.ToString());//Inclui item
                listFormaRecebimento.Items[countRow].SubItems.Add((listBoxFormaPagamento.SelectedItem.ToString()));
                listFormaRecebimento.Items[countRow].SubItems.Add(Convert.ToDecimal(total).ToString("C"));//inclui valor pago
                countRow++;//incrementa + 1
                item++;

            }
            catch (Exception)
            {
            }
        }

        void AplicaTrocoDesconto()
        {
            decimal vlrDesconto = txtDesconto.Text.StartsWith("R$") ? Convert.ToDecimal(txtDesconto.Text.Substring(3)) : Convert.ToDecimal(txtDesconto.Text);
            troco = Convert.ToDecimal(txtTroco.Text.Substring(3));
            txtTroco.Text = (vlrDesconto + troco).ToString("C");
            troco = decimal.Parse(txtTroco.Text.Substring(3));
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FinalizarVendaComum();
        }

        public void AtualizaSaldoContaCorrente(int contaID, string valor)
        {
            if (listBoxFormaPagamento.SelectedIndex == 0)
            {
                ContaCorrenteBO contaCorrenteBO = new ContaCorrenteBO();
                contaCorrenteBO.AtualizarSaldoPositivo(contaID, valor);
            }
        }
    }
}
