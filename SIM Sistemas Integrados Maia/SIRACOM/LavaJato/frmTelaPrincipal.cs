using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios;
using Negocios.TIPO;
using Negocios.BO;
using System.Media;

namespace LavaJato
{
    public partial class frmTelaInicial : Form
    {
        public frmTelaInicial()
        {
            InitializeComponent();
        }

        ItemContaReceberBO itemContaReceberBo = new ItemContaReceberBO();
        ItemContaReceber itemContaReceber = new ItemContaReceber();

        Boolean trueFalseBAuto, trueFalseBFechar;
        SoundPlayer som = new SoundPlayer();

        frmLoginSistema frmLogin; //Cria uma instancia frmLoginSistema

        frmBoasVindas frmBoasV = new frmBoasVindas();

        Empresa empresa;
        EmpresaBO empresaBo;
        int contadorLinha = 0;
        decimal totalPagar = 0;

        private void HabilitaTitulos()
        {
            foreach (ToolStripItem item in tlstrip.Items)
            {
                item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
        }


        public frmTelaInicial(frmLoginSistema frmLoginParam)
        {
            InitializeComponent();

            frmLogin = frmLoginParam;

            lblUsuaarioLogado.Text = frmLogin.cdUsuarios._NomeUsuario; //Atribui o lblUsuario ao Usuario logado ao Sistema
            frmBoasV.ShowDialog();
            lblDataAtual.Text = DateTime.Now.ToLongDateString();
        }

        private void frmTelaInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Confirma saida do Sistema ? ", "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                RealizarBackup();
            }
        }

        private void RealizarBackup()
        {
            try
            {
                Utilitarios.RealizarBackupBanco();

                MessageBox.Show("Backup automático gerado com sucesso", "Backup automático", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception msgErro)
            {
                MessageBox.Show(msgErro.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TimerSistema_Tick(object sender, EventArgs e)
        {
            TimerSistema.Enabled = true;
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");  //Exibe hora em formato 13:00:00
            //ExibirFotoRegistro();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBaseTodosClientes frmTodosClientes = new frmBaseTodosClientes();
            frmTodosClientes.ShowDialog();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sobreOSoftwareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSobreSoftware sSoftware = new frmSobreSoftware();
            sSoftware.ShowDialog();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Opção não esta disponível para esta versão!!!", "Atenção usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmCadastroFuncionarios cadastroFuncionarios = new frmCadastroFuncionarios();
            cadastroFuncionarios.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseTodosFornecedores frm = new frmBaseTodosFornecedores();
            frm.ShowDialog();
        }


        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

            frmBaseTodosUsuarios frm = new frmBaseTodosUsuarios();
            frm.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Help em fase de desenvolvimento! Desculpe o transtorno", "Atenção Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utilitarios.iniciaCalc();
        }

        private void blocoDeNotasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Utilitarios.iniciaNotePad();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

            Utilitarios.iniciaExcel();
        }

        private void frmTelaInicial_Load(object sender, EventArgs e)
        {
            ExibirFotoRegistro();

            CarregaConfiguracoesSistema();

            HabilitaTitulos();

            //Altera status conta vencidas
            AlterarStatusContaVencida();

            CarregaTodosLancamentos();
        }

        private void realizarVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmRealizarVendas frm = new frmRealizarVendas();
            frm.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmBaseTodosProdutos frmBaseProdutos = new frmBaseTodosProdutos();
            frmBaseProdutos.ShowDialog();
        }

        private void contasÀPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseTodosLancamentos frm = new frmBaseTodosLancamentos();
            frm.ShowDialog();
        }

