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
using System.Data.OleDb;

namespace LavaJato
{
    public partial class frmParametroContasReceberDetalhado : Form
    {
        public frmParametroContasReceberDetalhado()
        {
            InitializeComponent();
        }

        private void frmParametroContasReceberDetalhado_Load(object sender, EventArgs e)
        {
            txtSituação.SelectedIndex = 0;
            txtDateInicial.Text = "01/01/2013";
            txtDataFinal.Text = "01/01/2020";
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //frmContasReceberDetalhado frm = new frmContasReceberDetalhado();

            DateTime dataInicial = Convert.ToDateTime(txtDateInicial.Text);
            DateTime dataFinal = Convert.ToDateTime(txtDataFinal.Text);
            string status;

            int pos = txtSituação.SelectedIndex;

            switch (pos)
            {
                case 0:
                    status = "";
                    break;

                case 1:
                    status = "Prevista";
                    break;

                case 2:
                    status = "Recebido";
                    break;

                default:
                    status = "Vencida";
                    break;
            }

            string cliente = txtCliente.Text;

            //frm.ExibeTodasContasReceberDetalhada(status, cliente, dataInicial, dataFinal);
            //frm.ShowDialog();
        }

        private void frmParametroContasReceberDetalhado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnConsultar_Click(this, e);
            }
        }

        private void btnLimparBusca_Click(object sender, EventArgs e)
        {
            txtSituação.SelectedIndex = 0;
            txtDateInicial.Text = "01/01/2013";
            txtDataFinal.Text = "01/01/2020";
            txtCliente.Clear();
        }
    }
}
