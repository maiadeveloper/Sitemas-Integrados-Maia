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
    public partial class frmQtdeRV : Form
    {
        public frmQtdeRV()
        {
            InitializeComponent();
            txtQtde.Focus();
        }

        public int Qtde { get; set; }

        private void frmQtdeRV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrEmpty(txtQtde.Text))
                {
                    txtQtde.Focus();
                }
                else
                {
                    Qtde = Convert.ToInt32(txtQtde.Text);
                    this.Close();
                }
            }
            else if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmQtdeRV_Load(object sender, EventArgs e)
        {
            txtQtde.Focus();
        }
    }
}
