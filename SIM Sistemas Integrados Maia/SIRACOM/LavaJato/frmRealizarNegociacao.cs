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
using Negocios.RVTipo;
using Negocios.RVBo;
using Negocios.RVDao;
using System.Runtime.InteropServices;
using System.IO;

namespace LavaJato
{
    public partial class frmRealizarNegociacao : Form
    {
        public frmRealizarNegociacao()
        {
            InitializeComponent();
        }

        bool vlrNegociadoFocus;
        int rowCount = 0;
        int rowCountParcelamento = 0;
        decimal total = 0;
        int codCliente;
        int qtdeImpressao = 0;

        [DllImport("shell32.dll", EntryPoint = "ShellExecute")]
        public static extern int ShellExecuteA(int hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd);

        static string exeLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Remove(0, 6);


        //Carrega uma lista com os itens no qual sera exibido os valores que serão relacionados a negociaçao
        public void CarregaInfomacoesNegociacao(IList<ItemContaReceber> itensContaReceber)
        {
            foreach (var item in itensContaReceber.ToList())
            {
                CarregaListViewNegociacao(item);
                SelecionarClienteId(item);
            }

            txtTotalCobrado.Text = total.ToString("C");
        }

        //Retorna o cliente no qual sera feito a negociação
        private void SelecionarClienteId(ItemContaReceber item)
        {
            ItemContaReceber itemContaReceber = new ItemContaReceber();
            ItemContaReceberBO itemContaReceberBO = new ItemContaReceberBO();

            itemContaReceber = itemContaReceberBO.SelecionarItemContaReceberID(item._ItemContaReceberID);

            if (itemContaReceber != null)
            {
                ContasReceber contaReceber = new ContasReceber();
                ContasReceberBO contaReceberBO = new ContasReceberBO();

                contaReceber = contaReceberBO.RetornaContaReceberID(itemContaReceber._ContaReceber._ContaReceberID);

                if (contaReceber != null)
                {
                    RealizarVendasTipos realizaVenda = new RealizarVendasTipos();
                    RealizarVendasBO realizaVendaBO = new RealizarVendasBO();

                    realizaVenda = realizaVendaBO.RetornaNumeroVenda(contaReceber._NumeroVenda);

                    if (realizaVenda != null)
                    {
                        CadastroClientes cliente = new CadastroClientes();
                        CadastroClientesDAO clienteDAO = new CadastroClientesDAO();

                        cliente = clienteDAO.SelecionaClientePorID(realizaVenda._CodigoCliente);

                        codCliente = cliente._CodigoCliente;
                        txtCPFCNPJ.Text = cliente._CPF;
                        txtNomeFantasia.Text = cliente._Nome;
                    }
                }
            }
        }

        //Popula o listview com as informaçoes  ItemContaReceber
        private void CarregaListViewNegociacao(ItemContaReceber item)
        {
            listItensNegociacao.Items.Add(item._ItemContaReceberID.ToString());
            listItensNegociacao.Items[rowCount].SubItems.Add(item._NumeroParcela);
            listItensNegociacao.Items[rowCount].SubItems.Add(item._DataVencimento.ToString("dd/MM/yyyy"));
            listItensNegociacao.Items[rowCount].SubItems.Add(item.ValorCobrado.ToString("C"));

            total += item.ValorCobrado;

            rowCount++;
        }


        private void frmRealizarNegociacao_Load(object sender, EventArgs e)
        {
            HabilitaTitulos();
            txtParcelas.SelectedIndex = 0;
            toolStripButtonSalvar.Enabled = false;
        }

