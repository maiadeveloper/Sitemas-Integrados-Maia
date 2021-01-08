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
    public partial class frmAberturaFechamentoCaixa : Form
    {
        public frmAberturaFechamentoCaixa()
        {
            InitializeComponent();
        }

        private void frmAberturaFechamentoCaixa_Load(object sender, EventArgs e)
        {
            CarregaHoraAberturaCaixa();
        }

        void CarregaHoraAberturaCaixa()
        {
            txtDataAbertura.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CaixaBO caixaBo = new CaixaBO();
            Caixa caixa = new Caixa();

            if (string.IsNullOrEmpty(lblNumeroCaixa.Text))
            {
                caixa = new Caixa();

                caixa.DataAbertura = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                caixa.SaldoCaixa = Convert.ToDecimal("0.00");
                caixa.Situacao = "Aberto";

                caixaBo.AbrirCaixa(caixa);

                MessageBox.Show("Caixa aberto em " + DateTime.Now + "", "Abertura aberto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                caixa.DataFechamento = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy"));
                caixa.Situacao = "Fechado";
                caixa.CaixaID = int.Parse(lblNumeroCaixa.Text);

                caixaBo.FecharCaixa(caixa);

                MessageBox.Show("Caixa fechado em " + DateTime.Now + "", "Fechamento caixa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CarregaCaixaFechamento(int caixaID)
        {
            Caixa caixa = new Caixa();
            CaixaBO caixaBO = new CaixaBO();

            caixa = caixaBO.SelecionaCaixaDia(caixaID);

            if (caixa != null)
            {
                lblNumeroCaixa.Text = caixa.CaixaID.ToString();
                txtDataAbertura.Text = caixa.DataAbertura.ToString("dd/MM/yyyy");
            }
        }
    }
}
