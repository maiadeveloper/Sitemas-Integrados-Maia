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
    public partial class frmBaseTodosUsuarios : Form
    {
        public frmBaseTodosUsuarios()
        {
            InitializeComponent();

            HabilitaTitulos();
        }

        private void HabilitaTitulos()
        {
            foreach (ToolStripItem item in toolStrip1.Items)
            {
                item.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText;
            }
        }

        private void toolStripSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButtono_Click(object sender, EventArgs e)
        {
            frmCadastroUsuarios frm = new frmCadastroUsuarios();
            frm.ShowDialog();
        }
    }
}