        private void HabilitaTitulos()
        {
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGerarParcelas_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTotalNegociado.Text))
            {
                MessageBox.Show("Informe o valor da negociação!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTotalNegociado.Focus();
            }
            else
            {
                rowCountParcelamento = 0;
                lwParcelamento.Items.Clear();

                for (int i = 1; i <= Convert.ToInt32(txtParcelas.Text); i++)
                {
                    lwParcelamento.Items.Add(i + "/" + txtParcelas.Text);

                    lwParcelamento.Items[rowCountParcelamento].SubItems.Add(Convert.ToDateTime(DataVencimento(i)).ToString("dd/MM/yyyy dddddddddddddd"));
                    lwParcelamento.Items[rowCountParcelamento].SubItems.Add(GerarParcelamento(Convert.ToInt32(txtParcelas.Text), Convert.ToDecimal(txtTotalNegociado.Text.Substring(3))).ToString("N2"));
                    rowCountParcelamento++;
                }

                toolStripButtonSalvar.Enabled = true;
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

        private decimal GerarParcelamento(int qtdeParcela, decimal vlr)
        {
            if ((qtdeParcela > 0) && (vlr > 0))
                return (vlr / qtdeParcela);
            return vlr;
        }

        private void toolStripButtonSalvar_Click(object sender, EventArgs e)
        {
            GravarNegociacao();
        }

        private void GravarNegociacao()
        {
            if (MessageBox.Show("Confirma salvar esta negociação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = 0; i < lwParcelamento.Items.Count; i++)
                {
                    Negociacao negociacao = new Negociacao()
                    {
                        ClienteId = codCliente,
                        DataCadastro = DateTime.Now,
                        NumDocRelacionado = PegaRelacionamentoDoc(),
                        Situacao = "Aberto",
                        NumParcela = lwParcelamento.Items[i].SubItems[0].Text,
                        DataVencimento = Convert.ToDateTime(lwParcelamento.Items[i].SubItems[1].Text),
                        VlrParcela = Convert.ToDecimal(lwParcelamento.Items[i].SubItems[2].Text)
                    };

                    NegociacaoBO negociacaoBO = new NegociacaoBO();

                    negociacaoBO.InserirNegociacao(negociacao);
                }

                AlterarStatusItemContaReceberNeg();

                MessageBox.Show("Negociação realizada com sucesso", "Gravação bem sucedida", MessageBoxButtons.OK, MessageBoxIcon.Information);

                GerarArquivoTxtReciboPrestacao();
                ImprimirRecibodePrestacao();

                this.Close();
            }
        }

        private string PegaRelacionamentoDoc()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < listItensNegociacao.Items.Count; i++)
            {
                sb.Append(listItensNegociacao.Items[i].SubItems[0].Text);
                sb.Append("/");
            }

            return sb.ToString().Substring(0, sb.Length - 1);
        }

        private void AlterarStatusItemContaReceberNeg()
        {
            for (int i = 0; i < listItensNegociacao.Items.Count; i++)
            {
                ItemContaReceberBO itemContaReceberBO = new ItemContaReceberBO();

                itemContaReceberBO.AlterarStatusNegociacao(Convert.ToInt32(listItensNegociacao.Items[i].SubItems[0].Text), "Sim");
            }
        }

        public void ImprimirRecibodePrestacao()
        {
            int copia = 1;

            while (copia <= 2)
            {
                string path = exeLocation + "\\Cupom\\ReciboPrestacaoNegociacao.txt";
                frmRealizarNegociacao.ShellExecuteA(this.Handle.ToInt32(), "print", path, null, null, 0);

                copia++;
            }
        }

        public void GerarArquivoTxtReciboPrestacao()
        {
            //Carrega dados da empresa
            Empresa empresa = new Empresa();
            EmpresaBO empresaBO = new EmpresaBO();

            string vlorExtenso = Utilitarios.Extenso_Valor(Convert.ToDecimal(txtTotalCobrado.Text.Substring(3)));
            string vlrCorrigidoExtenso = Utilitarios.Extenso_Valor(Convert.ToDecimal(txtTotalNegociado.Text.Substring(3)));

            //Pega dados do cliente
            CadastroClientesDAO clienteDAO = new CadastroClientesDAO();
            CadastroClientes cliente = new CadastroClientes();

            cliente = clienteDAO.SelecionaClientePorID(codCliente);

            DateTime data = DateTime.Now;

            empresa = empresaBO.SelecionaUltimoRegistroEmpresa();
            qtdeImpressao = empresa.QtdeImpressaoRecibo;

            //cria o arquivo txt para um determinado diretorio
            FileInfo arquivo = new FileInfo(exeLocation + "\\Cupom\\ReciboPrestacaoNegociacao.txt");

            using (FileStream fs = arquivo.Create()) { }

            //Atribui valores aos campos,tais campos recebe os valores nescessários para criação da NFe
            string[] texto = {
                                 "                      TERMO DE RENEGOCIAÇÃO DE DÍVIDA                     ",
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
                                 "TERMO DE RENEGOCIAÇÃO DE DÍVIDA ",
                                 "",
                                 "Na presente data " + DateTime.Now.ToString("dd/MM/yyyy") +" é regido o acordo",
                                 "de novação de dívida entre a empresa (" + empresa._NomeFantasia +")",
                                 "sendo assim pessoa jurídica de direito privado, inscrita no CNPJ ("+ empresa._CnpjCpf +"),",
                                 "com sede (Rua:" + empresa._Rua + ","+ empresa._Numero.ToString() + " Bairro:" + empresa._Bairro +" CEP:" + empresa._Cep + "  " +empresa._Cidade + "-" + empresa._UF + ".",
                                 "",
                                 "Do outro lado o devedor ("+ cliente._Nome+"), portador do documento RG." + cliente._Rg + " CPF." + cliente._CPF +", residente e",
                                 "domiciliado na (Rua: " + cliente._End_Nome_Rua + "," + cliente._End_Numero.ToString() +" Bairro:" + cliente._Bairro + "  -  "+ "CEP:" + cliente._Cep + "   " + cliente._Cidade + "-" + cliente._Estado +").", 
                                 "O Devedor declara e se confessa devedor, nesta data, da importância",
                                 "de R$ (" + vlorExtenso.ToString().ToUpper() +"), referente a compra de produtos ref:(" + PegaRelacionamentoDoc() +").",
                                 "",
                                 "Afim da regularização do débito ambas as partes decidem que a dívida será",
                                 "parcelada em vezes ("+ txtParcelas.Text +").", 
                                 "",
                                 "O Credor, pretendendo reaver o seu crédito, compromete-se a parcelar o valor",
                                 "desta dívida, devidamente corrigido com a respectiva atualização, a contar",
                                 "do vencimento combinado entre ambos, o devedor, por sua vez, aceita a presente",
                                 "novação, obrigando-se a efetuar os pagamentos nas condições e formas descritas",
                                 "neste documento.",  
                                 "",
                                 "O Devedor pagará ao Credor, a importância certa, ajustada e total",
                                 "de  R$ ("+ vlrCorrigidoExtenso.ToString().ToUpper() +"), corrigidos até",
                                 "a presente data sendo que este valor será dividido em ("+ txtParcelas.Text +") parcela (s)",
                                 "mensais consecutivas,conforme segue :", 
                                 "",
                                "---------------------------------------------------------------------------------",
                                 "DETALHE PACELAMENTO:",
                                 "PARCELA       VENCIMENTO        VALOR",
                                 IncluirItens(),
                                 "VALOR TOTAL NEGOCIADO..:  " + txtTotalNegociado.Text,
                                 "---------------------------------------------------------------------------------",
                                 "O Devedor efetuará o pagamento mensal de cada parcela conforme combinado",
                                 "entre ambas as partes.", 
                                 "",
                                 "Tando ciente o devedor que no caso e inadimplemento de uma ou",
                                "mais parcelas, terá o devedor seu nome inscrito no Serviço de",
                                "Proteção ao Crédito. ", 
                                "",
                                "E por se acharem justo e pactuados, conforme os termos e condições aqui",
                                "estabelecidas, firmam o presente Termo de Renegociação de Dívida em duas",
                                "vias de igual teor.",  
                                 "---------------------------------------------------------------------------------",
                                empresa._NomeFantasia,
                                "Relacionado(s) a conta(s): " + PegaRelacionamentoDoc(),
                                "Porto Velho - Ro: " + data.ToString(),
                                "---------------------------------------------------------------------------------",
                                "Assinatura Devedor",
                                "",
                                "___________________________",
                                "---------------------------------------------------------------------------------",
                                "Assinatura Credor",
                                 "",
                                "___________________________",
                                "---------------------------------------------------------------------------------"};



            //Escreve as informações no arquivo txt, salvo no diretorio expecificado
            File.WriteAllLines(exeLocation + "\\Cupom\\ReciboPrestacaoNegociacao.txt", texto);
        }

        public string IncluirItens()
        {
            StringBuilder sb = new StringBuilder();

            if (lwParcelamento.Items.Count > 0)
            {
                string parcela, dtVcto, vlrParcela;

                for (int i = 0; i < lwParcelamento.Items.Count; i++)
                {
                    parcela = lwParcelamento.Items[i].SubItems[0].Text;
                    dtVcto = lwParcelamento.Items[i].SubItems[1].Text;
                    vlrParcela = lwParcelamento.Items[i].SubItems[2].Text;

                    sb.AppendLine("  " + parcela + "         " + dtVcto + "         " + vlrParcela + "  ");
                }
            }
            return sb.ToString();
        }

        private void txtTotalNegociado_Leave(object sender, EventArgs e)
        {
            try
            {
                txtTotalNegociado.Text = Convert.ToDecimal(txtTotalNegociado.Text).ToString("C");
                btnGerarParcelas.Focus();
            }
            catch (Exception msg)
            { }
        }

        private void frmRealizarNegociacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (vlrNegociadoFocus == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    try
                    {
                        txtTotalNegociado.Text = Convert.ToDecimal(txtTotalNegociado.Text).ToString("C");
                        vlrNegociadoFocus = false;
                        btnGerarParcelas.Focus();
                    }
                    catch (Exception msg)
                    { }
                }
            }
        }

        private void txtTotalNegociado_Enter(object sender, EventArgs e)
        {
            vlrNegociadoFocus = true;
        }

        private void lwParcelamento_DoubleClick(object sender, EventArgs e)
        {
           // DateTime dataVcto = Convert.ToDateTime(lwParcelamento.FocusedItem.SubItems[1].Text);

           // frmAlterarDataNegociacao frm = new frmAlterarDataNegociacao();

           // frm.GetDataVencimento(dataVcto);

           // frm.ShowDialog();

           // dataVcto = frm.DataVcto;

           // int index = lwParcelamento.FocusedItem.Index;

           // lwParcelamento.FocusedItem.SubItems.RemoveAt(index + 1);

           //lwParcelamento.Items[index].SubItems.Add(dataVcto.ToString());
        }

        private void txtTotalCobrado_DoubleClick(object sender, EventArgs e)
        {
            txtTotalNegociado.Text = txtTotalCobrado.Text;
        }
    }
}
