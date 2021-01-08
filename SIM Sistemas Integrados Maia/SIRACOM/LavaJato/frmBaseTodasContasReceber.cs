

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Negocios;
using Negocios.TIPO;
using Negocios.BO;

namespace LavaJato
{
    public partial class frmBaseTodasContasReceber : Form
    {
        public frmBaseTodasContasReceber()
        {
            InitializeComponent();
        }

        decimal totalGeral = 0;
        decimal totalPrevista = 0;
        decimal totalRecebida = 0;
        decimal totalVencida = 0;
        decimal totalPago = 0;
        decimal totalCobrado = 0;
        decimal totalJuros = 0;
        decimal totalAberto = 0;
        decimal totalMulta = 0;
        int contTotalizadores = 0;

        ItemContaReceberBO itemContaReceberBo = new ItemContaReceberBO();
        ItemContaReceber itemContaReceber = new ItemContaReceber();
        int contador = 0;

        private void HabilitaTitulos()
        {
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
        }

        private void frmBaseTodasContasReceber_Load(object sender, EventArgs e)
        {
            txtBusca.Focus();
            txtDateInicial.Text = "01/01/2010";
            txtDataFinal.Text = "01/01/2020";
            HabilitaTitulos();

            AlterarStatusContaVencida();
            CarregaListagemContasReceberItens();
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

        private void CarregaListagemContasReceberItens()
        {

            AlterarStatusContaVencida();

            DataSet ds = new DataSet();
            listagemContasReceber.SmallImageList = imageList1;
            listagemContasReceber.Items.Clear();
            contador = 0;
            totalGeral = 0;
            totalPrevista = 0;
            totalRecebida = 0;
            totalVencida = 0;
            totalPago = 0;
            totalCobrado = 0;
            totalJuros = 0;
            totalAberto = 0;
            totalMulta = 0;
            contTotalizadores = 0;
            contTotalizadores = 0;
            DateTime dataAtual = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
            string situacao;

            string query = string.Empty;

            if ((ckVencida.Checked == true) && (ckPrevista.Checked == true) && (ckRecebida.Checked == true))
            {
                query = "status = 'Vencida' OR status = 'Prevista' OR status = 'Recebido'";
            }

            else if ((ckVencida.Checked == true) && (ckPrevista.Checked == true) && (ckRecebida.Checked == false))
            {
                query = "status = 'Vencida' OR status = 'Prevista'";
            }
            else if ((ckVencida.Checked == true) && (ckPrevista.Checked == false) && (ckRecebida.Checked == true))
            {
                query = "status = 'Vencida' OR Status = 'Recebido'";
            }
            else if ((ckVencida.Checked == false) && (ckPrevista.Checked == true) && (ckRecebida.Checked == true))
            {
                query = "status = 'Prevista' OR status = 'Recebido'";
            }
            else if ((ckVencida.Checked == true) && (ckPrevista.Checked == false) && (ckRecebida.Checked == false))
            {
                query = "status = 'Vencida'";
            }
            else if ((ckVencida.Checked == false) && (ckPrevista.Checked == false) && (ckRecebida.Checked == true))
            {
                query = "status = 'Recebido'";
            }
            else if ((ckVencida.Checked == false) && (ckPrevista.Checked == true) && (ckRecebida.Checked == false))
            {
                query = "status = 'Prevista'";
            }
            else
            {
                query = "status = 'Vencida' OR status = 'Prevista' OR status = 'Recebido'";
            }

            ds = itemContaReceberBo.SelecionaListagemItensContaReceberDataSet(DateTime.Parse(txtDateInicial.Text), DateTime.Parse(txtDataFinal.Text), txtBusca.Text, query);

            if (ds != null)
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    if (row["status"].ToString() == "Vencida")
                    {
                        listagemContasReceber.Items.Add(row["status"].ToString(), 1);
                        totalVencida += Convert.ToDecimal(row["valorParcela"]);
                    }
                    else if (row["status"].ToString() == "Prevista")
                    {
                        listagemContasReceber.Items.Add(row["status"].ToString(), 2);
                        totalPrevista += Convert.ToDecimal(row["valorParcela"]);
                    }
                    else
                    {
                        listagemContasReceber.Items.Add(row["status"].ToString(), 0);
                        totalRecebida += Convert.ToDecimal(row["valorParcela"]);
                    }

                    AlterarFonteLinhaLctoVencida(DateTime.Now, row);
                    AlterarFonteLinhaNegociacao(row);
                    DesabilitaCheckbox(row, contador);

                    listagemContasReceber.Items[contador].SubItems.Add(row["itemContaReceberID"].ToString());
                    listagemContasReceber.Items[contador].SubItems.Add(row["CpfCnpj"].ToString());
                    listagemContasReceber.Items[contador].SubItems.Add(row["NomeFantasia"].ToString());
                    listagemContasReceber.Items[contador].SubItems.Add(row["diasAtraso"] == DBNull.Value ? "0" : Convert.ToInt32(row["diasAtraso"]).ToString());
                    listagemContasReceber.Items[contador].SubItems.Add(Convert.ToDateTime(row["dataVencimento"]).ToString("dd/MM/yyyy"));
                    listagemContasReceber.Items[contador].SubItems.Add(row["numeroParcela"].ToString());
                    listagemContasReceber.Items[contador].SubItems.Add(Convert.ToDecimal(row["valorParcela"]).ToString("C"));
                    listagemContasReceber.Items[contador].SubItems.Add(row["valorMulta"] == DBNull.Value ? Convert.ToDecimal("0,00").ToString("C") : Convert.ToDecimal(row["valorMulta"]).ToString("C"));
                    listagemContasReceber.Items[contador].SubItems.Add(row["valorJuros"] == DBNull.Value ? Convert.ToDecimal("0,00").ToString("C") : Convert.ToDecimal(row["valorJuros"]).ToString("C"));
                    listagemContasReceber.Items[contador].SubItems.Add(row["valorCobrado"] == DBNull.Value ? Convert.ToDecimal("0,00").ToString("C") : Convert.ToDecimal(row["valorCobrado"]).ToString("C"));
                    listagemContasReceber.Items[contador].SubItems.Add(row["valorPago"] == DBNull.Value ? Convert.ToDecimal("0,00").ToString("C") : Convert.ToDecimal(row["valorPago"]).ToString("C"));
                    listagemContasReceber.Items[contador].SubItems.Add(row["ValorAberto"] == DBNull.Value ? Convert.ToDecimal("0,00").ToString("C") : Convert.ToDecimal(row["ValorAberto"]).ToString("C"));


                    totalGeral += Convert.ToDecimal(row["valorParcela"]);
                    totalPago += row["valorPago"] == DBNull.Value ? Convert.ToDecimal("0,00") : Convert.ToDecimal(row["valorPago"]);
                    totalCobrado += row["valorCobrado"] == DBNull.Value ? Convert.ToDecimal("0,00") : Convert.ToDecimal(row["valorCobrado"]);
                    totalJuros += row["valorJuros"] == DBNull.Value ? Convert.ToDecimal("0,00") : Convert.ToDecimal(row["valorJuros"]);
                    totalMulta += row["valorMulta"] == DBNull.Value ? Convert.ToDecimal("0,00") : Convert.ToDecimal(row["valorMulta"]);
                    totalAberto += row["valorAberto"] == DBNull.Value ? Convert.ToDecimal("0,00") : Convert.ToDecimal(row["valorAberto"]);
                    contador++;
                }

                txtTotalAberto.Text = totalAberto.ToString("C");
                txtTotalPago.Text = totalPago.ToString("C");
                txtTotalCobrado.Text = totalCobrado.ToString("C");
                txtTotalJuros.Text = totalJuros.ToString("C");
                txtTotalMulta.Text = totalMulta.ToString("C");
                txtTotalParcelas.Text = totalGeral.ToString("C");
                txtTotalItem.Text = listagemContasReceber.Items.Count.ToString();
            }
        }

