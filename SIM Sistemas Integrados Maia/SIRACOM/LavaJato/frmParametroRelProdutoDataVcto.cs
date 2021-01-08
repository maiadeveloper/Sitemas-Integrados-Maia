using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LavaJato
{
    public partial class frmParametroRelProdutoDataVcto : Form
    {
        public frmParametroRelProdutoDataVcto()
        {
            InitializeComponent();
        }

        private void rbVencimentoDia_CheckedChanged(object sender, EventArgs e)
        {
            lblTipoRelatorio.Text = "Qtde dias vencimento:";
            txtDiasOuMes.Focus();
            txtDiasOuMes.Clear();
        }

        private void rbVencimentoMes_CheckedChanged(object sender, EventArgs e)
        {
            lblTipoRelatorio.Text = "Qtde meses vencimento:";
            txtDiasOuMes.Focus();
            txtDiasOuMes.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            if (ValidaCampos() == true)
            {
                string tipoBusca;

                if (rbVencimentoDia.Checked == true)
                {
                    tipoBusca = "QtdeDiasVencimento";
                }
                else
                {
                    tipoBusca = "QtdeMesVencimento";
                }

                tipoBusca = tipoBusca + " <= " + txtDiasOuMes.Text;

                FrmRelatorioProdutoDataVencimento frm = new FrmRelatorioProdutoDataVencimento();
                frm.CarregaRelatorioProdutoPorDataVcto(tipoBusca);
                frm.ShowDialog();
            }
            else
            {
                return;
            }
        }

        private Boolean ValidaCampos()
        {
            if ((rbVencimentoDia.Checked == false) && (rbVencimentoMes.Checked == false))
            {
                MessageBox.Show("Vocè deve informa o tipo de relatório", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtDiasOuMes.Text.Trim() == string.Empty)
            {
                string msgErro = rbVencimentoDia.Checked == true ? "Informe a quantidade de dias" : "Informe a quantidade de meses";

                MessageBox.Show(msgErro, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiasOuMes.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void frmParametroRelProdutoDataVcto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnVisualizar_Click(this, e);
            }
        }
    }
}
