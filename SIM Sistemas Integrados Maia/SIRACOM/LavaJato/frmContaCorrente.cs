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
using Negocios;
using System.Data.OleDb;
using Negocios.manterBancoBo;
using Negocios.manterBancoTipo;

namespace LavaJato
{
    public partial class frmContaCorrente : Form
    {
        public frmContaCorrente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ContaCorrente contaCorrente = new ContaCorrente();
            ContaCorrenteBO contaCorrenteBo = new ContaCorrenteBO();

            if (lblContaCorrente.Text == "0")
            {
                contaCorrente.Agencia = txtAgencia.Text;
                contaCorrente.BancoID = Convert.ToInt32(txtBanco.SelectedValue);
                contaCorrente.CC = int.Parse(txtContaCorrente.Text);
                contaCorrente.Saldo = decimal.Parse(txtSaldo.Text.Substring(3));

                contaCorrenteBo.GravarContaCorrente(contaCorrente);

                MessageBox.Show("Conta corrente gravado com sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (MessageBox.Show("Deseja gravar outro conta corrente ?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtAgencia.Text = txtBanco.Text = txtContaCorrente.Text = txtSaldo.Text = lblContaCorrente.Text = string.Empty;
                    txtBanco.Focus();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                contaCorrente.ContaID = int.Parse(lblContaCorrente.Text);
                contaCorrente.Agencia = txtAgencia.Text;
                contaCorrente.BancoID = int.Parse(txtBanco.SelectedValue.ToString());
                contaCorrente.CC = int.Parse(txtContaCorrente.Text);
                contaCorrente.Saldo = decimal.Parse(txtSaldo.Text.Substring(3));

                contaCorrenteBo.AlterarContaCorrente(contaCorrente);

                MessageBox.Show("Conta alterado gravado com sucesso", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtAgencia.Text = txtBanco.Text = txtContaCorrente.Text = txtSaldo.Text = lblContaCorrente.Text = string.Empty;
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmContaCorrente_Load(object sender, EventArgs e)
        {
            txtBanco.Focus();
            PopulaBanco();
        }

        public void CarregaDados(int contaID)
        {
            if (contaID > 0)
            {
                ContaCorrente contaCorrente = new ContaCorrente();
                ContaCorrenteBO contaCorrenteBO = new ContaCorrenteBO();

                contaCorrente = contaCorrenteBO.RetornaContaCorrenteID(contaID);
                lblContaCorrente.Text = contaCorrente.ContaID.ToString();
                txtAgencia.Text = contaCorrente.Agencia;
                txtBanco.SelectedItem = contaCorrente.BancoID;
                txtContaCorrente.Text = contaCorrente.CC.ToString();
                txtSaldo.Text = Convert.ToDecimal(contaCorrente.Saldo).ToString("C");
            }
        }

        public void PopulaBanco()
        {
            ManterBancoBO bancoBO = new ManterBancoBO();
            txtBanco.DataSource = bancoBO.PopularBanco();
            txtBanco.ValueMember = "BancoID";
            txtBanco.DisplayMember = "NomeBanco";
        }

        private void txtSaldo_Leave(object sender, EventArgs e)
        {
            try
            {
                txtSaldo.Text = Convert.ToDecimal(txtSaldo.Text).ToString("C");
            }
            catch (Exception) { }
        }

        private void btnAddBanco_Click(object sender, EventArgs e)
        {
            frmBanco frm = new frmBanco();
            frm.ShowDialog();
            PopulaBanco();
        }
    }
}
