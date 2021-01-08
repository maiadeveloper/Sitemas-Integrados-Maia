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
using Negocios.RVBo;
using Negocios.RVTipo;
using Negocios;
using System.Runtime.InteropServices;
using System.IO;

namespace LavaJato
{
    public partial class frmBaixarContaReceber : Form
    {
        public frmBaixarContaReceber()
        {
            InitializeComponent();
            CarregaContaReceberParcela(Convert.ToInt32(parametroCod), true);
            listBoxFormaPagamento.SelectedIndex = 0;
            txtPagando.Focus();
        }

        [DllImport("shell32.dll", EntryPoint = "ShellExecute")]
        public static extern int ShellExecuteA(int hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd);

        static string exeLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Remove(0, 6);

        int contador = 0;
        int item = 1;

        bool trueFalse = false;

        int countRow = 0;
        decimal totalRecebimento = 0;

        decimal totalPagar = 0;
        decimal juros = 0;

        bool isJuros = false;

        ItemContaReceber itemContaReceber = new ItemContaReceber();
        ItemContaReceberBO itemContaReceberBo = new ItemContaReceberBO();

        ContasReceber contaReceber = new ContasReceber();
        ContasReceberBO contaReceberBO = new ContasReceberBO();

        ItemContaReceberFormaRecebimento itemContaReceberFRec = new ItemContaReceberFormaRecebimento();
        ItemContaReceberFormaRecebimentoBO itemContaReceberFRecBO = new ItemContaReceberFormaRecebimentoBO();

        RealizarVendasBO vendasBO = new RealizarVendasBO();
        RealizarVendasTipos vendas = new RealizarVendasTipos();

        CadastroClientes cliente = new CadastroClientes();
        CadastroClientesDAO clienteDAO = new CadastroClientesDAO();

        ContaCorrenteBO contaCorrenteBO = new ContaCorrenteBO();

        StringBuilder sb = new StringBuilder();

        int parametroCod = 0;
        int diasAtraso;
        int contaID;
        int vendaID;
        decimal totalPago = 0;
        decimal troco = 0;
        decimal totalPagoDinheiro = 0;
        string status;
        decimal pagamentoHaver = 0;

        /// <summary>
        /// Habilita Titulo referente ao toolStripItem
        /// </summary>
        private void HabilitaTitulos()
        {
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
        }

        //Carrega informações inerente  as parcelas
        public void CarregaContaReceberParcela(int itemContaReceberID, bool isTrueFalse)
        {
            itemContaReceber = itemContaReceberBo.SelecionarItemContaReceberID(itemContaReceberID);

            if (itemContaReceber != null)
            {
                CarregaItensTipoRecebimento(Convert.ToInt32(itemContaReceber._ItemContaReceberID));
                HabilitaDesabilitaFormulario(isTrueFalse);

                parametroCod = itemContaReceber._ItemContaReceberID; ;
                //Pega conta receber
                contaReceber = contaReceberBO.RetornaContaReceberID(itemContaReceber._ContaReceber._ContaReceberID);
                contaID = contaReceber._ContaReceberID;

                //Pega venda
                vendas = vendasBO.RetornaNumeroVenda(contaReceber._NumeroVenda);
                vendaID = vendas._NumeroVenda;

                //Pega Dados cliente
                cliente = clienteDAO.SelecionaClientePorID(vendas._CodigoCliente);

                txtCPFCNPJ.Text = cliente._CPF;
                txtNomeFantasia.Text = cliente._Nome;
                txtDoc.Text = itemContaReceber._ItemContaReceberID.ToString();
                txtDataVencimento.Text = itemContaReceber._DataVencimento.ToString("dd/MM/yyyy");
                txtDataPgto.Text = DateTime.Now.ToString("dd/MM/yyyy");
                txtJuros.Text = itemContaReceber._Juros.ToString("C");
                txtMulta.Text = itemContaReceber.ValorMulta.ToString("C");
                txtNParcela.Text = itemContaReceber._NumeroParcela;
                txtTotalPaga.Text = itemContaReceber.ValorAberto > 0 ? itemContaReceber.ValorAberto.ToString("C") : itemContaReceber.ValorCobrado.ToString("C");
                txtValorParcela.Text = itemContaReceber._ValorParcela.ToString("C");
                pagamentoHaver = itemContaReceber._ValorPago;
                txtDiasAtraso.Text = itemContaReceber.DiasAtraso.ToString();
            }
        }

