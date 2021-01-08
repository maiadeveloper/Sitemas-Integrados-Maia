using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.BO;
using Negocios;
using Negocios.TIPO;

namespace LavaJato
{
    public partial class frmLancamento : Form
    {
        public frmLancamento()
        {
            InitializeComponent();

            PopulaEmpresa();
            PopulaClasseDespesas();
            PopulaTipoDespesas();
            PopulaFornecedores();
            PopulaTipoDocumento();
            PopularTipoBaixa();
        }

        int classeDespesaID = 0;
        int lancamentoID = 0;
        decimal totalVlrBaixa = 0;
        int countLinhaBaixa = 0;
        int item = 1;
        Boolean pagandoFocus;
        Boolean editar;

        private void PopulaEmpresa()
        {
            try
            {
                EmpresaBO empresaBO = new EmpresaBO();
                cbEmpresa.DataSource = empresaBO.CriaDataTableEmpresa();
                cbEmpresa.ValueMember = "codigoEmpresa";
                cbEmpresa.DisplayMember = "nomeFantasiaEmpresa";

                cbEmpresa.SelectedIndex = 0;
            }
            catch (Exception) { }
        }

        private void PopulaClasseDespesas()
        {
            ClasseDespesaBO classeDespesaBO = new ClasseDespesaBO();
            txtClasseDespesas.DataSource = classeDespesaBO.CriaDataTableClasseDespesas("");
            txtClasseDespesas.ValueMember = "ClasseDespesaID";
            txtClasseDespesas.DisplayMember = "NomeClasse";
        }

        private void PopulaTipoDespesas()
        {
            try
            {
                TipoDespesaBO tipoDespesaBO = new TipoDespesaBO();
                txtTipoDespesas.DataSource = tipoDespesaBO.CriaDataTableTipoDespesas(classeDespesaID);
                txtTipoDespesas.ValueMember = "TipoDespesaID";
                txtTipoDespesas.DisplayMember = "NomeTipoDespesa";
            }
            catch (Exception) { }
        }


        private void PopulaFornecedores()
        {
            CadastroFornecedoresBO fornecedoresBO = new CadastroFornecedoresBO();
            cbClieForn.DataSource = fornecedoresBO.CriaDataFornecedores();
            cbClieForn.ValueMember = "CodigoFornecedor";
            cbClieForn.DisplayMember = "Nome_Fantasia";
        }

        private void PopularTipoBaixa()
        {
            BaixaTiposBO baixaTiposBO = new BaixaTiposBO();
            cbTipoBaixa.DataSource = baixaTiposBO.CriaDataTableTipoDocumento("");
            cbTipoBaixa.ValueMember = "BaixaTipoID";
            cbTipoBaixa.DisplayMember = "NomeBaixaTipo";
        }

        private void PopulaTipoDocumento()
        {
            TipoDocumentoBO tipoDocumentoBO = new TipoDocumentoBO();
            cbTipoDocumento.DataSource = tipoDocumentoBO.CriaDataTableTipoDocumento("");
            cbTipoDocumento.ValueMember = "TipoDocumentoID";
            cbTipoDocumento.DisplayMember = "NomeTipoDocumento";
        }

        private void txtClasseDespesas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            classeDespesaID = Convert.ToInt32(txtClasseDespesas.SelectedValue);
            PopulaTipoDespesas();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (lblLancamentoID.Text == "0")
            {
                if (ValidarCamposObrigatorios() == true)
                {
                    GravarLancamento();
                }
                return;
            }
            else
            {
                AlterarLancamento();
            }

            //Método realiza baixa pgto
            RealizarBaixa();
        }

        private void AlterarLancamento()
        {
        }

