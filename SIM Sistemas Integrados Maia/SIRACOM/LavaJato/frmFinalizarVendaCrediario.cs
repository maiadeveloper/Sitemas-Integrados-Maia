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
using Negocios.RVTipo;
using Negocios.RVBo;
using Negocios.RVDao;
using Negocios;

namespace LavaJato
{
    public partial class frmFinalizarVendaCrediario : Form
    {
        ContasReceber contasReceber;
        ContasReceberBO contasReceberBo;

        ItemContaReceber itemContaReceber;
        ItemContaReceberBO itemContaReceberBo;

        CadastroClientes cliente = new CadastroClientes();
        CadastroClientesDAO clienteDAO = new CadastroClientesDAO();

        RealizarVendasBO realizaVendaBo;
        RealizarVendasTipos realizaVenda;

        public DateTime dataVencimento;//recebe a data de vencimento referente a parcela
        public decimal valorParcela;//recebe o valor da parcela
        public int prazo;//Recebe o prazo  para conta receber
        int contadorData = 1;//Utilizada para incrementa o mes referente cada parcela
        public bool statusVenda;
        public decimal totalFinalPagar;
        public int codigoCliente;
        public string formaPagamento;
        public int contaReceberID;
        StringBuilder sb = new StringBuilder();

        public frmFinalizarVendaCrediario()
        {
            InitializeComponent();
        }

        private void frmFinalizarVendaCrediario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                PesquisarCliente();
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

