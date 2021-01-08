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
    public partial class frmAlterarDataNegociacao : Form
    {
        public frmAlterarDataNegociacao()
        {
            InitializeComponent();
        }

        public DateTime DataVcto { get; set; }

        private void frmAlterarDataNegociacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataVcto = txtVencimentoInicial.Value;

                this.Close();
            }
        }

        public void GetDataVencimento(DateTime dataVcto)
        {
            txtVencimentoInicial.Value = dataVcto;
        }
    }
}
