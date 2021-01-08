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

namespace LavaJato
{
    public partial class frmBaseTodosLancamentos : Form
    {
        public frmBaseTodosLancamentos()
        {
            InitializeComponent();

            HabilitaTitulos();
        }

        int contadorLinha;
        decimal vlrTotal;

        private void HabilitaTitulos()
        {
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
        }

        private void toolStripButtono_Click(object sender, EventArgs e)
        {
            frmLancamento frm = new frmLancamento();
            frm.ShowDialog();
            CarregaTodosLancamentos();
        }

        public void CarregaTodosLancamentos()
        {
            DataSet ds = new DataSet();
            LancamentosBO lancamentoBO = new LancamentosBO();
            listViewLancamentos.SmallImageList = imageList1;
            string campo = cbCampoPesquisa.Text == "Data Lcto" ? "DataCadastro" : "DataVencimento";
            DateTime dataAtual = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));

            string situacao;

            if (rbAberto.Checked == true)
            {
                situacao = "Aberto";
            }
            else if (rbBaixado.Checked == true)
            {
                situacao = "Baixado";
            }
            else
            {
                situacao = null;
            }

            ds = lancamentoBO.LancamentosTodos(DateTime.Parse(txtDateInicial.Text), DateTime.Parse(txtDataFinal.Text), campo,situacao);

            if (ds != null)
            {
                listViewLancamentos.Items.Clear();
                contadorLinha = 0;
                vlrTotal = 0;

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    if ((row["ValorAberto"].ToString().StartsWith("0")) && (row["Situacao"].ToString() == "Aberto"))
                    {
                        listViewLancamentos.Items.Add(row["Situacao"].ToString(), 1);
                    }
                    else if ((row["ValorAberto"].ToString().StartsWith("0")) && (row["Situacao"].ToString() == "Baixado"))
                    {
                        listViewLancamentos.Items.Add(row["Situacao"].ToString(), 0);
                    }
                    else
                    {
                        listViewLancamentos.Items.Add(row["Situacao"].ToString(), 2);
                    }

                    //Verifica se a data atual e maior ou igual a data de vencimento
                    AlterarFonteLinhaLctoVencida(dataAtual, row);

                    listViewLancamentos.Items[contadorLinha].SubItems.Add(row["LancamentoID"].ToString());
                    listViewLancamentos.Items[contadorLinha].SubItems.Add(row["NumParcela"].ToString());
                    listViewLancamentos.Items[contadorLinha].SubItems.Add(row["nomeFantasiaEmpresa"].ToString());
                    listViewLancamentos.Items[contadorLinha].SubItems.Add(row["TipoLancamento"].ToString());
                    listViewLancamentos.Items[contadorLinha].SubItems.Add(row["Nome_Fantasia"].ToString());
                    listViewLancamentos.Items[contadorLinha].SubItems.Add(row["NomeTipoDocumento"].ToString());
                    listViewLancamentos.Items[contadorLinha].SubItems.Add(row["NomeTipoDespesa"].ToString());
                    listViewLancamentos.Items[contadorLinha].SubItems.Add(row["NomeClasse"].ToString());
                    listViewLancamentos.Items[contadorLinha].SubItems.Add(row["Descricao"].ToString());
                    listViewLancamentos.Items[contadorLinha].SubItems.Add(row["NumDoc"].ToString());
                    listViewLancamentos.Items[contadorLinha].SubItems.Add(Convert.ToDateTime(row["DataCadastro"]).ToString("dd/MM/yyyy"));
                    listViewLancamentos.Items[contadorLinha].SubItems.Add(Convert.ToDateTime(row["DataVencimento"]).ToString("dd/MM/yyyy"));
                    listViewLancamentos.Items[contadorLinha].SubItems.Add(Convert.ToDecimal(row["ValorPrincipal"]).ToString("C"));
                    listViewLancamentos.Items[contadorLinha].SubItems.Add(Convert.ToDecimal(row["ValorAberto"]).ToString("C"));
                    vlrTotal += Convert.ToDecimal(row["ValorPrincipal"].ToString());
                    contadorLinha++;
                }