        private void GravarLancamento()
        {
            for (int i = 1; i <= int.Parse(cbNumeroParcelas.Text); i++)
            {
                LancamentosBO lancamentoBO = new LancamentosBO();
                Lancamentos lancamentos = new Lancamentos();

                lancamentos.CodClienteFornecedor = Convert.ToInt32(cbClieForn.SelectedValue);
                lancamentos.DataCadastro = DateTime.Parse(txtDataEntrada.Text);
                lancamentos.DataEmissao = DateTime.Parse(txtDataEmissao.Text);
                lancamentos.DataVencimento = DateTime.Parse(DataVencimento(i).ToString());
                lancamentos.Descricao = txtDescricao.Text;
                lancamentos.EmpresaID = Convert.ToInt32(cbEmpresa.SelectedValue);
                lancamentos.NumDoc = txtNumDocum.Text;
                lancamentos.NumParcela = i.ToString();
                lancamentos.Observacao = "";
                lancamentos.Situacao = "Aberto";
                lancamentos.TipoDespesaID = Convert.ToInt32(txtTipoDespesas.SelectedValue);
                lancamentos.TipoDocumento = Convert.ToInt32(cbTipoDocumento.SelectedValue);
                lancamentos.TipoLancamento = txtTipoLancamento.Text.Equals(" -  DESPESA") ? "DESPESA" : "RECEITA";
                lancamentos.ValorDesconto = Convert.ToDecimal("0,00");
                lancamentos.ValorJuros = Convert.ToDecimal("0,00");
                lancamentos.ValorAberto = Convert.ToDecimal("0,00");
                lancamentos.ValorPrincipal = VlrParcela();

                lancamentoBO.InserirLancamento(lancamentos);
            }

            MessageBox.Show("Lançamento realizado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (MessageBox.Show("Deseja realizar um novo lançamento ?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cbEmpresa.Focus();
                LimparCampos();
            }
            else
            {
                this.Close();
            }
        }

        private void LimparCampos()
        {
            lancamentoID = 0;
            txtClasseDespesas.SelectedIndex = 0;
            txtDataEmissao.Value = DateTime.Now;
            txtDataEntrada.Value = DateTime.Now;
            txtDescricao.Clear();
            txtNumDocum.Clear();
            txtTipoDespesas.SelectedIndex = 0;
            txtTipoLancamento.SelectedIndex = 0;
            txtTotalParcela.Clear();
            txtValorDocumento.Clear();
            txtVencimentoInicial.Value = DateTime.Now.AddMonths(1);
            listViewParcelas.Items.Clear();
            btnAddClasseDespesa.Enabled = false;
            txtTipoDespesas.Text = string.Empty;
            txtTipoLancamento.Text = string.Empty;

            PopulaEmpresa();
            PopulaClasseDespesas();
            PopulaTipoDespesas();
            PopulaFornecedores();
            PopulaTipoDocumento();
            PopularTipoBaixa();

            if (lancamentoID == 0)
            {
                tabLancamentos.TabPages.Remove(tabPage3);
                cbNumeroParcelas.SelectedIndex = 0;
            }
        }

        private DateTime DataVencimento(int i)
        {
            DateTime dataVecimentoInicial = txtVencimentoInicial.Value;
            DateTime dataVencimentoParcela;

            if (i == 1)
            {
                return dataVecimentoInicial;
            }
            else
            {
                return dataVencimentoParcela = dataVecimentoInicial.AddMonths(i - 1);
            }
        }

        private Decimal VlrParcela()
        {
            decimal vlrParcela = 0;

            if (!string.IsNullOrEmpty(txtValorDocumento.Text))
            {
                vlrParcela = Convert.ToDecimal(txtValorDocumento.Text.Substring(3)) / int.Parse(cbNumeroParcelas.Text);
            }

            return vlrParcela;
        }

        private void frmLancamento_Load(object sender, EventArgs e)
        {
            if (lancamentoID == 0)
            {
                tabLancamentos.TabPages.Remove(tabPage3);
                cbNumeroParcelas.SelectedIndex = 0;
            }

            HabilitaTitulos();

        }


        private void HabilitaTitulos()
        {
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
        }

