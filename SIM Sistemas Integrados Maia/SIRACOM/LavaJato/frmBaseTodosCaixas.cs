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
using System.Runtime.InteropServices;
using System.IO;
using Negocios.RVBo;
using Negocios.RVTipo;
using Negocios.TIPO;
using System.Collections;

namespace LavaJato
{
    public partial class frmBaseTodosCaixas : Form
    {
        public frmBaseTodosCaixas()
        {
            InitializeComponent();
        }

        [DllImport("shell32.dll", EntryPoint = "ShellExecute")]
        public static extern int ShellExecuteA(int hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd);

        static string exeLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Remove(0, 6);

        StringBuilder sb;

        decimal totalVenda, totalRecebido, totalDespesas, totalPgtoLacamentos, saldoCaixa;
        DateTime dataParametro;

        public void CarregaListagemCaixas()
        {
            CaixaBO caixaBO = new CaixaBO();
            DataSet ds = new DataSet();
            ds = caixaBO.SelecionaCaixaPeriodo(Convert.ToDateTime(txtDateInicial.Text), Convert.ToDateTime(txtDataFinal.Text));
            int countRow = 0;

            listViewCaixaDiarios.Items.Clear();

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                //Adiciona os itens do list view

                listViewCaixaDiarios.Items.Add(row["CaixaID"].ToString());//0
                listViewCaixaDiarios.Items[countRow].SubItems.Add(row["DataAbertura"] != DBNull.Value ? Convert.ToDateTime(row["DataAbertura"]).ToString("dd/MM/yyyy") : "");//1
                listViewCaixaDiarios.Items[countRow].SubItems.Add(row["DataFechamento"] != DBNull.Value ? Convert.ToDateTime(row["DataFechamento"]).ToString("dd/MM/yyyy") : "");//2
                listViewCaixaDiarios.Items[countRow].SubItems.Add(row["DataReabertura"] != DBNull.Value ? Convert.ToDateTime(row["DataReabertura"]).ToString("dd/MM/yyyy") : "");//3
                listViewCaixaDiarios.Items[countRow].SubItems.Add((row["Situacao"]).ToString());//4


                listViewCaixaDiarios.Items[countRow].SubItems.Add(row["SaldoCaixa"] != DBNull.Value ? Convert.ToDecimal(row["SaldoCaixa"]).ToString() : Convert.ToDecimal("0.00").ToString("C"));

                if (row["Situacao"].Equals("Aberto"))
                {
                    listViewCaixaDiarios.Items[countRow].ForeColor = System.Drawing.Color.Green; 
                }

                countRow++;
            }
        }

        private void frmBaseTodosCaixas_Load(object sender, EventArgs e)
        {
            txtDateInicial.Value = Convert.ToDateTime("01/01/2013");
            txtDataFinal.Value = Convert.ToDateTime("01/01/2020");

            CarregaListagemCaixas();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CarregaListagemCaixas();
        }

