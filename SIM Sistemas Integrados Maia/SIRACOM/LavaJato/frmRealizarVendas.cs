using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.RVTipo;
using Negocios.RVBo;
using Negocios.RVDao;
using Negocios.ProdBo;
using Negocios.ProdTipo;
using Negocios.TIPO;
using Negocios;
using Negocios.BO;
using System.IO;
using System.Runtime.InteropServices;

namespace LavaJato
{
    public partial class frmRealizarVendas : Form
    {
        public frmRealizarVendas()
        {
            InitializeComponent();

            ExibirFotoRegistro();
            lblDataAtual.Text = DateTime.Now.ToLongDateString() + "   ";

            HabilitaTitulos();
        }
        private void HabilitaTitulos()
        {
            foreach (ToolStripItem item in tlstrip.Items)
            {
                item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
        }

        [DllImport("shell32.dll", EntryPoint = "ShellExecute")]
        public static extern int ShellExecuteA(int hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd);

        static string exeLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Remove(0, 6);
        int posItemRemover;
        int numeroVenda;
        int qtdeImpressao;
        int contator = 0;//Contador usado para controlar a posição de cada item no list view
        int codigoProduto;//Recebe o codigo do produto
        public bool statusVendasRV = false;//Verifica o status da venda
        public string formaPgto = "";//Mostra a forma de pagamento
        public decimal desc = 0;
        public decimal totalVenda;
        public decimal totalPagar;
        public int codigoContaReceber;
        public bool frmPgtoDinheiro, frmPgtoCD, frmPgtoCC;
        public decimal troco = 0;
        public decimal pagando;
        int item = 1;
        int qtde = 0;
        public int clienteID = 0;
        StringBuilder sb;
        StringBuilder sb2;
        StringBuilder sb3;

        RealizarVendasBO realizaVendaBo;
        RealizarVendasTipos realizaVenda;

        ProdutosTipo produto;
        ProdutosBO produtoBo;

        public void PegaUsuarioLogado(string usuario)
        {
            txtOperador.Text = usuario;
        }

        /// <summary>
        /// Carrega as caracteristica da lista
        /// Inserir os itens na lista
        /// </summary>
        public void CarregaCaracteristicaListViewItensVenda()
        {
            try
            {
                //Adiciona os itens do list view
                listaItensProdutoVenda.Items.Add(item.ToString());
                listaItensProdutoVenda.Items[contator].SubItems.Add(codigoProduto.ToString());
                listaItensProdutoVenda.Items[contator].SubItems.Add(txtCodigoBarra.Text);
                listaItensProdutoVenda.Items[contator].SubItems.Add(txtDescricaoProduto.Text);
                listaItensProdutoVenda.Items[contator].SubItems.Add(txtValorUnitario.Text);
                listaItensProdutoVenda.Items[contator].SubItems.Add(txtQtdade.Text);
                listaItensProdutoVenda.Items[contator].SubItems.Add(txtSubTotal.Text);

                item++;
            }
            catch (Exception)
            {
                string erro = "erro";
            }
        }

        /// <summary>
        /// Pecorre a lista somando o total parcial
        /// </summary>
        private void PecorreListaItensVendasValorParcial()
        {
            decimal vlrTotalParcial = 0;

            for (int i = 0; i < listaItensProdutoVenda.Items.Count; i++)
            {
                vlrTotalParcial += decimal.Parse(listaItensProdutoVenda.Items[i].SubItems[6].Text.Substring(3));
            }

            txtTotalParcial.Text = vlrTotalParcial.ToString("C");
            totalVenda = vlrTotalParcial;
        }

        /// <summary>
        /// Calcula sutotal da venda
        /// </summary>
        /// <param name="qtde"></param>
        /// <param name="precoUnitario"></param>
        private void CalculaSubTotal(int qtde, decimal precoUnitario)
        {
            decimal subTotal = 0;
            qtde = int.Parse(txtQtdade.Text);
            precoUnitario = decimal.Parse(txtValorUnitario.Text.Substring(3));
            subTotal = (qtde * precoUnitario);
            txtSubTotal.Text = subTotal.ToString("C");
        }

        /// <summary>
        /// Evento responsavel por chamar o metodo que faz inserção de item na lista de venda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRealizarVendas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCodigoBarra_Leave(this, e);
            }
            else if (e.KeyCode == Keys.F2)
            {
                PesquisarProduto();
            }
            else if (e.KeyCode == Keys.F3)
            {
                if (MessageBox.Show("Confirma sair desta venda?", "Confirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show("Confirma sair desta venda ?", "Confirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else if (e.KeyCode == Keys.F5)
            {
                FinalizarVendaComum();
            }
            else if (e.KeyCode == Keys.F4)
            {
                FinalizarVendaCrediario();
            }
            else if (e.KeyCode == Keys.F7)
            {
                RemoverUltimoItemLista();
                PecorreListaItensVendasValorParcial();
            }
            else if (e.KeyCode == Keys.F8)
            {
                frmImportarOrcamento frm = new frmImportarOrcamento();
                frm.ShowDialog();
                ImportarOrcamento(frm.numeroOrcamento);
            }
            else if (e.KeyCode == Keys.F9)
            {
                AdicionarQtde();
            }
        }

        private void AdicionarQtde()
        {
            using (frmQtdeRV frm = new frmQtdeRV())
            {
                frm.ShowDialog();

                if (frm.Qtde != 0)
                {
                    qtde = Convert.ToInt32(frm.Qtde);
                    txtCodigoBarra.Focus();
                }
            }
        }

        private void FinalizarVendaCrediario()
        {
            if (!string.IsNullOrEmpty(txtTotalParcial.Text))
            {
                IncluirItens();
                frmFinalizarVendaCrediario frm = new frmFinalizarVendaCrediario();
                frm.CarregaDadosFinalizarVenda(Convert.ToDecimal(txtTotalParcial.Text.Substring(3)), numeroVenda);
                frm.ShowDialog();
                statusVendasRV = frm.statusVenda;
                clienteID = frm.codigoCliente;
                formaPgto = frm.formaPagamento;
                codigoContaReceber = frm.contaReceberID;
                FinalizarVenda(Convert.ToDecimal(txtTotalParcial.Text.Substring(3)));
            }
            else
            {
                MessageBox.Show("Não existem itens pra finalização desta venda", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FinalizarVendaComum()
        {
            if (!string.IsNullOrEmpty(txtTotalParcial.Text))
            {
                IncluirItens();
                frmFinalizarVendaComum frmFinalizarVC = new frmFinalizarVendaComum();
                frmFinalizarVC.CarregaDadosFinalizarVenda(Convert.ToDecimal(txtTotalParcial.Text.Substring(3)), numeroVenda);
                frmFinalizarVC.ShowDialog();
                statusVendasRV = frmFinalizarVC.statusVenda;
                formaPgto = frmFinalizarVC.formaPagamentoVC;
                desc = frmFinalizarVC.descontoOferecido;
                troco = frmFinalizarVC.troco;
                pagando = frmFinalizarVC.pagandoDinheiro;
                totalPagar = frmFinalizarVC.totalFinalPagar;
                FinalizarVenda(frmFinalizarVC.totalFinalPagar);
            }
            else
            {
                MessageBox.Show("Não existem itens pra finalização desta venda", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RemoverUltimoItemLista()
        {
            try
            {
                frmRemoverItemVendaPosicao frm = new frmRemoverItemVendaPosicao();
                frm.ShowDialog();

                for (int i = 0; i < listaItensProdutoVenda.Items.Count; i++)
                {
                    string codigoSelecionado = listaItensProdutoVenda.Items[i].SubItems[2].Text;

                    if (frm.codigoBarra == codigoSelecionado)
                    {
                        posItemRemover = i;
                        contator = contator - 1;
                        item = item - 1;
                        listaItensProdutoVenda.Items.RemoveAt(posItemRemover);
                        PecorreListaItensVendasValorParcial();
                    }
                }
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Metodo Inseri item na lista
        /// </summary>
        private void InserirProdutoLista()
        {
            if (ValidarCampoObrigatoriosItens() == true)
            {
                CalculaSubTotal(int.Parse(txtQtdade.Text), decimal.Parse(txtValorUnitario.Text.Substring(3)));
                CarregaCaracteristicaListViewItensVenda();
                PecorreListaItensVendasValorParcial();
                contator++;
                LimparCamposBox();
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// Pesquisa um derterminado produto
        /// </summary>
        private void PesquisarProduto()
        {
            if (!string.IsNullOrEmpty(txtDataVenda.Text))
            {
                frmPesquisarProduto frmProduto = new frmPesquisarProduto();
                frmProduto.ShowDialog();

                txtCodigoBarra.Text = frmProduto.codigoBarra;
                codigoProduto = int.Parse(frmProduto.codigoProduto.ToString());
                txtDescricaoProduto.Text = frmProduto.nomeProduto;
                txtValorUnitario.Text = frmProduto.valorUnitario.ToString("C");
                txtQtdade.Text = qtde != 0 ? qtde.ToString() : "1";
                PesquisaProdutoID();
                CalculaSubTotal(int.Parse(txtQtdade.Text), decimal.Parse(txtValorUnitario.Text.Substring(3)));
                InserirProdutoLista();
                qtde = 0;
            }
            else
            {
                MessageBox.Show("Venda não foi iniciada - Pressione a tecla F6", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PesquisaProdutoID()
        {
            ProdutosTipo produto = new ProdutosTipo();
            ProdutosBO produtoBO = new ProdutosBO();

            if (codigoProduto != 0)
            {
                produto = produtoBO.SelectCodProduto(codigoProduto);
            }
        }

        /// <summary>
        /// Evento load do forms, carrega metodo para desativação dos campos e botoes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmRealizarVendas_Load(object sender, EventArgs e)
        {
            if (VerificaCaixaAberto() == true)
            {
                DesabilitaHabilitaCamposVendas(false);
                IniciarNovaVenda();
            }
            else
            {
                if (MessageBox.Show("O caixa para esta data não foi aberto.\n Deseja realizar abertura do caixa ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmAberturaFechamentoCaixa frm = new frmAberturaFechamentoCaixa();
                    frm.ShowDialog();
                    IniciarNovaVenda();
                }
                else
                {
                    this.Close();
                }
            }

            if (VerificaCaixaFechado() == true)
            {
                if (MessageBox.Show("O caixa ja encontra-se fechado.\n Deseja realizar reabertura do caixa ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Caixa caixa = new Caixa();
                    CaixaBO caixaBO = new CaixaBO();

                    caixa = caixaBO.SelecionaUltimoCaixa();

                    caixa.CaixaID = caixa.CaixaID;
                    caixa.Situacao = "Aberto";
                    caixa.DataReabertura = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));

                    caixaBO.ReabrirCaixa(caixa);

                    MessageBox.Show("Caixa reaberto com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Método validar campo obrigatorio
        /// </summary>
        /// <returns></returns>
        public Boolean ValidarCampoObrigatoriosItens()
        {
            if (txtCodigoBarra.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campo obrigatório! Digite o código de barra do produto", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigoBarra.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Método limpa campos do produto
        /// </summary>
        private void LimparCamposBox()
        {
            txtCodigoBarra.Focus();
            txtCodigoBarra.Clear();
        }

        /// <summary>
        /// Método desabilita habilita campos
        /// </summary>
        /// <param name="trueFalse"></param>
        private void DesabilitaHabilitaCamposVendas(bool trueFalse)
        {
            txtOperador.Enabled = trueFalse;
            txtNumeroVenda.Enabled = trueFalse;
            txtCodigoBarra.Enabled = trueFalse;
            txtCodigoBarra.Enabled = trueFalse;
            txtDescricaoProduto.Enabled = trueFalse;
            txtQtdade.Enabled = trueFalse;
            txtSubTotal.Enabled = trueFalse;
            txtValorUnitario.Enabled = trueFalse;
            txtCaixa.Enabled = trueFalse;
            txtTotalParcial.Enabled = trueFalse;
            txtDataVenda.Enabled = trueFalse;
        }

        /// <summary>
        /// Método retorna numero da venda atual
        /// </summary>
        private int GerarNumeroVenda()
        {
            realizaVenda = new RealizarVendasTipos();
            realizaVendaBo = new RealizarVendasBO();

            numeroVenda = 1;

            realizaVenda = realizaVendaBo.RetornaNumerVenda();

            if (realizaVenda != null)
            {
                int codigoAtual = realizaVenda._NumeroVenda;
                numeroVenda = codigoAtual + 1;

                txtNumeroVenda.Text = preencheNumeros(numeroVenda.ToString());
            }
            else
            {
                txtNumeroVenda.Text = preencheNumeros(numeroVenda.ToString());
            }

            return numeroVenda;
        }

        /// <summary>
        /// Método acrescenta zeros ao numero inicial da empresa
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        protected string preencheNumeros(string num)
        {
            while (num.Length < 4)
            {
                num = "0" + num;
            }

            return num;
        }

        /// <summary>
        /// Método inica uma nova venda
        /// </summary>
        private void IniciarNovaVenda()
        {
            LimparCamposBox();
            DesabilitaHabilitaCamposVendas(true);
            txtDataVenda.Text = DateTime.Now.ToString("dd/MM/yyyy");
            GerarNumeroVenda();
            txtCodigoBarra.Focus();
        }

        /// <summary>
        /// Método finalizar venda
        /// </summary>
        private void FinalizarVenda(decimal totalFinal)
        {
            if (statusVendasRV == true)
            {
                GravaDadosVenda(totalFinal);

                LimpaCamposGeral();

                DesabilitaHabilitaCamposVendas(false);

                item = 1;

                MessageBox.Show("Venda realizada com sucesso", "Gravação ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (formaPgto != "Crédiario Loja")
                {
                    GerarArquivoTxtComprovanteVenda();
                    ImprimirComprovanteVenda();
                }
                else
                {
                    GerarArquivoTxtReciboPrestacao();
                    ImprimirRecibodePrestacao();
                }

                if (MessageBox.Show("Deseja iniciar uma nova venda ?", "Confirme", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    IniciarNovaVenda();
                    sb = null;
                    sb2 = null;
                    sb3 = null;
                    pagando = 0;
                    frmPgtoCC = false;
                    frmPgtoCD = false;
                    frmPgtoDinheiro = false;
                }
                else
                {
                    this.Close();
                }
            }
        }

        /// <summary>
        /// Método faz inserção dados do cabeçalho da venda
        /// </summary>
        private void GravaDadosVenda(decimal valorFinalPagar)
        {
            realizaVenda = new RealizarVendasTipos();
            realizaVendaBo = new RealizarVendasBO();

            realizaVenda._NumeroVenda = int.Parse(txtNumeroVenda.Text);
            realizaVenda._DataVenda = DateTime.Parse(txtDataVenda.Text);
            realizaVenda._CodigoCliente = clienteID != 0 ? clienteID : 15;
            realizaVenda._FormaPagamento = formaPgto;
            realizaVenda._TotalPagar = valorFinalPagar;
            realizaVenda._Descontos = desc;


            //Grava cabeçalho
            realizaVendaBo.GravarCabecalhoVenda(realizaVenda);

            //Grava itens venda
            GravaItemsVenda();
        }

        /// <summary>
        /// Grava os itens de cada venda
        /// </summary>
        private void GravaItemsVenda()
        {
            realizaVenda = new RealizarVendasTipos();
            realizaVendaBo = new RealizarVendasBO();

            //busca o numero da venda realizada
            realizaVenda._NumeroVenda = int.Parse(txtNumeroVenda.Text);

            realizaVenda = realizaVendaBo.RetornaNumeroVenda(realizaVenda);

            if (realizaVenda != null)
            {
                for (int i = 0; i < listaItensProdutoVenda.Items.Count; i++)
                {
                    realizaVenda._NumeroVenda = realizaVenda._NumeroVenda;
                    realizaVenda._Item = i + 1;
                    realizaVenda._Iuo = int.Parse(listaItensProdutoVenda.Items[i].SubItems[1].Text);
                    realizaVenda._Descricao = listaItensProdutoVenda.Items[i].SubItems[3].Text;
                    realizaVenda._PrecoUnitario = decimal.Parse(listaItensProdutoVenda.Items[i].SubItems[4].Text.Substring(3));
                    realizaVenda._Qtde = int.Parse(listaItensProdutoVenda.Items[i].SubItems[5].Text);
                    realizaVenda._SubTotal = decimal.Parse(listaItensProdutoVenda.Items[i].SubItems[6].Text.Substring(3));

                    realizaVendaBo.GravaItensVenda(realizaVenda);

                    //Remove a quantidade de itens que foi vendido, referente ao cada item no estoque
                    produtoBo = new ProdutosBO();
                    produtoBo.BaixarQtdeProdutoEstoque(realizaVenda._Iuo, realizaVenda._Qtde);
                }
            }
        }

        /// <summary>
        /// Limpa todos os campos inclusive o listview com os itens da venda
        /// </summary>
        private void LimpaCamposGeral()
        {
            txtCodigoBarra.Focus();
            txtCodigoBarra.Clear();
            txtDescricaoProduto.Clear();
            txtTotalParcial.Clear();
            txtSubTotal.Clear();
            txtQtdade.Clear();
            txtNumeroVenda.Clear();
            txtValorUnitario.Clear();
            listaItensProdutoVenda.Items.Clear();
            contator = 0;
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
                    codigoProduto = produto._CodigoProduto;
                    txtDescricaoProduto.Text = produto._NomeProduto;
                    txtValorUnitario.Text = produto._ValorUnitario.ToString("C");
                    txtQtdade.Text = qtde != 0 ? qtde.ToString() : "1";
                    CalculaSubTotal(int.Parse(txtQtdade.Text), decimal.Parse(txtValorUnitario.Text.Substring(3)));
                    PesquisaProdutoID();
                    InserirProdutoLista();
                    qtde = 0;
                }
                else
                {
                    MessageBox.Show("Produto não cadastrado - solicite o cadastro do mesmo", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigoBarra.Focus();
                    txtCodigoBarra.Clear();
                }
            }
        }

        public void ImportarOrcamento(int numeroOrcamento)
        {
            DataTable dt = new DataTable();
            OrcamentoBO orcamentoBO = new OrcamentoBO();

            dt = orcamentoBO.CriaDataTableSelecionaItensOrcamentos(numeroOrcamento);

            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    //Adiciona os itens do list view
                    listaItensProdutoVenda.Items.Add(row.ItemArray[3].ToString());
                    listaItensProdutoVenda.Items[contator].SubItems.Add(row.ItemArray[2].ToString());
                    listaItensProdutoVenda.Items[contator].SubItems.Add(row.ItemArray[8].ToString());
                    listaItensProdutoVenda.Items[contator].SubItems.Add(row.ItemArray[7].ToString());
                    listaItensProdutoVenda.Items[contator].SubItems.Add(Convert.ToDecimal(row.ItemArray[5]).ToString("C"));
                    listaItensProdutoVenda.Items[contator].SubItems.Add(row.ItemArray[4].ToString());
                    listaItensProdutoVenda.Items[contator].SubItems.Add(Convert.ToDecimal(row.ItemArray[6]).ToString("C"));

                    contator++;
                }

                PecorreListaItensVendasValorParcial();
            }
            else
            {
                MessageBox.Show("Orçamento não encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void ImprimirRecibodePrestacao()
        {
            int copia = 1;

            while (copia <= 2)
            {
                string path = exeLocation + "\\Cupom\\ReciboPrestacao.txt";
                frmRealizarVendas.ShellExecuteA(this.Handle.ToInt32(), "print", path, null, null, 0);

                copia++;
            }
        }

        public void GerarArquivoTxtReciboPrestacao()
        {
            //Carrega dados da empresa
            Empresa empresa = new Empresa();
            EmpresaBO empresaBO = new EmpresaBO();

            //Pega dados do cliente
            CadastroClientesDAO clienteDAO = new CadastroClientesDAO();
            CadastroClientes cliente = new CadastroClientes();

            cliente = clienteDAO.SelecionaClientePorID(clienteID);

            DateTime data = DateTime.Now;

            empresa = empresaBO.SelecionaUltimoRegistroEmpresa();
            qtdeImpressao = empresa.QtdeImpressaoRecibo;

            //cria o arquivo txt para um determinado diretorio
            FileInfo arquivo = new FileInfo(exeLocation + "\\Cupom\\ReciboPrestacao.txt");

            using (FileStream fs = arquivo.Create()) { }

            //Atribui valores aos campos,tais campos recebe os valores nescessários para criação da NFe
            string[] texto = {
                                 "                          CONTRATO DE VENDA                          ",
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
                                 "ITENS DA VENDA:",
                                 "Item  Cod   Produto                                        Qtde   Preço   Total",
                                 "---------------------------------------------------------------------------------",
                                 IncluirItens(),
                                 "---------------------------------------------------------------------------------",
                                 "VALOR TOTAL PRODUTO(S)..:R$                                         " + totalVenda,
                                  "---------------------------------------------------------------------------------",
                                  "---------------------------------------------------------------------------------",
                                 "DETALHE PACELAMENTO:",
                                 "PARCELA       VENCIMENTO                                               VALOR",
                                 IncluirItensContaReceber(),
                                 "VALOR TOTAL CONTA PAGAR..:R$                                       " + totalVenda,
                                 "---------------------------------------------------------------------------------",
                                 "---------------------------------------------------------------------------------",
                                 "TERMO DO CONTRATO DA VENDA:",
                                 "Declaro ter recebido neste ato, o(s) produto(s) acima especificado(s) em perfeita(s)",
                                 "condição(oes) de uso.",
                                 "Estou ciente da divida acima especificada e dos titulos oriundos, dos prazoz de vencimento",
                                 "de cada parcela e que após a inadimplência superior a 05(cinco) dias o titulo vencido",
                                 "sera encaminhado ao cartório de protesto desta comarca para cobrança.",
                                 "Apos a data de vencimento sera acrescido encargos contratuais por atraso de 2%",
                                 ",juros de mora de 0,75% a.m.",
                                 " ",
                                 "Assumo inteira responsabilidade pelas informações prestadas e autorizo a sua confirmação",
                                 "e comprometo-me a atualizar o meu endereço toda vez que mudar.",
                                 " ",
                                 "---------------------------------------------------------------------------------",
                                empresa._NomeFantasia,
                                "Número venda:" + numeroVenda.ToString(),
                                "Porto Velho - Ro: " + data.ToString(),
                                "---------------------------------------------------------------------------------",
                             };

            //Escreve as informações no arquivo txt, salvo no diretorio expecificado
            File.WriteAllLines(exeLocation + "\\Cupom\\ReciboPrestacao.txt", texto);
        }

        public string IncluirItensContaReceber()
        {
            DataTable dt = new DataTable();
            ItemContaReceberBO itemContaReceberBO = new ItemContaReceberBO();

            dt = itemContaReceberBO.CriaDataTableSelecionaItemContasReceber(codigoContaReceber);

            sb3 = new StringBuilder();

            foreach (DataRow row in dt.Rows)
            {
                sb3.AppendLine("   " + row.ItemArray[7].ToString() + "             " + Convert.ToDateTime(row.ItemArray[9]).ToString("dd/MM/yyyy") + "                                                  " + Convert.ToDecimal(row.ItemArray[8]).ToString("C").Substring(3));
            }

            return sb3.ToString();
        }

        public void ImprimirComprovanteVenda()
        {
            Empresa empresa = new Empresa();
            EmpresaBO empresaBO = new EmpresaBO();

            empresa = empresaBO.SelecionaUltimoRegistroEmpresa();
            qtdeImpressao = empresa.QtdeImpressaoRecibo;
            int copia = 1;

            if (empresa.ConfirmaImpressao == 1)
            {
                if (MessageBox.Show("Deseja imprimir comprovante da venda: " + numeroVenda.ToString() + "", "Confirmação recibo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    while (copia <= qtdeImpressao)
                    {
                        string path = exeLocation + "\\Cupom\\ComprovanteVenda.txt";
                        frmRealizarVendas.ShellExecuteA(this.Handle.ToInt32(), "print", path, null, null, 0);

                        copia++;
                    }
                }
            }
            else
            {
                while (copia <= qtdeImpressao)
                {
                    string path = exeLocation + "\\Cupom\\ComprovanteVenda.txt";
                    frmRealizarVendas.ShellExecuteA(this.Handle.ToInt32(), "print", path, null, null, 0);

                    copia++;
                }
            }
        }

        public void GerarArquivoTxtComprovanteVenda()
        {
            //Carrega dados da empresa
            Empresa empresa = new Empresa();
            EmpresaBO empresaBO = new EmpresaBO();

            string nomeCliente = clienteID != 0 ? "VENDA AVULSA" : "VENDA AVULSA";

            DateTime data = DateTime.Now;

            empresa = empresaBO.SelecionaUltimoRegistroEmpresa();

            //cria o arquivo txt para um determinado diretorio
            FileInfo arquivo = new FileInfo(exeLocation + "\\Cupom\\ComprovanteVenda.txt");

            using (FileStream fs = arquivo.Create()) { }

            //Atribui valores aos campos,tais campos recebe os valores nescessários para criação da NFe
            string[] texto = {
                                 "                            COMPROVANTE DE VENDA                            ",
                                 "---------------------------------------------------------------------------------",
                                  "" + empresa._NomeFantasia,
                                  "" +"CNPJ:" + empresa._CnpjCpf,
                                  "" +"Rua:" + empresa._Rua + ","+ empresa._Numero.ToString(),
                                  "" +"Bairro:" + empresa._Bairro + "  -  " + "CEP:" + empresa._Cep + "  " +empresa._Cidade + "-" + empresa._UF,
                                  "" +"Fone:" +empresa._Fone,
                                 "---------------------------------------------------------------------------------",
                                 "Data:" + data.ToString() +        "          Número venda:" + numeroVenda.ToString(), 
                                 "Cliente :" + nomeCliente,
                                 "---------------------------------------------------------------------------------",
                                 "---------------------------------------------------------------------------------",
                                 "Item  Cod   Produto                                        Qtde   Preço   Total",
                                 "---------------------------------------------------------------------------------",
                                 IncluirItens(),
                                 "---------------------------------------------------------------------------------",
                                 "VALOR TOTAL PRODUTO(S)..:R$                                        " + totalVenda,
                                 "DESCONTO......:R$                                                            - " + desc,
                                 "                                                                                      --------",
                                 "TOTAL PAGAR..:R$                                                            " + totalPagar,
                                IncluirPagandoDinheiro(),
                                 "                                                                                      --------",
                                 "TROCO............:R$" + "                                                            " + troco.ToString("N2"),
                                 "---------------------------------------------------------------------------------",
                                 "---------------------------------------------------------------------------------",
                                 "FORMA PAGAMENTO                                                         VALOR",
                                 IncluirTipoRecebimento(), 
                                 "---------------------------------------------------------------------------------",
                                 "Porto Velho - Ro: " + data.ToString(),
                                "---------------------------------------------------------------------------------",
                             };

            //Escreve as informações no arquivo txt, salvo no diretorio expecificado
            File.WriteAllLines(exeLocation + "\\Cupom\\ComprovanteVenda.txt", texto);
        }

        private string IncluirPagandoDinheiro()
        {
            DataTable dt = new DataTable();
            ItemTipoRecebimentoVendaBO itemTipoRecebimentoVendaBO = new ItemTipoRecebimentoVendaBO();
            dt = itemTipoRecebimentoVendaBO.CriaDataTableSelecionaItemVendaFormaRecebimenoto(numeroVenda);

            foreach (DataRow row in dt.Rows)
            {
                if (row["formaRecebimento"].ToString().StartsWith("02"))
                {
                    frmPgtoCD = true;
                }
                else if (row["formaRecebimento"].ToString().StartsWith("03"))
                {
                    frmPgtoCC = true;
                }
                else
                {
                    frmPgtoDinheiro = true;
                }
            }

            if ((frmPgtoDinheiro == true) && (frmPgtoCC == false) && (frmPgtoCD == false))
            {
                return "PAGANDO........:R$" + "                                                          - " + pagando.ToString("N2");
            }
            else
            {
                return string.Empty;
            }
        }

        public string IncluirItens()
        {
            if (listaItensProdutoVenda.Items.Count > 0)
            {
                sb = new StringBuilder();

                string item, cod, produto, qtde, preco, total;

                for (int i = 0; i < listaItensProdutoVenda.Items.Count; i++)
                {
                    item = (i + 1).ToString(); cod = listaItensProdutoVenda.Items[i].SubItems[1].Text;
                    produto = listaItensProdutoVenda.Items[i].SubItems[3].Text;
                    qtde = listaItensProdutoVenda.Items[i].SubItems[5].Text;
                    preco = listaItensProdutoVenda.Items[i].SubItems[4].Text.Substring(3);
                    total = listaItensProdutoVenda.Items[i].SubItems[6].Text.Substring(3);

                    sb.AppendLine("  " + item + "      " + cod + "      " + produto + " " + qtde + " " + preco + " " + total);
                }
            }
            return sb.ToString();
        }

        public string IncluirTipoRecebimento()
        {
            DataTable dt = new DataTable();
            ItemTipoRecebimentoVendaBO itemTipoRecebimentoVendaBO = new ItemTipoRecebimentoVendaBO();
            dt = itemTipoRecebimentoVendaBO.CriaDataTableSelecionaItemVendaFormaRecebimenoto(numeroVenda);
            sb2 = new StringBuilder();

            foreach (DataRow row in dt.Rows)
            {
                if (row["formaRecebimento"].ToString().StartsWith("01"))
                {
                    frmPgtoDinheiro = true;
                    sb2.AppendLine(row["formaRecebimento"].ToString() + "                                                                     " + Convert.ToDecimal(row["vlrPago"]).ToString("C").Substring(3));
                }
                if (row["formaRecebimento"].ToString().StartsWith("02"))
                {
                    frmPgtoCD = true;
                    sb2.AppendLine(row["formaRecebimento"].ToString() + "                                                         " + Convert.ToDecimal(row["vlrPago"]).ToString("C").Substring(3));
                }
                if (row["formaRecebimento"].ToString().StartsWith("03"))
                {
                    frmPgtoCC = true;
                    sb2.AppendLine(row["formaRecebimento"].ToString() + "                                                         " + Convert.ToDecimal(row["vlrPago"]).ToString("C").Substring(3));
                }
            }

            return sb2.ToString();
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (listaItensProdutoVenda.SelectedIndices.Count > 0)
            {
                if (MessageBox.Show("Confirma remover este item ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int index = listaItensProdutoVenda.FocusedItem.Index;
                    listaItensProdutoVenda.Items.RemoveAt(index);
                    PecorreListaItensVendasValorParcial();
                    contator = contator - 1;
                    item = item - 1;
                }
            }
        }

        public Boolean VerificaCaixaAberto()
        {
            CaixaBO caixaBO = new CaixaBO();
            DataSet ds = new DataSet();
            ds = caixaBO.SelecionaCaixaDiaDataSet(DateTime.Now);
            bool resp = false;

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                resp = true;
            }

            return resp;
        }

        public Boolean VerificaCaixaFechado()
        {
            CaixaBO caixaBO = new CaixaBO();
            DataSet ds = new DataSet();
            ds = caixaBO.SelecionaCaixaDiaDataSet(DateTime.Now);
            bool resp = false;

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                if (row.ItemArray[4].ToString() == "Fechado")
                {
                    resp = true;
                }
            }

            return resp;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        public void ExibirFotoRegistro()
        {
            try
            {
                Empresa empresa = new Empresa();
                EmpresaBO empresaBo = new EmpresaBO();

                empresa = empresaBo.SelecionaUltimoRegistroEmpresa();

                //Carrega imagem do fundo

                if (!string.IsNullOrEmpty(empresa._LogoEmpresa))
                {
                    pictureBox1.Image = Image.FromFile(empresa._LogoEmpresa);
                }
            }
            catch (Exception)
            { }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FinalizarVendaComum();
        }

        private void toolStripFinalizarVendaAvista_Click(object sender, EventArgs e)
        {
            FinalizarVendaCrediario();
        }

        private void toolStripProdutos_Click(object sender, EventArgs e)
        {
            PesquisarProduto();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            AdicionarQtde();
        }

        private void toolStripRemoverItem_Click(object sender, EventArgs e)
        {
            RemoverUltimoItemLista();
            PecorreListaItensVendasValorParcial();
        }
    }
}