        private void cadastrarBancoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmBanco frmBanco = new frmBanco();
            frmBanco.ShowDialog();
        }


        private void button16_Click(object sender, EventArgs e)
        {
            Utilitarios.iniciaNotePad();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Utilitarios.iniciaCalc();
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

            Utilitarios.iniciaWord();
        }

        private void button21_Click(object sender, EventArgs e)
        {

            Utilitarios.iniciaExcel();
        }

        private void button19_Click(object sender, EventArgs e)
        {

            Utilitarios.iniciaNavegador();
        }

        private void fornecedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPesquisarFornecedores janelaFornecedores = new frmPesquisarFornecedores();
            janelaFornecedores.ShowDialog();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategoria janelaCategoria = new frmCategoria();
            janelaCategoria.ShowDialog();
        }

        private void toolStripMenuItem6_Click_1(object sender, EventArgs e)
        {
            frmPesquisarCliente janelaClientes = new frmPesquisarCliente();
            janelaClientes.ShowDialog();
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            frmPesquisarProduto janelaProdutos = new frmPesquisarProduto();
            janelaProdutos.ShowDialog();
        }

        private void frmTelaInicial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                frmBaseTodosOrcamentos frm = new frmBaseTodosOrcamentos();
                frm.ShowDialog();
            }
            else if (e.KeyCode == Keys.F11)
            {
                frmRealizarVendas frmRV = new frmRealizarVendas();
                frmRV.PegaUsuarioLogado(lblUsuaarioLogado.Text);
                frmRV.ShowDialog();
            }
            else if (e.KeyCode == Keys.F6)
            {
                frmBaseTodasContasReceber frm = new frmBaseTodasContasReceber();
                frm.ShowDialog();
            }
            else if (e.KeyCode == Keys.F5)
            {
                frmMovimentacaoDiaria frm = new frmMovimentacaoDiaria();
                frm.ShowDialog();
            }
            else if (e.KeyCode == Keys.F4)
            {
                frmTodasVendasRealizadas frm = new frmTodasVendasRealizadas();
                frm.ShowDialog();
            }

            else if (e.KeyCode == Keys.F3)
            {
                frmBaseTodosLancamentos frm = new frmBaseTodosLancamentos();
                frm.ShowDialog();
            }

            else if (e.KeyCode == Keys.F2)
            {
                frmBaseTodasDespesas frm = new frmBaseTodasDespesas();
                frm.ShowDialog();
            }

            else if (e.KeyCode == Keys.F10)
            {
                frmBaseTodosProdutos frm = new frmBaseTodosProdutos();
                frm.ShowDialog();
            }

            else if (e.KeyCode == Keys.F9)
            {
                frmBaseTodosClientes frm = new frmBaseTodosClientes();
                frm.ShowDialog();
            }

            else if (e.KeyCode == Keys.F8)
            {
                frmCadastroFornecedores frm = new frmCadastroFornecedores();
                frm.ShowDialog();
            }
        }

        public void ExibirFotoRegistro()
        {
            try
            {
                empresa = new Empresa();
                empresaBo = new EmpresaBO();

                empresa = empresaBo.SelecionaUltimoRegistroEmpresa();

                lblRegistrado.Text = "Registrado para: " + empresa._NomeFantasia;

                if (!string.IsNullOrEmpty(empresa._LogoEmpresa))
                {
                    pictureBox1.Image = Image.FromFile(empresa._LogoEmpresa);
                }
            }
            catch (Exception)
            { }
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {

            frmPesquisaCategoriaProduto frmPCategoriaProduto = new frmPesquisaCategoriaProduto();
            frmPCategoriaProduto.ShowDialog();
        }

        private void configuraçõesGeraisDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracoesGeraisSistema frm = new frmConfiguracoesGeraisSistema();
            frm.ShowDialog();
        }

        public void CarregaConfiguracoesSistema()
        {
            Configuracoes configuracoes = new Configuracoes();
            ConfiguracoesBO configuracoesBo = new ConfiguracoesBO();

            configuracoes = configuracoesBo.SelecionaConfiguracaoAtualSistema();

            if (configuracoes._BackupAutomatico == "ativo")
            {
                trueFalseBAuto = true;
            }
            else
            {
                trueFalseBAuto = false;
            }

            if (configuracoes._BackupAposFechar == "ativo")
            {
                trueFalseBFechar = true;
            }
            else
            {
                trueFalseBFechar = false;
            }

            frmTelaInicial frm = new frmTelaInicial();
            frm.Text = string.Format("{0} - {1} - {2}", configuracoes._NomeSistema, configuracoes._VersaoSistemaAtual, configuracoes._DataVersaoAtual);
        }

        private void testandoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelatorioProduto frmRelatorioProduto = new FrmRelatorioProduto();
            frmRelatorioProduto.ShowDialog();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmTodasVendasRealizadas frm = new frmTodasVendasRealizadas();
            frm.ShowDialog();
        }

        private void toolStripButtonOrcamento_Click(object sender, EventArgs e)
        {
            frmBaseTodosOrcamentos frmBTodosO = new frmBaseTodosOrcamentos();
            frmBTodosO.ShowDialog();
        }

        private void toolStripButtonPDV_Click(object sender, EventArgs e)
        {
            frmRealizarVendas frmRV = new frmRealizarVendas();
            frmRV.PegaUsuarioLogado(lblUsuaarioLogado.Text);
            frmRV.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmMovimentacaoDiaria frmVR = new frmMovimentacaoDiaria();
            frmVR.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (frmBaseTodasContasReceber frm = new frmBaseTodasContasReceber())
            {
                frm.ShowDialog();
            }
        }

        private void toolStripClientes_Click(object sender, EventArgs e)
        {
            frmBaseTodosClientes frmTodosClientes = new frmBaseTodosClientes();
            frmTodosClientes.ShowDialog();
        }

        private void toolStripProdutos_Click(object sender, EventArgs e)
        {
            frmBaseTodosProdutos frmBaseProdutos = new frmBaseTodosProdutos();
            frmBaseProdutos.ShowDialog();
        }

        private void toolStripSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmTodasVendasRealizadas frm = new frmTodasVendasRealizadas();
            frm.ShowDialog();
        }

        protected void AlterarStatusContaVencida()
        {
            try
            {
                DataTable dt = new DataTable();

                dt = itemContaReceberBo.CriaDataTableSelecionarTodasItemContasReceber();

                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        //Alterar o status da conta se estiver vencida;
                        if (Convert.ToDateTime(row["dataVencimento"]) <= DateTime.Now)
                        {
                            itemContaReceber._Status = "Vencida";
                            itemContaReceber._ItemContaReceberID = Convert.ToInt32(row.ItemArray[6].ToString());
                            itemContaReceber.DiasAtraso = Convert.ToInt32(DiasAtraso(Convert.ToDateTime(row["dataVencimento"])));

                            decimal vlrPago = Convert.ToDecimal(row["valorPago"]);

                            if (vlrPago > 0)
                            {
                                itemContaReceber._Juros = Convert.ToDecimal(CalculaJuros(Convert.ToDecimal(row["valorAberto"]), Convert.ToDateTime(row["dataVencimento"])));
                            }
                            else
                            {
                                itemContaReceber._Juros = Convert.ToDecimal(CalculaJuros(Convert.ToDecimal(row["valorParcela"]), Convert.ToDateTime(row["dataVencimento"])));
                            }

                            itemContaReceber.ValorMulta = Convert.ToDecimal(CalcularMulta(Convert.ToDecimal(row["valorParcela"]), Convert.ToDateTime(row["dataVencimento"])));
                            itemContaReceber.ValorCobrado = Convert.ToDecimal(TotalPagar(Convert.ToDecimal(row["valorParcela"]), Convert.ToDateTime(row["dataVencimento"])));

                            if (row["negociacao"].ToString() != "Sim")
                            {
                                itemContaReceberBo.AlterarStatusItemContaReceber(itemContaReceber);
                            }

                        }
                        else if (row["status"].ToString() == "Prevista")
                        {
                            itemContaReceber._ItemContaReceberID = Convert.ToInt32(row["itemContaReceberID"]);
                            itemContaReceber.ValorCobrado = TotalPagar(Convert.ToDecimal(row["valorParcela"]), Convert.ToDateTime(row["dataVencimento"]));
                            itemContaReceberBo.AlterarTotalCobradotemContaReceber(itemContaReceber);
                        }

                        itemContaReceberBo.AlterarTotalAberto(itemContaReceber._ItemContaReceberID);
                    }
                }
            }
            catch (Exception msg)
            {
                MessageBox.Show(msg.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Retorna quantidade de dias em atraso
        public int DiasAtraso(DateTime dataVencimeto)
        {
            TimeSpan intervalo = DateTime.Now.Subtract(dataVencimeto);
            return intervalo.Days;
        }

        //Calcula juros pertinente a parcela que esta vencida
        public decimal CalculaJuros(decimal vlrParcela, DateTime dataVencimento)
        {
            decimal juros = 0;

            if (DiasAtraso(dataVencimento) > 0)
            {
                decimal porcentagemJuros = decimal.Parse("0,75");// cobra juros de 1% ao dia

                juros = (vlrParcela / 100);//Pega o valor da parcela dividi por 100
                juros = (juros * porcentagemJuros);//pega o resultado da divisão multiplica pela porcentagem que deseja aplicar
                //juros = (juros / 30);//Pega o resultado  dividi por 30 que equivale ao dias do mes
                juros = (juros * DiasAtraso(dataVencimento));//Pega o resultado da divisão por 30 é multiplica por dias de atraso

                juros = Convert.ToDecimal(string.Format("{0:n2}", juros));
            }

            return juros;
        }

        //Calcula total a pagar, somando-se (juros + multa + vlrParcela)
        public decimal TotalPagar(decimal total, DateTime dataVencimento)
        {
            decimal totalPagar = (total + CalculaJuros(total, dataVencimento) + CalcularMulta(total, dataVencimento));
            return totalPagar;
        }

        //Calcula o valor da multa inerente ao valor da parcela
        public decimal CalcularMulta(decimal vlrParcela, DateTime dataVancimento)
        {
            decimal multa = 0;

            if (DiasAtraso(dataVancimento) > 0)
            {
                multa = Convert.ToDecimal(string.Format("{0}", (vlrParcela / 100) * 2));//cobra multa de 2%
            }

            return multa;
        }

        private void receitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParametroContasReceberDetalhado frm = new frmParametroContasReceberDetalhado();
            frm.ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            frmConfiguracoesGeraisSistema frm = new frmConfiguracoesGeraisSistema();
            frm.ShowDialog();
            ExibirFotoRegistro();
        }

        private void vendasRealizadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelatoriosVendasRealizadas frm = new frmRelatoriosVendasRealizadas();
            frm.ShowDialog();
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            frmBaseTodosBancos frm = new frmBaseTodosBancos();
            frm.ShowDialog();
        }

        private void despesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseTodasTiposDespesas frm = new frmBaseTodasTiposDespesas();
            frm.ShowDialog();
        }

        private void classeDespesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseTodasClasseDespesas frm = new frmBaseTodasClasseDespesas();
            frm.ShowDialog();
        }

        private void contaCorrenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseTodasContaCorrente frm = new frmBaseTodasContaCorrente();
            frm.ShowDialog();
        }

        private void lançamentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBaseTodosLancamentos frm = new frmBaseTodosLancamentos();
            frm.ShowDialog();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            frmBaseTodosLancamentos frm = new frmBaseTodosLancamentos();
            frm.ShowDialog();
        }

        private void toolStripButton4_Click_1(object sender, EventArgs e)
        {
            frmBaseTodasDespesas frm = new frmBaseTodasDespesas();
            frm.ShowDialog();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            frmBaseTodosFornecedores frm = new frmBaseTodosFornecedores();
            frm.ShowDialog();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            frmLoginSistema frm = new frmLoginSistema();
            frm.ShowDialog();
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            frmBaseTodosCaixas frm = new frmBaseTodosCaixas();
            frm.ShowDialog();
        }

        private void menuAbrirFechar_Click(object sender, EventArgs e)
        {
            frmAberturaFechamentoCaixa frm = new frmAberturaFechamentoCaixa();
            frm.ShowDialog();
        }

        private void menuCaixas_Click(object sender, EventArgs e)
        {
            frmBaseTodosCaixas frm = new frmBaseTodosCaixas();
            frm.ShowDialog();
        }

        private void receitasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmParametroContasReceberDetalhado frm = new frmParametroContasReceberDetalhado();
            frm.ShowDialog();
        }

        private void tlstrip_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void tlstrip_DoubleClick(object sender, EventArgs e)
        {
            tlstrip.Visible = false;
        }


        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            tlstrip.Visible = true;
        }

        private void entradasDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmBaseTodasEntradasProdutos frm = new frmBaseTodasEntradasProdutos())
            {
                frm.ShowDialog();
            }
        }

        private void despesasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (frmBaseRelatorioGDespesas frm = new frmBaseRelatorioGDespesas())
            {
                frm.ShowDialog();
            }
        }

        private void estoqueMinimoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmRelatorioProduto frm = new FrmRelatorioProduto())
            {
                frm.CarregaRelatorioEstoqueMinimo("minimo");
                frm.ShowDialog();
            }
        }

        private void máximoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmRelatorioProduto frm = new FrmRelatorioProduto())
            {
                frm.CarregaRelatorioEstoqueMinimo("maximo");
                frm.ShowDialog();
            }
        }

        private void geralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmRelatorioProduto frm = new FrmRelatorioProduto())
            {
                frm.CarregaRelatorioEstoqueMinimo("geral");
                frm.ShowDialog();
            }
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        public void CarregaTodosLancamentos()
        {
            DataTable dt = new DataTable();
            LancamentosBO lancamentoBO = new LancamentosBO();
            dt = lancamentoBO.CriaDataTableSelecionaTodosLancamentos();
            DateTime dataAtual = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));

            if (dt.Rows.Count > 0)
            {
                listViewContasAPagar.Items.Clear();
                contadorLinha = 0;
                totalPagar = 0;

                foreach (DataRow row in dt.Rows)
                {
                    if (Convert.ToDateTime(row["DataVencimento"]) <= dataAtual)
                    {
                        panel1.Visible = true;

                        listViewContasAPagar.Items.Add(row["LancamentoID"].ToString());
                        listViewContasAPagar.Items[contadorLinha].SubItems.Add(row["Nome_Fantasia"].ToString());
                        listViewContasAPagar.Items[contadorLinha].SubItems.Add(row["Descricao"].ToString());
                        listViewContasAPagar.Items[contadorLinha].SubItems.Add(Convert.ToDateTime(row["DataVencimento"]).ToString("dd/MM/yyyy"));
                        listViewContasAPagar.Items[contadorLinha].SubItems.Add(Convert.ToDecimal(row["ValorPrincipal"]).ToString("C"));
                        contadorLinha++;

                        totalPagar += Convert.ToDecimal(row["ValorPrincipal"]);
                    }
                }

                lblTotalPagar.Text = string.Format("Total a pagar: {0}", totalPagar.ToString("C"));
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void listViewContasAPagar_DoubleClick_1(object sender, EventArgs e)
        {
            if (listViewContasAPagar.Items.Count > 0)
            {
                frmLancamento frm = new frmLancamento();
                frm.CarregaDadosBaixarLancamento(int.Parse(listViewContasAPagar.FocusedItem.SubItems[0].Text));
                frm.ShowDialog();
                CarregaTodosLancamentos();

                if (listViewContasAPagar.Items.Count == 0)
                {
                    panel1.Visible = false;
                }
            }
        }

        private void giroEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desculpe o transtorno, relatório e fase de desenvolvimento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void maisVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desculpe o transtorno, relatório e fase de desenvolvimento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void menosVendidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desculpe o transtorno, relatório e fase de desenvolvimento", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void produtosProximoVencimentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParametroRelProdutoDataVcto frm = new frmParametroRelProdutoDataVcto();
            frm.ShowDialog();
        }
        
        private void negociaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaseTodasNegociacoes frm = new frmBaseTodasNegociacoes();
            frm.ShowDialog();
        }
    }
}