        private void listViewCaixaDiarios_DoubleClick(object sender, EventArgs e)
        {
            if ((listViewCaixaDiarios.Items.Count > 0) && (listViewCaixaDiarios.FocusedItem.SubItems[4].Text != "Fechado"))
            {
                int caixaId = Convert.ToInt32(listViewCaixaDiarios.FocusedItem.SubItems[0].Text);

                frmAberturaFechamentoCaixa frm = new frmAberturaFechamentoCaixa();
                frm.CarregaCaixaFechamento(caixaId);
                frm.ShowDialog();
                CarregaListagemCaixas();

                GerarArquivoTxtMovimentacao();
                ImprimirMovimentacao();
            }
            else
            {
                MessageBox.Show("Caixa fechado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (listViewCaixaDiarios.Items.Count > 0)
            {
                Caixa caixa = new Caixa();
                CaixaBO caixaBO = new CaixaBO();

                caixa.CaixaID = int.Parse(listViewCaixaDiarios.FocusedItem.SubItems[0].Text);

                if (e.ClickedItem.Name.Equals("menuReabrir"))
                {
                    if (MessageBox.Show("Confirma reabertura do caixa ? ", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        caixa.Situacao = "Aberto";
                        caixa.DataReabertura = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));

                        caixaBO.ReabrirCaixa(caixa);

                        MessageBox.Show("Caixa reaberto com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else if ((e.ClickedItem.Name.Equals("menuFechar") && (listViewCaixaDiarios.FocusedItem.SubItems[4].Text != "Fechado")))
                {
                    if (MessageBox.Show("Confirma fechamento do caixa ? ", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        caixa.DataFechamento = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                        caixa.SaldoCaixa = saldoCaixa;
                        caixa.Situacao = "Fechado";

                        caixaBO.FecharCaixa(caixa);

                        MessageBox.Show("Caixa fechado em " + DateTime.Now + "", "Fechamento caixa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        GerarArquivoTxtMovimentacao();
                        ImprimirMovimentacao();
                    }
                }
                else
                {
                    MessageBox.Show("Caixa fechado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                CarregaListagemCaixas();
            }
        }

        public void GerarArquivoTxtMovimentacao()
        {
            //Carrega dados da empresa
            Empresa empresa = new Empresa();
            EmpresaBO empresaBO = new EmpresaBO();

            DateTime data = DateTime.Now;

            empresa = empresaBO.SelecionaUltimoRegistroEmpresa();

            CalculaSaldoEmDinheiro();
            //cria o arquivo txt para um determinado diretorio
            FileInfo arquivo = new FileInfo(exeLocation + "\\Cupom\\Movimentacao.txt");

            using (FileStream fs = arquivo.Create()) { }

            //Atribui valores aos campos,tais campos recebe os valores nescessários para criação da NFe
            string[] texto = {
                                "                          MOVIMENTAÇÃO DO DIA " + DateTime.Now.ToString("dd/MM/yyyy"),
                                "                          FECHAMENTO DE CAIXA                    ",
                                "",
                                  "" + empresa._NomeFantasia,
                                  "" +"CNPJ:" + empresa._CnpjCpf,
                                  "" +"Rua:" + empresa._Rua + ","+ empresa._Numero.ToString(),
                                  "" +"Bairro:" + empresa._Bairro + "  -  " + "CEP:" + empresa._Cep + "  " +empresa._Cidade + "-" + empresa._UF,
                                  "" +"Fone:" +empresa._Fone,
                                 "---------------------------------------------------------------------------------",
                                 "                         VENDAS REALIZADAS",
                                  "Nº VENDA                         VALOR VENDA",
                                  CarregaVendasRealizadas(),
                                  "TOTAL VENDA(S)........................" +            totalVenda.ToString("C"),
                                "---------------------------------------------------------------------------------",   
                                "---------------------------------------------------------------------------------",
                                 "                         CONTAS RECEBIDAS",
                                 "Nº REC                         VALOR RECEBIDO",
                                  CarregaContasRecebidas(),
                                  "TOTAL RECEBIDO(S)........................" +      totalRecebido.ToString("C"),
                                "---------------------------------------------------------------------------------",   
                                "---------------------------------------------------------------------------------",
                                 "                         SAÍDA DE CAIXA",
                                 "Nº DESPESA                         VALOR DESPESA",
                                  CarregaTodasDespesas(),
                                  "TOTAL DESPESA(S)........................" +      totalDespesas.ToString("C"),
                                "---------------------------------------------------------------------------------",   
                                "---------------------------------------------------------------------------------",
                                 "                         CONTAS PAGAS",
                                 "Nº PGTO                         VALOR PAGO",
                                 CarregaBaixaLancamentos(),
                                 "TOTAL PAGO(S)........................" +      totalPgtoLacamentos.ToString("C"),
                                "---------------------------------------------------------------------------------",   
                                "---------------------------------------------------------------------------------",
                                  "                         RESUMO GERAL",
                                "TOTAL: VENDAS REALIZADA(S)........................" + totalVenda.ToString("C"),
                                "TOTAL: CONTAS RECEBIDA(S)........................" + totalRecebido.ToString("C"),
                                "TOTAL: SAÍDA DE CAIXA........................." +    totalDespesas.ToString("C"),
                                "TOTAL: CONTAS PAGA(S)........................" + totalPgtoLacamentos.ToString("C"),
                                "",
                                "VALOR TOTAL EM CAIXA........................" + saldoCaixa.ToString("C"),
                                "---------------------------------------------------------------------------------",   
                                "---------------------------------------------------------------------------------",
                                "Porto Velho - Ro - Data Hora Fechamento: " + data.ToString(),
                                "autenticação automática:" + Autenticacao(),
                                "---------------------------------------------------------------------------------",
                             };

            //Escreve as informações no arquivo txt, salvo no diretorio expecificado
            File.WriteAllLines(exeLocation + "\\Cupom\\Movimentacao.txt", texto);

        }

        public string CarregaVendasRealizadas()
        {
            if (listViewCaixaDiarios.Items.Count > 0)
            {
                DataSet ds = new DataSet();
                RealizarVendasBO realizaVendasBO = new RealizarVendasBO();
                sb = new StringBuilder();

                DateTime dataAbertura = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"));

                ds = realizaVendasBO.Vendas(dataAbertura, dataAbertura);

                if (ds != null)
                {
                    string numeroVenda, valorVenda;
                    totalVenda = 0;

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        numeroVenda = row["NumeroVenda"].ToString();
                        valorVenda = Convert.ToDecimal(row["TotalPagar"]).ToString("C");
                        totalVenda += Convert.ToDecimal(row["TotalPagar"]);
                        sb.AppendLine(" " + numeroVenda + "                                  " + valorVenda + " ");
                    }
                }
            }
            return sb.ToString();
        }

        private string CarregaTodasDespesas()
        {
            DataSet ds = new DataSet();
            DespesasBO despesasBO = new DespesasBO();
            sb = new StringBuilder();

            DateTime dataAbertura = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"));

            ds = despesasBO.TodasDespesas(dataAbertura, dataAbertura);

            if (ds != null)
            {
                string numeroDespesa, valorDespesa;
                totalDespesas = 0;

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    numeroDespesa = row["DespesasID"].ToString();
                    valorDespesa = Convert.ToDecimal(row["Valor"]).ToString("C");
                    totalDespesas += Convert.ToDecimal(row["Valor"]);
                    sb.AppendLine(" " + numeroDespesa + "                                  " + valorDespesa + " ");
                }
            }

            return sb.ToString();
        }

        public string CarregaContasRecebidas()
        {
            DataSet ds = new DataSet();
            ItemContaReceberFormaRecebimentoBO itemContaReceberFormaRecebimentoBO = new ItemContaReceberFormaRecebimentoBO();
            sb = new StringBuilder();

            DateTime dataAbertura = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"));

            ds = itemContaReceberFormaRecebimentoBO.RetornaDataSetContaReceberFormaRecebimento(dataAbertura, dataAbertura);

            if (ds != null)
            {
                string nRecebimento, vlorRecebido;
                totalRecebido = 0;

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    nRecebimento = row["itemContarReceberID"].ToString();
                    vlorRecebido = Convert.ToDecimal(row["vlrPago"]).ToString("C");
                    totalRecebido += Convert.ToDecimal(row["vlrPago"]);
                    sb.AppendLine(" " + nRecebimento + "                                " + vlorRecebido + " ");
                }
            }
            return sb.ToString();
        }

        public string CarregaBaixaLancamentos()
        {
            if (listViewCaixaDiarios.Items.Count > 0)
            {
                DataSet ds = new DataSet();
                LancamentosBaixasBO lancamentosBaixasBo = new LancamentosBaixasBO();
                sb = new StringBuilder();

                DateTime dataAbertura = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"));

                ds = lancamentosBaixasBo.LancamentosBaixaTodos(dataAbertura, dataAbertura);

                if (ds != null)
                {
                    string numeroLctoBaixa, valorBaixa;
                    totalPgtoLacamentos = 0;

                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        numeroLctoBaixa = row["LancamentoBaixaID"].ToString();
                        valorBaixa = Convert.ToDecimal(row["VlorBaixa"]).ToString("C");
                        totalPgtoLacamentos += Convert.ToDecimal(row["VlorBaixa"]);
                        sb.AppendLine(" " + numeroLctoBaixa + "                                  " + valorBaixa + " ");
                    }
                }
            }
            return sb.ToString();
        }

        public void CalculaSaldoEmDinheiro()
        {
            //Pega vendas em dinheiro
            DataSet ds = new DataSet();
            RealizarVendasBO realizaVendasBO = new RealizarVendasBO();
            int vendaID;
            DateTime dataAbertura = DateTime.Parse(DateTime.Now.ToString("dd/MM/yyyy"));

            ds = realizaVendasBO.Vendas(dataAbertura, dataAbertura);

            if (ds != null)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    vendaID = Convert.ToInt32(row["NumeroVenda"].ToString());

                    ItemTipoRecebimentoVendaBO tipoRecebimentoVendaBO = new ItemTipoRecebimentoVendaBO();
                    DataTable dt = new DataTable();
                    dt = tipoRecebimentoVendaBO.CriaDataTableSelecionaItemVendaFormaRecebimenoto(vendaID);

                    if (dt != null)
                    {
                        foreach (DataRow rowDt in dt.Rows)
                        {
                            if (rowDt["formaRecebimento"].ToString().StartsWith("01 - Dinheiro"))
                            {
                                saldoCaixa += Convert.ToDecimal(rowDt["vlrPago"].ToString());
                            }
                        }
                    }
                }
            }
            //Pega recebimento em dinheiro
        }


        public void ImprimirMovimentacao()
        {
            if (MessageBox.Show("Desejar imprimir movimentação do dia ?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string path = exeLocation + "\\Cupom\\Movimentacao.txt";
                frmBaseTodosCaixas.ShellExecuteA(this.Handle.ToInt32(), "print", path, null, null, 0);
            }
        }

        public string Autenticacao()
        {
            return Guid.NewGuid().ToString();
        }

        public void LendoArquivoMovimentacao()
        {
            string path = exeLocation + "\\Cupom\\Movimentacao.txt";

            StreamReader objReader = new StreamReader(path);
            string sLine = "";
            ArrayList arrText = new ArrayList();
            StringBuilder texto = new StringBuilder();

            while (sLine != null)
            {
                sLine = objReader.ReadLine();
                if (sLine != null)
                    arrText.Add(sLine);
            }
            objReader.Close();

            foreach (string sOutput in arrText)
            {
                texto.AppendLine(sOutput);
            }

            MessageBox.Show(texto.ToString());
        }
    }
}
