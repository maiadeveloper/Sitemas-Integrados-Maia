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
using Negocios;

namespace LavaJato
{
    public partial class frmBaseTodasNegociacoes : Form
    {
        public frmBaseTodasNegociacoes()
        {
            InitializeComponent();
        }

        int countRow = 0;
        decimal total = 0;
        decimal totalAberto = 0;
        decimal totalFechado = 0;

        [DllImport("shell32.dll", EntryPoint = "ShellExecute")]
        public static extern int ShellExecuteA(int hwnd, string lpOperation, string lpFile, string lpParameters, string lpDirectory, int nShowCmd);

        static string exeLocation = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Remove(0, 6);

        private void btnLimparBusca_Click(object sender, EventArgs e)
        {
            txtBusca.Clear();
            CarregaTodasNegociacoes();
        }

        private void frmBaseTodasNegociacoes_Load(object sender, EventArgs e)
        {
            CarregaTodasNegociacoes();
        }

        private void CarregaTodasNegociacoes()
        {
            DataTable dt = new DataTable();
            NegociacaoBO negociacaoBO = new NegociacaoBO();
            total = 0;
            totalFechado = 0;
            totalAberto = 0;
            lwNegociacoes.Items.Clear();
            countRow = 0;

            string situacao;

            if (rbAberto.Checked == true)
            {
                situacao = "Aberto";
            }
            else if (rbFechado.Checked == true)
            {
                situacao = "Fechado";
            }
            else
            {
                situacao = null;
            }

            dt = negociacaoBO.ListaNegociacoes(txtBusca.Text, situacao);

            if (dt != null)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["Situacao"].ToString() == "Aberto")
                    {
                        lwNegociacoes.Items.Add(row["Situacao"].ToString(), 0);
                        totalAberto += Convert.ToDecimal(row["VlrParcela"]);
                    }
                    else if (row["Situacao"].ToString() == "Fechado")
                    {
                        lwNegociacoes.Items.Add(row["Situacao"].ToString(), 1);
                        totalFechado += Convert.ToDecimal(row["VlrParcela"]);
                    }

                    AlterarFonteLinhaLctoVencida(row);

                    lwNegociacoes.Items[countRow].SubItems.Add(row["Id"].ToString());
                    lwNegociacoes.Items[countRow].SubItems.Add(row["CpfCnpj"].ToString());
                    lwNegociacoes.Items[countRow].SubItems.Add(row["NomeFantasia"].ToString());
                    lwNegociacoes.Items[countRow].SubItems.Add(row["NumParcela"].ToString());
                    lwNegociacoes.Items[countRow].SubItems.Add(Convert.ToDateTime(row["DataVencimento"]).ToString("dd/MM/yyyy dddddddddddddd"));
                    lwNegociacoes.Items[countRow].SubItems.Add(Convert.ToDecimal(row["VlrParcela"]).ToString("C"));
                    lwNegociacoes.Items[countRow].SubItems.Add(row["NumDocRelacionado"].ToString());

                    total += Convert.ToDecimal(row["VlrParcela"]);
                    countRow++;
                }