        public void CarregaDadosEditarLancamento(int lancamentoID)
        {
            this.lancamentoID = lancamentoID;

            Lancamentos lancamentos = new Lancamentos();
            LancamentosBO lancamentosBO = new LancamentosBO();

            editar = true;

            lancamentos = lancamentosBO.SelecionarLancamentoID(lancamentoID);

            if (lancamentos != null)
            {
                tabLancamentos.TabPages.Remove(tabPage3);

                lblLancamentoID.Text = lancamentos.LancamentoID.ToString();
                txtDataEmissao.Text = lancamentos.DataEmissao.ToString("dd/MM/yyyy");
                txtDataEntrada.Text = lancamentos.DataCadastro.ToString("dd/MM/yyyy");
                txtDescricao.Text = lancamentos.Descricao;
                txtNumDocum.Text = lancamentos.NumDoc;
                cbNumeroParcelas.SelectedText = lancamentos.NumParcela.ToString();

                //pega o favorecido
                CadastroFornecedoresBO fornecedoresBO = new CadastroFornecedoresBO();
                CadastroFornecedores fornecedores = new CadastroFornecedores();

                fornecedores._CodigoFornecedor = lancamentos.CodClienteFornecedor;

                fornecedores = fornecedoresBO.SelecionaFornecedores(fornecedores);

                if (fornecedores != null)
                {
                    cbClieForn.Text = fornecedores._Nome_Fantasia;
                }

                //pega tipo despesa
                TipoDespesa tipoDespesa = new TipoDespesa();
                TipoDespesaBO tipoDespesaBO = new TipoDespesaBO();

                tipoDespesa = tipoDespesaBO.SelecionaTipoDespesaID(lancamentos.TipoDespesaID);

                if (tipoDespesa != null)
                {
                    txtTipoDespesas.Text = tipoDespesa.NomeTipoDespesa;
                }

                //pega clase despesa - provisoriamente
                ClasseDespesa classeDespesa = new ClasseDespesa();
                ClasseDespesaBO classeDepsaBO = new ClasseDespesaBO();

                classeDespesa = classeDepsaBO.SelecionarClasseDespesaID(tipoDespesa.ClasseDespesaID);

                if (classeDespesa != null)
                {
                    txtClasseDespesas.Text = classeDespesa.NomeClasse;
                }

                //pega tipo documento
                TipoDocumento tipoDocumento = new TipoDocumento();
                TipoDocumentoBO tipoDocumentoBO = new TipoDocumentoBO();

                tipoDocumento = tipoDocumentoBO.SelecionarTipoDocumentoID(lancamentos.TipoDocumento);

                if (tipoDocumento != null)
                {
                    cbTipoDocumento.Text = tipoDocumento.NomeTipoDocumento;
                }

                txtTipoLancamento.Text = lancamentos.TipoLancamento;
                txtTotalParcela.Text = lancamentos.ValorPrincipal.ToString("C");
                txtValorDocumento.Text = lancamentos.ValorPrincipal.ToString("C");
                txtVencimentoInicial.Text = lancamentos.DataVencimento.ToString("dd/MM/yyyy");
                txtPagando.Text = lancamentos.ValorPrincipal.ToString("C");
            }
        }

        public void CarregaDadosBaixarLancamento(int lancamentoID)
        {
            this.lancamentoID = lancamentoID;

            Lancamentos lancamentos = new Lancamentos();
            LancamentosBO lancamentosBO = new LancamentosBO();

            lancamentos = lancamentosBO.SelecionarLancamentoID(lancamentoID);

            if (lancamentos != null)
            {
                tabLancamentos.TabPages.Remove(tabPage1);
                tabLancamentos.SelectedTab = tabPage3;

                lblLancamentoID.Text = lancamentoID.ToString();
                txtLancamentoID.Text = lancamentoID.ToString();
                txtDescricaoBaixa.Text = lancamentos.Descricao;
                txtParcelaBaixa.Text = lancamentos.ValorPrincipal.ToString("C");
                txtParcelaBaixa.Text = lancamentos.NumParcela;
                txtNumeroDocumentoBaixa.Text = lancamentos.NumDoc;
                txtValorParcelaBaixa.Text = lancamentos.ValorPrincipal.ToString("C");
                txtPagando.Text = lancamentos.ValorPrincipal.ToString("C");

                CarregaLancamentosBaixaID(lancamentoID);

                txtPagando.Focus();
            }
        }

