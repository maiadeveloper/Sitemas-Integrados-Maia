using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios.manterBancoBo;

namespace LavaJato
{
    public partial class frmBaseTodosBancos : Form
    {
        public frmBaseTodosBancos()
        {
            InitializeComponent();
        }

        int countRow = 0;

        private void toolStripSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            frmBanco frm = new frmBanco();
            frm.ShowDialog();
            CarregaBancos();
        }

        private void CarregaBancos()
        {
            DataTable dt = new DataTable();
            ManterBancoBO objBancoBo = new ManterBancoBO();

            dt = objBancoBo.CriaDataTableBanco(txtBusca.Text);

            if (dt != null)
            {
                listViewBancos.Items.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    //Adiciona os itens do list view
                    listViewBancos.Items.Add(row.ItemArray[0].ToString());//0
                    listViewBancos.Items[countRow].SubItems.Add((row.ItemArray[1]).ToString());//1
                    countRow++;
                }
                countRow = 0;
            }
        }

        private void frmBaseTodosBancos_Load(object sender, EventArgs e)
        {
            CarregaBancos();
        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {
            CarregaBancos();
        }

        private void listViewBancos_DoubleClick(object sender, EventArgs e)
        {
            int bancoID = int.Parse(listViewBancos.FocusedItem.SubItems[0].Text);
            frmBaseTodosBancos frm = new frmBaseTodosBancos();
        }

        private void btnLimparBusca_Click(object sender, EventArgs e)
        {
            CarregaBancos();
            txtBusca.Clear();
            txtBusca.Focus();
        }
    }
}
