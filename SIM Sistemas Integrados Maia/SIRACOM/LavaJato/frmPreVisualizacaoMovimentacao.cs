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
    public partial class frmPreVisualizacaoMovimentacao : Form
    {
        public frmPreVisualizacaoMovimentacao()
        {
            InitializeComponent();
        }

        [DllImport("shell32.dll", EntryPoint = "ShellExecute")]
        public static extern int ShellExecuteA(int hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd);

        static string exeLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Remove(0, 6);

        StringBuilder sb;

        decimal totalVenda, totalRecebido, totalDespesas, totalPgtoLacamentos, saldoCaixa;
        DateTime dataParametro;

        public void GerarArquivoTxtMovimentacao(DateTime dataInicio, DateTime dataFim)
        {
            //Carrega dados da empresa
            Empresa empresa = new Empresa();
            EmpresaBO empresaBO = new EmpresaBO();

            DateTime data = DateTime.Now;

            empresa = empresaBO.SelecionaUltimoRegistroEmpresa();

            CalculaSaldoEmDinheiro(dataInicio, dataFim);
            //cria o arquivo txt para um determinado diretorio
            FileInfo arquivo = new FileInfo(exeLocation + "\\Cupom\\Movimentacao.txt");

            using (FileStream fs = arquivo.Create()) { }

            //Atribui valores aos campos,tais campos recebe os valores nescessários para criação da NFe
            string[] texto = {
                                "                          MOVIMENTAÇÃO POR PERÍODO",
                                "                          DATA INICIAL: " + dataInicio.ToString("dd/MM/yyyy"),
                                "                          DATA FINAL: " + dataFim.ToString("dd/MM/yyyy"),
                                "",
                                  "" + empresa._NomeFantasia,
                                  "" +"CNPJ:" + empresa._CnpjCpf,
                                  "" +"Rua:" + empresa._Rua + ","+ empresa._Numero.ToString(),
                                  "" +"Bairro:" + empresa._Bairro + "  -  " + "CEP:" + empresa._Cep + "  " +empresa._Cidade + "-" + empresa._UF,
                                  "" +"Fone:" +empresa._Fone,
                                 "---------------------------------------------------------------------------------",
                                 "                         VENDAS REALIZADAS",
                                  "Nº VENDA                         VALOR VENDA",
                                  CarregaVendasRealizadas(dataInicio,dataFim),
                                  "TOTAL VENDA(S)........................" +            totalVenda.ToString("C"),
                                "---------------------------------------------------------------------------------",   
                                "---------------------------------------------------------------------------------",
                                 "                         CONTAS RECEBIDAS",
                                 "Nº REC                         VALOR RECEBIDO",
                                  CarregaContasRecebidas(dataInicio,dataFim),
                                  "TOTAL RECEBIDO(S)........................" +      totalRecebido.ToString("C"),
                                "---------------------------------------------------------------------------------",   
                                "---------------------------------------------------------------------------------",
                                 "                         SAÍDA DE CAIXA",
                                 "Nº DESPESA                         VALOR DESPESA",
                                  CarregaTodasDespesas(dataInicio,dataFim),
                                  "TOTAL DESPESA(S)........................" +      totalDespesas.ToString("C"),
                                "---------------------------------------------------------------------------------",   
                                "---------------------------------------------------------------------------------",
                                 "                         CONTAS PAGAS",
                                 "Nº PGTO                         VALOR PAGO",
                                 CarregaBaixaLancamentos(dataInicio,dataFim),
                                 "TOTAL PAGO(S)........................" +      totalPgtoLacamentos.ToString("C"),
                                "---------------------------------------------------------------------------------",   
                                "---------------------------------------------------------------------------------",
                                  "                         RESUMO GERAL",
                                "TOTAL: VENDAS REALIZADA(S)........................" + totalVenda.ToString("C"),
                                "TOTAL: CONTAS RECEBIDA(S)........................" + totalRecebido.ToString("C"),
                                "TOTAL: SAÍDA DE CAIXA........................." +    totalDespesas.ToString("C"),
                                "TOTAL: CONTAS PAGA(S)........................" + totalPgtoLacamentos.ToString("C"),
                                "",
                                "VALOR TOTAL EM CAIXA........................" + (saldoCaixa - (totalDespesas + totalPgtoLacamentos)).ToString("C"),
                                "---------------------------------------------------------------------------------",   
                                "---------------------------------------------------------------------------------",
                                "Porto Velho - Ro - Data Hora Fechamento: " + data.ToString(),
                                "---------------------------------------------------------------------------------",
                             };

            //Escreve as informações no arquivo txt, salvo no diretorio expecificado
            File.WriteAllLines(exeLocation + "\\Cupom\\Movimentacao.txt", texto);
        }

        public string CarregaVendasRealizadas(DateTime dataInicio, DateTime dataFim)
        {

            DataSet ds = new DataSet();
            RealizarVendasBO realizaVendasBO = new RealizarVendasBO();
            sb = new StringBuilder();

            ds = realizaVendasBO.Vendas(dataInicio, dataFim);

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
            return sb.ToString();
        }

        private string CarregaTodasDespesas(DateTime dataInicio, DateTime dataFim)
        {
            DataSet ds = new DataSet();
            DespesasBO despesasBO = new DespesasBO();
            sb = new StringBuilder();

            ds = despesasBO.TodasDespesas(dataInicio, dataFim);

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

        public string CarregaContasRecebidas(DateTime dataInicio, DateTime dataFim)
        {
            DataSet ds = new DataSet();
            ItemContaReceberFormaRecebimentoBO itemContaReceberFormaRecebimentoBO = new ItemContaReceberFormaRecebimentoBO();
            sb = new StringBuilder();

            ds = itemContaReceberFormaRecebimentoBO.RetornaDataSetContaReceberFormaRecebimento(dataInicio, dataFim);

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

        public string CarregaBaixaLancamentos(DateTime dataInicio, DateTime dataFim)
        {
            DataSet ds = new DataSet();
            LancamentosBaixasBO lancamentosBaixasBo = new LancamentosBaixasBO();
            sb = new StringBuilder();

            ds = lancamentosBaixasBo.LancamentosBaixaTodos(dataInicio, dataFim);

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

            return sb.ToString();
        }

        public void CalculaSaldoEmDinheiro(DateTime dataInicio, DateTime dataFim)
        {
            //Pega vendas em dinheiro
            DataSet ds = new DataSet();
            RealizarVendasBO realizaVendasBO = new RealizarVendasBO();
            int vendaID;

            ds = realizaVendasBO.Vendas(dataInicio, dataFim);

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

        public void CarregaArquivoMovimentacao()
        {
            int counter = 0;
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader(exeLocation + @"\Cupom\Movimentacao.txt");

            while ((line = file.ReadLine()) != null)
            {
                lsDadosMovimentacao.Items.Add(line);
                counter++;
            }

            file.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma impressão desta movimentação?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string path = exeLocation + "\\Cupom\\Movimentacao.txt";
                frmBaseTodosCaixas.ShellExecuteA(this.Handle.ToInt32(), "print", path, null, null, 0);
            }
        }
    }
}