        private void frmLancamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtValorDocumento.Text))
                {
                    try
                    {
                        txtValorDocumento.Text = Convert.ToDecimal(txtValorDocumento.Text).ToString("C");
                    }
                    catch (Exception)
                    {
                        //ERRO
                    }
                }
                if (pagandoFocus == true)
                {
                    txtPagando.Text = Convert.ToDecimal(txtPagando.Text).ToString("C");
                    pagandoFocus = false;
                    btnBaixar.Focus();
                    btnBaixar_Click(this, e);
                }
            }
        }

        private Boolean ValidarCamposObrigatorios()
        {
            if (string.IsNullOrEmpty(cbEmpresa.Text))
            {
                MessageBox.Show("Campo obrigatório! Informe nome da empresa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbEmpresa.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtTipoLancamento.Text))
            {
                MessageBox.Show("Campo obrigatório! Informe tipo de lançamento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTipoLancamento.Focus();
                return false;
            }

            else if (cbClieForn.Text.Equals("Selecione uma opção"))
            {
                MessageBox.Show("Campo obrigatório! Informe o favorecido", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbClieForn.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtNumDocum.Text))
            {
                MessageBox.Show("Campo obrigatório! Informe o número do documento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNumDocum.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(cbTipoDocumento.Text))
            {
                MessageBox.Show("Campo obrigatório! Informe tipo do documento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbTipoDocumento.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtTipoDespesas.Text))
            {
                MessageBox.Show("Campo obrigatório! Informe tipo da despesa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTipoDespesas.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtDescricao.Text))
            {
                MessageBox.Show("Campo obrigatório! Informe a descrição", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescricao.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtValorDocumento.Text))
            {
                MessageBox.Show("Campo obrigatório! Informe a valor do documento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValorDocumento.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnBaixar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCamposObrigatoriosBaixas() == true)
                {
                    listViewBaixas.Items.Add(item.ToString());
                    listViewBaixas.Items[countLinhaBaixa].SubItems.Add(cbTipoBaixa.SelectedValue.ToString());
                    listViewBaixas.Items[countLinhaBaixa].SubItems.Add(cbTipoBaixa.Text);
                    listViewBaixas.Items[countLinhaBaixa].SubItems.Add("pgto ref. " + txtDescricaoBaixa.Text + " nº doc." + txtNumeroDocumentoBaixa.Text);
                    listViewBaixas.Items[countLinhaBaixa].SubItems.Add(txtCodigoContaCorrente.Text);
                    listViewBaixas.Items[countLinhaBaixa].SubItems.Add(txtDescricaoContaCorrent.Text);
                    listViewBaixas.Items[countLinhaBaixa].SubItems.Add(txtPagando.Text);

                    totalVlrBaixa += Convert.ToDecimal(txtPagando.Text.Substring(3));
                    txtTotalBaixas.Text = totalVlrBaixa.ToString("C");
                    countLinhaBaixa++;
                    item++;
                }
                return;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void CarregaVlorPacialBaixas()
        {
            totalVlrBaixa = 0;

            for (int i = 0; i < listViewBaixas.Items.Count; i++)
            {
                totalVlrBaixa += decimal.Parse(listViewBaixas.Items[i].SubItems[6].Text.Substring(3));
            }

            txtTotalBaixas.Text = totalVlrBaixa.ToString("C");
        }

        private void txtPagando_Leave(object sender, EventArgs e)
        {
            try
            {
                txtPagando.Text = Convert.ToDecimal(txtPagando.Text).ToString("C");
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Realizar lancamentos baixa
        /// </summary>
        private void RealizarBaixa()
        {
            if (MessageBox.Show("Confirma  realizar a baixa deste documento ?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LancamentosBaixas lancamentosBaixas;
                LancamentosBaixasBO lancamentoBaixasBO;

                if (listViewBaixas.Items.Count > 0)
                {
                    for (int i = 0; i < listViewBaixas.Items.Count; i++)
                    {
                        lancamentosBaixas = new LancamentosBaixas();
                        lancamentoBaixasBO = new LancamentosBaixasBO();

                        lancamentosBaixas.LancamentoID = Convert.ToInt32(txtLancamentoID.Text);
                        lancamentosBaixas.Item = int.Parse(listViewBaixas.Items[i].SubItems[0].Text);
                        lancamentosBaixas.BaixaTipoID = int.Parse(listViewBaixas.Items[i].SubItems[1].Text);
                        lancamentosBaixas.Descricao = listViewBaixas.Items[i].SubItems[3].Text;
                        lancamentosBaixas.ContaID = int.Parse(listViewBaixas.Items[i].SubItems[4].Text);
                        lancamentosBaixas.VlorBaixa = decimal.Parse(listViewBaixas.Items[i].SubItems[6].Text.Substring(3));
                        lancamentosBaixas.DataBaixa = Convert.ToDateTime(txtDataPgto.Value.ToString("dd/MM/yyyy"));
                        lancamentosBaixas.NumParcela = int.Parse(txtParcelaBaixa.Text);

                        lancamentoBaixasBO.InserirLancamentoBaixa(lancamentosBaixas);

                        //Atualiza conta
                        ContaCorrenteBO contaCorrenteBO = new ContaCorrenteBO();
                        contaCorrenteBO.AtualizarSaldoDespesa(lancamentosBaixas.ContaID, lancamentosBaixas.VlorBaixa.ToString());
                    }

                    MessageBox.Show("Baixa realizada com sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Atualiza status
                    Lancamentos lancamentos = new Lancamentos();
                    LancamentosBO lancamentoBO = new LancamentosBO();

                    lancamentos.DataPgto = DateTime.Now;
                    lancamentos.Situacao = ValorAberto() == 0 ? "Baixado" : "Aberto";
                    lancamentos.LancamentoID = int.Parse(txtLancamentoID.Text);
                    lancamentos.ValorAberto = ValorAberto();

                    lancamentoBO.AlterarLancamentoBaixar(lancamentos);

                    this.Close();
                }
            }
        }

        private decimal ValorAberto()
        {
            return Convert.ToDecimal(txtValorParcelaBaixa.Text.Substring(3)) - Convert.ToDecimal(txtTotalBaixas.Text.Substring(3));
        }

        private void CarregaLancamentosBaixaID(int lancametoID)
        {
            LancamentosBaixasBO lancamentosBaixasBO = new LancamentosBaixasBO();
            DataTable dt = new DataTable();
            int countRow;

            dt = lancamentosBaixasBO.CriaDataTableLancamentosBaixas(lancamentoID);

            if (dt != null)
            {
                listViewBaixas.Items.Clear();
                countRow = 0;

                foreach (DataRow row in dt.Rows)
                {
                    listViewBaixas.Items.Add(row["Item"].ToString());
                    listViewBaixas.Items[countRow].SubItems.Add(row["BaixaTipoID"].ToString());
                    listViewBaixas.Items[countRow].SubItems.Add("descriao tipo baixa");
                    listViewBaixas.Items[countRow].SubItems.Add("pgto ref nº doc." + txtNumeroDocumentoBaixa.Text);
                    listViewBaixas.Items[countRow].SubItems.Add(row["ContaID"].ToString());
                    listViewBaixas.Items[countRow].SubItems.Add("Descrição conta");
                    listViewBaixas.Items[countRow].SubItems.Add(Convert.ToDecimal(row["VlorBaixa"]).ToString("C"));

                    totalVlrBaixa += Convert.ToDecimal(row["VlorBaixa"]);
                    txtTotalBaixas.Text = totalVlrBaixa.ToString("C");
                    countLinhaBaixa++;
                    item++;
                }
            }
        }

        private void txtPagando_Enter(object sender, EventArgs e)
        {
            pagandoFocus = true;
        }

        private Boolean ValidarCamposObrigatoriosBaixas()
        {
            if (string.IsNullOrEmpty(txtPagando.Text))
            {
                MessageBox.Show("Campo obrigatório! Informe a valor a ser pago", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPagando.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtCodigoContaCorrente.Text))
            {
                MessageBox.Show("Campo obrigatório! a conta corrente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnAddConta.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnAddTipoDespesa_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedores frm = new frmCadastroFornecedores();
            frm.ShowDialog();
            PopulaFornecedores();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddConta_Click(object sender, EventArgs e)
        {
            frmBaseTodasContaCorrente frm = new frmBaseTodasContaCorrente();
            frm.ShowDialog();

            txtCodigoContaCorrente.Text = frm.CodigoContaCorrente.ToString();
            txtDescricaoContaCorrent.Text = frm.NomeContaCorrente;
        }

        private void removerItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewBaixas.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show("Confirma este item ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int index = listViewBaixas.FocusedItem.Index;
                    listViewBaixas.Items.RemoveAt(index);
                    countLinhaBaixa = countLinhaBaixa - 1;
                    item = item - 1;
                    CarregaVlorPacialBaixas();
                }
            }
        }

        private void btnAddClasseDespesa_Click_1(object sender, EventArgs e)
        {
            int lvLinhaParcela = 0;
            decimal totalParcelas = 0;
            listViewParcelas.Items.Clear();

            for (int i = 1; i <= int.Parse(cbNumeroParcelas.Text); i++)
            {
                listViewParcelas.Items.Add(i.ToString());
                listViewParcelas.Items[lvLinhaParcela].SubItems.Add("Ref ao documento de nº " + txtNumDocum.Text);
                listViewParcelas.Items[lvLinhaParcela].SubItems.Add(DataVencimento(i).ToString("dd/MM/yyyy dddddddddddddd"));
                listViewParcelas.Items[lvLinhaParcela].SubItems.Add(VlrParcela().ToString("C"));

                totalParcelas += VlrParcela();

                lvLinhaParcela++;
            }

            txtTotalParcela.Text = Convert.ToDecimal(totalParcelas).ToString("C");
        }

        private void txtValorDocumento_Leave(object sender, EventArgs e)
        {
            if (editar != true)
            {
                if (!string.IsNullOrEmpty(txtValorDocumento.Text))
                {
                    if (txtValorDocumento.Text.StartsWith("R$"))
                    {
                        txtValorDocumento.Text = Convert.ToDecimal(txtValorDocumento.Text.Substring(3)).ToString("C");
                    }
                    else
                    {
                        txtValorDocumento.Text = Convert.ToDecimal(txtValorDocumento.Text).ToString("C");
                    }
                    btnAddClasseDespesa.Enabled = true;
                }
            }
        }
    }
}