                txtTotalItem.Text = lwNegociacoes.Items.Count.ToString();
                txtTotal.Text = total.ToString("C");
                txtTotalAberto.Text = totalAberto.ToString("C");
                txtTotalFechado.Text = totalFechado.ToString("C");
            }
        }

        private void toolStripSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AlterarFonteLinhaLctoVencida(DataRow row)
        {
            if (row["Situacao"].ToString().Equals("Aberto"))
            {
                lwNegociacoes.Items[countRow].ForeColor = System.Drawing.Color.Black;
            }
            else if (row["Situacao"].ToString().Equals("Fechado"))
            {
                lwNegociacoes.Items[countRow].ForeColor = System.Drawing.Color.Green;
            }
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            CarregaTodasNegociacoes();
        }

        private void baixarContaReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lwNegociacoes.Items.Count > 0)
            {
                if (lwNegociacoes.FocusedItem.SubItems[0].Text.Equals("Fechado"))
                {
                    MessageBox.Show("Documento ja encontra-se baixado", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MessageBox.Show("Confirma a baixa deste documento? \n\n Codigo:       "
                        + lwNegociacoes.FocusedItem.SubItems[1].Text + "\n CPF :            "
                        + lwNegociacoes.FocusedItem.SubItems[2].Text + "\n Cliente:        "
                        + lwNegociacoes.FocusedItem.SubItems[3].Text + "\n Data Vcto:    "
                        + lwNegociacoes.FocusedItem.SubItems[5].Text + "\n Parcela:         "
                        + lwNegociacoes.FocusedItem.SubItems[4].Text + "\n Valor:             "
                        + lwNegociacoes.FocusedItem.SubItems[6].Text + "", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        NegociacaoBO negociacaoBO = new NegociacaoBO();
                        negociacaoBO.AlterarSituacao(int.Parse(lwNegociacoes.FocusedItem.SubItems[1].Text));

                        MessageBox.Show("Documento baixado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        GerarArquivoTxtComprovantePgtoNegociacao();
                        ImprimirComprovantePagamento();

                        CarregaTodasNegociacoes();
                    }
                }
            }
        }

        private int RetornaCodigoCliente()
        {
            Negociacao negociacao = new Negociacao();
            NegociacaoBO negociacaoBO = new NegociacaoBO();

            negociacao = negociacaoBO.SelecionaNegociacaoId(int.Parse(lwNegociacoes.FocusedItem.SubItems[1].Text));

            return negociacao.ClienteId;
        }

        public void GerarArquivoTxtComprovantePgtoNegociacao()
        {
            //Carrega dados da empresa
            Empresa empresa = new Empresa();
            EmpresaBO empresaBO = new EmpresaBO();

            //Pega dados do cliente
            CadastroClientesDAO clienteDAO = new CadastroClientesDAO();
            CadastroClientes cliente = new CadastroClientes();

            cliente = clienteDAO.SelecionaClientePorID(RetornaCodigoCliente());

            DateTime data = DateTime.Now;

            empresa = empresaBO.SelecionaUltimoRegistroEmpresa();

            //cria o arquivo txt para um determinado diretorio
            FileInfo arquivo = new FileInfo(exeLocation + "\\Cupom\\ComprovantePgtoNegociacao.txt");

            using (FileStream fs = arquivo.Create()) { }

            //Atribui valores aos campos,tais campos recebe os valores nescessários para criação da NFe
            string[] texto = {
                                "                     COMPROVANTE DE PAGAMENTO NEGOCIAÇÃO              ",
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
                                 "Nº DOC:     PARCELA:      VLR PAGO",
                                 " "+  lwNegociacoes.FocusedItem.SubItems[1].Text + "          " + lwNegociacoes.FocusedItem.SubItems[3].Text+ "          " + lwNegociacoes.FocusedItem.SubItems[5].Text ,
                                 "---------------------------------------------------------------------------------",
                                empresa._NomeFantasia,
                                "Porto Velho - Ro - Data Hora Pagamento: " + data.ToString(),
                                "---------------------------------------------------------------------------------",
                             };

            //Escreve as informações no arquivo txt, salvo no diretorio expecificado
            File.WriteAllLines(exeLocation + "\\Cupom\\ComprovantePgtoNegociacao.txt", texto);
        }

        public void ImprimirComprovantePagamento()
        {
            int copia = 1;

            while (copia <= 2)
            {
                string path = exeLocation + "\\Cupom\\ComprovantePgtoNegociacao.txt";
                frmBaseTodasNegociacoes.ShellExecuteA(this.Handle.ToInt32(), "print", path, null, null, 0);
                copia++;
            }
        }

        private void rbAberto_CheckedChanged(object sender, EventArgs e)
        {
            CarregaTodasNegociacoes();
        }

        private void rbFechado_CheckedChanged(object sender, EventArgs e)
        {
            CarregaTodasNegociacoes();
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            CarregaTodasNegociacoes();
        }
    }
}
