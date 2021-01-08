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
    public partial class frmDespesa : Form
    {
        public frmDespesa()
        {
            InitializeComponent();
            PopulaClasseDespesas();
            PopulaTipoDespesas();
        }

        int classeDespesaID = 0;
        int countRow;


        ContaCorrenteBO contaCorrenteBO;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarCampoObrigatorios() == true)
            {
                DespesasBO despesasBO = new DespesasBO();

                if (lblDespesaID.Text == "0")
                {
                    //Insert
                    Despesas despesas = new Despesas();

                    despesas.TipoDespesaID = Convert.ToInt32(txtTipoDespesas.SelectedValue);
                    despesas.ContaID = int.Parse(txtCodigoContaCorrente.Text);
                    despesas.Data = Convert.ToDateTime(txtData.Text);
                    despesas.DescricaoDespesa = txtDescricao.Text;
                    despesas.Valor = Convert.ToDecimal(txtValor.Text.Substring(3));

                    despesasBO.InserirDespesa(despesas);

                    contaCorrenteBO = new ContaCorrenteBO();
                    contaCorrenteBO.AtualizarSaldoDespesa(despesas.ContaID, despesas.Valor.ToString());

                    MessageBox.Show("Despesas salva com sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (MessageBox.Show("Deseja cadastrar uma nova despesas ? ", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        LimparCampos();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    //Update
                    Despesas despesas = new Despesas();
                    despesas.DespesasID = int.Parse(lblDespesaID.Text);
                    despesas.TipoDespesaID = Convert.ToInt32(txtTipoDespesas.SelectedValue);
                    despesas.ContaID = int.Parse(txtCodigoContaCorrente.Text);
                    despesas.Data = Convert.ToDateTime(txtData.Text);
                    despesas.Valor = Convert.ToDecimal(txtValor.Text.Substring(3));

                    MessageBox.Show("Despesas alterada com sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                return;
            }
        }

        public Boolean ValidarCampoObrigatorios()
        {
            if (txtClasseDespesas.SelectedValue == null)
            {
                MessageBox.Show("Campo obrigatório - Selecione classe despesa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClasseDespesas.Focus();
                return false;
            }
             if (txtValor.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campo obrigatório - Informe o valor", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Focus();
                return false;
            }
            if (txtDescricao.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campo obrigatório - Informe a descrição", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescricao.Focus();
                return false;
            }

            if (txtCodigoContaCorrente.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Campo obrigatório - Selecione uma conta corrente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnAddConta.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnAddClasseDespesa_Click(object sender, EventArgs e)
        {
            frmClasseDespesa frm = new frmClasseDespesa();
            frm.ShowDialog();
            PopulaClasseDespesas();
        }

        private void btnAddTipoDespesa_Click(object sender, EventArgs e)
        {
            frmTipoDespesa frm = new frmTipoDespesa();
            frm.ShowDialog();
            PopulaTipoDespesas();
        }

        private void btnAddConta_Click(object sender, EventArgs e)
        {
            frmBaseTodasContaCorrente frm = new  frmBaseTodasContaCorrente();
            frm.ShowDialog();

            txtCodigoContaCorrente.Text = frm.CodigoContaCorrente.ToString();
            txtDescricaoContaCorrent.Text = frm.NomeContaCorrente;
        }

        private void PopulaClasseDespesas()
        {
            ClasseDespesaBO classeDespesaBO = new ClasseDespesaBO();
            txtClasseDespesas.DataSource = classeDespesaBO.CriaDataTableClasseDespesas("");
            txtClasseDespesas.ValueMember = "ClasseDespesaID";
            txtClasseDespesas.DisplayMember = "NomeClasse";
        }

        private void PopulaTipoDespesas()
        {
            try
            {
                TipoDespesaBO tipoDespesaBO = new TipoDespesaBO();
                txtTipoDespesas.DataSource = tipoDespesaBO.CriaDataTableTipoDespesas(classeDespesaID);
                txtTipoDespesas.ValueMember = "TipoDespesaID";
                txtTipoDespesas.DisplayMember = "NomeTipoDespesa";
            }
            catch (Exception) { }
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            try
            {
                txtValor.Text = Convert.ToDecimal(txtValor.Text).ToString("C");
            }
            catch (Exception)
            {
                //erro
            }
        }

        private void frmDespesa_Load(object sender, EventArgs e)
        {
           
        }

        private void LimparCampos()
        {
            txtClasseDespesas.Focus();
            lblDespesaID.Text = "0";
            PopulaClasseDespesas();
            PopulaTipoDespesas();
            txtValor.Clear();
            txtDescricao.Clear();
            txtData.Text = DateTime.Now.ToString();
            txtCodigoContaCorrente.Clear();
            txtDescricaoContaCorrent.Clear();
        }

        private void txtClasseDespesas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            classeDespesaID = Convert.ToInt32(txtClasseDespesas.SelectedValue);
            PopulaTipoDespesas();
        }
    }
}