        private void PesquisarCliente()
        {
            try
            {
                frmPesquisarCliente frmCliente = new frmPesquisarCliente();
                frmCliente.ShowDialog();

                if (ConsultarClienteContaPendente(Convert.ToInt32(frmCliente.codigoCliente)))
                {
                    txtCodigoCliente.Text = frmCliente.codigoCliente.ToString();
                    txtNomeCliente.Text = frmCliente.nomeCliente;
                    txtCpfCNPJ.Text = frmCliente.cpfCnpj;
                    codigoCliente = int.Parse(txtCodigoCliente.Text);
                }
                else
                {
                    if (MessageBox.Show("O cliente " + frmCliente.nomeCliente.ToString().ToUpper() + "! esta com  inadimplência(s) no sistema. \n\n" +
                                     "Deseja continuar com operação ?", "Atenção - Restrinção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        txtCodigoCliente.Text = frmCliente.codigoCliente.ToString();
                        txtNomeCliente.Text = frmCliente.nomeCliente;
                        txtCpfCNPJ.Text = frmCliente.cpfCnpj;
                        codigoCliente = int.Parse(txtCodigoCliente.Text);
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {
            }
        }

        private Boolean ConsultarClienteContaPendente(int clienteID)
        {
            bool situacao = true;
            realizaVenda = new RealizarVendasTipos();
            realizaVendaBo = new RealizarVendasBO();
            DataTable dt = new DataTable();

            contasReceber = new ContasReceber();
            contasReceberBo = new ContasReceberBO();

            dt = realizaVendaBo.RetornaDataTableVendaClienteId(clienteID);

            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    contasReceber = contasReceberBo.RetornaContaReceberNumeroVenda(int.Parse(row["numeroVenda"].ToString()));

                    if (contasReceber != null)
                    {
                        if (contasReceber._Situacao.Equals("Aberto"))
                        {
                            itemContaReceber = new ItemContaReceber();
                            itemContaReceberBo = new ItemContaReceberBO();

                            DataTable dtItem = new DataTable();

                            dtItem = itemContaReceberBo.CriaDataTableSelecionaItemContasReceber(contasReceber._ContaReceberID);

                            foreach (DataRow rowItem in dtItem.Rows)
                            {
                                if (rowItem["status"].Equals("Vencida"))
                                {
                                    situacao = false;
                                    break;
                                }
                            }
                        }
                    }
                }
     
            }
            return situacao;
        }

        public Boolean ValidarCampos()
        {
            if (txtCodigoCliente.Text.Trim() == string.Empty)
            {
                txtCodigoCliente.Focus();
                MessageBox.Show("Campo obrigatóiro! digite o cliente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtPrazo.Text.Trim() == string.Empty)
            {
                txtPrazo.Focus();
                MessageBox.Show("Campo obrigatóiro! informe o prazo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtParcelas.Text.Trim() == string.Empty)
            {
                txtParcelas.Focus();
                MessageBox.Show("Campo obrigatóiro! infomre o número de parcelas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Método Grava conta a receber
        /// </summary>
        public void GravarCabecalhoContaReceber()
        {
            contasReceber = new ContasReceber();
            contasReceberBo = new ContasReceberBO();

            contasReceber._DataEntrada = DateTime.Parse(txtDataAtual.Text);
            contasReceber._RealizarVenda._NumeroVenda = int.Parse(txtNumeroVenda.Text);
            contasReceber._Valor_total = decimal.Parse(txtValorVenda.Text.Substring(3));

            contasReceberBo.InserirContasReceber(contasReceber);
        }

        /// <summary>
        /// Método grava as parcela referente a conta receber
        /// </summary>
        private void GravaItemParcelaContaReceber()
        {
            contasReceber = new ContasReceber();
            contasReceberBo = new ContasReceberBO();

            contasReceber = contasReceberBo.RetornaContaReceberID();
            contaReceberID = contasReceber._ContaReceberID;

            itemContaReceber = new ItemContaReceber();
            itemContaReceberBo = new ItemContaReceberBO();

            GeraDataPrazo();

            //Gera valor da parcela
            GeraValorParcela();

            for (int i = 1; i <= int.Parse(txtParcelas.Text); i++)
            {
                //Gera data de vencimento
                GeraDataVencimento();

                itemContaReceber._ContaReceber._ContaReceberID = contasReceber._ContaReceberID;
                itemContaReceber._NumeroParcela = i + "/" + txtParcelas.Text;
                itemContaReceber._ValorParcela = valorParcela;
                itemContaReceber.ValorAberto = Convert.ToDecimal("0");
                itemContaReceber._ValorPago = Convert.ToDecimal("0");
                itemContaReceber.ValorCobrado = Convert.ToDecimal("0");
                itemContaReceber._Juros = Convert.ToDecimal("0");
                itemContaReceber.ValorMulta = Convert.ToDecimal("0");
                itemContaReceber.DiasAtraso = Convert.ToInt32(0);
                itemContaReceber._DataVencimento = dataVencimento;
                itemContaReceber._Status = "Prevista";
                itemContaReceberBo.InserirItemContaReceber(itemContaReceber);

                contadorData++;
            }
        }

        /// <summary>
        /// Método gera data de vencimento
        /// </summary>
        private void GeraDataVencimento()
        {
            if (contadorData != 1)
            {
                dataVencimento = dataVencimento.AddMonths(1);
                txtDtVencimento.Text = dataVencimento.ToString("dd/MM/yyyy");
            }
        }

        private void GeraDataPrazo()
        {
            DateTime dataAtual = DateTime.Now;
            dataVencimento = dataAtual.AddDays(Convert.ToInt16(txtPrazo.Text));
            txtDtVencimento.Text = dataVencimento.ToString("dd/MM/yyyy");
        }

        /// <summary>
        /// Método gera o valor das parcelas
        /// </summary>
        private void GeraValorParcela()
        {
            decimal valorTotal = decimal.Parse(txtValorVenda.Text.Substring(3));
            valorParcela = (valorTotal / int.Parse(txtParcelas.Text));
        }

        private void toolStripButtonSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos() == true)
            {
                if (MessageBox.Show("Confirma finalizar esta venda ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    GravarCabecalhoContaReceber();
                    GravaItemParcelaContaReceber();
                    statusVenda = true;
                    codigoCliente = Convert.ToInt32(txtCodigoCliente.Text);
                    formaPagamento = "Crédiario Loja";
                    this.Close();
                }
            }
            else
            {
                return;
            }
        }

        public void CarregaDadosFinalizarVenda(decimal valorTotalVenda, int parametroNumeroVenda)
        {
            txtNumeroVenda.Text = parametroNumeroVenda.ToString();
            txtValorVenda.Text = Convert.ToDecimal(valorTotalVenda).ToString("C");
        }

        private void frmFinalizarVendaCrediario_Load(object sender, EventArgs e)
        {
            txtPrazo.Text = "30";
            txtParcelas.Text = "1";
            txtDataAtual.Text = Convert.ToDateTime(DateTime.Now).ToString("dd/MM/yyyy");
            GeraDataPrazo();
            GeraDataVencimento();
            HabilitaTitulos();
        }

        private void HabilitaTitulos()
        {
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
        }

        private void rbCartaoCredito_CheckedChanged(object sender, EventArgs e)
        {
            cliente = clienteDAO.SelecionaClientePorID(13);

            txtCodigoCliente.Text = cliente._CodigoCliente.ToString();
            txtNomeCliente.Text = cliente._Nome;
            txtCpfCNPJ.Text = cliente._CPF;
            txtCodigoCliente.Focus();
        }

        private void rbCrediarioLoja_CheckedChanged(object sender, EventArgs e)
        {
            PesquisarCliente();
        }
    }
}
