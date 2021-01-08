using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios;
using Negocios.BO;
using Negocios.TIPO;

namespace LavaJato
{
    public partial class frmBaseTodosFornecedores : Form
    {
        public frmBaseTodosFornecedores()
        {
            InitializeComponent();
            CarregaTodosFornecedores();
            HabilitaTitulos();
        }

        int countRow = 0;

        private void toolStripSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtono_Click(object sender, EventArgs e)
        {
            frmCadastroFornecedores frm = new frmCadastroFornecedores();
            frm.ShowDialog();
            CarregaTodosFornecedores();
        }

        private void HabilitaTitulos()
        {
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
        }

        private void CarregaTodosFornecedores()
        {
            DataTable dt = new DataTable();
            CadastroFornecedoresBO fornecedoresBO = new CadastroFornecedoresBO();

            dt = fornecedoresBO.CriaDataFornecedoresParametro(txtBusca.Text);

            if (dt != null)
            {
                listViewForcedores.Items.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    //Adiciona os itens do list view
                    listViewForcedores.Items.Add(row["CodigoFornecedor"].ToString());
                    listViewForcedores.Items[countRow].SubItems.Add(row["CNPJ"].ToString());
                    listViewForcedores.Items[countRow].SubItems.Add(row["Nome_Fantasia"].ToString());
                    countRow++;
                }
            }

            countRow = 0;
        }

        private void ExcluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewForcedores.Items.Count > 0)
            {
                if (MessageBox.Show("Confirma exclusão do fornecedor: " + listViewForcedores.FocusedItem.SubItems[2].Text + " ?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CadastroFornecedoresBO fornecerdorBO = new CadastroFornecedoresBO();
                    int cod = int.Parse(listViewForcedores.FocusedItem.SubItems[0].Text);

                    if (ConsultaEntradaProdutoCodFornecedor(cod) && (ConsultaLancamentoFornecedorCod(cod) == false))
                    {
                        fornecerdorBO.ExcluirFornecedor(cod);
                        MessageBox.Show("Fornecedor excluido com sucesso", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBusca.Clear();
                        CarregaTodosFornecedores();
                    }
                    else
                    {
                        MessageBox.Show("Este fornecedor não pode ser excluido pois ele encontra-se vinculado a um evento no sistema", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }
            }
        }

        private bool ConsultaEntradaProdutoCodFornecedor(int cod)
        {
            bool resp = false;

            if (cod > 0)
            {

                EntradaProduto entradaProduto = new EntradaProduto();
                EntradaProdutoBO entradaProdutoBO = new EntradaProdutoBO();

                entradaProduto = entradaProdutoBO.SelecinaEntradaCodigoFornecedor(cod);

                if (entradaProduto != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return resp;
        }

        private bool ConsultaLancamentoFornecedorCod(int cod)
        {
            bool resp = false;

            if (cod > 0)
            {

                Lancamentos lancamentos = new Lancamentos();
                LancamentosBO lancamentosBO = new LancamentosBO();

                lancamentos = lancamentosBO.SelecionarLancamentoCodFornecedor(cod);

                if (lancamentos != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            return resp;
        }

        private void txtBusca_TextChanged_1(object sender, EventArgs e)
        {
            CarregaTodosFornecedores();
        }

        private void btnLimparBusca_Click_1(object sender, EventArgs e)
        {
            txtBusca.Focus();
            CarregaTodosFornecedores();
        }
    }
}