        private void DesabilitaCheckbox(DataRow row, int linha)
        {
            if (row["negociacao"].Equals("Sim"))
            {
            }
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CarregaListagemContasReceberItens();
        }

        private void frmBaseTodasContasReceber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CarregaListagemContasReceberItens();
            }
        }

        private void contextMenuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (listagemContasReceber.Items.Count > 0)
            {
                int cod = int.Parse(listagemContasReceber.FocusedItem.SubItems[1].Text);
                itemContaReceber = itemContaReceberBo.SelecionarItemContaReceberID(cod);

                if (itemContaReceber != null)
                {
                    if (e.ClickedItem.Name.Equals("baixarContaReceberToolStripMenuItem"))
                    {
                        if (listagemContasReceber.FocusedItem.SubItems[0].Text != "Recebido")
                        {
                            frmBaixarContaReceber frmBaixaCR = new frmBaixarContaReceber();
                            frmBaixaCR.CarregaContaReceberParcela(cod, true);
                            frmBaixaCR.ShowDialog();
                            CarregaListagemContasReceberItens();
                        }
                        else
                        {
                            MessageBox.Show("Parcela já foi baixada", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else if (e.ClickedItem.Name.Equals("visualizarParcelaToolStripMenuItem"))
                    {
                        if (listagemContasReceber.FocusedItem.SubItems[0].Text == "Recebido")
                        {
                            frmBaixarContaReceber frmBaixaCR = new frmBaixarContaReceber();
                            frmBaixaCR.CarregaContaReceberParcela(cod, false);
                            frmBaixaCR.ShowDialog();
                            CarregaListagemContasReceberItens();
                        }
                        else
                        {
                            MessageBox.Show("Opção valida somente para parcelas ja baixadas", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else if (e.ClickedItem.Name.Equals("detalharToolStripMenuItem"))
                    {
                        frmDetalhamentoProdutosContasReceber frm = new frmDetalhamentoProdutosContasReceber();
                        frm.CarregaItensVendas(itemContaReceber._ContaReceber._ContaReceberID);
                        frm.ShowDialog();
                    }
                    else if (e.ClickedItem.Name.Equals("ExcluirToolStripMenuItem"))
                    {
                        if (MessageBox.Show("Confirma exclusão da conta Nº " + cod + " ? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            itemContaReceberBo.ExcluirItemContaReceber("itemContaReceberID", cod);
                            MessageBox.Show("Conta excluida com sucesso", "Resultado :)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CarregaListagemContasReceberItens();
                        }
                    }
                }
            }
        }

        private void AlterarFonteLinhaLctoVencida(DateTime dataAtual, DataRow row)
        {
            if (row["status"].ToString().Equals("Vencida"))
            {
                listagemContasReceber.Items[contador].ForeColor = System.Drawing.Color.Red;
            }
            else if (row["status"].ToString().Equals("Prevista"))
            {
                listagemContasReceber.Items[contador].ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                listagemContasReceber.Items[contador].ForeColor = System.Drawing.Color.Green;
            }
        }

        private void AlterarFonteLinhaNegociacao(DataRow row)
        {
            if (row["negociacao"].ToString() == "Sim")
            {
                listagemContasReceber.Items[contador].ForeColor = System.Drawing.Color.Blue;
            }
        }


        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBusca.Text))
            {
                CarregaListagemContasReceberItens();
            }
        }

        private void btnLimparBusca_Click(object sender, EventArgs e)
        {
            txtBusca.Clear();
            txtDateInicial.Text = "01/01/2010";
            txtDataFinal.Text = "01/01/2020";
            CarregaListagemContasReceberItens();
        }

        private void ckVencida_CheckedChanged(object sender, EventArgs e)
        {
            CarregaListagemContasReceberItens();
        }

        private void ckPrevista_CheckedChanged(object sender, EventArgs e)
        {
            CarregaListagemContasReceberItens();
        }

        private void ckRecebida_CheckedChanged(object sender, EventArgs e)
        {
            CarregaListagemContasReceberItens();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Utilitarios.iniciaCalc();
        }

        private void toolStripSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmBaseRelatorioGDespesas frm = new frmBaseRelatorioGDespesas();
            frm.ShowDialog();
        }

        private void aplicarNegociaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listagemContasReceber.Items.Count > 0)
            {
                contador = 0;

                List<ItemContaReceber> itensContaReceber = new List<ItemContaReceber>();

                for (int i = 0; i < listagemContasReceber.Items.Count; i++)
                {
                    if (listagemContasReceber.Items[contador].Checked == true)
                    {
                        itensContaReceber.Add(new ItemContaReceber() 
                        {
                            _ItemContaReceberID = Convert.ToInt32(listagemContasReceber.Items[contador].SubItems[1].Text),
                            ValorCobrado = Convert.ToDecimal(listagemContasReceber.Items[contador].SubItems[10].Text.Substring(3)),
                            _DataVencimento = Convert.ToDateTime(listagemContasReceber.Items[contador].SubItems[5].Text), _NumeroParcela = listagemContasReceber.Items[contador].SubItems[6].Text });
                    }
                    contador++;
                }

                if (itensContaReceber.Count != 0)
                {
                    using (frmRealizarNegociacao frm = new frmRealizarNegociacao())
                    {
                        frm.CarregaInfomacoesNegociacao(itensContaReceber);

                        frm.ShowDialog();

                        CarregaListagemContasReceberItens();
                    }
                }
                else
                {
                    MessageBox.Show("Selecione ao menos uma conta para negociação", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
