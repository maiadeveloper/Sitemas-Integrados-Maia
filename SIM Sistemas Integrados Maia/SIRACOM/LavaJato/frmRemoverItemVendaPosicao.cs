using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.ProdBo;
using Negocios.ProdTipo;

namespace LavaJato
{
    public partial class frmRemoverItemVendaPosicao : Form
    {
        public frmRemoverItemVendaPosicao()
        {
            InitializeComponent();
        }

        public string codigoBarra;

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma remover este item da venda ? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                codigoBarra = txtCodigoBarra.Text;
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void frmRemoverItemVendaPosicao_Load(object sender, EventArgs e)
        {
            txtCodigoBarra.Focus();
        }

        private void frmRemoverItemVendaPosicao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtCodigoBarra.Text))
                {
                    btnRemover_Click(this, e);
                }
            }
        }

        private void txtCodigoBarra_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCodigoBarra.Text))
            {
                btnRemover_Click(this, e);
            }
        }
    }
}
