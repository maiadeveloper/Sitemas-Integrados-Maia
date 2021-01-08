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
    public partial class frmImportarOrcamento : Form
    {
        public frmImportarOrcamento()
        {
            InitializeComponent();
        }

        public int numeroOrcamento;

        private void frmImportarOrcamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtNumeroOrcamento.Text))
                {
                    btnImportar_Click(this, e);
                }
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma importação deste orçamento ? ", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                numeroOrcamento = int.Parse(txtNumeroOrcamento.Text);
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void frmImportarOrcamento_Load(object sender, EventArgs e)
        {
            txtNumeroOrcamento.Focus();
        }
    }
}