        //Salva informações pertinente ao item conta receber
        private void GravarItemFormaRecebimento()
        {
            ItemContaReceberFormaRecebimento itemContaReceberFR = new ItemContaReceberFormaRecebimento();
            ItemContaReceberFormaRecebimentoBO itemContaReceberFRDAO = new ItemContaReceberFormaRecebimentoBO();

            for (int i = 0; i < listFormaRecebimento.Items.Count; i++)
            {
                itemContaReceberFR._ItenContaReceber._ItemContaReceberID = parametroCod;
                itemContaReceberFR._Item = int.Parse(listFormaRecebimento.Items[i].SubItems[0].Text);
                itemContaReceberFR._FormaRecebimento = listFormaRecebimento.Items[i].SubItems[1].Text;
                itemContaReceberFR._VlrPago = decimal.Parse(listFormaRecebimento.Items[i].SubItems[2].Text.Substring(3));
                itemContaReceberFR._DataHora = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"));
                itemContaReceberFRDAO.Gravar(itemContaReceberFR);

                AtualizaSaldoContaCorrenteCaixaEmpresa(itemContaReceberFR._FormaRecebimento, itemContaReceberFR._VlrPago);
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

        private void IncluirTipoRecebimento()
        {
            if (HabilitaDesabilitaFormulario(trueFalse) == true)
            {
                //Verifica se o campos esta vazio, caso contrario ele redireciona o para  digitar um valor maior que 0
                if ((!string.IsNullOrEmpty(txtPagando.Text)) && (Convert.ToDecimal(txtPagando.Text) > 0))
                {
                    listFormaRecebimento.Items.Add(item.ToString());
                    listFormaRecebimento.Items[contador].SubItems.Add(listBoxFormaPagamento.SelectedItem.ToString());
                    listFormaRecebimento.Items[contador].SubItems.Add(RetornaTroco() != 0 ? decimal.Parse(txtTotalPaga.Text.Substring(3)).ToString("C") : decimal.Parse(txtPagando.Text).ToString("C"));
                    item++;
                    contador++;

                    //Exibe o total que ja foi recebido
                    txtTotalRecebido.Text = RetornaTotalPago().ToString("C");

                    //Exibe troco caso haja
                    txtTroco.Text = RetornaTroco().ToString("C");

                    //Inicia o método que retorna valor restante a pagar
                    txtPagando.Text = RetornaRestantePagar().ToString();

                    //Pega total em somente em dinheiro
                    totalPagoDinheiro = RetornaTotalPagoDinheiro();

                    //Limpa campo que recebe valor pagando
                    txtPagando.Focus();

                    //Finaliza conta caso valor seja igual ao valor total pagar
                    if (RetornaTotalPago() == decimal.Parse(txtTotalPaga.Text.Substring(3)))
                    {
                        GravarOperacao();
                    }
                }
                else
                {
                    txtPagando.Focus();
                }
            }
            else
            {
                return;
            }
        }

        private void GravarOperacao()
        {
            if (HabilitaDesabilitaFormulario(trueFalse) == true)
            {
                if (MessageBox.Show("Deseja realizar baixa ?", "Confirmação sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    GravarItemFormaRecebimento();

                    GravarItemContaReceber();

                    MessageBox.Show("Pagamento realizado com sucesso", "Pagamento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GerarArquivoTxtComprovantePgto();
                    ImprimirComprovantePagamento();
                    this.Close();

                }
            }
            else
            {
                return;
            }
        }

        //Retorna troco
        private decimal RetornaTroco()
        {
            troco = decimal.Parse(txtPagando.Text) - decimal.Parse(txtTotalPaga.Text.Substring(3));

            if (troco > 0)
                return troco;
            return 0;
        }

        //Retorna restante que falta ser pago 
        private decimal RetornaRestantePagar()
        {
            return decimal.Parse(txtTotalPaga.Text.Substring(3)) - RetornaTotalPago();
        }

        //Retorna valor total  referente ao pagamento
        private decimal RetornaTotalPago()
        {
            totalPago = 0;

            for (int i = 0; i < listFormaRecebimento.Items.Count; i++)
                totalPago += decimal.Parse(listFormaRecebimento.Items[i].SubItems[2].Text.Substring(3));
            return totalPago;
        }

        private decimal RetornaTotalPagoDinheiro()
        {
            totalPagoDinheiro = 0;

            for (int i = 0; i < listFormaRecebimento.Items.Count; i++)
            {
                if (listFormaRecebimento.Items[i].SubItems[1].Text == "01 - Dinheiro")
                {
                    totalPagoDinheiro += decimal.Parse(listFormaRecebimento.Items[i].SubItems[2].Text.Substring(3));
                }
            }
            return totalPagoDinheiro;
        }


        private void frmBaixarContaReceber_Load(object sender, EventArgs e)
        {
            HabilitaTitulos();
        }

        private void btnLimparFormasRecebimento_Click(object sender, EventArgs e)
        {
            listFormaRecebimento.Items.Clear();
            contador = 0;
            item = 1;
            txtTroco.Text = string.Empty;
            txtTotalRecebido.Text = string.Empty;
            txtPagando.Text = string.Empty;
            txtPagando.Focus();
        }

        private void GravarItemContaReceber()
        {
            AlterarStatus();

            ItemContaReceber itemContaReceber = new ItemContaReceber();
            ItemContaReceberBO itemContaReceberBo = new ItemContaReceberBO();

            itemContaReceber._ItemContaReceberID = parametroCod;
            itemContaReceber._DataPagamento = Convert.ToDateTime(txtDataPgto.Text);
            itemContaReceber._Juros = Convert.ToDecimal(txtJuros.Text.Substring(3));
            itemContaReceber._ValorPago = pagamentoHaver != 0 ? pagamentoHaver + RetornaTotalPago() : RetornaTotalPago();
            itemContaReceber.ValorAberto = RetornaTotalAberto();
            itemContaReceber._Status = status;

            itemContaReceberBo.EfetuarPagamentoContaReceberParcela(itemContaReceber);
        }


        private void AlterarStatus()
        {
            decimal totalPagar = decimal.Parse(txtTotalPaga.Text.Substring(3));
            decimal totalPago = RetornaTotalPago();

            if (totalPago < totalPagar)
            {
                status = "Prevista";
            }
            else
            {
                status = "Recebido";
            }
        }

        //Retorna total em aberto, utilizar esse metodo caso o cliente realizar pagamento haver
        private decimal RetornaTotalAberto()
        {
            return decimal.Parse(txtTotalPaga.Text.Substring(3)) - RetornaTotalPago();
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            ConfirmacaoSairOperacao();
        }

        public void ImprimirComprovantePagamento()
        {
            int copia = 1;

            while (copia <= 2)
            {
                string path = exeLocation + "\\Cupom\\ComprovantePgto.txt";
                frmRealizarVendas.ShellExecuteA(this.Handle.ToInt32(), "print", path, null, null, 0);
                copia++;
            }
        }

        public void GerarArquivoTxtComprovantePgto()
        {
            //Carrega dados da empresa
            Empresa empresa = new Empresa();
            EmpresaBO empresaBO = new EmpresaBO();

            //Pega dados do cliente
            CadastroClientesDAO clienteDAO = new CadastroClientesDAO();
            CadastroClientes cliente = new CadastroClientes();

            cliente = clienteDAO.SelecionaClientePorID(vendas._CodigoCliente);

            DateTime data = DateTime.Now;

            empresa = empresaBO.SelecionaUltimoRegistroEmpresa();

            //cria o arquivo txt para um determinado diretorio
            FileInfo arquivo = new FileInfo(exeLocation + "\\Cupom\\ComprovantePgto.txt");

            using (FileStream fs = arquivo.Create()) { }

            //Atribui valores aos campos,tais campos recebe os valores nescessários para criação da NFe
            string[] texto = {
                                "                          COMPROVANTE DE PAGAMENTO                    ",
                                 "---------------------------------------------------------------------------------",
                                 "CREDOR:",
                                  "" + empresa._NomeFantasia,
                                  "" +"CNPJ:" + empresa._CnpjCpf,
                                  "" +"Rua:" + empresa._Rua + ","+ empresa._Numero.ToString(),
                                  "" +"Bairro:" + empresa._Bairro + "  -  " + "CEP:" + empresa._Cep + "  " +empresa._Cidade + "-" + empresa._UF,
                                  "" +"Fone:" +empresa._Fone,
                                "---------------------------------------------------------------------------------",
                                "---------------------------------------------------------------------------------",
                                 "DEVEDOR:",
                                 "Cliente :" + cliente._Nome,
                                 "CPF:" + cliente._Cnpj,
                                 "Rua: " + cliente._End_Nome_Rua + "," + cliente._End_Numero.ToString(),
                                 "Bairro:" + cliente._Bairro + "  -  "+ "CEP:" + cliente._Cep + "   " + cliente._Cidade + "-" + cliente._Estado,
                                 "Fone:" + cliente._Telefone_Celular + "|" + cliente._Telefone_Fixo + "|" + cliente._TelefoneCelular1,
                                 "---------------------------------------------------------------------------------",
                                 "---------------------------------------------------------------------------------",
                                 "DETALHE PARCELA PAGA",
                                 "Nº VENDA:" + vendaID + "      Nº CONTA: " + contaID,
                                 "PARC  VCTO           DIAS ATR.  VLOR  MULTA  JUROS  VLRPAGO",
                                 " " +txtNParcela.Text + "   " + txtDataVencimento.Text + "    " + diasAtraso  + "             " + txtValorParcela.Text.Substring(3) + "  " + " " + txtMulta.Text.Substring(3) + "    " + txtJuros.Text.Substring(3) + "      " + txtTotalPaga.Text.Substring(3),
                                 "---------------------------------------------------------------------------------",
                                 "---------------------------------------------------------------------------------",
                                 "FORMA RECEBIMENTO",
                                 "ITEM         FORMA PAG         DATA PAG       VALOR",
                                 IncluirItensFormaRecebimento(),
                                 "---------------------------------------------------------------------------------",
                                empresa._NomeFantasia,
                                "Porto Velho - Ro - Data Hora Pagamento: " + data.ToString(),
                                "---------------------------------------------------------------------------------",
                             };

            //Escreve as informações no arquivo txt, salvo no diretorio expecificado
            File.WriteAllLines(exeLocation + "\\Cupom\\ComprovantePgto.txt", texto);
        }

        public string IncluirItensFormaRecebimento()
        {
            DataTable dt = new DataTable();
            ItemContaReceberFormaRecebimentoBO itemContaReceberFormaRecebimentoBO = new ItemContaReceberFormaRecebimentoBO();

            dt = itemContaReceberFormaRecebimentoBO.CriaDataTableSelecionaItemContasReceberFormaRecebimenoto(parametroCod);

            sb = new StringBuilder();

            foreach (DataRow row in dt.Rows)
            {
                DateTime dataHora = row["dataHora"] == DBNull.Value ? Convert.ToDateTime(DateTime.MinValue.ToString("dd/MM/yyyy")) : Convert.ToDateTime(row["dataHora"]);
                sb.AppendLine("  " + row.ItemArray[3].ToString() + "            " + row.ItemArray[4].ToString() + "         " + dataHora.ToString("dd/MM/yyyy") + "      " + Convert.ToDecimal(row.ItemArray[5]).ToString("C").Substring(3));
            }

            return sb.ToString();
        }

        private void listBoxFormaPagamento_DoubleClick(object sender, EventArgs e)
        {
            txtPagando.Focus();
        }

        private void frmBaixarContaReceber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (isJuros == true)
                {
                    AplicarDescontoJuros();
                }
                else
                {
                    IncluirTipoRecebimento();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                ConfirmacaoSairOperacao();
            }
            else if (e.KeyCode == Keys.F5)
            {
                GravarOperacao();
            }
            else if (e.KeyCode == Keys.F4)
            {
                FocarCampoRemoverJuros();
            }
            else if (e.KeyCode == Keys.F7)
            {
                DesfazerJurosAplicado();
            }
        }

        private void FocarCampoRemoverJuros()
        {
            if (MessageBox.Show("Deseja converter juros em desconto ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                juros = Convert.ToDecimal(txtJuros.Text.Substring(3));
                totalPagar = Convert.ToDecimal(txtTotalPaga.Text.Substring(3));
                lblDescontoJuros.Text = "(-) Desconto";
                txtJuros.ReadOnly = false;
                isJuros = true;
                txtJuros.Focus();
            }
            else
            {
                txtPagando.Focus();
                lblDescontoJuros.Text = "(+) Valor Juros";
                return;
            }
        }

        private void AplicarDescontoJuros()
        {
            if (txtJuros.Text.Length > 0)
            {

                txtJuros.Text = txtJuros.Text.StartsWith("R$") ? Convert.ToDecimal(txtJuros.Text.Substring(3)).ToString("C") : Convert.ToDecimal(txtJuros.Text).ToString("C");

                decimal novoVlrCobrado = Convert.ToDecimal(txtTotalPaga.Text.Substring(3)) - Convert.ToDecimal(txtJuros.Text.Substring(3));

                if (MessageBox.Show("Confirma converter juros em desconto ?" +
                    "\n-------------------------------------------------" +
                    "\n    Juros Atual:              " + juros.ToString("C") +
                    "\n    Total cobrado:          " + totalPagar.ToString("C") +
                    "\n    Desconto aplicado: - " + txtJuros.Text +
                    "\n-------------------------------------------------" +
                    "\n" + " " +
                    "\n" + "Novo total cobrado será de: " + novoVlrCobrado.ToString("C") +
                    " ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtTotalPaga.Text = novoVlrCobrado.ToString("C");
                    txtJuros.ReadOnly = true;
                    isJuros = false;
                    txtPagando.Focus();
                }
                else
                {
                    DesfazerJurosAplicado();
                }
            }
        }

        private void DesfazerJurosAplicado()
        {
            txtJuros.Text = juros.ToString("C");
            txtTotalPaga.Text = totalPagar.ToString("C");
            lblDescontoJuros.Text = "(+) Valor Juros";
            txtPagando.Focus();
        }

        private void ConfirmacaoSairOperacao()
        {
            if (RetornaTotalPago() != 0)
            {
                if (MessageBox.Show("Existem valores em aberto, deseja sair sem concluir operação ?", "Confirmação sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
                txtPagando.Focus();
            }

            this.Close();
        }

        private void toolStripButtonSalvar_Click(object sender, EventArgs e)
        {
            GravarOperacao();
        }


        public void CarregaItensTipoRecebimento(int codigo)
        {
            DataTable dt = new DataTable();
            ItemContaReceberFormaRecebimentoBO itemFormaRecebimentoBO = new ItemContaReceberFormaRecebimentoBO();

            dt = itemFormaRecebimentoBO.CriaDataTableSelecionaItemContasReceberFormaRecebimenoto(codigo);

            if (dt.Rows.Count > 0)
            {
                listItenFormaRecebimento.Items.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    //Adiciona os itens do list view
                    listItenFormaRecebimento.Items.Add(row["formaRecebimento"].ToString());
                    listItenFormaRecebimento.Items[countRow].SubItems.Add(Convert.ToDateTime(row["dataHora"] == DBNull.Value ? Convert.ToDateTime(DateTime.MinValue) : row["dataHora"]).ToString("dd/MM/yyyy"));
                    listItenFormaRecebimento.Items[countRow].SubItems.Add(Convert.ToDecimal(row["vlrPago"]).ToString("C"));

                    countRow++;

                    totalRecebimento += Convert.ToDecimal(row["vlrPago"]);
                }
                countRow = 0;
                txtTotal.Text = totalRecebimento.ToString("C");
                txtTotalHaver.Text = txtTotal.Text;

            }
            else
            {
                listItenFormaRecebimento.Enabled = false;
            }
        }

        public bool HabilitaDesabilitaFormulario(bool isTrueFalse)
        {
            if (isTrueFalse == false)
            {
                trueFalse = false; ;
            }
            else
            {
                trueFalse = true;
            }

            return trueFalse;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Utilitarios.iniciaCalc();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            FocarCampoRemoverJuros();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            DesfazerJurosAplicado();
        }
    }
}
