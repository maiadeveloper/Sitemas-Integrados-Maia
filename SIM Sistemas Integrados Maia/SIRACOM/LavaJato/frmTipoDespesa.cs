using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.BO;
using Negocios.TIPO;

namespace LavaJato
{
    public partial class frmTipoDespesa : Form
    {
        public frmTipoDespesa()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lblTipoDespesaID.Text))
            {
                AlterarDespesa();
            }
            else
            {
                GravarDespesa();
            }
        }

        private void GravarDespesa()
        {
            if (!string.IsNullOrEmpty(txtTipoDespesa.Text))
            {
                TipoDespesa tipoDespesa = new TipoDespesa();
                TipoDespesaBO tipoDespesaBO = new TipoDespesaBO();

                tipoDespesa.ClasseDespesaID = Convert.ToInt32(txtClasseDespesa.SelectedValue);
                tipoDespesa.NomeTipoDespesa = txtTipoDespesa.Text;

                tipoDespesaBO.GravarTipoDespesa(tipoDespesa);

                MessageBox.Show("Tipo despesa gravado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (MessageBox.Show("Desejar cadastrar outro tipo de despesa ?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtClasseDespesa.Focus();
                    txtTipoDespesa.Clear();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Informe o nome tipo despesa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AlterarDespesa()
        {
            if (!string.IsNullOrEmpty(txtTipoDespesa.Text))
            {
                TipoDespesa tipoDespesa = new TipoDespesa();
                TipoDespesaBO tipoDespesaBO = new TipoDespesaBO();

                tipoDespesa.TipoDespesaID = int.Parse(lblTipoDespesaID.Text);
                tipoDespesa.ClasseDespesaID = Convert.ToInt32(txtClasseDespesa.SelectedValue);
                tipoDespesa.NomeTipoDespesa = txtTipoDespesa.Text;

                tipoDespesaBO.AlteraTipoDespesa(tipoDespesa);

                MessageBox.Show("Tipo despesa alterado com sucesso", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("Informe o nome tipo despesa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTipoDespesa_Load(object sender, EventArgs e)
        {
            PopulaClasseDespesas();
        }

        public void CarregaDados(int tipoDespesaID)
        {
            if (tipoDespesaID > 0)
            {
                TipoDespesa tipoDespesa = new TipoDespesa();
                TipoDespesaBO tipoDespesaBO = new TipoDespesaBO();

                tipoDespesa = tipoDespesaBO.SelecionaTipoDespesaID(tipoDespesaID);

                lblTipoDespesaID.Text = tipoDespesa.TipoDespesaID.ToString();
                txtClasseDespesa.SelectedValue = tipoDespesa.ClasseDespesaID;
                txtTipoDespesa.Text = tipoDespesa.NomeTipoDespesa;
            }
        }

        private void btnAddClasseDespesa_Click(object sender, EventArgs e)
        {
            frmClasseDespesa frm = new frmClasseDespesa();
            frm.ShowDialog();
            PopulaClasseDespesas();
        }

        private void PopulaClasseDespesas()
        {
            ClasseDespesaBO classeDespesaBO = new ClasseDespesaBO();
            txtClasseDespesa.DataSource = classeDespesaBO.CriaDataTableClasseDespesas("");
            txtClasseDespesa.ValueMember = "ClasseDespesaID";
            txtClasseDespesa.DisplayMember = "NomeClasse";
        }
    }
}