                txtTotalItem.Text = Convert.ToDecimal(vlrTotal).ToString("C");
                txtQtdeItem.Text = listViewLancamentos.Items.Count.ToString();
            }
        }

        private void AlterarFonteLinhaLctoVencida(DateTime dataAtual, DataRow row)
        {
            if ((dataAtual >= Convert.ToDateTime(row["DataVencimento"]) && (row["Situacao"].ToString().Equals("Aberto"))))
            {
                listViewLancamentos.Items[contadorLinha].ForeColor = System.Drawing.Color.Black;
                listViewLancamentos.Items[contadorLinha].BackColor = System.Drawing.Color.Salmon;
            }
            else if ((dataAtual < Convert.ToDateTime(row["DataVencimento"]) && (row["Situacao"].ToString().Equals("Aberto"))))
            {
                listViewLancamentos.Items[contadorLinha].BackColor = System.Drawing.Color.White;
            }
            else
            {
                listViewLancamentos.Items[contadorLinha].BackColor = System.Drawing.Color.MediumSpringGreen;
            }
        }

        public void VerificaPrazoVencimento(DataRow row)
        {
            DateTime dataVencimento = DateTime.Parse(row["DataVencimento"].ToString());
            TimeSpan intervalo = DateTime.Now.Subtract(dataVencimento);

            int prazo = intervalo.Days;

            prazo = prazo > 3 ? 1 : 2;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CarregaTodosLancamentos();
        }

        private void frmBaseTodosLancamentos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CarregaTodosLancamentos();
            }
        }

        private void btnLimparBusca_Click(object sender, EventArgs e)
        {
            txtDateInicial.Value = Convert.ToDateTime("01/01/2013");
            txtDataFinal.Value = Convert.ToDateTime("01/01/2020");
            cbCampoPesquisa.SelectedIndex = 1;
            CarregaTodosLancamentos();
        }

        private void frmBaseTodosLancamentos_Load(object sender, EventArgs e)
        {
            txtDateInicial.Value = Convert.ToDateTime("01/01/2013");
            txtDataFinal.Value = Convert.ToDateTime("01/01/2020");

            CarregaTodosLancamentos();

            cbCampoPesquisa.SelectedIndex = 1;
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            frmLancamento frm = new frmLancamento();

            if ((listViewLancamentos.Items.Count > 0) && (listViewLancamentos.FocusedItem.SubItems[0].Text != "Baixado"))
            {
                if (e.ClickedItem.Name.Equals("menuBaixar"))
                {
                    frm.CarregaDadosBaixarLancamento(int.Parse(listViewLancamentos.FocusedItem.SubItems[1].Text));
                    frm.ShowDialog();
                }
            }
            if (e.ClickedItem.Name.Equals("menuEstornar"))
            {
                EstornarLancamento(int.Parse(listViewLancamentos.FocusedItem.SubItems[1].Text));
            }
            if (e.ClickedItem.Name.Equals("menuExcluir"))
            {
                ExcluirLancamento(int.Parse(listViewLancamentos.FocusedItem.SubItems[1].Text));
            }
            else if (e.ClickedItem.Name.Equals("menuEditar"))
            {
                frm.CarregaDadosEditarLancamento(int.Parse(listViewLancamentos.FocusedItem.SubItems[1].Text));
                frm.ShowDialog();
            }

            CarregaTodosLancamentos();

        }

        private void ExcluirLancamento(int p)
        {
            if (MessageBox.Show("Confirma exclusão deste lançamento ? ", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

            }
        }

        private void EstornarLancamento(int lancamentoID)
        {
            if (MessageBox.Show("Confirma estorno deste pagamento ? ", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Atualiza saldo
                ContaCorrenteBO contaCorrenteBO = new ContaCorrenteBO();

                //Pega dados referente ao lancamento baixa
                LancamentosBaixasBO lancamentosBaixasBO = new LancamentosBaixasBO();
                DataTable dt = new DataTable();

                dt = lancamentosBaixasBO.CriaDataTableLancamentosBaixas(lancamentoID);

                if (dt != null)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        //Atualiza a conta corrente
                        contaCorrenteBO.AtualizarSaldoDespesaEstorno(Convert.ToInt32(row["ContaID"].ToString()), row["VlorBaixa"].ToString());

                        //Excluir a baixa
                        lancamentosBaixasBO.DeletarLancamentoBaixa(Convert.ToInt32(row["LancamentoBaixaID"]));
                    }
                }

                //Atualiza lancamento
                LancamentosBO lancamentosBO = new LancamentosBO();
                Lancamentos lancamentos = new Lancamentos();

                lancamentos.Situacao = "Aberto";
                lancamentos.LancamentoID = lancamentoID;
                lancamentos.ValorAberto = decimal.Parse("0,00");
                lancamentos.DataPgto = Convert.ToDateTime(DateTime.MinValue);

                lancamentosBO.AlterarLancamentoBaixar(lancamentos);

                MessageBox.Show("Estorno realizado com sucesso", "Atençao", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CarregaTodosLancamentos();
            }
        }

        private void toolStripSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            CarregaTodosLancamentos();
        }

        private void rbAberto_CheckedChanged(object sender, EventArgs e)
        {
            CarregaTodosLancamentos();
        }

        private void rbBaixado_CheckedChanged(object sender, EventArgs e)
        {
            CarregaTodosLancamentos();
        }

        private void txtDateInicial_ValueChanged(object sender, EventArgs e)
        {
            CarregaTodosLancamentos();
        }

        private void txtDataFinal_ValueChanged(object sender, EventArgs e)
        {
            CarregaTodosLancamentos();
        }

        private void cbCampoPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregaTodosLancamentos();
        }
    }
}
